using Practice2.Data.Entity;
using Practice2.Data.JsonData;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;

namespace Practice2
{
    public partial class Editapartment : Window
    {
        public Editapartment()
        {
            InitializeComponent();

            List<Apartments> Apartments = JsonData.LoadApartmentsFromJson();

            ComboBoxApartmentsChoise.Items.Clear();

            foreach (var apartment in Apartments) //Додає квартири в список для редагування
            {
                ComboBoxItem comboBox = new ComboBoxItem();

                comboBox.Content = apartment.Name;

                ComboBoxApartmentsChoise.Items.Add(comboBox);
            }

            ComboBoxApartmentsChoiseDelete.Items.Clear();

            foreach (var apartment in Apartments) //Додає квартири в список для видалення
            {
                ComboBoxItem comboBox = new ComboBoxItem();

                comboBox.Content = apartment.Name;

                ComboBoxApartmentsChoiseDelete.Items.Add(comboBox);
            }
        }

        #region Buttons
        void ButtonDeleteClick(object sender, RoutedEventArgs e) //Видаляє квартиру з json файлу
        {

            List<Apartments> Apartments = JsonData.LoadApartmentsFromJson();

            var apartmentToRemove = Apartments.Find(a => a.Name == ComboBoxApartmentsChoiseDelete.Text);

            Apartments.Remove(apartmentToRemove);

            string json = JsonSerializer.Serialize(Apartments, JsonData.optionsSerializer);
            File.WriteAllText(JsonData.apartmentfile, json);

            Editapartment editapartment = new Editapartment();

            this.Close();

            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

            editapartment.Owner = mainWindow;
            editapartment.ShowDialog();

            ButtonDelete.IsEnabled = false;
        }
        void ButtonEditSave(object sender, RoutedEventArgs e)  //Зберігає зміни користувача в json
        {
            List<Apartments> Apartments = JsonData.LoadApartmentsFromJson();

            var apartmentToUpdate = Apartments.Find(a => a.Name == ComboBoxApartmentsChoise.Text);

            apartmentToUpdate.Owner = TextBoxOwner.Text;
            apartmentToUpdate.Area = (int)NumericUpDownArea.Value;
            apartmentToUpdate.Floor = (int)NumericUpDownFloor.Value;
            apartmentToUpdate.PublicUtilities = (int)NumericUpDownBill.Value;

            JsonData.SaveApartmentsToJson(apartmentToUpdate);

            Editapartment editapartment = new Editapartment();

            this.Close();

            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

            editapartment.Owner = mainWindow;
            editapartment.ShowDialog();
        }
        #endregion

        #region ComboBox
        void ComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e) //Дозволяє змінювати значення в квартирі, якщо користувач обрав її з списку
        {

            List<Apartments> Apartments = JsonData.LoadApartmentsFromJson();

            if (TextBoxOwner.IsEnabled != true)
            {
                TextBoxOwner.IsEnabled = true;
                NumericUpDownArea.IsEnabled = true;
                NumericUpDownBill.IsEnabled = true;
                NumericUpDownFloor.IsEnabled = true;
            }


            if (Apartments != null)
            {
                var apartmentToUpdate = Apartments.Find(a => a.Name == ComboBoxApartmentsChoise.Text);

                if (apartmentToUpdate.Name != null)
                {

                    TextBoxOwner.Text += apartmentToUpdate.Owner;
                    NumericUpDownArea.Value = apartmentToUpdate.Area;
                    NumericUpDownFloor.Value = apartmentToUpdate.Floor;
                    NumericUpDownBill.Value = apartmentToUpdate.PublicUtilities;

                    ButtonSave.IsEnabled = true;
                    return;
                }
            }

        }

        void ComboBoxDeleteSelectionChanged(object sender, SelectionChangedEventArgs e) { ButtonDelete.IsEnabled = true; } //Дозволяє видаляти квартиру, якщо користувач обрав її з списку
        #endregion

        void TextBoxOwnerIsEmpty(object sender, TextChangedEventArgs e) //Якщо користувач не ввів ім`я власника
        {
            if (TextBoxOwner.Text.Length < 0) { TextBoxOwner.Text = "None"; }
            return;
        }
    }
}
