using System.Collections.ObjectModel;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WPFCourse_CH6_DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<int> availableNumbers { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            availableNumbers = new ObservableCollection<int>();
            for (int i = 0; i < 10; i++)
            {
                availableNumbers.Add(i);
            }
            //possibility to set the databinding of window to itself/ 2nd option define it in xaml "header" code - DataContext="{Binding RelativeSource={RelativeSource Self}}"
            this.DataContext = this;
        }

        private void btnAddNumber(object sender, RoutedEventArgs e)
        {
            try
            {
                availableNumbers.Add(cbCars.SelectedIndex);
            } catch
            {
                MessageBox.Show("Please select something from lower combo box...");
            }

        }

        private void btnDeleteNumber(object sender, RoutedEventArgs e)
        {
            try
            {
                availableNumbers.Remove(lbNumbers.SelectedIndex);
            } catch {
                MessageBox.Show("Nothing is selected...");
            }
        }
    }
}