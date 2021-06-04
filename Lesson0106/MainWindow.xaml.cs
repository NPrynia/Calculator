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
using Lesson0106;
using System.Data;



namespace Lesson0106
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string exp;
        
       
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();


        }

        

        private void btn1_Click(object sender, RoutedEventArgs e)
        {

            tbexp.Text = tbexp.Text + "1";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            tbexp.Text = tbexp.Text + "4";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            tbexp.Text = tbexp.Text + "7";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            tbexp.Text = tbexp.Text + "0";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            tbexp.Text = tbexp.Text + "2";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            tbexp.Text = tbexp.Text + "5";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            tbexp.Text = tbexp.Text + "8";
        }

        private void btnComma_Click(object sender, RoutedEventArgs e)
        {

            if (tbexp.Text != "")
            {
                string temp = tbexp.Text.Substring(tbexp.Text.Length - 1);
                if (temp == "×" || temp == "^" || temp == "/" || temp == "-" || temp == "+" || temp == "%" || temp == ",") 
                {



                }
                else
                {
                    tbexp.Text = tbexp.Text + ".";
                }
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            tbexp.Text = tbexp.Text + "3";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            tbexp.Text = tbexp.Text + "6";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            tbexp.Text = tbexp.Text + "9";
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            if(tbexp.Text !=  "" )
            {
                char[] c = new char[tbexp.Text.Length - 1];
                tbexp.Text.CopyTo(0, c, 0, c.Length);
                tbexp.Text = new string(c);
            }
         
        }

        private void btnPow_Click(object sender, RoutedEventArgs e)
        {
            if (tbexp.Text != "")
            {
                string temp = tbexp.Text.Substring(tbexp.Text.Length - 1);
                if (temp == "*" || temp == "^" || temp == "/" || temp == "-" || temp == "+" || temp == "%" || temp == ",")
                {



                }
                else
                {
                    tbexp.Text = tbexp.Text + "^";
                }
            }
        }

        private void btnMulti_Click(object sender, RoutedEventArgs e)
        {
            if (tbexp.Text != "")
            {
                string temp = tbexp.Text.Substring(tbexp.Text.Length - 1);
                if (temp == "*" || temp == "^" || temp == "/" || temp == "-" || temp == "+" || temp == "%" || temp == ",")
                {



                }
                else
                {
                    tbexp.Text = tbexp.Text + "*";

                }
            }

            
            
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            if (tbexp.Text != "")
            {
                string temp = tbexp.Text.Substring(tbexp.Text.Length - 1);
                if (temp == "*" || temp == "^" || temp == "/" || temp == "-" || temp == "+" || temp == "%" || temp == ",")
                {



                }
                else
                {
                    tbexp.Text = tbexp.Text + "/";
                }
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            
            if (tbexp.Text != "")
            {
                string temp = tbexp.Text.Substring(tbexp.Text.Length - 1);
                if (temp == "*" || temp == "^" || temp == "/" || temp == "-" || temp == "+" || temp == "%" || temp == ",")
                {



                }
                else
                {
                    tbexp.Text = tbexp.Text + "+";
                }
            }
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (tbexp.Text != "")
            {
                string temp = tbexp.Text.Substring(tbexp.Text.Length - 1);
                if (temp == "*" || temp == "^" || temp == "/" || temp == "-" || temp == "+" || temp == "%" || temp == ",")
                {



                }
                else
                {
                    tbexp.Text = tbexp.Text + "-";
                }
            }
        }

        private void btnProc_Click(object sender, RoutedEventArgs e)
        {
            if (tbexp.Text != "")
            {
                string temp = tbexp.Text.Substring(tbexp.Text.Length - 1);
            if (temp == "*" || temp == "^" || temp == "/" || temp == "-" || temp == "+" || temp == "%" || temp == ",")
            {



            }
            else
            {
                tbexp.Text = tbexp.Text + "%";
            }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbexp.Text = "";
        }

        private void btnEq_Click(object sender, RoutedEventArgs e)
        {
            tbres.Text  = Convert.ToString(Calculate.calculate(tbexp.Text));
            
        }

        private void btnPercnt_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
