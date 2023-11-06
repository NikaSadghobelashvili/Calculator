using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        bool operation = false;
        double resultValue = 0;
        string performedOperator = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void clicl_event(object sender, EventArgs e)
        {
            
            if ((textBox1.Text == "0") || operation)
            {
                textBox1.Clear();
            }
            operation = false;
            Button b = (Button)sender;
            textBox1.Text += b.Text;
            
        }

        private void operation_event(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (resultValue != 0)
            {
                button16_Click(sender, e);
                performedOperator = b.Text;
                operation = true;
                resultValue = Double.Parse(textBox1.Text);
                label1.Text = resultValue + " " + performedOperator;
            }
            else
            { 
            performedOperator = b.Text;
            resultValue = Double.Parse(textBox1.Text);
            operation = true;
                label1.Text = resultValue + " " + performedOperator;
            }
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (performedOperator == "+")
            {
                textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
            }
            else if (performedOperator == "-")
            {
                textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
            }
            else if (performedOperator == "*")
            {
                textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
            }
            else if (performedOperator == "/")
            {
                textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
            }
            resultValue = 0;
            label1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
                button15_Click(sender, e);
            if(textBox1.Text!="0")
           textBox1.Text=textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
