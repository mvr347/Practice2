using HandyControl.Themes;
using Practice2.Data.Entity;
using Practice2.Data.JsonData;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;


namespace Practice2.Pages
{
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();

            CultureInfo currentLangauge = App.Language;

            if (App.user.IsAdmin == true)
            {
                ButtonDelete.Visibility = Visibility.Collapsed;
                ButtonWipeAllUsers.Visibility = Visibility.Visible;
            }

            foreach (var lang in App.AvailableLanguages)
            {
                ComboBoxItem itemLang = new ComboBoxItem();
                itemLang.Content = lang.DisplayName;
                itemLang.Tag = lang;
                itemLang.IsSelected = lang.Equals(currentLangauge);
                itemLang.Selected += ChangeLanguageClick;
                ComboBoxLanguageChange.Items.Add(itemLang);
            }

            if (ThemeManager.Current.ApplicationTheme == ApplicationTheme.Dark)
            {
                ToggleButtonTheme.IsChecked = true;
            }
            else
            {
                ToggleButtonTheme.IsChecked = false;
            }

        }

        private void ChangeLanguageClick(object sender, EventArgs e)
        {
            ComboBoxItem languageMenu = sender as ComboBoxItem;
            if (languageMenu != null)
            {
                if (languageMenu.Tag is CultureInfo lang)
                {
                    App.Language = lang;
                }
            }
        }
        private void ToggleButtonChanged(object sender, EventArgs e)
        {
            if (ToggleButtonTheme.IsChecked == true)
            {
                ((App)Application.Current).UpdateTheme(ApplicationTheme.Dark);
            }
            else
            {
                ((App)Application.Current).UpdateTheme(ApplicationTheme.Light);
            }
        }
        public void ButtonDeleteClick(object sender, EventArgs e)
        {
            string account = App.user.Username;

            List<User> users = JsonData.LoadUsersFromJson();

            var userToDelete = users.Find(item => item.Username == account);

            if (userToDelete.Username.Length >= 0)
            {
                users.Remove(userToDelete);
            }

            string json = JsonSerializer.Serialize(users, JsonData.optionsSerializer);
            File.WriteAllText(JsonData.file, json);

            App.user = default;

            Window parentWindow = Window.GetWindow(this);

            Authorization authorization = new Authorization();
            authorization.Show();

            parentWindow.Close();

        }
        public void ButtonWipeAllUsersClick(object sender, EventArgs e)
        {
            MessageBoxResult result = HandyControl.Controls.MessageBox.Show("You really wanna wipe delete users data?", "Wipe all users data", MessageBoxButton.OKCancel, MessageBoxImage.Question);

            if (result == MessageBoxResult.OK)
            {
                File.Delete(JsonData.file);
                JsonData.CreateFile();
            }
        }
    }
}
