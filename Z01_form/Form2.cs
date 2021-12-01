using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int a = int.Parse(str);

            NewMethod(a);

        }

        private void NewMethod(int a)
        {
            NewMethod1(a);
        }

        private void NewMethod1(int a)
        {
            if (a <= 0x0 || a >= 1000)
                MessageBox.Show("Некоректное число. Введите целое число!");
            else
            {
                // нахождение числа
                textBox2.Text = ((a % 10) + (a / 10 % 10)) % 2 == 0 ? "Число - является четным" : "Число - не является четным";
            }
        }

        private void Button2_Click(object sender, EventArgs e) => Close();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
