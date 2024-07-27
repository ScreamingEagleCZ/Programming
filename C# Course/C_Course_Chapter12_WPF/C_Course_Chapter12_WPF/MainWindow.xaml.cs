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

namespace C_Course_Chapter12_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button myButton = new Button(); // create "B" button
            myButton.Content = "B";         // set content for button
            Grid.SetRow(myButton, 3);       // set row property for button
            Grid.SetColumn(myButton, 4);

            Grid myGrid = (Grid)FindName("myGrid"); // find the element with name "myGrid" cast it to Grid and save to variable myGrid
            myGrid.Children.Add(myButton);          // add button to my Grid
        }
        private void ButtonA_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Oh, hello there Buddy!");
        }
    }
}