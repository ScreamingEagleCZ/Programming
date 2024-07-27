using C_Course_Ch12_DataBinding.Data;
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

namespace C_Course_Ch12_DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person  // create instance of class
        {
            Name = "Jax Teller",
            Age = 37
        };

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = person;  // assign context from person to use in text boxes in xaml
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string personData = person.Name + " is " + person.Age + " years old...";
            MessageBox.Show(personData);
        }
    }
}