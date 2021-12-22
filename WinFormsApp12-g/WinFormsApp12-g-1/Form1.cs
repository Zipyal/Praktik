using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp12_g_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MakeExercise()
        {
            try
            {
                Point point = (Point)textBox1.Text;

                labelPointOut.Text = $"Point: {(string)point}";

                labelTrFl.Text = $"X Y are equals: { (point ? "yes" : "no")}";
                
                point+=int.Parse(textBox2.Text);
                
                labelPl.Text = $"Plus scalar: {(string)point}";

                point++;

                labelPlPl.Text= $"Plus plus: {(string)point}";

                point--;

                labelMnMn.Text= $"Minus minus: {(string)point}";
            }
            catch
            {
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MakeExercise();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MakeExercise();
        }

    }
}
