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
/// En grafik miniräknare 
/// Grunden designad genom att följa denna guide:
/// https://www.instructables.com/Creating-a-Calculator-Visual-Studio-C/
/// 
/// Miniräknaren håller minne via en sträng
/// </summary>

namespace calculator3
{
    //minnet sparas genom string input och ritas upp på skärmen
    //beräkningar sker genom att skriva över minne till op1 och op2 och utföra beräkning med den operation som angetts

    public partial class Calculator : Form
    {
       
        string input = string.Empty;
        string op1 = string.Empty;
        string op2 = string.Empty;
        char operation;
        double result = 0.0;
        List<string> memory = new List<string>();

        public Calculator()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            input += "1";
            this.textBox1.Text = input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input += "2";
            this.textBox1.Text = input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input += "3";
            this.textBox1.Text = input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input += "4";
            this.textBox1.Text = input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input += "5";
            this.textBox1.Text = input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input += "6";
            this.textBox1.Text = input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input += "7";
            this.textBox1.Text = input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input += "8";
            this.textBox1.Text = input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input += "9";
            this.textBox1.Text = input;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            input += "0";
            this.textBox1.Text = input;
        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            input += ",";
            this.textBox1.Text = input;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.op1 = string.Empty;
            this.op2 = string.Empty;
        }

        //Vid operand sparas minnet till op1 för att kunna återanvända input

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
            equals_Click(sender, e);
        }

        private void equals_Click(object sender, EventArgs e)
        {

            //felhantering för Parse är redundant eftersom inkompatibel input inte är möjlig
            //Enklare else satser för att kolla vilken operator som ska användas

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
                result = Math.Sqrt(num1);
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
                    textBox1.Text = "div zero error, it's still impossible";
                }
            }

            //minnet som hålls i result går över till input igen för att fortsätta beräkning från senaste resultat
            input = result.ToString();

            memory.Add(input);
            Console.WriteLine(memory);
        }
    }
}