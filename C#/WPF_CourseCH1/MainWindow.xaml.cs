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

namespace WPF_CourseCH1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LeButton.Content = "HeeeYaaaa";
            LeButton.Width = 200;

            TextBlock_Header.Text = "Hello from the CS side... :)";
            TextBlock_Header.Foreground = Brushes.Orange;
            
            /// Commented part creates text block from code behind and places it in window
            /// But in this state overwrites everything in the xaml window

            /*
            TextBlock myTb= new TextBlock();
            myTb.Text = "Text block created in\n codebehind completely";
            myTb.Inlines.Add("this is added using inlines!");
            myTb.Inlines.Add(new Run("Run text that I added in code behind")
            {
                Foreground = Brushes.Red,
                TextDecorations = TextDecorations.Underline
            });
            myTb.TextWrapping = TextWrapping.Wrap;
            myTb.Foreground = Brushes.DarkGoldenrod;
            this.Content = myTb;    // makes myTb to be content of main window
            */

        }

        private void LeButton_Click(object sender, RoutedEventArgs e)
        {
            LeButton.Content = "Johny!";
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LeButton2_Click(object sender, RoutedEventArgs e)
        {
            LeLabel.Background = Brushes.Orange;
            LeLabel.Foreground = Brushes.White;
            LeLabel.Content = "You are DOOMed!!!";
            LeLabel.FontSize += 1;
            LeButton2.Foreground = Brushes.DarkRed;
            LeButton2.Background = Brushes.Red;
        }

        private void LeButton2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            LeLabel.Background = Brushes.LightBlue;
            LeLabel.Foreground= Brushes.Black;
            LeLabel.Content = "Or not?";
            LeLabel.FontSize -= 3;
        }

        private void LeButton2_MouseEnter(object sender, MouseEventArgs e)
        {
            LeButton.Background = Brushes.LightGreen;
            LeLabel.Content = "Whats going to happen?";
        }

        private void LeButton2_MouseLeave(object sender, MouseEventArgs e)
        {
            LeButton.Background = Brushes.Violet;
            LeLabel.Content = "Everything is awesome!!!";
        }

        private void BMW_button_Checked(object sender, RoutedEventArgs e)
        {
            BMW_label.Background = Brushes.LightCyan;
            Great_button.IsChecked = true;
        }

        private void Audi_button_Checked(object sender, RoutedEventArgs e)
        {
            Audi_label.Background = Brushes.LightCyan;
            Gay_button.IsChecked = true;
        }

        private void Mercedes_button_Checked(object sender, RoutedEventArgs e)
        {
            Mercedes_label.Background = Brushes.LightCyan;
            Gay_button.IsChecked = true;
        }

        private void Nissan_button_Checked(object sender, RoutedEventArgs e)
        {
            Nissan_label.Background = Brushes.LightCyan;
            OK_button.IsChecked = true;
        }

        private void BMW_button_Unchecked(object sender, RoutedEventArgs e)
        {
            BMW_label.Background = Brushes.Transparent;
        }

        private void Audi_button_Unchecked(object sender, RoutedEventArgs e)
        {
            Audi_label.Background = Brushes.Transparent;
        }

        private void Mercedes_button_Unchecked(object sender, RoutedEventArgs e)
        {
            Mercedes_label.Background = Brushes.Transparent;
        }

        private void Nissan_button_Unchecked(object sender, RoutedEventArgs e)
        {
            Nissan_label.Background = Brushes.Transparent;
        }

        private void Engine_Checked(object sender, RoutedEventArgs e)
        {
            Engine_lbl.Background = Brushes.LightGray;
        }

        private void Wheels_Checked(object sender, RoutedEventArgs e)
        {
            Wheels_lbl.Background = Brushes.LightGray;
        }

        private void Body_Checked(object sender, RoutedEventArgs e)
        {
            Body_lbl.Background = Brushes.LightGray;
        }

        private void Infotainment_Checked(object sender, RoutedEventArgs e)
        {
            Infotainment_lbl.Background= Brushes.LightGray;
        }

        private void Seats_Checked(object sender, RoutedEventArgs e)
        {
            Seats_lbl.Background = Brushes.LightGray;
        }

        private void Suspension_Checked(object sender, RoutedEventArgs e)
        {
            Suspension_lbl.Background = Brushes.LightGray;
        }

        private void Engine_Unchecked(object sender, RoutedEventArgs e)
        {
            Engine_lbl.Background = Brushes.Transparent;
        }

        private void Wheels_Unchecked(object sender, RoutedEventArgs e)
        {
            Wheels_lbl.Background = Brushes.Transparent;
        }

        private void Body_Unchecked(object sender, RoutedEventArgs e)
        {
            Body_lbl.Background = Brushes.Transparent;
        }

        private void Infotainment_Unchecked(object sender, RoutedEventArgs e)
        {
            Infotainment_lbl.Background = Brushes.Transparent;
        }

        private void Seats_Unchecked(object sender, RoutedEventArgs e)
        {
            Seats_lbl.Background = Brushes.Transparent;
        }

        private void Suspension_Unchecked(object sender, RoutedEventArgs e)
        {
            Suspension_lbl.Background = Brushes.Transparent;
        }

        private void Master_Checked(object sender, RoutedEventArgs e)
        {
            Engine.IsEnabled = true;
            Wheels.IsEnabled = true;
            Body.IsEnabled = true;
            Infotainment.IsEnabled = true;
            Seats.IsEnabled = true;
            Suspension.IsEnabled = true;
        }

        private void Master_Unchecked(object sender, RoutedEventArgs e)
        {
            Engine.IsChecked = false;
            Wheels.IsChecked = false;
            Body.IsChecked = false;
            Infotainment.IsChecked = false;
            Seats.IsChecked = false;
            Suspension.IsChecked = false;
            Engine.IsEnabled = false;
            Wheels.IsEnabled = false;
            Body.IsEnabled = false;
            Infotainment.IsEnabled = false;
            Seats.IsEnabled = false;
            Suspension.IsEnabled = false;
        }

        private void ImageHomer_MouseUp(object sender, MouseButtonEventArgs e)
        {
            HomerIMG.Source = new BitmapImage(new Uri(@"/WPF_CourseCH1;component/Images/homer.png", UriKind.Relative));
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (SliderTextBlock != null)
            {
                SliderTextBlock.Text = $"Slider value is: {Slider.Value.ToString()} by CS-code";
                if (Slider.Value == 10)
                {
                    SliderTextBlock.Text = "XXX";
                }
                SliderTextBlock.FontSize = Slider.Value;
            }
            
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            CalendarTextBlock.Text = Calendar.SelectedDate.ToString();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((sender as DatePicker).SelectedDate != null)
            {
                string myDate = (sender as DatePicker).SelectedDate.ToString();
                MessageBox.Show($"Date has been changed to {myDate}");
            }
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Booyakasha!!!");
        }
    }
}