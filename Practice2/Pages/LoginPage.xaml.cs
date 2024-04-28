using Practice2.Data.Entity;
using Practice2.Data.JsonData;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Practice2.Pages
{
    using BCrypt.Net;
    using Practice2.Data;

    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();

        }
        #region Login
        protected async void Login(object sender, RoutedEventArgs e) //Здійснює вхід користувача
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

                    HandyControl.Controls.MessageBox.Show(DataHandler.GetTextComponent("login_exception1"), DataHandler.GetTextComponent("exception"), MessageBoxButton.OK, MessageBoxImage.Error);

                    await Task.Delay(3000);

                    logUsername.ClearValue(Border.BorderBrushProperty);
                    logPassword.ClearValue(Border.BorderBrushProperty);

                    return;
                }
                else if (!BCrypt.Verify(logPassword.Password, user.Value.Password))
                {

                    logUsername.BorderBrush = Brushes.Red;
                    logPassword.BorderBrush = Brushes.Red;

                    HandyControl.Controls.MessageBox.Show(DataHandler.GetTextComponent("login_exception1"), DataHandler.GetTextComponent("exception"), MessageBoxButton.OK, MessageBoxImage.Error);

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

                HandyControl.Controls.MessageBox.Show(DataHandler.GetTextComponent("login_exception2"), DataHandler.GetTextComponent("exception"), MessageBoxButton.OK, MessageBoxImage.Error);

                await Task.Delay(3000);

                logUsername.ClearValue(Border.BorderBrushProperty);

                return;
            }

        }
        #endregion
        void HyperLinkSingIn(object sender, RoutedEventArgs e) //Змінює сторінку логіна на реєстрацію
        {
            Authorization parentWindow = (Authorization)Window.GetWindow(this);
            parentWindow.AuthorizationMainFrame.Navigate(new RegistrationPage());
        }
    }
}
