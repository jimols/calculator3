using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator3
{
    public partial class Form1 : Form
    {

        string input = string.Empty;
        string op1 = string.Empty;
        string op2 = string.Empty;
        char operation;
        double result = 0.0;


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {

        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            op1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void buttonSubstraction_Click(object sender, EventArgs e)
        {
            op1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            op1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            op1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
