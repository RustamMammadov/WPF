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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OnStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Food meat = new Food()
        {
            Name = "Meat",
            Picture = "https://media.wired.com/photos/5b493b6b0ea5ef37fa24f6f6/master/w_2560%2Cc_limit/meat-80049790.jpg",
            Price = 14
        };

        Food flour = new Food()
        {
            Name = "Flour",
            Picture = "https://www.unlockfood.ca/EatRightOntario/media/Website-images-resized/All-about-grain-flours-resized.jpg",
            Price = 1
        };

        Food milk = new Food()
        {
            Name = "Milk",
            Picture = "https://th-thumbnailer.cdn-si-edu.com/DxqNnKhkIiGNJ_qtxy86XeqxcgY=/1000x750/filters:no_upscale()/https://tf-cmsv2-smithsonianmag-media.s3.amazonaws.com/filer/6f/6e/6f6e0661-8a07-43f6-ba5c-94f0e5855dbe/istock_000005534054_large.jpg",
            Price = 2
        };

        Food egg = new Food()
        {
            Name = "Egg",
            Picture = "https://kidseatincolor.com/wp-content/uploads/2022/02/eggs-e1648216369366.jpeg",
            Price = 2
        };

        public Food NewFood { get; set; } = new ();

        public ObservableCollection<Food> baseList = new();

        public ObservableCollection<Food> store { get; set; } = new();
        public ObservableCollection<Food> basket { get; set; } = new();

        public MainWindow()
        {
            InitializeComponent();
            
            store = new()
            {
                meat, flour, milk, egg
            };

            for (int i = 0; i < store.Count; i++)
            {
                baseList.Add(store[i]);
            }

            DataContext = this;
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Text_Box == sender)
            {
                Text_Box.Text = string.Empty;
            }
            Text_Box.Foreground = new SolidColorBrush(Colors.Black);

        }

        private void Text_Box_MouseLeave(object sender, MouseEventArgs e)
        {

            if (Text_Box.Text == string.Empty && Text_Box == sender)
            {
                Text_Box.Text = "Search...";
                Text_Box.Foreground = new SolidColorBrush(Colors.LightGray);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.DataContext is Food fd)
                {
                    basket.Add(fd);
                    MessageBox.Show("Food added completed", "Info",MessageBoxButton.OK,MessageBoxImage.Asterisk);

                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (basket.Count != 0)
            {
                Basket w_basket = new Basket();
                w_basket.basket = basket;
                for (int i = 0; i < basket.Count; i++)
                {
                    w_basket.Sum += basket[i].Price;
                }
                w_basket.Show();
            }
            else
            {
                MessageBox.Show("Basket is empty, please add food!!!", "Info",MessageBoxButton.OK,MessageBoxImage.Stop);
            }
        }

        private void Text_Box_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (Text_Box.Text != "Search..." && Text_Box.Text != string.Empty)
            {
                List<Food> searchList = new();
                for (int i = 0; i < store.Count; i++)
                {
                    if (store[i].Name.ToLower().StartsWith(Text_Box.Text.ToLower()))
                    {
                        searchList.Add(store[i]);
                    }
                }
                if (searchList.Count > 0)
                {
                    store.Clear();
                    for (int i = 0; i < searchList.Count; i++)
                    {
                        store.Add(searchList[i]);
                    }
                }
                else
                {
                    store.Clear();
                }
            }
            else if (Text_Box.Text == string.Empty)
            {
                store.Clear();
                for (int i = 0; i < baseList.Count; i++)
                {
                    store.Add(baseList[i]);
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            AddFood addFood = new AddFood();
            Hide();
            addFood.baseList = baseList;
            addFood.store = store;
            addFood.ShowDialog();
            Show();
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            EditFood editFood = new EditFood();
            Hide();
            editFood.NewFood = (sender as ListView)?.SelectedItem as Food;
            editFood.ShowDialog();
            Show();
            
        }
    }
}
