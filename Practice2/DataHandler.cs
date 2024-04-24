using Practice2.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Practice2.Data
{
    public static class DataHandler
    {
        public static void ChangeMergedDictionaries(string pattern, string newSource)
        {

            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri(newSource, UriKind.Relative);

            ResourceDictionary oldDict = (
                from d in Application.Current.Resources.MergedDictionaries
                where d.Source != null && d.Source.OriginalString.StartsWith(pattern)
                select d).FirstOrDefault();

            if (oldDict != null)
            {
                int index = Application.Current.Resources.MergedDictionaries.IndexOf(oldDict);
                Application.Current.Resources.MergedDictionaries.Remove(oldDict);
                Application.Current.Resources.MergedDictionaries.Insert(index, dict);
            }
            else
            {
                Application.Current.Resources.MergedDictionaries.Add(dict);
            }
        }
        public static ResourceDictionary GetLanguageDictionary()
        {
            return (
                from d in Application.Current.Resources.MergedDictionaries
                where d.Source != null && d.Source.OriginalString.StartsWith(@"\Data\Language\")
                select d).FirstOrDefault();
        }

        public static bool UserExists(User users)
        {
            ResourceDictionary lang = GetLanguageDictionary();

            bool userExists = JsonData.JsonData.LoadUsersFromJson().Any(u => u.Username == users.Username);
            if (userExists)
            {
                HandyControl.Controls.MessageBox.Show((string)lang["btn_Enter"], "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return userExists;
        }

        public static bool IsFileEmpty()
        {
            List<User> users = JsonData.JsonData.LoadUsersFromJson();

            return !users.Any();
        }
    }
}
