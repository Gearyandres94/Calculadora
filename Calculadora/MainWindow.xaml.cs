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

namespace Calculadora
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

        string resnum = "";
        decimal num1 = 0.0M;
        decimal num2 = 0.0M;
        bool isSeg = false;
        bool isDecimal = false;
        bool isNewNum = false;
        bool existOpAntes = false;
        char op;


        private void n1_Click(object sender, RoutedEventArgs e)
        {
            if (isNewNum == true)
            {
                resnum = "";
                this.TxtRes.Text = resnum;
                resnum += "1";
                this.TxtRes.Text = resnum;
                isNewNum = false;

            }

            else
            {

                resnum += "1";
                this.TxtRes.Text = resnum;

            }
        }

        private void n2_Click(object sender, RoutedEventArgs e)
        {

            if (isNewNum == true)
            {
                resnum = "";
                this.TxtRes.Text = resnum;
                resnum += "2";
                this.TxtRes.Text = resnum;
                isNewNum = false;

            }

            else
            {

                resnum += "2";
                this.TxtRes.Text = resnum;

            }
        }

        private void n3_Click(object sender, RoutedEventArgs e)
        {

            if (isNewNum == true)
            {
                resnum = "";
                this.TxtRes.Text = resnum;
                resnum += "3";
                this.TxtRes.Text = resnum;
                isNewNum = false;

            }

            else
            {

                resnum += "3";
                this.TxtRes.Text = resnum;

            }
        }




        private void n4_Click(object sender, RoutedEventArgs e)
        {

            if (isNewNum == true)
            {
                resnum = "";
                this.TxtRes.Text = resnum;
                resnum += "4";
                this.TxtRes.Text = resnum;
                isNewNum = false;

            }

            else
            {

                resnum += "4";
                this.TxtRes.Text = resnum;

            }
        }

        private void n5_Click(object sender, RoutedEventArgs e)
        {
            if (isNewNum == true)
            {
                resnum = "";
                this.TxtRes.Text = resnum;
                resnum += "5";
                this.TxtRes.Text = resnum;
                isNewNum = false;

            }

            else
            {

                resnum += "5";
                this.TxtRes.Text = resnum;

            }
        }

        private void n6_Click(object sender, RoutedEventArgs e)
        {
            if (isNewNum == true)
            {
                resnum = "";
                this.TxtRes.Text = resnum;
                resnum += "6";
                this.TxtRes.Text = resnum;
                isNewNum = false;

            }

            else
            {

                resnum += "6";
                this.TxtRes.Text = resnum;

            }
        }

        private void n7_Click(object sender, RoutedEventArgs e)
        {

            if (isNewNum == true)
            {
                resnum = "";
                this.TxtRes.Text = resnum;
                resnum += "7";
                this.TxtRes.Text = resnum;
                isNewNum = false;

            }

            else
            {

                resnum += "7";
                this.TxtRes.Text = resnum;

            }

        }

        private void n8_Click(object sender, RoutedEventArgs e)
        {

            if (isNewNum == true)
            {
                resnum = "";
                this.TxtRes.Text = resnum;
                resnum += "8";
                this.TxtRes.Text = resnum;
                isNewNum = false;

            }

            else
            {

                resnum += "8";
                this.TxtRes.Text = resnum;

            }
        }

        private void n9_Click(object sender, RoutedEventArgs e)
        {
            if (isNewNum == true)
            {
                resnum = "";
                this.TxtRes.Text = resnum;
                resnum += "9";
                this.TxtRes.Text = resnum;
                isNewNum = false;

            }

            else
            {

                resnum += "9";
                this.TxtRes.Text = resnum;

            }
        }
        private void n0_Click(object sender, RoutedEventArgs e)
        {
            if (isNewNum == true)
            {
                resnum = "";
                this.TxtRes.Text = resnum;
                resnum += "0";
                this.TxtRes.Text = resnum;
                isNewNum = false;

            }

            else
            {

                resnum += "0";
                this.TxtRes.Text = resnum;

            }
        }

        //decimal


        private void dec_Click(object sender, RoutedEventArgs e)
        {


            if (isDecimal == false)

            {
                resnum += ',';
                TxtRes.Text = resnum;
                isDecimal = true;
            }
        }



        //positivo negativo

        private void mame_Click(object sender, RoutedEventArgs e)
        {
            decimal prub = Convert.ToDecimal(resnum);
            prub *= -1;
            resnum = prub.ToString();
            this.TxtRes.Text = resnum;

        }

        //Operaciones

        private void Sum_Click(object sender, RoutedEventArgs e)
        {

            if (isSeg == false)
            {
                if (existOpAntes == true)
                {
                    num2 = Convert.ToDecimal(resnum);
                    num1 = backop(num1, op, num2);
                }
                num1 = Convert.ToDecimal(resnum);
                isDecimal = false;
               
                isSeg = true;
                op = '+';
                existOpAntes = true;

            }
            else
            {
                num2 = Convert.ToDecimal(resnum);
                isDecimal = false;
                num1 += num2;
                resnum = num1.ToString();
                this.TxtRes.Text = resnum;
                num1 = num2 = 0;
                op = '0';
                isSeg = false;
                isNewNum = true;



            }

        }



        private void Res_Click(object sender, RoutedEventArgs e)
        {
            if (isSeg == false)
            {
                if (existOpAntes == true)
                {
                    num2 = Convert.ToDecimal(resnum);
                    num1 = backop(num1, op, num2);
                }
                num1 = Convert.ToDecimal(resnum);
                isDecimal = false;
               
                isSeg = true;
                op = '-';
                existOpAntes = true;
            }
            else
            {
                num2 = Convert.ToDecimal(resnum);
                isDecimal = false;
                num1 -= num2;
                resnum = num1.ToString();
                this.TxtRes.Text = resnum;
                num1 = num2 = 0;
                op = '0';
                isSeg = false;
                isNewNum = true;


            }
        }

        private void mult_Click(object sender, RoutedEventArgs e)
        {
            if (isSeg == false)
            {
                if (existOpAntes == true)
                {
                    num2 = Convert.ToDecimal(resnum);
                    num1 = backop(num1, op, num2);
                }
                num1 = Convert.ToDecimal(resnum);
                isDecimal = false;
               
                isSeg = true;
                op = '*';
                existOpAntes = true;
            }
            else
            {
                num2 = Convert.ToDecimal(resnum);
                isDecimal = false;
                num1 *= num2;
                resnum = num1.ToString();
                this.TxtRes.Text = resnum;
                num1 = num2 = 0;
                op = '0';
                isSeg = false;
                isNewNum = true;


            }
        }


        private void div_Click(object sender, RoutedEventArgs e)
        {
            if (isSeg == false)
            {
                if (existOpAntes == true)
                {
                    num2 = Convert.ToDecimal(resnum);
                    num1 = backop(num1, op, num2);
                }
                num1 = Convert.ToDecimal(resnum);
               
                this.TxtRes.Text = resnum;
                isSeg = true;
                op = '/';
                existOpAntes = true;
            }
            else
            {
                num2 = Convert.ToDecimal(resnum);
                isDecimal = false;
                num1 = decimal.Divide(num1, num2);
                resnum = num1.ToString();
                this.TxtRes.Text = resnum;
                num1 = num2 = 0;
                op = '0';
                isSeg = false;
                isNewNum = true;


            }
        }

        //Igual
        private void equal_Click(object sender, RoutedEventArgs e)
        {
            switch (op)
            {
                case '+':
                    num2 = Convert.ToDecimal(resnum);
                    num1 += num2;
                    resnum = Convert.ToString(num1);
                    this.TxtRes.Text = resnum;
                    num1 = num2 = 0;
                    isDecimal = false;
                    isNewNum = true;
                    isSeg = false;
                    existOpAntes = false;

                    break;

                case '-':
                    num2 = Convert.ToDecimal(resnum);
                    num1 -= num2;
                    resnum = Convert.ToString(num1);

                    this.TxtRes.Text = resnum;
                    num1 = num2 = 0;
                    isDecimal = false;
                    isNewNum = true;
                    isSeg = false;
                    existOpAntes = false;
                    break;

                case '*':
                    num2 = Convert.ToDecimal(resnum);
                    num1 *= num2;
                    resnum = Convert.ToString(num1);
                    this.TxtRes.Text = resnum;
                    num1 = num2 = 0;
                    isDecimal = false;
                    isNewNum = true;
                    isSeg = false;
                    existOpAntes = false;

                    break;


                case '/':
                    num2 = Convert.ToDecimal(resnum);
                    num1 = decimal.Divide(num1, num2);
                    resnum = Convert.ToString(num1);
                    this.TxtRes.Text = resnum;
                    num1 = num2 = 0;
                    isDecimal = false;
                    isNewNum = true;
                    isSeg = false;
                    existOpAntes = false;
                    break;

                default:
                    resnum = Convert.ToString(num1);
                    this.TxtRes.Text = resnum;
                    isDecimal = false;
                    num1 = 0;
                    isNewNum = true;
                    isSeg = false;
                    existOpAntes = false;

                    break;

            }
        }
        public decimal backop(decimal num1, char op, decimal num2)
        {
            decimal res=0;

            switch (op)
            {
                case '+':
                    res = num1 + num2;
                    

               break;

                case '-':

                    res = num1 - num2;
                    
                    break;

                case '*':
                    res = num1 * num2;
                   
                    break;


                case '/':
                    res = decimal.Divide(num1, num2);
                    
                    break;

                default:
                    

                    break;

            }

            return res ;
        }

    }
}
