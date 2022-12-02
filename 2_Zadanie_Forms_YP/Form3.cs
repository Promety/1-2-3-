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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rate;
            int j = 5;
            int k = 1;
            textBox1.Text = "";


            rate = (int)numericUpDown1.Value;


            textBox1.Text += "while" + Environment.NewLine;

            
            textBox1.Text += "Таблица перевода долларов США в рубли"+ Environment.NewLine;

  
            while (j <= 120)
            {
                textBox1.Text += $"{j}\t{j * rate }" + Environment.NewLine;
               
                j += 5;
            }

            textBox2.Text += Environment.NewLine + "do...while" + Environment.NewLine;
            textBox2.Text += "Таблица перевода долларов США в рубли" + Environment.NewLine;

            k = 0;
            do
            {

                textBox2.Text += $"{k}\t{k * rate }" + Environment.NewLine;
                
                k += 5;
            } while (k <= 120);


            textBox3.Text += Environment.NewLine + "for" + Environment.NewLine;
            textBox3.Text += "Таблица перевода долларов США в рубли" + Environment.NewLine;
            for (j = 5; j <= 120; j += 5)
                textBox3.Text += $"{j}\t{j * rate }" + Environment.NewLine;


        }
    
    }
}
    
