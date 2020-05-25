using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab10
{
    /// <summary>
    /// Interaction logic for AddCarWindow.xaml
    /// </summary>
    public partial class AddCarWindow : Window
    {
        public Car car;
        private List<Car> cars;

        public AddCarWindow()
        {
            InitializeComponent();
        }

        public AddCarWindow(List<Car> cars_)
        {
            InitializeComponent();
            cars = new List<Car>(cars_);
        }

      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (
          
               Regex.IsMatch(tbLiczbaDrzwi.Text, @"^[a-zA-Z]+$") ||
               Regex.IsMatch(tbPrzebieg.Text, @"^[a-zA-Z]+$")
               )
            {
                MessageBox.Show("Niepoprawne dane!");
                return;
            }

            if (cars.Any(x => x.NrRejestracyjny == tbNrRej.Text))
            {
                MessageBox.Show("Samochod o podanym numerze rejestracyjnym juz jest zarejestrowany!");
                return;
            }



            car = new Car() { doorNumber = int.Parse(tbLiczbaDrzwi.Text), model = tbModel.Text, NrRejestracyjny = tbNrRej.Text, productionDate = (DateTime)datePicker.SelectedDate, przebieg = int.Parse(tbPrzebieg.Text) };

            this.DialogResult = true;


        }
    }
}
