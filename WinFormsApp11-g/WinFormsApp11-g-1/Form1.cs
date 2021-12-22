using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp11_g_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MakeExcericese()
        {
            try
            {
                WinFormsApp11_g_1.Point point = new Point(int.Parse(textBox1.Text), int.Parse(textBox2.Text));

                pointOutData.Text = ($"point coords: {point.X} {point.Y}");

                outDataLength.Text = $"length: {point.CalcLengthToCoordinatesStart()}";

                point.MultiplyPointOnScalar = int.Parse(textBox5.Text);

                outDataScalar.Text = ($"point coords: {point.X} {point.Y}");

                point.ReplacePoint(int.Parse(textBox3.Text), int.Parse(textBox4.Text));

                outDataVector.Text = ($"point coords: {point.X} {point.Y}");

            }
            catch
            {
                outDataScalar.Text = "error";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MakeExcericese();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            MakeExcericese();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            MakeExcericese();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            MakeExcericese();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeExcericese();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            MakeExcericese();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
