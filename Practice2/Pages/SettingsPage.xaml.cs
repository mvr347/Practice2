using HandyControl.Themes;
using Practice2.Data;
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

            if (App.user.IsAdmin == true) //Якщо користувач адміністратор надає доступ до видалення всіх користувачів. В іному випадку користувач зможе видалити аккаунт
            {
                ButtonDelete.Visibility = Visibility.Collapsed;
                ButtonWipeAllUsers.Visibility = Visibility.Visible;
            }

            foreach (var lang in App.AvailableLanguages) //Добаляє в комбобокс поля для зміни мови
            {
                ComboBoxItem itemLang = new ComboBoxItem();
                itemLang.Content = lang.DisplayName;
                itemLang.Tag = lang;
                itemLang.IsSelected = lang.Equals(currentLangauge);
                itemLang.Selected += ComboboxChangeLanguageClick;
                ComboBoxLanguageChange.Items.Add(itemLang);
            }

            if (ThemeManager.Current.ApplicationTheme == ApplicationTheme.Dark) //Для зміни теми
            {
                ToggleButtonTheme.IsChecked = true;
            }
            else
            {
                ToggleButtonTheme.IsChecked = false;
            }

        }

        void ComboboxChangeLanguageClick(object sender, EventArgs e) //Міняє мову якщо користувач вибрав її в ComboBoxLanguageChange
        {
            ComboBoxItem languageMenu = sender as ComboBoxItem;

            CultureInfo currentLangauge = App.Language;

            ComboBoxLanguageChange.SelectedItem = currentLangauge;

            if (languageMenu != null)
            {
                if (languageMenu.Tag is CultureInfo lang)
                {
                    App.Language = lang;
                }
            }
        }
        #region Buttons
        void ToggleButtonChanged(object sender, EventArgs e) //Здійснює зміну теми
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
        void ButtonDeleteClick(object sender, EventArgs e) //Здійснює видалення користувача
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
        void ButtonWipeAllUsersClick(object sender, EventArgs e) //Видаляє всіх користувачів(файл:) )
        {
            JsonData.CreateFile();

            MessageBoxResult result = HandyControl.Controls.MessageBox.Show(DataHandler.GetTextComponent("settings.text10"), DataHandler.GetTextComponent("settings.text11"), MessageBoxButton.OKCancel, MessageBoxImage.Question);

            if (result == MessageBoxResult.OK)
            {
                File.Delete(JsonData.file);
                JsonData.CreateFile();
            }
        }
        #endregion

        //void Button_Click(object sender, RoutedEventArgs e) //На курсач
        //{
        //    if (PasswordBoxCurrentPassword.Password != App.user.Password)
        //    {
        //        App.user = default;

        //        Authorization authorization = new Authorization();

        //        Window.GetWindow(this).Close();

        //        authorization.Show();

        //        return;
        //    }
        //    else
        //    {
        //        App.user.ChangePassword(PasswordBoxNewPassword.Password);

        //        HandyControl.Controls.MessageBox.Show(DataHandler.GetTextComponent("settings.text12"), DataHandler.GetTextComponent("settings.text13"), MessageBoxButton.OK, MessageBoxImage.Information);
        //    }
        //}
    }
}
