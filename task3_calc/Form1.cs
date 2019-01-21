using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3_calc
{
    public partial class Form1 : Form
    {
        double value = 0;
        string opr = "";
        bool opr_Pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0")||(opr_Pressed)) textBox1.Clear();
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void opr_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            opr = b.Text;
            value = double.Parse(textBox1.Text);
            opr_Pressed = true;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (opr)
            {
                case "+":
                    textBox1.Text = (value + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            opr_Pressed = false;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            value = 0;
        }
    }
}
