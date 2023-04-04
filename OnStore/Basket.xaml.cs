using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace OnStore
{
    /// <summary>
    /// Interaction logic for Basket.xaml
    /// </summary>
    public partial class Basket : Window
    {
        

        public Basket()
        {
            InitializeComponent();
            DataContext = this;
        }

        public double Sum { get; set; } = 0;
        public ObservableCollection<Food> basket { get; set; } = new();

        public double BasketSum()
        {
            double sum = 0;
            for (int i = 0; i < basket.Count; i++)
            {
                sum += basket[i].Price;
            }
            return sum;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            basket.Clear();
            Close();
            
            MessageBox.Show("Your purchase has been successfully completed, we are waiting for you again...", "Info",MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }
    }
}
