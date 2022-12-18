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
        double a;
        double result;
        public IOperation operation;
        BaseOperations baseOperations;

        public Form1()
        {
            baseOperations = new BaseOperations();
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

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (baseOperations.Operation != Operation.None)
            {
                if (double.TryParse(mainTextBox.Text, out double num))
                {
                    result = baseOperations.Execute(a, num);
                    a = result;
                    baseOperations.ChangeOperation(Operation.None);
                }
                mainTextBox.Text = result.ToString();
            }
        }

        private void FullClearButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = "";
            result = 0;
            baseOperations.ChangeOperation(Operation.None);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Text.Length > 0)
            {
                mainTextBox.Text = mainTextBox.Text.Remove(mainTextBox.Text.Length - 1);
                if (double.TryParse(mainTextBox.Text, out double num))
                {
                    Init(num);
                }

            }
        }
        private void Init(double num)
        {
            if (baseOperations.Operation == Operation.None)
            {
                a = num;
            }
            else
            {
                result = baseOperations.Execute(a, num);
                a = result;
            }
        }
        private void OperationButton_Click(object sender, EventArgs e)
        {  
            if (double.TryParse(mainTextBox.Text,out double num))
            {                 
                Button button = sender as Button;
                Init(num);
                baseOperations.ChangeOperation((Operation)int.Parse(button.Tag.ToString()));
                mainTextBox.Text = "";
                
            }
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Text.Length == 0)
                return;
                
            if(mainTextBox.Text.Length != 0 && mainTextBox.Text[mainTextBox.Text.Length - 1] != ',')
            {
                mainTextBox.Text += ",";
            }
        }
    }
}
