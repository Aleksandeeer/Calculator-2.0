using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            else if (!mainTextBox.Text.Contains("-"))
            {
                mainTextBox.Text += "-";
            }
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Text.Length == 0)
                return;
                
            if(mainTextBox.Text.Length != 0 && !mainTextBox.Text.Contains(","))
            {
                mainTextBox.Text += ",";
            }
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(mainTextBox.Text);

            if(a > 0)
            {
                mainTextBox.Text = Math.Sqrt(a).ToString();
            }
        }

        private void gammaButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = SpecialFunctions.Gamma(Convert.ToDouble(mainTextBox.Text)).ToString();
        }

        private void besselButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = SpecialFunctions.BesselI0(Convert.ToDouble(mainTextBox.Text)).ToString();
        }

        private void sinButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = Math.Sin(Convert.ToDouble(mainTextBox.Text)).ToString();
        }

        private void cosButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = Math.Cos(Convert.ToDouble(mainTextBox.Text)).ToString();
        }

        private void tgButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = Math.Tan(Convert.ToDouble(mainTextBox.Text)).ToString();
        }

        private void ctgButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = (1 / Math.Tan(Convert.ToDouble(mainTextBox.Text))).ToString();
        }

        private void piButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = Convert.ToString(Math.PI);
        }

        private void eButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = Convert.ToString(Math.E);
        }
    }
}
