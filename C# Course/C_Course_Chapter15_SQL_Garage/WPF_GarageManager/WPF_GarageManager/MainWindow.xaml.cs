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
            ShowCars();
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
                //MessageBox.Show(ex.ToString());
            }

        }

        private void ShowCars()
        {
            try
            {
                string query = "select * from Car";
                // the SqlDataAdapter can be imagined like an Interface to make Tables usable by C# Objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)  // its opening and closing the sql connection as well
                {
                    DataTable carTable = new DataTable();

                    sqlDataAdapter.Fill(carTable);

                    // which Information of the Table in DataTable should be shown in our ListBox?
                    listCars.DisplayMemberPath = "Name";
                    // which Value should be delivered when an Item from our ListBox is selected?
                    listCars.SelectedValuePath = "Id";
                    // the reference to the Data the ListBox should populate
                    listCars.ItemsSource = carTable.DefaultView;
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
            ShowSelectedGarageInTextBox();
        }
        private void listCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowSelectedCarInTextBox();
        }
        private void DeleteGarage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from Garage where id = @GarageId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@GarageId", listGarages.SelectedValue);
                sqlCommand.ExecuteScalar();
            } 
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            } 
            finally
            {
                sqlConnection.Close();
                ShowGarages();
            }


        }
        private void ShowSelectedGarageInTextBox()
        {
            try
            {
                string query = "select location from Garage where Id = @GarageId";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // the SqlDataAdapter can be imagined like an Interface to make Tables usable by C# Objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)  // its opening and closing the sql connection as well
                {

                    sqlCommand.Parameters.AddWithValue("@GarageId", listGarages.SelectedValue);

                    DataTable garageDataTable = new DataTable();

                    sqlDataAdapter.Fill(garageDataTable);

                    myTextBox.Text = garageDataTable.Rows[0]["Location"].ToString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }
        private void ShowSelectedCarInTextBox()
        {
            try
            {
                string query = "select name from Car where Id = @CarId";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // the SqlDataAdapter can be imagined like an Interface to make Tables usable by C# Objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)  // its opening and closing the sql connection as well
                {

                    sqlCommand.Parameters.AddWithValue("@CarId", listCars.SelectedValue);

                    DataTable garageDataTable = new DataTable();

                    sqlDataAdapter.Fill(garageDataTable);

                    myTextBox.Text = garageDataTable.Rows[0]["Name"].ToString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }
        private void AddGarage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Garage values (@Location)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Location", myTextBox.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowGarages();
            }
        }

        private void UpdateGarage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "update Garage Set Location = @Location where Id = @GarageId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@GarageId", listGarages.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Location", myTextBox.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowGarages();
            }
        }

        private void RemoveCar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from GarageCar where GarageId = @GarageId and CarId = @CarId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();

                sqlCommand.Parameters.AddWithValue("@GarageId", listGarages.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@CarId", listAssociatedCars.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowAssociatedCars();
                ShowGarages();
                
            }
        }

        private void AddToGarage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into GarageCar values (@GarageId, @CarId)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@GarageId", listGarages.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@CarId", listCars.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowAssociatedCars();
            }
        }

        private void UpdateCars_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "update Car Set Name = @Name where Id = @NameId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@NameId", listCars.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Name", myTextBox.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowCars();
            }
        }

        private void AddCarToList_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Car values (@Name)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Name", myTextBox.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowCars();
            }
        }

        private void DeleteCarFromList_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from Car where id = @CarId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@CarId", listCars.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowCars();
                ShowAssociatedCars();
            }
        }
    }
}
