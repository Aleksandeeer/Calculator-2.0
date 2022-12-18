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
        List<int> terms = new List<int>();
        operations op = new operations();

        enum operations
        {
            plus,
            minus,
            division,
            multiply
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "1";
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "2";
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "3";
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "4";
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "5";
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "6";
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "7";
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "8";
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "9";
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "0";
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            terms.Add(Convert.ToInt32(mainTextBox.Text));
            
            op = operations.plus;

            mainTextBox.Text = "";
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            terms.Add(Convert.ToInt32(mainTextBox.Text));

            op = operations.minus;

            mainTextBox.Text = "";
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            terms.Add(Convert.ToInt32(mainTextBox.Text));

            op = operations.division;

            mainTextBox.Text = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            terms.Add(Convert.ToInt32(mainTextBox.Text));

            op = operations.multiply;

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

        private void EqualButton_Click(object sender, EventArgs e)
        {
            terms.Add(Convert.ToInt32(mainTextBox.Text));
            int result;

            textBox1.Text = "";
            for (int i = 0; i < terms.Count(); i++)
            {
                textBox1.Text += terms.ElementAt(i).ToString();
            }


            switch (op)
            {
                case operations.plus:
                    {
                        result = terms.ElementAt(0) + terms.ElementAt(1);

                        mainTextBox.Text = result.ToString();

                        terms.Clear();

                        break;
                    }
                case operations.minus:
                    {
                        result = terms.ElementAt(0) - terms.ElementAt(1);

                        mainTextBox.Text = result.ToString();

                        terms.Clear();

                        break;
                    }
                case operations.division:
                    {
                        result = terms.ElementAt(0) / terms.ElementAt(1);

                        mainTextBox.Text = result.ToString();

                        terms.Clear();

                        break;
                    }
                case operations.multiply:
                    {
                        result = terms.ElementAt(0) * terms.ElementAt(1); 

                        mainTextBox.Text = result.ToString();

                        terms.Clear();

                        break;
                    }
            }
        }

        private void FullClearButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = "";
        }
    }
}
