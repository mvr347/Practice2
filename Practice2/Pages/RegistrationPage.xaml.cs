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
        protected async void Registration(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();

            string username = regUsername.Text.Trim();
            string password = regPassword.Password.Trim();
            string confirmpassword = regConfirmPassword.Password.Trim();

            bool isAdmin = DataHandler.IsFileEmpty();
            User user = new User(
                username: regUsername.Text,
                password: regPassword.Password,
                isAdmin: isAdmin
            );

            user.Password = BCrypt.HashPassword(regPassword.Password);

            if (DataHandler.UserExists(user))
            {
                return;

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmpassword))
                {

                    regUsername.BorderBrush = Brushes.Red;
                    regPassword.BorderBrush = Brushes.Red;
                    regConfirmPassword.BorderBrush = Brushes.Red;

                    HandyControl.Controls.MessageBox.Show("Incorrect username,password or password confirm!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                    await Task.Delay(3000);

                    regUsername.ClearValue(Border.BorderBrushProperty);
                    regPassword.ClearValue(Border.BorderBrushProperty);
                    regConfirmPassword.ClearValue(Border.BorderBrushProperty);

                    return;
                }
                else if (username.Length <= 2 || username.Length >= 15)
                {
                    regUsername.BorderBrush = Brushes.Red;

                    if (username.Length <= 2) HandyControl.Controls.MessageBox.Show("Username too short!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                    if (username.Length >= 15) HandyControl.Controls.MessageBox.Show("Username too long!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                    await Task.Delay(3000);

                    regUsername.ClearValue(Border.BorderBrushProperty);

                    return;
                }
                if (password.Length <= 6 || password.Length >= 18)
                {
                    regPassword.BorderBrush = Brushes.Red;

                    if (password.Length <= 6) HandyControl.Controls.MessageBox.Show("Passwords too short!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                    if (password.Length >= 18) HandyControl.Controls.MessageBox.Show("Passwords too long!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                    await Task.Delay(3000);

                    regPassword.ClearValue(Border.BorderBrushProperty);

                    return;
                }
                else if (password != confirmpassword)
                {
                    regPassword.BorderBrush = Brushes.Red;
                    regConfirmPassword.BorderBrush = Brushes.Red;

                    HandyControl.Controls.MessageBox.Show("Passwords are different!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                    await Task.Delay(3000);

                    regPassword.ClearValue(Border.BorderBrushProperty);
                    regConfirmPassword.ClearValue(Border.BorderBrushProperty);

                    return;
                }

            }
            else
            {
                JsonData.SaveUsersToJson(user);

                App.user = user;

                Window.GetWindow(this).Close();

                mainWindow.Show();
            }
        }

        public void HyperLinkLogIn(object sender, RoutedEventArgs e)
        {
            Authorization parentWindow = (Authorization)Window.GetWindow(this);
            parentWindow.AuthorizationMainFrame.Navigate(new LoginPage());
        }
    }
}
