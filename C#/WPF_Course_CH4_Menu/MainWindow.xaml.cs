using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.IO;        // for file management
using Microsoft.Win32;  // for file management
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
        string text1 = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. " +
                "Nulla quis diam. Phasellus et lorem id felis nonummy placerat. Nullam eget nisl. " +
                "Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus " +
                "id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor " +
                "repellendus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, " +
                "per inceptos hymenaeos. Phasellus enim erat, vestibulum vel, aliquam a, posuere eu, " +
                "velit. Nulla turpis magna, cursus sit amet, suscipit a, interdum id, felis. " +
                "Fusce nibh. Curabitur ligula sapien, pulvinar a vestibulum quis, facilisis vel sapien. " +
                "Nulla non lectus sed nisl molestie malesuada.";
        string text2 = "Curabitur bibendum justo non orci. Maecenas sollicitudin. Nulla non lectus sed " +
                "nisl molestie malesuada. Duis risus. Nullam justo enim, consectetuer nec, ullamcorper ac, " +
                "vestibulum in, elit. Maecenas fermentum, sem in pharetra pellentesque, velit turpis volutpat " +
                "ante, in pharetra metus odio a lectus. Maecenas sollicitudin. Fusce consectetuer risus a nunc. " +
                "Integer pellentesque quam vel velit. Vivamus porttitor turpis ac leo. Duis aute irure dolor in " +
                "reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Phasellus et lorem " +
                "id felis nonummy placerat. Nullam dapibus fermentum ipsum. Curabitur ligula sapien, pulvinar a " +
                "vestibulum quis, facilisis vel sapien. Etiam posuere lacus quis dolor. Etiam commodo dui eget wisi.";
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
            OpenFileDialog openFileDialog = new OpenFileDialog();   // new object of file dialog

            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // default directory to be opened...
            openFileDialog.InitialDirectory = System.IO.Path.GetFullPath(
                Environment.CurrentDirectory + @"\..\..\..");
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // possibility to filter which files are allowed to open

            if (openFileDialog.ShowDialog() == true)
            {
                tbFilePath.Text = openFileDialog.FileName;   // reads fileName with route fe.: C:\Users\jakub\OneDrive\Documents\Diablo IV\LocalPrefs.txt
                tbFilePath.Visibility = Visibility.Visible;
                myTextBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void Open_Project_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Open Project clicked...");
        }
        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = System.IO.Path.GetFullPath(
                Environment.CurrentDirectory + @"\..\..\..");
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // possibility to filter which file types are allowed to save
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, myTextBox.Text);
            }
        }

        private void Clone_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Clone Repository clicked...");
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(myTextBox.Text + " printed!");
            myTextBox.Text = "";
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {

            myTextBox.Text = "";
        }

        private void cbFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cbFontSize = (ComboBox)sender;
            ComboBoxItem cbFontSizeItem = (ComboBoxItem)cbFontSize.SelectedItem;
            string newFontSize = (string)cbFontSizeItem.Content;

            if (Int32.TryParse(newFontSize, out int temp))
            {
                if(myTextBox != null)
                {
                    myTextBox.FontSize = temp;
                }
            }
        }

        private void miItalic_Click(object sender, RoutedEventArgs e)
        {
            myTextBox.FontStyle = FontStyles.Italic;
        }

        private void miNormal_Click(object sender, RoutedEventArgs e)
        {
            myTextBox.FontStyle = FontStyles.Normal;
        }

        private void miOblique_Click(object sender, RoutedEventArgs e)
        {
            myTextBox.FontStyle = FontStyles.Oblique;
        }

        private void miBold_Checked(object sender, RoutedEventArgs e)
        {
            miLight.IsChecked = false;
            myTextBox.FontWeight = FontWeights.Bold;
        }

        private void miBold_Unchecked(object sender, RoutedEventArgs e)
        {
            myTextBox.FontWeight = FontWeights.Normal;
        }

        private void miLight_Checked(object sender, RoutedEventArgs e)
        {
            miBold.IsChecked = false;
            myTextBox.FontWeight = FontWeights.Light;
        }

        private void miLight_Unchecked(object sender, RoutedEventArgs e)
        {
            myTextBox.FontWeight = FontWeights.Normal;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (miAltText.IsChecked)
            {
                myTextBox.Text = text2;
            } else
            {
                myTextBox.Text = text1;
            }
        }
        private void myTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = myTextBox.Text;
            int length = text.Length;
            sbFilling.Value = GetFilling(length);
            if (sbFilling.Value < 20)
            {
                sbFilling.Foreground = Brushes.Yellow;
            }
            else if (sbFilling.Value < 80)
            {
                sbFilling.Foreground = Brushes.Orange;
            }
            else
            {
                sbFilling.Foreground = Brushes.Green;
            }
        }

        private int GetFilling(int value)
        {
            if (value < 0)
            {
                return 0;
            }
            else if (value > 100)
            {
                return 100;
            } else
            {
                return value;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}