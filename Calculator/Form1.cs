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
        double a, b;
        Operation op = new Operation();

        enum Operation
        {
            Plus = 1,
            Minus,
            Multiply,
            Division
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void DigitClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int digit;
            if (button != null && int.TryParse(button.Text, out digit) == true)
            {
                mainTextBox.Text += digit.ToString();
            }
            else
            {
                throw new Exception("not a cipher");
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Text != "")
            {
                if (this.op == 0)
                    a = Convert.ToDouble(mainTextBox.Text);
                else
                {
                    b = Convert.ToDouble(mainTextBox.Text);
                    SwitchOperation();
                }

                Button button = sender as Button;
                int op;

                if (button != null && int.TryParse(button.Tag.ToString(), out op))
                    this.op = (Operation)op;

                mainTextBox.Text = "";
            }
            else
            {
                throw new Exception("Ошибка: введите число");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Text != "")
                mainTextBox.Text = mainTextBox.Text.Remove(mainTextBox.Text.Length - 1);
        }

        private void SwitchOperation()
        {
            textBox1.Text = "";
            textBox1.Text += "a: " + a.ToString() + " b: " + b.ToString();

            double result = 0;

            switch (op)
            {
                case Operation.Plus:
                    {
                        result = a + b;
                        break;
                    }
                case Operation.Minus:
                    {
                        result = a - b;
                        break;
                    }
                case Operation.Division:
                    {
                        result = a / b;
                        break;
                    }
                case Operation.Multiply:
                    {
                        result = a * b;
                        break;
                    }
            }

            a = result;
            mainTextBox.Text = result.ToString();
        }
        private void EqualButton_Click(object sender, EventArgs e)
        {
            SwitchOperation();
            op = 0;
        }

        private void FullClearButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = "";
            a = 0;
            b = 0;
        }
    }
}
