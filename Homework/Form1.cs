using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form1 : Form
    {
        int counter = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (counter == 5) this.BackColor = Color.FromArgb(5, 5, 5);
            //else if (counter == 10) this.BackColor = Color.FromArgb(150, 150, 150);
            //else if(counter == 15) this.BackColor = Color.FromArgb(250, 250, 250);


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            if (counter == 5) this.BackColor = Color.FromArgb(20, 82, 123);
            else if (counter == 10) this.BackColor = Color.FromArgb(150, 50, 150);
            else if (counter == 15) this.BackColor = Color.FromArgb(33, 150, 20);
            count.Text = counter.ToString();


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            counter = 0;
            this.BackColor = Color.FromArgb(250, 250, 250);
            count.Text = counter.ToString();
        }

        private void count_Click(object sender, EventArgs e)
        {

        }
    }
}
