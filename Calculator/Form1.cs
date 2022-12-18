using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics; 

namespace Calculator
{
    public partial class Form1 : Form
    {
        List<double> terms = new List<double>();
        Operation op = new Operation();
        double result;
        enum Operation
        {
            Plus = 0,
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
            if(double.TryParse(mainTextBox.Text, out double result) == false)
            {
                return;
            }
            terms.Add(Convert.ToDouble(mainTextBox.Text));
            Button button = sender as Button;
            int op;
            if(button != null && int.TryParse(button.Tag.ToString(),out op))
            {
                this.op = (Operation)op;
            }
            if (terms.Count > 1)
            {
                SwitchOperation();
            }
            mainTextBox.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Text != "")
            {
                mainTextBox.Text = mainTextBox.Text.Remove(mainTextBox.Text.Length - 1);
            }
            result = 0;
            terms.Clear();
        }
        private void SwitchOperation()
        {
            switch (op)
            {
                case Operation.Plus:
                    {
                        result = terms.ElementAt(0) + terms.ElementAt(1);
                        break;
                    }
                case Operation.Minus:
                    {
                        result = terms.ElementAt(0) - terms.ElementAt(1);
                        break;
                    }
                case Operation.Division:
                    {
                        result = terms.ElementAt(0) / terms.ElementAt(1);
                        break;
                    }
                case Operation.Multiply:
                    {
                        result = terms.ElementAt(0) * terms.ElementAt(1);
                        break;
                    }
            }
            mainTextBox.Text = result.ToString();
            terms.Clear();
        }
        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (terms.Count > 0 && double.TryParse(mainTextBox.Text, out double result))
            {
                terms.Add(result);
                SwitchOperation();
            }
        }

        private void FullClearButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
