using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
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



// TODO: Owner queries, inserting
// TODO: filter

namespace Lab10

{
    public partial class MainWindow : Window
    {
        protected string DataBaseConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Desktop\STUDIA\4 semestr\oop\Lab10\Database1.mdf;Integrated Security=True";



        public List<Car> list;


        public List<Car> SqlCarSelect()
        {
            var list = new List<Car>();
            using (var dataBase = new SqlConnection(DataBaseConnectionString))
            {
                var cmd = dataBase.CreateCommand();
                cmd.CommandText = "SELECT [Marka], [DataProdukcji], [LiczbaDrzwi], [NrRejestracyjny], [Przebieg] FROM [dbo].[CarsDB]";
                cmd.CommandType = CommandType.Text;

                dataBase.Open();
                var res = cmd.ExecuteReader();
                while (res.Read())
                    list.Add(new Car() { model = res.GetString(0), productionDate = res.GetDateTime(1), doorNumber = res.GetInt32(2), NrRejestracyjny = res.GetString(3), przebieg = res.GetInt32(4) });
                

            }


            return list;
        }





        public void SqlCarInsert(Car car)
        {
            using (var db = new SqlConnection(DataBaseConnectionString))
            {
                var cmd = db.CreateCommand();
                cmd.CommandText = "INSERT INTO [dbo].[CarsDB]([Marka], [DataProdukcji], [LiczbaDrzwi],[NrRejestracyjny], [Przebieg]) VALUES(@a, @b, @c, @d, @e);";

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@a", car.model);
                cmd.Parameters.AddWithValue("@b", car.productionDate);
                cmd.Parameters.AddWithValue("@c", car.doorNumber);
                cmd.Parameters.AddWithValue("@d", car.NrRejestracyjny);
                cmd.Parameters.AddWithValue("@e", car.przebieg);

                db.Open();
                var res = cmd.ExecuteNonQuery();
                Debug.WriteLine("Lines inserted : " + res);

            }
        }


        public void SqlRemoveCar(Car car)
        {
            using (var db = new SqlConnection(DataBaseConnectionString))
            {
                var command = db.CreateCommand();
                command.CommandText = @"delete from [dbo].[CarsDB] where [NrRejestracyjny] = @regNum;";
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@regNum", car.NrRejestracyjny);

                db.Open();
                var query = command.ExecuteNonQuery();
                Debug.WriteLine("Lines deleted : " + query);
            }
        }


        public MainWindow()
        {
            InitializeComponent();


            list = SqlCarSelect();



            carsDG.ItemsSource = list;


            carsDG.AutoGenerateColumns = false;
            carsDG.CanUserAddRows = false;
            carsDG.CanUserResizeColumns = false;
            carsDG.CanUserReorderColumns = false;
            carsDG.CanUserDeleteRows = false;

        }

        private void addCarButton_Click(object sender, RoutedEventArgs e)
        {

            var dialog = new AddCarWindow(list);
            if (dialog.ShowDialog() == true)
            {
                SqlCarInsert(dialog.car);
                list.Add(dialog.car);
                carsDG.Items.Refresh();
            }
            



        }

        private void deleteCarButton_Click(object sender, RoutedEventArgs e)
        {
            if(carsDG.SelectedItem is Car)
            {
                SqlRemoveCar((Car)carsDG.SelectedItem);
                list.Remove((Car)carsDG.SelectedItem);
                carsDG.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Musisz wybrać samochód do usunięcia!");
            }
        }

        private void ownerInfoButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
