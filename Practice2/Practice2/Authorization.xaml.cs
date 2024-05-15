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


            AuthorizationMainFrame.Navigate(new Uri("Pages/RegistrationPage.xaml", UriKind.Relative)); //Стартує застосунок з головної сторінки (реєстрації)

            CultureInfo currentLangauge = App.Language;

            foreach (var lang in App.AvailableLanguages) //Додає доступні мови в список для змоги її міняти
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Content = lang.DisplayName;
                radioButton.Tag = lang;
                radioButton.IsChecked = lang.Equals(currentLangauge);
                radioButton.Checked += RadioButtonLanguageClick;
            }
        }

        #region Change Language
        private async void ButtonLanguageClick(object sender, RoutedEventArgs e) //Якщо мова не задана == Англійська
        {

            CultureInfo currentLangauge = App.Language;

            if (RadioButtonEnglish.IsChecked != true && RadioButtonUkrainian.IsChecked != true) RadioButtonEnglish.IsChecked = true;

            await Task.Delay(130);

            if (currentLangauge.Name == "uk-UA")
            {
                RadioButtonUkrainian.IsChecked = true;
            }
            else { RadioButtonEnglish.IsChecked = true; }

            PopupLanguage.IsOpen = true;
        }

        private void RadioButtonLanguageClick(object sender, RoutedEventArgs e) //Обраний радіобатон == мова застосунку
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
        void ButtonThemeClick(object sender, RoutedEventArgs e) => PopupTheme.IsOpen = true; //Відкриває меню зміни теми

        void ThemeSelected(object sender, RoutedEventArgs e) //Міняє тему
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
