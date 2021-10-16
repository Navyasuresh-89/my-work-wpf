using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_interest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {

            double amount, interest;

            double time;

            double compound_interest;



            amount = Convert.ToDouble(textBox1.Text);



            interest = Convert.ToDouble(textBox2.Text);



            time = Convert.ToDouble(textBox3.Text);



            compound_interest = amount * (Math.Pow((1 + interest / 100), time));



            textBox4.Text = compound_interest.ToString("0.00");



        }


    }
}
