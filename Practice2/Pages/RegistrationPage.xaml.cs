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

            if (password != confirmpassword)
            {
                regPassword.BorderBrush = Brushes.Red;
                regConfirmPassword.BorderBrush = Brushes.Red;

                HandyControl.Controls.MessageBox.Show("Passwords are different!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                await Task.Delay(3000);

                regPassword.ClearValue(Border.BorderBrushProperty);
                regConfirmPassword.ClearValue(Border.BorderBrushProperty);

                return;
            }

            bool isAdmin = Handler.IsFileEmpty();
            User user = new User(
                username: regUsername.Text,
                password: regPassword.Password,
                isAdmin: isAdmin
            );
            user.Password = BCrypt.HashPassword(regPassword.Password);

            if (Handler.UserExists(user))
            {
                return;
            }
            else
            {
                JsonData.SaveUsersToJson(user);

                App.user = user;

                Window.GetWindow(this).Close();

                mainWindow.Show();
            }
        }

        public void hplLoginAccount(object sender, RoutedEventArgs e)
        {
            Authorization parentWindow = (Authorization)Window.GetWindow(this);
            parentWindow.AuthorizationMainFrame.Navigate(new LoginPage());
        }
    }
}
