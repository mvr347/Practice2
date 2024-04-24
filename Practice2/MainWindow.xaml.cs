using System;
using System.Windows;
using System.Windows.Media;

namespace Practice2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainWindowFrame.Navigate(new Uri("Pages/HomePage.xaml", UriKind.Relative));

            Loaded += WindowLoaded;

        }
        public void WindowLoaded(object sender, RoutedEventArgs e)
        {
            ButtonTransperent();

            ButtonHome.ClearValue(BackgroundProperty);

            UsernameLabel.Content = App.user.Username;
        }

        public void SettingsClick(object sender, RoutedEventArgs e)
        {
            ButtonTransperent();

            MainWindowFrame.Navigate(new Uri("Pages/SettingsPage.xaml", UriKind.Relative));
        }
        public void LogoutClick(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            App.user = default;

            Close();
        }
        #region Buttons
        private void ButtonHomeClick(object sender, RoutedEventArgs e)
        {
            ButtonTransperent();

            ButtonHome.ClearValue(BackgroundProperty);

            MainWindowFrame.Navigate(new Uri("Pages/HomePage.xaml", UriKind.Relative));
        }
        public void ButtonCalculatorClick(object sender, RoutedEventArgs e)
        {
            ButtonTransperent();

            ButtonCalculator.ClearValue(BackgroundProperty);

            MainWindowFrame.Navigate(new Uri("Pages/CalculatorPage.xaml", UriKind.Relative));
        }
        public void ButtonApartamentsClick(object sender, RoutedEventArgs e)
        {
            ButtonTransperent();

            ButtonApartaments.ClearValue(BackgroundProperty);

            MainWindowFrame.Navigate(new Uri("Pages/ApartamentsPage.xaml", UriKind.Relative));
        }
        public void ButtonTransperent()
        {
            ButtonHome.Background = Brushes.Transparent;
            ButtonCalculator.Background = Brushes.Transparent;
            ButtonApartaments.Background = Brushes.Transparent;
        }
        #endregion
    }
}
