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

namespace calculatorpro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal num1;
        decimal num2;
        string operation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void input(string a)
        {
            if (numbox.Text == "0")
                numbox.Text = a;
            else
                numbox.Text += a;
        }

        private void _0btn_Click(object sender, RoutedEventArgs e)
        {
            input("0");
        }

        private void _1btn_Click(object sender, RoutedEventArgs e)
        {
            input("1");
        }

        private void _2btn_Click(object sender, RoutedEventArgs e)
        {
            input("2");
        }

        private void _3btn_Click(object sender, RoutedEventArgs e)
        {
            input("3");
        }

        private void _4btn_Click(object sender, RoutedEventArgs e)
        {
            input("4");
        }

        private void _5btn_Click(object sender, RoutedEventArgs e)
        {
            input("5");
        }

        private void _6btn_Click(object sender, RoutedEventArgs e)
        {
            input("6");
        }

        private void _7btn_Click(object sender, RoutedEventArgs e)
        {
            input("7");
        }

        private void _8btn_Click(object sender, RoutedEventArgs e)
        {
            input("8");
        }

        private void _9btn_Click(object sender, RoutedEventArgs e)
        {
            input("9");
        }

        private void plusbtn_Click(object sender, RoutedEventArgs e)
        {
            num1 = decimal.Parse(numbox.Text);
            operation = "+";
            numbox.Text = "0";
        }

        private void debtn_Click(object sender, RoutedEventArgs e)
        {
            num1 = decimal.Parse(numbox.Text);
            operation = "-";
            numbox.Text = "0";
        }

        private void timebtn_Click(object sender, RoutedEventArgs e)
        {
            num1 = decimal.Parse(numbox.Text);
            operation = "*";
            numbox.Text = "0";
        }

        private void provbtn_Click(object sender, RoutedEventArgs e)
        {
            num1 = decimal.Parse(numbox.Text);
            operation = "/";
            numbox.Text = "0";
        }

        private void powbtn_Click(object sender, RoutedEventArgs e)
        {
            num1 = decimal.Parse(numbox.Text);
            operation = "^";
            numbox.Text = "0";
        }

        private void modbtn_Click(object sender, RoutedEventArgs e)
        {
            num1 = decimal.Parse(numbox.Text);
            operation = "%";
            numbox.Text = "0";
        }

        private void eqbtn_Click(object sender, RoutedEventArgs e)
        {
            num2 = decimal.Parse(numbox.Text);

            switch (operation)
            {
                case "+":
                    numbox.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    numbox.Text = (num1 - num2).ToString();
                    break;
                case "×":
                    numbox.Text = (num1 * num2).ToString();
                    break;
                case "÷":
                    numbox.Text = (num1 / num2).ToString();
                    break;
                case "^":
                    numbox.Text = (Math.Pow(double.Parse(num1.ToString()), double.Parse(num2.ToString()))).ToString();
                    break;
                case "%":
                    numbox.Text = (num1 % num2).ToString();
                    break;
            }
        }

        private void sinbtn_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
                numbox.Text = (Math.Sin(double.Parse(numbox.Text))).ToString();
            else if (num1 != 0 && operation != "" && num2 == 0)
                numbox.Text = (Math.Sin(double.Parse(num1.ToString()))).ToString();
            else
            {
                num2 = decimal.Parse(numbox.Text);

                switch (operation)
                {
                    case "+":
                        numbox.Text = (num1 + num2).ToString();
                        break;
                    case "-":
                        numbox.Text = (num1 - num2).ToString();
                        break;
                    case "×":
                        numbox.Text = (num1 * num2).ToString();
                        break;
                    case "÷":
                        numbox.Text = (num1 / num2).ToString();
                        break;
                    case "^":
                        numbox.Text = (Math.Pow(double.Parse(num1.ToString()), double.Parse(num2.ToString()))).ToString();
                        break;
                    case "Mod":
                        numbox.Text = (num1 % num2).ToString();
                        break;
                }

                numbox.Text = (Math.Sin(double.Parse(numbox.Text))).ToString();
            }
        }

        private void cosbtn_Click(object sender, RoutedEventArgs e)
        {
            {
                if (operation == "")
                    numbox.Text = (Math.Cos(double.Parse(numbox.Text))).ToString();
                else if (num1 != 0 && operation != "" && num2 == 0)
                    numbox.Text = (Math.Cos(double.Parse(num1.ToString()))).ToString();
                else
                {
                    num2 = decimal.Parse(numbox.Text);

                    switch (operation)
                    {
                        case "+":
                            numbox.Text = (num1 + num2).ToString();
                            break;
                        case "-":
                            numbox.Text = (num1 - num2).ToString();
                            break;
                        case "×":
                            numbox.Text = (num1 * num2).ToString();
                            break;
                        case "÷":
                            numbox.Text = (num1 / num2).ToString();
                            break;
                        case "^":
                            numbox.Text = (Math.Pow(double.Parse(num1.ToString()), double.Parse(num2.ToString()))).ToString();
                            break;
                        case "%":
                            numbox.Text = (num1 % num2).ToString();
                            break;
                    }

                    numbox.Text = (Math.Cos(double.Parse(numbox.Text))).ToString();
                }
            }
        }

        private void tanbtn_Click(object sender, RoutedEventArgs e)
        {
            {
                if (operation == "")
                    numbox.Text = (Math.Tan(double.Parse(numbox.Text))).ToString();
                else if (num1 != 0 && operation != "" && num2 == 0)
                    numbox.Text = (Math.Tan(double.Parse(num1.ToString()))).ToString();
                else
                {
                    num2 = decimal.Parse(numbox.Text);

                    switch (operation)
                    {
                        case "+":
                            numbox.Text = (num1 + num2).ToString();
                            break;
                        case "-":
                            numbox.Text = (num1 - num2).ToString();
                            break;
                        case "×":
                            numbox.Text = (num1 * num2).ToString();
                            break;
                        case "÷":
                            numbox.Text = (num1 / num2).ToString();
                            break;
                        case "^":
                            numbox.Text = (Math.Pow(double.Parse(num1.ToString()), double.Parse(num2.ToString()))).ToString();
                            break;
                        case "%":
                            numbox.Text = (num1 % num2).ToString();
                            break;
                    }

                    numbox.Text = (Math.Tan(double.Parse(numbox.Text))).ToString();
                }
            }
        }

        private void logbtn_Click(object sender, RoutedEventArgs e)
        {
            {
                if (operation == "")
                    numbox.Text = (Math.Log10(double.Parse(numbox.Text))).ToString();
                else if (num1 != 0 && operation != "" && num2 == 0)
                    numbox.Text = (Math.Log10(double.Parse(num1.ToString()))).ToString();
                else
                {
                    num2 = decimal.Parse(numbox.Text);

                    switch (operation)
                    {
                        case "+":
                            numbox.Text = (num1 + num2).ToString();
                            break;
                        case "-":
                            numbox.Text = (num1 - num2).ToString();
                            break;
                        case "×":
                            numbox.Text = (num1 * num2).ToString();
                            break;
                        case "÷":
                            numbox.Text = (num1 / num2).ToString();
                            break;
                        case "^":
                            numbox.Text = (Math.Pow(double.Parse(num1.ToString()), double.Parse(num2.ToString()))).ToString();
                            break;
                        case "%":
                            numbox.Text = (num1 % num2).ToString();
                            break;
                    }

                    numbox.Text = (Math.Log10(double.Parse(numbox.Text))).ToString();
                }
            }
        }

        private void fbtn_Click(object sender, RoutedEventArgs e)
        {
            int f = 1;
            for (int i = 1; i <= int.Parse(numbox.Text); i++)
            {
                f = f * i;
            }
            numbox.Text = f.ToString();
        }

        private void rootbtn_Click(object sender, RoutedEventArgs e)
        {
            {
                if (operation == "")
                    numbox.Text = (Math.Sqrt(double.Parse(numbox.Text))).ToString();
                else if (num1 != 0 && operation != "" && num2 == 0)
                    numbox.Text = (Math.Sqrt(double.Parse(num1.ToString()))).ToString();
                else
                {
                    num2 = decimal.Parse(numbox.Text);

                    switch (operation)
                    {
                        case "+":
                            numbox.Text = (num1 + num2).ToString();
                            break;
                        case "-":
                            numbox.Text = (num1 - num2).ToString();
                            break;
                        case "×":
                            numbox.Text = (num1 * num2).ToString();
                            break;
                        case "÷":
                            numbox.Text = (num1 / num2).ToString();
                            break;
                        case "^":
                            numbox.Text = (Math.Pow(double.Parse(num1.ToString()), double.Parse(num2.ToString()))).ToString();
                            break;
                        case "%":
                            numbox.Text = (num1 % num2).ToString();
                            break;
                    }

                    numbox.Text = (Math.Sqrt(double.Parse(numbox.Text))).ToString();
                }
            }
        }

        private void dotbtn_Click(object sender, RoutedEventArgs e)
        {
            if (numbox.Text != "")
            {
                if (!numbox.Text.Contains("."))
                    input(".");
            }
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            if (numbox.Text != "0")
            {
                if (numbox.Text.Length == 1)
                {
                    numbox.Text = "0";
                }
                else if (numbox.Text.Length > 1)
                {
                    numbox.Text = numbox.Text.Substring(0, numbox.Text.Length - 1);
                }
            }
        }

        private void delallbtn_Click(object sender, RoutedEventArgs e)
        {
            numbox.Text = "0";
            num1 = 0;
            num2 = 0;
            operation = "";
        }
    }
}
