using Practice2.Data.Entity;
using Practice2.Data.JsonData;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Practice2.Pages
{
    using BCrypt.Net;
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected async void Login(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();

            User user = JsonData.LoadUsersFromJson().Find(u => u.Username == logUsername.Text);

            string username = logUsername.Text.Trim();
            string password = logPassword.Password.Trim();


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {

                logUsername.BorderBrush = Brushes.Red;
                logPassword.BorderBrush = Brushes.Red;

                HandyControl.Controls.MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                await Task.Delay(3000);

                logUsername.ClearValue(Border.BorderBrushProperty);
                logPassword.ClearValue(Border.BorderBrushProperty);

            }

            if (!BCrypt.Verify(logPassword.Password, user.Password))
            {
                MessageBox.Show("Не правильний логін або пароль.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                App.user = user;

                Window.GetWindow(this).Close();

                mainWindow.Show();
            }
        }

        private void hplCreateAccount(object sender, RoutedEventArgs e)
        {
            Authorization parentWindow = (Authorization)Window.GetWindow(this);
            parentWindow.AuthorizationMainFrame.Navigate(new RegistrationPage());
        }
    }
}
