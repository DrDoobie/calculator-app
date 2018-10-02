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
    public partial class Calculator : Form
    {

        private bool isCalculated;
        private bool val1Entered;
        private decimal value1, value2;
        private string operationType;
        decimal result;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            
        }

        private void InputNumber(object sender, EventArgs e)
        {
            if(!isCalculated)
            {
                val1Entered = true;

                if (inputBox.Text != "0")
                {
                    inputBox.Text = inputBox.Text + ((Button)sender).Text;

                } else {
                    inputBox.Text = ((Button)sender).Text;
                }
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            if(inputBox.Text != null)
            {
                inputBox.Text = null;
                val1Entered = false;

                value1 = 0;
                value2 = 0;

                isCalculated = false;
            }
        }

        private void Operate(object sender, EventArgs e)
        {
            if(val1Entered)
            {
                value1 = Convert.ToDecimal(inputBox.Text);
                operationType = ((Button)sender).Name;
                inputBox.Text = null; 
            }
        }

        private void Calculate(object sender, EventArgs e)
        {
            if (inputBox.Text != null && !isCalculated && val1Entered)
            {
                value2 = Convert.ToDecimal(inputBox.Text);

                if(operationType == "add")
                {
                    result = value1 + value2;

                } else if(operationType == "subtract") {
                    result = value1 - value2;

                } else if(operationType == "multiply") {
                    result = value1 * value2;

                } else if(operationType == "divide") {
                    result = value1 / value2;
                }

                isCalculated = true;
                inputBox.Text = result.ToString();
            }
        }
    }
}
