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
        List<double> terms = new List<double>();
        Operation op = new Operation();

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
            terms.Add(Convert.ToDouble(mainTextBox.Text));
            Button button = sender as Button;
            int op;
            if(button != null && int.TryParse(button.Tag.ToString(),out op))
            {
                this.op = (Operation)op;
            }
            mainTextBox.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Text != "")
            {
                mainTextBox.Text = mainTextBox.Text.Remove(mainTextBox.Text.Length - 1);
            }
            terms.Clear();
        }
        private void SwitchOperation()
        {
            double result =0;
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
            terms.Add(Convert.ToDouble(mainTextBox.Text));       
            SwitchOperation();       
        }

        private void FullClearButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = "";
        }
    }
}
