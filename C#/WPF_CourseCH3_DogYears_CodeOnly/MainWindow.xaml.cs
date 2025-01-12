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

namespace WPF_CourseCH3_DogYears_CodeOnly
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TextBlock ResultTextBlock;
        public TextBox InputDogAge;
        StackPanel MainVerticalStackPanel = new StackPanel();   // creates panel to insert additional elements
        public MainWindow()
        {
            InitializeComponent();
            myMainWindow.Title = "Dog years calculator - built in code behind";
            myMainWindow.Width = 410;
            Image backgroundImage = new Image()
            {
                Source = new BitmapImage(new Uri("pack://application:,,,/WPF_CourseCH3_DogYears_CodeOnly;component/Images/doggo.png")),
                Width = 300
            };

            ResultTextBlock = new TextBlock() { Text = "Your dog is ...", FontSize = 16};
            InputDogAge = new TextBox() 
            { 
                Width = 120, 
                TextAlignment = TextAlignment.Center, 
                FontSize = 16, 
                Margin = new Thickness(5,0,0,0) 
            };
            InputDogAge.KeyDown += InputDogAge_KeyDown; // adding event in c#

            TextBlock userQuestion = new TextBlock() { Text = "How old is your dog?", FontSize = 18};

            StackPanel HorizontalSP = new StackPanel() { Orientation = Orientation.Horizontal, Margin = new Thickness(1,5,0,0)};

            HorizontalSP.Children.Add(userQuestion);
            HorizontalSP.Children.Add(InputDogAge);
            MainVerticalStackPanel.Children.Add(HorizontalSP);
            MainVerticalStackPanel.Children.Add(ResultTextBlock);   
            MainVerticalStackPanel.Children.Add(backgroundImage);

            myMainWindow.Content = MainVerticalStackPanel;  //shows the above stackpanel on window
        }
        private void InputDogAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                try
                {
                    int inputDogAge = Int32.Parse(InputDogAge.Text);
                    string resultHumanAge = "";
                    if (inputDogAge >= 0 && inputDogAge <= 1)
                    {
                        resultHumanAge = "0-15";
                        ResultTextBlock.Text = "Your dog is " + resultHumanAge + " years old";
                    }
                    if (inputDogAge == 2)
                    {
                        resultHumanAge = "16-24";
                        ResultTextBlock.Text = "Your dog is " + resultHumanAge + " years old";
                    }
                    if (inputDogAge >= 3)
                    {
                        resultHumanAge = (24 + (inputDogAge - 2) * 4).ToString();
                        ResultTextBlock.Text = "Your dog is " + resultHumanAge + " years old";
                    }
                    TextBlock congratulations = new TextBlock() { Text = "Congratulations to him!"};
                    MainVerticalStackPanel.Children.Add(congratulations);   // this line will be added after entering the age
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please input whole number" + ex);
                }
            }
        }
    }
}