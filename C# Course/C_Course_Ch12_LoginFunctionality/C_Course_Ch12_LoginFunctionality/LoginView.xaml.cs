using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace C_Course_Ch12_LoginFunctionality
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }
        public void OnLoginBtnClicked(object sender, RoutedEventArgs e)
        {
            string passwordEntered = PassBox.Password;

            string? envPw = Environment.GetEnvironmentVariable("UltraPassword");

            if (envPw != null)
            {
                if (passwordEntered == envPw) {
                    MessageBox.Show("Entered correct password...");
                } else {
                    MessageBox.Show("Password wrong...");
                }
            } else
            {
                MessageBox.Show("Environment variable not found");
            }
        }
        public void OnPasswordChanged(object sender, EventArgs e)
        {
            LoginButton.IsEnabled = !string.IsNullOrEmpty(PassBox.Password);
        }
    }
}
