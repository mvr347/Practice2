using Practice2.Data.JsonData;
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
        public void WindowLoaded(object sender, RoutedEventArgs e) //Дія при запуску вікна
        {
            ButtonTransperent();

            JsonData.CreateFile();

            ButtonHome.ClearValue(BackgroundProperty);

            UsernameLabel.Content = App.user.Username;
        }

        #region Buttons
        void ButtonHomeClick(object sender, RoutedEventArgs e) //Головна сторінка
        {
            ButtonTransperent();

            ButtonHome.ClearValue(BackgroundProperty);

            MainWindowFrame.Navigate(new Uri("Pages/HomePage.xaml", UriKind.Relative));
        }
        void ButtonCalculatorClick(object sender, RoutedEventArgs e) //Сторінка калькулятор
        {
            ButtonTransperent();

            ButtonCalculator.ClearValue(BackgroundProperty);

            MainWindowFrame.Navigate(new Uri("Pages/CalculatorPage.xaml", UriKind.Relative));
        }
        void ButtonApartmentsClick(object sender, RoutedEventArgs e) //Сторінка квартир
        {
            ButtonTransperent();

            ButtonApartments.ClearValue(BackgroundProperty);

            MainWindowFrame.Navigate(new Uri("Pages/ApartmentsPage.xaml", UriKind.Relative));
        }

        void ButtonSettingsClick(object sender, RoutedEventArgs e) //Сторінка параметрів
        {
            ButtonTransperent();

            MainWindowFrame.Navigate(new Uri("Pages/SettingsPage.xaml", UriKind.Relative));
        }
        void ButtonLogoutClick(object sender, RoutedEventArgs e) //вихід з акаунту
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            App.user = default;

            Close();
        }
        void ButtonTransperent() //Очищення фону для кнопок
        {
            ButtonHome.Background = Brushes.Transparent;
            ButtonCalculator.Background = Brushes.Transparent;
            ButtonApartments.Background = Brushes.Transparent;
        }
        #endregion
    }
}
