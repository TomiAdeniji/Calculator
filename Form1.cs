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
        Double resultValue = 0;
        String operationPerformed = "";

        bool isOpPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            //clears 0 in text box to display number clicked
            if ((textDisplayResult.Text == "0") || (isOpPerformed))
            {
                textDisplayResult.Clear();
            }
            isOpPerformed = false;
            Button button = (Button)sender;
            textDisplayResult.Text += button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textDisplayResult.Text);
            labelCurrentOp.Text = resultValue + "" + operationPerformed;
            isOpPerformed = true;
            //var operator = (Button)sender;

            //textDisplayResult.Text = textDisplayResult.Text + operator.Text;
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            textDisplayResult.Text = "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textDisplayResult.Text = "0";
            resultValue = 0;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textDisplayResult.Text = (resultValue + Double.Parse(textDisplayResult.Text)).ToString();
                    break;
                case "-":
                    textDisplayResult.Text = (resultValue - Double.Parse(textDisplayResult.Text)).ToString();
                    break;
                case "*":
                    textDisplayResult.Text = (resultValue * Double.Parse(textDisplayResult.Text)).ToString();
                    break;
                case "/":
                    textDisplayResult.Text = (resultValue / Double.Parse(textDisplayResult.Text)).ToString();
                    break;
                default:
                    break;

            }
        }
    }
}
