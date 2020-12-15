using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/// <summary>
/// följde instruktioner från denna
/// https://www.instructables.com/Creating-a-Calculator-Visual-Studio-C/
/// </summary>

namespace calculator3
{
    public partial class Calculator : Form
    {

        string input = string.Empty;
        string op1 = string.Empty;
        string op2 = string.Empty;
        char operation;
        double result = 0.0;


        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.op1 = string.Empty;
            this.op2 = string.Empty;
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

        private void equals_Click(object sender, EventArgs e)
        {

            op2 = input;
            double num1, num2;
            double.TryParse(op1, out num1);
            double.TryParse(op2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == 'R')
            {
                result = Math.Pow(num1, num2);

                textBox1.Text = result.ToString();
            }
            else if (operation == '√')
            {
                result = Math.Sqrt(num1 * num2);
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "division by zero error";
                }
            }
            input = result.ToString();
        }

        private void button_RaisedTo(object sender, EventArgs e)
        {
            op1 = input;
            operation = 'R'; 
            input = string.Empty;
        }

        private void squarRoot_Click(object sender, EventArgs e)
        {
            op1 = input;
            operation = '√';
            input = string.Empty;
        }
    }
}
