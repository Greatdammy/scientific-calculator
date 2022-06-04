using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scientific.calculator
{
    public partial class Form1 : Form
    {
        double num1;
        string operation;
        double result;
        public Form1()
        {
            InitializeComponent();
        }

      
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else textBox1.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else textBox1.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else textBox1.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else textBox1.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else textBox1.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else textBox1.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else textBox1.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else textBox1.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else textBox1.Text += 9;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else textBox1.Text += 0;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            operation = "*";
            textBox1.Text = "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            operation = "+";
            textBox1.Text = "0";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            operation = "/";
            textBox1.Text = "0";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            operation = "-";
            textBox1.Text = "0";
        }

        private void btnPlMu_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = result * -1;
            textBox1.Text = result.ToString(); 
        }

        private void btnInvers_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = 1 / result;
            textBox1.Text = result.ToString();
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = result / 100;
            textBox1.Text = result.ToString();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.PI;
            textBox1.Text = result.ToString();

        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Sin(result);
            textBox1.Text = result.ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Cos(result);
            textBox1.Text = result.ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Tan(result);
            textBox1.Text = result.ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Log10(result);
            textBox1.Text = result.ToString();
        }

        private void btnX3_Click(object sender, EventArgs e)
        {
            result =double.Parse(textBox1.Text);
            result = Math.Pow(result, 3);
            textBox1.Text =result.ToString();

        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            int index = textBox1.Text.Length;
            index--;
            textBox1.Text = textBox1.Text.Remove(index);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Sqrt(result);
            textBox1.Text = result.ToString();
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Pow(result, 2);
            textBox1.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double num2 = Convert.ToDouble(textBox1.Text);
            if(operation == "+")
            {
                result = num1 + num2;
            }
            if (operation == "-")
            {
                result = num1 - num2;
            }
            if (operation == "*")
            {
                result = num1 * num2;
            }
            if (operation == "/")
            {
                result = num1 / num2;
            }

            textBox1.Text = result.ToString();
            num1 = result;
        }
    }
}
