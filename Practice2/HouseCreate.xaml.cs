using Practice2.Data.Entity;
using Practice2.Data.JsonData;
using System;
using System.Windows;

namespace Practice2
{
    public partial class HouseCreate : Window
    {
        public HouseCreate()
        {
            InitializeComponent();
        }

        void ButtonCreateClick(object sender, RoutedEventArgs e) //Створює квартири за вказівками (параметрами) користувача
        {
            uint count = (uint)ApartmentsCount.Value;
            int totalFloors = (int)ApartmentsFloorCount.Value;

            int minArea = (int)ApartmentsMinArea.Value;
            int maxArea = (int)ApartmentsMaxArea.Value;

            int minBill = (int)ApartmentsMinBill.Value;
            int maxBill = (int)ApartmentsMaxBill.Value;

            JsonData.CreateFile();

            Random rnd = new Random();

            for (uint i = 0; i < count; i++)
            {
                int floor = rnd.Next(1, totalFloors);

                double apArea = rnd.Next(minArea, maxArea);

                int utilitiesBill = apArea < 30 ? rnd.Next(minBill, minBill * 2) : rnd.Next(minBill, maxBill);

                Apartments apartment = new Apartments(
                    name: $"Apartment {floor}-{i + 1}",
                    floor: floor,
                    owner: "None",
                    area: apArea,
                    publicutilities: utilitiesBill
                );

                App.Apartments = (Apartments)apartment;


                JsonData.SaveApartmentsToJson(apartment);
            }

            MainWindow mainWindow = new MainWindow();

            Window.GetWindow(this).Close();

            mainWindow.Show();

            mainWindow.MainWindowFrame.Navigate(new Uri("Pages/ApartmentsPage.xaml", UriKind.Relative));
        }
    }

}

