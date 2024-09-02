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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e) // плюс
        {
            int a;
            int b;
            int c;
            int d;
            int f;
            int g;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox3.Text);
            d = Convert.ToInt16(textBox2.Text);
            f = Convert.ToInt16(textBox4.Text);
            c = a + b;
            g = d + f;
            textBox5.Text = Convert.ToString(c) + " + " + Convert.ToString(g) + "i";
        }

        private void button2_Click(object sender, EventArgs e)  // минус
        {
            int a;
            int b;
            int c;
            int d;
            int f;
            int g;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox3.Text);
            d = Convert.ToInt16(textBox2.Text);
            f = Convert.ToInt16(textBox4.Text);
            c = a - b;
            g = d - f;
            textBox5.Text = Convert.ToString(c) + " + " + Convert.ToString(g) + "i";
        }

        private void button3_Click(object sender, EventArgs e)  // умножить
        {
            int a;
            int b;
            int c;
            int d;
            int f;
            int g;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox3.Text);
            d = Convert.ToInt16(textBox2.Text);
            f = Convert.ToInt16(textBox4.Text);
            c = a * b;
            g = d * f;
            textBox5.Text = Convert.ToString(c) + " + " + Convert.ToString(g) + "i";
        }
    }
}
