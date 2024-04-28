using Practice2.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Practice2.Data
{
    public static class DataHandler
    {
        #region Language
        public static void ChangeMergedDictionaries(string pattern, string newSource) //Зміни джерела словників ресурсів
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

        public static ResourceDictionary GetLanguageDictionary() //отримання словника ресурсів
        {
            return (
                from d in Application.Current.Resources.MergedDictionaries
                where d.Source != null && d.Source.OriginalString.StartsWith(@"Data\Languages\")
                select d).FirstOrDefault();
        }
        public static string GetTextComponent(string key) //Для використання словника ресурсів в cs коді
        {
            return GetLanguageDictionary()[key] as string;
        }
        #endregion

        #region User
        public static bool UserExists(User users) //Якщо користувач існує
        {

            bool userExists = JsonData.JsonData.LoadUsersFromJson().Any(u => u.Username == users.Username);
            if (userExists)
            {
                HandyControl.Controls.MessageBox.Show(GetTextComponent("user_exists"), GetTextComponent("exception"), MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return userExists;
        }
        #endregion

        #region Files
        public static bool IsFileEmptyUser() //Якщо файл пустий
        {
            List<User> users = JsonData.JsonData.LoadUsersFromJson();

            return !users.Any();
        }
        #endregion
    }
}
