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

namespace SimpleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (resultBoard.Content.Equals("0"))
            {
                resultBoard.Content = "";
            }
            resultBoard.Content = "0";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (resultBoard.Content.Equals("0"))
            {
                resultBoard.Content = "";
            }
            resultBoard.Content += "7";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (resultBoard.Content.Equals("0"))
            {
                resultBoard.Content = "";
            }
            resultBoard.Content += "8";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (resultBoard.Content.Equals("0"))
            {
                resultBoard.Content = "";
            }
            resultBoard.Content += "9";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (resultBoard.Content.Equals("0"))
            {
                resultBoard.Content = "";
            }
            resultBoard.Content += "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (resultBoard.Content.Equals("0"))
            {
                resultBoard.Content = "";
            }
            resultBoard.Content += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (resultBoard.Content.Equals("0"))
            {
                resultBoard.Content = "";
            }
            resultBoard.Content += "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (resultBoard.Content.Equals("0"))
            {
                resultBoard.Content = "";
            }
            resultBoard.Content += "3";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (resultBoard.Content.Equals("0"))
            {
                resultBoard.Content = "";
            }
            resultBoard.Content += "2";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (resultBoard.Content.Equals("0"))
            {
                resultBoard.Content = "";
            }
            resultBoard.Content += "1";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (!resultBoard.Content.Equals("0"))
            {
                resultBoard.Content += "0";
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            string res = resultBoard.Content.ToString();
            res.Remove(0, res.Length - 1); 
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            resultBoard.Content += " + ";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            resultBoard.Content += " - ";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            resultBoard.Content += " * ";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            resultBoard.Content += " / ";
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            int res = Convert.ToInt32(resultBoard.Content.ToString());
            resultBoard.Content = Math.Sqrt(res);
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            resultBoard.Content += " % ";
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            long res = Convert.ToInt64(resultBoard.Content.ToString());
            resultBoard.Content = Math.Pow(res, 2);
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            string res = resultBoard.Content.ToString();
            string[] vyraz = res.Split(" ");
            switch(vyraz[1])
            {
                case "*":
                    resultBoard.Content = Convert.ToInt32(vyraz[0]) * Convert.ToInt32(vyraz[2]);
                    break;
                case "/":
                    if (vyraz[0].Equals("0"))
                    {
                        resultBoard.Content = 0;
                    }
                    else
                    {
                        double vysledek = Convert.ToDouble(vyraz[0]) / Convert.ToDouble(vyraz[2]);
                        resultBoard.Content = vysledek;
                    }

                    break;
                case "+":
                    resultBoard.Content = Convert.ToInt32(vyraz[0]) + Convert.ToInt32(vyraz[2]);
                    break;
                case "-":
                    resultBoard.Content = Convert.ToInt32(vyraz[0]) - Convert.ToInt32(vyraz[2]);
                    break;
                case "%":
                    resultBoard.Content = Convert.ToInt32(vyraz[0]) % Convert.ToInt32(vyraz[2]);
                    break;
            }
        }
    }
}
