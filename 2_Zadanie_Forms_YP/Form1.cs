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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         private void button1_Click(object sender, EventArgs e)
        {
            double k = double.Parse(numericUpDown1.Text);
            double m = double.Parse(numericUpDown2.Text);
          
                switch (k)
            {
                case 6: { textBox1.Text = "Шестерка "; break; }
                case 7: { textBox1.Text = ("Семерка "); break; }
                case 8: { textBox1.Text = ("Восьмерка "); break; }
                case 9: { textBox1.Text = ("Девятка "); break; }
                case 10: { textBox1.Text = ("Десятка "); break; }
                case 11: { textBox1.Text = ("Валет "); break; }
                case 12: { textBox1.Text = ("Дама "); break; }
                case 13: { textBox1.Text = ("Король "); break; }
                case 14: { textBox1.Text = ("Туз "); break; }
                default: { MessageBox.Show("Число должно быть от 6 до 14!, Ошибочка"); break; }
            }
            switch (m)
            {
                case 1: { textBox1.Text += (" Пики"); break; }
                case 2: { textBox1.Text += ("Буби"); break; }
                case 3: { textBox1.Text += ("Черви"); break; }
                case 4: { textBox1.Text += ("Крести"); break; }
                default: { MessageBox.Show("Число должно быть от 1 до 4!, Ошибочка"); break; }
            }

        }

      

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form2 newfrm = new Form2();
            newfrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newfrm = new Form3();
            newfrm.Show();
        }
    }
}
