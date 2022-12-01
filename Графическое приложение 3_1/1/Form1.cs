using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        private int a;
        private int b;
        private int c;
        private int f(int x)
        {
            return (x / 10) % 10;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void res_Button_Click(object sender, EventArgs e)
        {
            if (A_textBox.Text == "" || B_textBox.Text == "" || c_textBox.Text == "")
            {
                MessageBox.Show("Введены не все значения!!!");
            }
            else
            {
                try
                {
                    a = int.Parse(A_textBox.Text);
                    if (a == 0)
                    {
                        MessageBox.Show("0 - не натуральное чило");
                        return;
                    }
                    else if ((a < 10) ||(a<0))
                    {
                        MessageBox.Show("Минимальное число 10");
                        return;
                    }         
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод!");
                }
                try
                {
                    b = int.Parse(B_textBox.Text);
                    if (b == 0)
                    {
                        MessageBox.Show("0 - не натуральное чило");
                        return;
                    }
                    else if ((b < 10) || (b < 0))
                    {
                        MessageBox.Show("Минимальное число 10");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод!");
                }
                try
                {
                    c = int.Parse(c_textBox.Text);
                    if (c == 0)
                    {
                        MessageBox.Show("0 - не натуральное чило");
                        return;
                    }
                    else if ((c < 10) || (c < 0))
                    {
                        MessageBox.Show("Минимальное число 10");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод!");
                }
                int res = f(a) + f(b) - f(c);
                res_TextBox.Text = "Результат вычисления = " + res;
            }
        }
    }
}
