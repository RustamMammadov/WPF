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
using Emoji;
using Emoji.Wpf;
using Microsoft.VisualBasic;

namespace WpfApp2
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        public List<Person> People { get; set; } = new();
        public MainWindow()
        {
            InitializeComponent();
            People = new Bogus.Faker<Person>()
               .RuleFor(p => p.FullName, f => f.Person.FullName)
               .RuleFor(p => p.Time, f => f.Date.RecentTimeOnly())
               .RuleFor(p => p.Avatar, f => f.Person.Avatar).Generate(5);
            DataContext = this;

        }

        private void Picker_Picked(object sender, Emoji.Wpf.EmojiPickedEventArgs e)
        {
            var smile = Emoji.Selection;
            if (Text_Box.Text == "Write a message")
            {
                Text_Box.Clear();
                Text_Box.Foreground = new SolidColorBrush(Colors.Black);
                Text_Box.Text += smile;
            }
            else
                Text_Box.Text += smile;
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            writing.IsEnabled = true;
            Text_Box.Text = string.Empty;
            Text_Box.Foreground = new SolidColorBrush(Colors.Black);
            if (sender is ListView l_w)
            {
                Stpl.Children.Clear();
                var prs = l_w.SelectedItem as Person;
                prs.Time = TimeOnly.FromDateTime(DateTime.Now);
                Friend_Name.Content = prs.FullName;
                Is_online.Content = "Online";
                for (int i = 0; i < prs.ChatList.Count; i++)
                {
                    StackPanel view = new();
                    view.MaxWidth = 333;
                    view.Margin = new Thickness(5);

                    System.Windows.Controls.TextBlock text = new();
                    text.TextWrapping = TextWrapping.Wrap;
                    text.Text = prs.ChatList[i].Text;
                    text.MaxWidth = 333;
                    text.FontSize = 20;
                    text.Margin = new Thickness(6);
                    view.Children.Add(text);

                    System.Windows.Controls.TextBlock time = new();
                    time.Text = prs.ChatList[i].Time.ToString();
                    time.FontSize = 9;
                    time.HorizontalAlignment = HorizontalAlignment.Right;
                    time.Margin = new Thickness(5);

                    view.Children.Add(time);
                    if (prs.ChatList[i].Friend == true)
                    {
                        view.HorizontalAlignment = HorizontalAlignment.Left;
                        view.Background = new SolidColorBrush(Colors.Yellow);
                    }
                    else
                    {
                        view.HorizontalAlignment = HorizontalAlignment.Right;
                        view.Background = new SolidColorBrush(Colors.Aqua);
                    }
                    Stpl.Children.Add(view);
                }

            }

        }
        private void Text_Box_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Text_Box.Text == "Write a message")
            {
                Text_Box.Text = string.Empty;
                Text_Box.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Text_Box.Text == string.Empty)
            {
                Text_Box.Foreground = new SolidColorBrush(Colors.Gray);
                Text_Box.Text = "Write a message";
            }

        }

        private void Text_Box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {            
                Chat chat = new()
                {
                    Friend = false,
                    Text = Text_Box.Text,
                    Time = TimeOnly.FromDateTime(DateTime.Now),
                };
                (List_View.SelectedItem as Person)?.ChatList.Add(chat);
                if (Text_Box.Text.ToString().ToLower() == ("salam") || Text_Box.Text.ToString().ToLower() == ("necesen?"))
                {
                    Chat t_chat = new();
                    t_chat.Friend = true;
                    if(Text_Box.Text.ToString().ToLower() == ("salam"))
                        t_chat.Text = "Essalamun Aleykum";
                    if(Text_Box.Text.ToString().ToLower() == ("necesen?"))
                        t_chat.Text = "Nece olacig, yashamaga chalishiriq";
                    t_chat.Time = TimeOnly.FromDateTime(DateTime.Now);
                    (List_View.SelectedItem as Person)?.ChatList.Add(t_chat);
                }
                
                else if(Text_Box.Text.ToString().Count() > 6 && Text_Box.Text.ToString().Count() < 15)
                {
                    Chat t_chat = new();
                    t_chat.Friend = true;
                    t_chat.Text = "Indi bashim qarishiqdi sora yazaram";
                    t_chat.Time = TimeOnly.FromDateTime(DateTime.Now);
                    (List_View.SelectedItem as Person)?.ChatList.Add(t_chat);
                }
                else 
                {
                    Chat t_chat = new();
                    t_chat.Friend = true;
                    t_chat.Text = "Sene demedim Indi bashim qarishiqdi sora yazaram.... Qirilda... 😡";
                    t_chat.Time = TimeOnly.FromDateTime(DateTime.Now);
                    (List_View.SelectedItem as Person)?.ChatList.Add(t_chat);
                }
                Text_Box.Text = string.Empty;
                ListView_MouseDoubleClick(List_View, null);

            }
        }
    }
}
