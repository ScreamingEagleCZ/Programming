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

namespace WPF_Course_CH3_DogYears
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

        private void InputAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                try{
                    int inputDogAge = Int32.Parse(InputAge.Text);
                    string dogAge = "";
                    if (inputDogAge >= 0 && inputDogAge <2)
                    {
                        dogAge = "0-15";
                    }
                    if (inputDogAge == 2)
                    {
                        dogAge = "16-24";
                    }
                    if (inputDogAge >= 3)
                    {
                        int tempAge = 24 + (inputDogAge - 2) * 4;
                        dogAge = tempAge.ToString();
                    }
                    string resultHumanAge = $"Your dog is the age of {dogAge} years old human.";
                    ResultTextBlock.Text = resultHumanAge ;
                } catch (Exception myException){
                    MessageBox.Show("Not a valid number, please enter whole years." + myException.Message);
                }
            }
        }
    }
}