using HandyControl.Themes;
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
            AuthorizationMainFrame.Navigate(App.registrationPage);

            CultureInfo currentLangauge = App.Language;

            foreach (var lang in App.AvailableLanguages)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Content = lang.DisplayName;
                radioButton.Tag = lang;
                radioButton.IsChecked = lang.Equals(currentLangauge);
                radioButton.Checked += btnLangChoiseClick;
            }
        }


        #region Change Language
        private async void btnLangClick(object sender, RoutedEventArgs e)
        {

            CultureInfo currentLangauge = App.Language;

            await Task.Delay(130);

            if (currentLangauge.Name == "en-US")
            {
                rbLangEnglish.IsChecked = true;
            }
            else if (currentLangauge.Name == "uk-UA")
            {
                rbLangUkrainian.IsChecked = true;
            }

            PopupLanguage.IsOpen = true;
        }

        private void btnLangChoiseClick(object sender, RoutedEventArgs e)
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
        private void btnConfigClick(object sender, RoutedEventArgs e) => PopupConfig.IsOpen = true;

        private void btnSkinsClick(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is Button button)
            {
                PopupConfig.IsOpen = false;

                if (button.Tag is ApplicationTheme tag)
                {
                    ((App)Application.Current).UpdateTheme(tag);
                }
            }
        }
        #endregion
    }
}
