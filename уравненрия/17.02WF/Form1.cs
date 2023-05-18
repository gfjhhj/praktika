using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17._02WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonWF.Click += buttonWF_Click;
        }

        private void buttonWF_Click(object sender, EventArgs e)
        {

            //labelWF1.Text = $"Привет {textBoxA.Text}";
            // a,b,c; a2+bx+c =0; d= b2-4ac; x=-b+-d/2a; x=(-b/2a); x=error
            int a;
            int b;
            int c;
            double x1;
            double x2;
            int d;
            int.TryParse(textBoxA.Text, out a);
            int.TryParse(textBoxB.Text, out b);
            int.TryParse(textBoxC.Text, out c);
            d = (b * b) - 4 * a * c;
            if (d > 0)
            {
                x1 = ((b * b) - Math.Sqrt(d)) / 2 * a;
                x2 = ((b * b) + Math.Sqrt(d)) / 2 * a;
                labelWF1.Text = $"x1={x1}, x2={x2}";
            }
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                labelWF1.Text = $"x1={x1}";
            }
            else
            {
                labelWF1.Text = "Решения нет";
            }
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
