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
    /// Interaction logic for AddFood.xaml
    /// </summary>
    public partial class AddFood : Window
    {
        public AddFood()
        {
            InitializeComponent();
            DataContext = this;
        }

        public ObservableCollection<Food> baseList =new();
        public ObservableCollection<Food> store { get; set; } = new();

        public Food NewFood { get; set; }=new();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NewFood.Name == string.Empty || NewFood.Price == 0 || NewFood.Picture == string.Empty)
            {
                MessageBox.Show("Fill in all the lines!", "Info", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
            else
            {
                store.Add(NewFood);
                baseList.Add(NewFood);
                NewFood = new();
                Close();
                MessageBox.Show("Food added completed", "Info", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                
            }
            
        }
    }
}
