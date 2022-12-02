using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Zadanie_Forms_YP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(numericUpDown1.Text);
            double y = double.Parse(numericUpDown2.Text);
            double r1 = 15;
            double r2 = 25;
            
            if (x * x + y * y == r1 * r1)
            {
               textBox3.Text ="На границе";
            }
            else if (x * x + y * y < r1 * r1)
            {
                textBox3.Text = "Внутри";
            }
            else if (x * x + y * y == r2 * r2)
            {
                textBox3.Text = "На границе";
            }
            else if (x * x + y * y < r2 * r2)
            {
                textBox3.Text = "Вне";
            }
            else textBox3.Text = "Внутри";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = null;
        }

    }
}
