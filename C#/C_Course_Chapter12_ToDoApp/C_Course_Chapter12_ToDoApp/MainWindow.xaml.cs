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

namespace C_Course_Chapter12_ToDoApp
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

        private void AddTodoButton_Click(object sender, RoutedEventArgs e)
        {
            string todoText = ToDoInput.Text;   // Read text from TextBox
            if (!string.IsNullOrEmpty(todoText))
            {
                // Possibility to add text the older way below...
                // TextBlock todoItem = new TextBlock();
                // todoItem.Text = todoText;
                TextBlock todoItem = new TextBlock // newer way of accessing properties directly
                { 
                    Text = todoText, 
                    Margin = new Thickness(10),
                    Foreground = new SolidColorBrush(Colors.White),
                }; 
                ToDoList.Children.Add(todoItem);    // Add text to ToDoList StackPanel
                ToDoInput.Clear();  // Clear the TextBox
            }
        }
    }
}