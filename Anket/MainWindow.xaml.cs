using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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

namespace Anket
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //public ObservableCollection<Info> InfoList { get; set; } = new();



        public ObservableCollection<Info> InfoList
        {
            get { return (ObservableCollection<Info>)GetValue(InfoListProperty); }
            set { SetValue(InfoListProperty, value); }
        }

        // Using a DependencyProperty as the backing store for InfoList.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InfoListProperty =
            DependencyProperty.Register("InfoList", typeof(ObservableCollection<Info>), typeof(MainWindow));





        public Info InfoPerson
        {
            get { return (Info)GetValue(InfoPersonProperty); }
            set { SetValue(InfoPersonProperty, value); }
        }

        // Using a DependencyProperty as the backing store for InfoPerson.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InfoPersonProperty =
            DependencyProperty.Register("InfoPerson", typeof(Info), typeof(MainWindow));


        //public Info InfoPerson { get; set; }



        public MainWindow()
        {
            InfoPerson = new();
            InfoList = new();
            InitializeComponent();
            DataContext = this;
        }



        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (InfoPerson.Name == string.Empty || InfoPerson.Surname == string.Empty || InfoPerson.Email == string.Empty)
            {
                MessageBox.Show("Fill in the lines correctly!", "Info", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
            else if (InfoPerson.Phone < 111111111)
            {
                MessageBox.Show("The number is not correct!", "Info", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
            else if (InfoPerson.Born.Year > 2005)
            {
                MessageBox.Show("Questionnaires of those under 18 years of age are not accepted.", "Info", MessageBoxButton.OK, MessageBoxImage.Stop);

            }
            else
            {
                InfoList.Add(InfoPerson);
                InfoPerson = new();

            }
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            InfoPerson = (sender as ListBox)?.SelectedItem as Info;
            Add.Visibility = Visibility.Hidden;
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            if (InfoPerson.Name == string.Empty || InfoPerson.Surname == string.Empty || InfoPerson.Email == string.Empty)
            {
                MessageBox.Show("Fill in the lines correctly!", "Info", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
            else if (InfoPerson.Phone < 111111111)
            {
                MessageBox.Show("The number is not correct!", "Info", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
            else if (InfoPerson.Born.Year > 2005)
            {
                MessageBox.Show("Questionnaires of those under 18 years of age are not accepted.", "Info", MessageBoxButton.OK, MessageBoxImage.Stop);

            }
            if (InfoPerson.Name == string.Empty || InfoPerson.Surname == string.Empty || InfoPerson.Email == string.Empty || InfoPerson.Phone < 111111111 || InfoPerson.Born.Year > 2005)
            {
                InfoList.Remove(InfoPerson);
            }
            else
            {
                if (InfoList.Contains(InfoPerson) == false)
                    InfoList.Add(InfoPerson);
                Add.Visibility = Visibility.Visible;
                InfoPerson = new();
            }

        }

        private void FailName_MouseEnter(object sender, MouseEventArgs e)
        {
            if (FailName == sender)
            {
                FailName.Text = string.Empty;
            }
            FailName.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void FailName_MouseLeave(object sender, MouseEventArgs e)
        {
            if (FailName.Text == string.Empty && FailName == sender)
            {
                FailName.Text = "Faylin adi";
                FailName.Foreground = new SolidColorBrush(Colors.LightGray);
            }
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (FailName.Text != "Faylin adi" && FailName.Text != string.Empty &&  InfoList.Count > 0)
            {
                var json = JsonSerializer.Serialize(InfoList);
                File.WriteAllText($"{FailName.Text}.json", json);
                MessageBox.Show("Saved", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Filename is not entered or the list is empty", "Info", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Load_Click(object sender, RoutedEventArgs e)
        {
            if (FailName.Text != string.Empty && FailName.Text != "Faylin adi")
            {
                try
                {
                    var json = File.ReadAllText($"{FailName.Text}.json");
                    ObservableCollection<Info>? Infos = JsonSerializer.Deserialize<ObservableCollection<Info>>(json);
                    InfoList = Infos;
                    FailName.Text = string.Empty;
                    MessageBox.Show("Loading Complated!", "Info", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("File not found", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter file name", "Info", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
        }
    }
}
