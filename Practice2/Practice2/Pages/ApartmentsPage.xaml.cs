using Practice2.Data.Entity;
using Practice2.Data.JsonData;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Practice2.Pages
{
    public partial class ApartmentsPage : Page
    {
        public ApartmentsPage()
        {
            InitializeComponent();

            if (App.user.IsAdmin != false) //Якщо користувач адміністратор, кнопка редагування квартир з`являється
            {
                ButtonEditApartments.Visibility = Visibility.Visible;
            }

            if (!File.Exists(JsonData.apartmentfile)) //Якщо файл не існує він створюється, з`являються кнопки створення квартир
            {
                JsonData.CreateFile();

                TextBoxNoApartments.Visibility = Visibility.Visible;
                ButtonNoApartments.Visibility = Visibility.Visible;
            }

            List<Apartments> Apartments = JsonData.LoadApartmentsFromJson();

            if (Apartments == null || !Apartments.Any()) //Якщо в файлі немає користувачів або він пустий, з`являються кнопки створення квартир
            {
                TextBoxNoApartments.Visibility = Visibility.Visible;
                ButtonNoApartments.Visibility = Visibility.Visible;

                return;
            }
            else //Відображення списку з квартирами
            {
                TextBoxNoApartments.Visibility = Visibility.Collapsed;
                ButtonNoApartments.Visibility = Visibility.Collapsed;

                ListViewApartments.Visibility = Visibility.Visible;

                ApartmentsListView(); //Загрузка квартир в лист через метод
            }

        }
        void ApartmentsListView() //Загрузка квартир в лист 
        {
            List<Apartments> apartments = JsonData.LoadApartmentsFromJson();

            ListViewApartments.Items.Clear();

            if (apartments != null)
            {

                foreach (var apartment in apartments)
                {
                    ListViewItem listViewItem = new ListViewItem();

                    listViewItem.Content = apartment;

                    ListViewApartments.Items.Add(listViewItem);
                }
            }
            else { return; }

        }
        #region Buttons
        void ButtonCreateApartmentsDataClick(object sender, RoutedEventArgs e) //Перекидає на створення квартир
        {
            HouseCreate HouseCreate = new HouseCreate();

            Window.GetWindow(this).Close();

            HouseCreate.Show();
        }


        private void ButtonSettingsClick(object sender, RoutedEventArgs e) //Перекидає на редагування квартир
        {
            Editapartment editapartment = new Editapartment();

            editapartment.ShowDialog();
        }
        #endregion
    }
}
