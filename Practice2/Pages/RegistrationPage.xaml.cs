using Practice2.Data;
using Practice2.Data.Entity;
using Practice2.Data.JsonData;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Practice2.Pages
{
    using BCrypt.Net;
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        #region Registration
        protected async void Registration(object sender, RoutedEventArgs e) //Здійснює вхід користувача
        {
            MainWindow mainWindow = new MainWindow();

            string username = regUsername.Text.Trim();
            string password = regPassword.Password.Trim();
            string confirmpassword = regConfirmPassword.Password.Trim();

            bool isAdmin = DataHandler.IsFileEmptyUser();
            User user = new User(
                username: regUsername.Text,
                password: regPassword.Password,
                isAdmin: isAdmin,
                apartment: null
            );

            user.Password = BCrypt.HashPassword(regPassword.Password);

            if (DataHandler.UserExists(user))
            {
                return;
            }
            else
            {

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmpassword))
                {

                    regUsername.BorderBrush = Brushes.Red;
                    regPassword.BorderBrush = Brushes.Red;
                    regConfirmPassword.BorderBrush = Brushes.Red;

                    HandyControl.Controls.MessageBox.Show(DataHandler.GetTextComponent("registration_exception1"), DataHandler.GetTextComponent("exception"), MessageBoxButton.OK, MessageBoxImage.Error);

                    await Task.Delay(3000);

                    regUsername.ClearValue(Border.BorderBrushProperty);
                    regPassword.ClearValue(Border.BorderBrushProperty);
                    regConfirmPassword.ClearValue(Border.BorderBrushProperty);

                    return;
                }
                else if (username.Length <= 2 || username.Length >= 15)
                {
                    regUsername.BorderBrush = Brushes.Red;

                    if (username.Length <= 2) HandyControl.Controls.MessageBox.Show(DataHandler.GetTextComponent("registration_exception2"), DataHandler.GetTextComponent("exception"), MessageBoxButton.OK, MessageBoxImage.Error);

                    if (username.Length >= 15) HandyControl.Controls.MessageBox.Show(DataHandler.GetTextComponent("registration_exception3"), DataHandler.GetTextComponent("exception"), MessageBoxButton.OK, MessageBoxImage.Error);

                    await Task.Delay(3000);

                    regUsername.ClearValue(Border.BorderBrushProperty);

                    return;
                }
                if (password.Length <= 6 || password.Length >= 18)
                {
                    regPassword.BorderBrush = Brushes.Red;

                    if (password.Length <= 6) HandyControl.Controls.MessageBox.Show(DataHandler.GetTextComponent("registration_exception4"), DataHandler.GetTextComponent("exception"), MessageBoxButton.OK, MessageBoxImage.Error);

                    if (password.Length >= 18) HandyControl.Controls.MessageBox.Show(DataHandler.GetTextComponent("registration_exception5"), DataHandler.GetTextComponent("exception"), MessageBoxButton.OK, MessageBoxImage.Error);

                    await Task.Delay(3000);

                    regPassword.ClearValue(Border.BorderBrushProperty);

                    return;
                }
                else if (password != confirmpassword)
                {
                    regPassword.BorderBrush = Brushes.Red;
                    regConfirmPassword.BorderBrush = Brushes.Red;

                    HandyControl.Controls.MessageBox.Show(DataHandler.GetTextComponent("registration_exception6"), DataHandler.GetTextComponent("exception"), MessageBoxButton.OK, MessageBoxImage.Error);

                    await Task.Delay(3000);

                    regPassword.ClearValue(Border.BorderBrushProperty);
                    regConfirmPassword.ClearValue(Border.BorderBrushProperty);

                    return;
                }

                JsonData.SaveUsersToJson(user);

                App.user = user;

                Window.GetWindow(this).Close();

                mainWindow.Show();
            }
        }
        #endregion

        void HyperLinkLogIn(object sender, RoutedEventArgs e)  //Змінює сторінку реєстрацію на логіна 
        {
            Authorization parentWindow = (Authorization)Window.GetWindow(this);
            parentWindow.AuthorizationMainFrame.Navigate(new LoginPage());
        }
    }
}
