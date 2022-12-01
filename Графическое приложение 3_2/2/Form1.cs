using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
   
    public partial class Form1 : Form
    {
        private double a;
        private double b;
        private double h;

        private double f(double x)
        {
            double y = 0;
            if (Math.Pow(x, 2) + 2 * x + 1 < 2)
                y = Math.Pow(x, 2);
            else if (Math.Pow(x, 2) + 2 * x + 1 >= 3)
                y = 0.0;
            else
                y = (1 / (Math.Pow(x, 2) - 1));
            return y;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void res_Button_Click(object sender, EventArgs e)
        {
            if (start_TextBox.Text == "" || finish_TextBox.Text == "" || H_TextBox.Text == "")
            {
                MessageBox.Show("Введены не все значения");
            }
            else
            {
                res_TextBox.Text = "";
                try
                {
                    a = double.Parse(start_TextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод!");
                    return;
                }
                try
                {
                    b = double.Parse(finish_TextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод!");
                    return;
                }
                if (a > b)
                {
                    MessageBox.Show("Начальная точка диапазона не может быть больше конечной точки");
                    return;
                }
                try
                {
                    h = double.Parse(H_TextBox.Text);
                    if (h == 0)
                    {
                        MessageBox.Show("Шаг не может быть равен 0");
                        return;
                    }
                    else if (h < 0)
                    {
                        MessageBox.Show("Шаг не может быть меньше 0");
                        return;

                    }
                }
                catch
                {
                    Console.Write("Некорректный ввод!");
                }
                for (double i = a; i <= b; i += h)
                {
                    res_TextBox.Text += "f(" + Math.Round (i,2)+") = "+ Math.Round(f(i),2)+"\n"; 
                }
            }
        }
    }
}
