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

namespace C_Course_Ch12_ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>    // new list of type Person with name People
        {
            new Person{Name = "Jax Teller", Age = 37},  // adding "Persons" to list
            new Person{Name = "Opie", Age = 38},
            new Person{Name = "Gemma", Age = 56},
            new Person{Name = "Juice", Age = 28},
            new Person{Name = "Clay", Age = 62}
        };
        public MainWindow()
        {
            InitializeComponent();
            ListBoxPeople.ItemsSource = People;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxPeople.SelectedItems;
            foreach (var item in selectedItems)
            {
                var person = (Person)item;
                MessageBox.Show(person.Name);
            }
        }
    }
}