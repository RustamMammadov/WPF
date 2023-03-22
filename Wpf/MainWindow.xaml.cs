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

namespace Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> data = new();
        string num_col = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button b)
            {
                if (float.TryParse(b.Content.ToString(), out float c))
                {

                    num_col += b.Content.ToString();
                    lebel_canvas.Content = num_col;
                    if (data.Count > 0)
                    {
                        if (lebel_history.Content.ToString() == "0")
                            lebel_history.Content = string.Empty;
                        Print_lebel_history();
                    }
                    else
                        lebel_history.Content = num_col;
                }
                else
                {
                    if (b.Content.ToString() == "CE")
                    {
                        lebel_canvas.Content = "0";
                        num_col = string.Empty;
                    }
                    else if (b.Content.ToString() == "C")
                    {
                        data.Clear();
                        num_col = string.Empty;
                        lebel_canvas.Content = "0";
                        lebel_history.Content = "0";
                    }
                    else if (b.Content.ToString() == "%")
                    {
                        if (data.Count == 0)
                        {
                            data.Clear();
                            num_col = string.Empty;
                            lebel_canvas.Content = "0";
                            lebel_history.Content = "0";
                        }
                        else if (num_col == string.Empty)
                        {
                            if (data[1] == "=")
                            {
                                data.Clear();
                                num_col = string.Empty;
                                lebel_canvas.Content = "0";
                                lebel_history.Content = "0";
                            }
                            else
                            {
                                float temp;
                                temp = Convert.ToSingle(data[0]) * Convert.ToSingle(data[2]) / 100;
                                data[2] = temp.ToString();
                                lebel_canvas.Content = temp.ToString();
                                Print_lebel_history();
                            }
                        }
                        else
                        {
                            float temp;
                            temp = Convert.ToSingle(data[0]) * Convert.ToSingle(num_col) / 100;
                            data.Add(temp.ToString());
                            lebel_canvas.Content = temp.ToString();
                            num_col = string.Empty;
                            Print_lebel_history();

                        }
                    }
                    else if (b.Content.ToString() == "√")
                    {
                        if (data.Count == 0)
                        {
                            data.Clear();
                            num_col = Math.Sqrt(Convert.ToDouble(num_col)).ToString();
                            lebel_canvas.Content = num_col;
                            lebel_history.Content = num_col;
                        }
                        else if (num_col == string.Empty)
                        {
                            if (data.Count == 3)
                            {
                                data[2] = Math.Sqrt(Convert.ToDouble(data[2])).ToString();
                                lebel_canvas.Content = data[2];
                            }
                            else if (data.Count == 2)
                            {
                                data[0] = Math.Sqrt(Convert.ToDouble(data[0])).ToString();
                                lebel_canvas.Content = data[0];
                            }
                            Print_lebel_history();
                        }
                        else
                        {
                            num_col = Math.Sqrt(Convert.ToDouble(num_col)).ToString();
                            data.Add(num_col);
                            lebel_canvas.Content = num_col;
                            num_col = string.Empty;
                            Print_lebel_history();
                        }
                    }
                    else if (b.Content.ToString() == "x²")
                    {
                        if (data.Count == 0)
                        {
                            data.Clear();
                            num_col = Math.Pow(Convert.ToSingle(num_col), 2).ToString();
                            lebel_canvas.Content = num_col;
                            lebel_history.Content = num_col;
                        }
                        else if (num_col == string.Empty)
                        {
                            if (data.Count == 3)
                            {
                                data[2] = Math.Pow(Convert.ToSingle(data[2]), 2).ToString();
                                lebel_canvas.Content = data[2];
                            }
                            else if (data.Count == 2)
                            {
                                data[0] = Math.Pow(Convert.ToSingle(data[0]), 2).ToString();
                                lebel_canvas.Content = data[0];
                            }
                            Print_lebel_history();
                        }
                        else
                        {
                            num_col = Math.Pow(Convert.ToSingle(num_col), 2).ToString();
                            data.Add(num_col);
                            lebel_canvas.Content = num_col;
                            num_col = string.Empty;
                            Print_lebel_history();
                        }
                    }
                    else if (b.Content.ToString() == "1/x")
                    {
                        try
                        {
                            if (data.Count == 0)
                            {
                                if (num_col != "0")
                                {
                                    data.Clear();
                                    num_col = (1 / Convert.ToSingle(num_col)).ToString();
                                    lebel_canvas.Content = num_col;
                                    lebel_history.Content = num_col;
                                }
                                else
                                    throw new DivideByZeroException();
                            }
                            else if (num_col == string.Empty)
                            {
                                if (data.Count == 3)
                                {
                                    if (data[2] != "0")
                                    {
                                        data[2] = (1 / Convert.ToSingle(data[2])).ToString();
                                        lebel_canvas.Content = data[2];
                                    }
                                    else
                                        throw new DivideByZeroException();

                                }
                                else if (data.Count == 2)
                                {
                                    if (data[0] != "0")
                                    {
                                        data[0] = (1 / Convert.ToSingle(data[0])).ToString();
                                        lebel_canvas.Content = data[0];
                                    }
                                    else
                                        throw new DivideByZeroException();
                                }
                                Print_lebel_history();
                            }
                            else
                            {
                                if (num_col != "0")
                                {
                                    num_col = (1 / Convert.ToSingle(num_col)).ToString();
                                    data.Add(num_col);
                                    lebel_canvas.Content = num_col;
                                    num_col = string.Empty;
                                    Print_lebel_history();
                                }
                                else
                                    throw new DivideByZeroException();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Cannot divide by zero");
                            num_col = string.Empty;
                        }
                    }
                    else if (b.Name == "btn_backspace")
                    {
                        if (num_col != string.Empty)
                        {
                            string temp = lebel_canvas.Content.ToString();
                            temp = temp.Remove(temp.Length - 1);
                            lebel_canvas.Content = temp;
                            num_col = temp;
                            Print_lebel_history();
                        }
                    }
                    else if (b.Content.ToString() == "±")
                    {
                        if (data.Count == 0)
                        {
                            if (num_col == string.Empty)
                            {
                                num_col = "0";
                            }
                            num_col = (-1 * Convert.ToSingle(num_col)).ToString();
                            lebel_canvas.Content = num_col;
                            lebel_history.Content = num_col;
                        }
                        else if (num_col != string.Empty)
                        {
                            num_col = (Convert.ToSingle(num_col) * -1).ToString();
                            data.Add(num_col);
                            lebel_canvas.Content = num_col;
                            num_col = string.Empty;
                        }
                        else
                        {
                            num_col = (Convert.ToSingle(data[0]) * -1).ToString();
                            lebel_canvas.Content = num_col;
                            num_col = string.Empty;
                        }
                    }
                    else if (b.Content.ToString() == ",")
                    {
                        if (!lebel_canvas.Content.ToString().Contains(",") && !num_col.Contains(","))
                        {
                            lebel_canvas.Content += ",";
                            num_col += ",";
                        }
                        else
                            MessageBox.Show("This number is already float number");
                    }
                    else
                    {
                        if (num_col != string.Empty)
                        {
                            data.Add(num_col);
                            num_col = string.Empty;
                        }
                        if (data.Count == 1)
                        {
                            data.Add(b.Content.ToString()!);
                        }
                        else if (data.Count == 3)
                        {
                            if (float.TryParse(data[0], out float number1) && float.TryParse(data[2], out float number2))
                            {
                                if (data[1] == "+")
                                {
                                    data.Clear();
                                    data.Add((number1 + number2).ToString());
                                    data.Add(b.Content.ToString());
                                }
                                else if (data[1] == "-")
                                {
                                    data.Clear();
                                    data.Add((number1 - number2).ToString());
                                    data.Add(b.Content.ToString());
                                }
                                else if (data[1] == "x")
                                {
                                    data.Clear();
                                    data.Add((number1 * number2).ToString());
                                    data.Add(b.Content.ToString());
                                }
                                else if (data[1] == "/")
                                {
                                    if (number2 == 0)
                                    {                                       
                                        data.Clear();
                                        data.Add("Cannot divide by zero");
                                        
                                    }
                                    else
                                    {
                                        data.Clear();
                                        data.Add((number1 / number2).ToString());
                                        data.Add(b.Content.ToString());
                                    }
                                }
                                else if (data[1] == "=")
                                {
                                    string temp = data[2];
                                    data.Clear();
                                    data.Add(temp);
                                    data.Add(b.Content.ToString());
                                }
                            }
                            else
                                MessageBox.Show("ERROR");
                        }
                        else
                            data[1] = b.Content.ToString();
                        lebel_canvas.Content = data[0];
                        Print_lebel_history();
                    }
                }
            }
        }

        public void Print_lebel_history()
        {
            lebel_history.Content = string.Empty;
            for (int i = 0; i < data.Count; i++)
            {
                lebel_history.Content += data[i];
            }
        }
    }
}
