using HandyControl.Themes;
using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Practice2
{
    public partial class Authorization
    {
        public static Frame TheMainFrame { get; private set; }

        public Authorization()
        {
            InitializeComponent();

            TheMainFrame = AuthorizationMainFrame;


            AuthorizationMainFrame.Navigate(new Uri("Pages/RegistrationPage.xaml", UriKind.Relative));

            CultureInfo currentLangauge = App.Language;

            foreach (var lang in App.AvailableLanguages)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Content = lang.DisplayName;
                radioButton.Tag = lang;
                radioButton.IsChecked = lang.Equals(currentLangauge);
                radioButton.Checked += RadioButtonLanguageClick;
            }
        }

        #region Change Language
        private async void ButtonLanguageClick(object sender, RoutedEventArgs e)
        {

            CultureInfo currentLangauge = App.Language;

            if (RadioButtonbEnglish.IsChecked != true && RadioButtonUkrainian.IsChecked != true) RadioButtonbEnglish.IsChecked = true;

            RadioButtonbEnglish.IsChecked = true;

            await Task.Delay(130);

            if (currentLangauge.Name == "uk-UA")
            {
                RadioButtonUkrainian.IsChecked = true;
            }
            else { RadioButtonbEnglish.IsChecked = true; }

            PopupLanguage.IsOpen = true;
        }

        private void RadioButtonLanguageClick(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is RadioButton radioButton)
            {

                if (radioButton.Content.Equals("UKR"))
                {
                    App.Language = new CultureInfo("uk-UA");
                }
                else if (radioButton.Content.Equals("ENG"))
                {
                    App.Language = new CultureInfo("en-US");
                }

                PopupLanguage.IsOpen = false;
            }
        }
        #endregion
        #region Change Theme
        private void ButtonThemeClick(object sender, RoutedEventArgs e) => PopupTheme.IsOpen = true;

        private void ThemeSelected(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is Button button)
            {
                PopupTheme.IsOpen = false;

                if (button.Tag is ApplicationTheme tag)
                {
                    ((App)Application.Current).UpdateTheme(tag);
                }
            }
        }
        #endregion
    }
}
