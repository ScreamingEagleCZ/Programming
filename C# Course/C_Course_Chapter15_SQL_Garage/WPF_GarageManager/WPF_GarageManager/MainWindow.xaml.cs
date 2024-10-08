using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WPF_GarageManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;


        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["WPF_GarageManager.Properties.Settings.PanjutorialsDBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            ShowGarages();
        }

        private void ShowGarages()
        {
            try
            {
                string query = "select * from Garage";
                // the SqlDataAdapter can be imagined like an Interface to make Tables usable by C# Objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)  // its opening and closing the sql connection as well
                {
                    DataTable garageTable = new DataTable();

                    sqlDataAdapter.Fill(garageTable);

                    // which Information of the Table in DataTable should be shown in our ListBox?
                    listGarages.DisplayMemberPath = "Location";
                    // which Value should be delivered when an Item from our ListBox is selected?
                    listGarages.SelectedValuePath = "Id";
                    // the reference to the Data the ListBox should populate
                    listGarages.ItemsSource = garageTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void ShowAssociatedCars()
        {
            try
            {
                string query = "select * from Car c inner join GarageCar " +
                    "gc on c.Id = gc.CarId where gc.GarageId = @GarageId";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // the SqlDataAdapter can be imagined like an Interface to make Tables usable by C# Objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)  // its opening and closing the sql connection as well
                {

                    sqlCommand.Parameters.AddWithValue("@GarageId", listGarages.SelectedValue);

                    DataTable carTable = new DataTable();

                    sqlDataAdapter.Fill(carTable);

                    // which Information of the Table in DataTable should be shown in our ListBox?
                    listAssociatedCars.DisplayMemberPath = "Name";
                    // which Value should be delivered when an Item from our ListBox is selected?
                    listAssociatedCars.SelectedValuePath = "Id";
                    // the reference to the Data the ListBox should populate
                    listAssociatedCars.ItemsSource = carTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void listGarages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowAssociatedCars();
        }
    }
}
