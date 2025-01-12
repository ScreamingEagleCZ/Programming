using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Course_CH4_Menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void New_File_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New File clicked...");
        }

        private void New_Project_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New Project clicked...");
        }

        private void Open_File_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Open File clicked...");
        }

        private void Open_Project_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Open Project clicked...");
        }

        private void Clone_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Clone Repository clicked...");
        }
    }
}