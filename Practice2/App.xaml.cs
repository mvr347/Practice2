using HandyControl.Themes;
using Practice2.Data.Entity;
using Practice2.Data.JsonData;
using Practice2.Pages;
using Practice2.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace Practice2
{
    public partial class App : Application
    {
        public static User user = new User();

        public static readonly LoginPage loginPage = new LoginPage();
        public static readonly RegistrationPage registrationPage = new RegistrationPage();

        private static List<CultureInfo> _availableLanguages = new List<CultureInfo>();
        public App()
        {
            _availableLanguages.Clear();
            _availableLanguages.Add(new CultureInfo("en-US"));
            _availableLanguages.Add(new CultureInfo("uk-UA"));
            JsonData.CreateDirectory();
            Language = Settings.Default.DefaultLanguage;
        }

        public static ReadOnlyCollection<CultureInfo> AvailableLanguages
        {
            get
            {
                return _availableLanguages.AsReadOnly();
            }
        }

        public static List<CultureInfo> Languages
        {
            get
            {
                return _availableLanguages;
            }
        }


        public static CultureInfo Language
        {
            get
            {
                return System.Threading.Thread.CurrentThread.CurrentUICulture;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                if (value == System.Threading.Thread.CurrentThread.CurrentUICulture) return;
                System.Threading.Thread.CurrentThread.CurrentUICulture = value;
                Data.Handler.ChangeMergedDictionaries(@"\Data\Languages\", String.Format(@"\Data\Languages\{0}.xaml", value.Name));
                Settings.Default.DefaultLanguage = Language;
                Settings.Default.Save();
            }
        }

        internal void UpdateTheme(ApplicationTheme theme)
        {
            if (ThemeManager.Current.ApplicationTheme != theme)
            {
                ThemeManager.Current.ApplicationTheme = theme;
            }
        }

        internal void UpdateAccent(Brush accent)
        {
            if (ThemeManager.Current.AccentColor != accent)
            {
                ThemeManager.Current.AccentColor = accent;
            }
        }
    }
}
