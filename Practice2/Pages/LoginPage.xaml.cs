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

            DataContext = this;

        }

        protected async void Login(object sender, RoutedEventArgs e)
        {

            string username = logUsername.Text.Trim();
            string password = logPassword.Password.Trim();

            User? user = JsonData.LoadUsersFromJson().Find(u => u.Username == logUsername.Text);

            if (user != null && user.Value.Username != null && user.Value.Password != null)
            {

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {

                    logUsername.BorderBrush = Brushes.Red;
                    logPassword.BorderBrush = Brushes.Red;

                    HandyControl.Controls.MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                    await Task.Delay(3000);

                    logUsername.ClearValue(Border.BorderBrushProperty);
                    logPassword.ClearValue(Border.BorderBrushProperty);

                    return;
                }
                else if (!BCrypt.Verify(logPassword.Password, user.Value.Password))
                {

                    logUsername.BorderBrush = Brushes.Red;
                    logPassword.BorderBrush = Brushes.Red;

                    HandyControl.Controls.MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                    await Task.Delay(3000);

                    logUsername.ClearValue(Border.BorderBrushProperty);
                    logPassword.ClearValue(Border.BorderBrushProperty);

                    return;
                }
                else
                {
                    App.user = (User)user;

                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();

                    Window parentWindow = Window.GetWindow(this);
                    parentWindow.Close();
                }
            }
            else
            {
                logUsername.BorderBrush = Brushes.Red;

                HandyControl.Controls.MessageBox.Show("User don`t exist", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                await Task.Delay(3000);

                logUsername.ClearValue(Border.BorderBrushProperty);

                return;
            }

        }

        private void HyperLinkSingIn(object sender, RoutedEventArgs e)
        {
            Authorization parentWindow = (Authorization)Window.GetWindow(this);
            parentWindow.AuthorizationMainFrame.Navigate(new RegistrationPage());
        }
    }
}
