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
        Double ResultValue = 0;
        String OperatorClicked = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button but = (Button)sender;
            if (but.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + but.Text;

            }
            else
                textBox_Result.Text = textBox_Result.Text + but.Text;
            
        }

        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button button = (Button)sender;


            if (ResultValue != 0)
            {
                buttonEquals.PerformClick();
                OperatorClicked = button.Text;
                labelOperation.Text = ResultValue + " " + OperatorClicked;
                isOperationPerformed = true;
            }
            else
            { 
                OperatorClicked = button.Text;
                ResultValue = Double.Parse(textBox_Result.Text);
                labelOperation.Text = ResultValue + " " + OperatorClicked;
                isOperationPerformed = true;
            }
        }

        private void button_Click_Clear(object sender, EventArgs e)
        {
            textBox_Result.Text = " ";
            ResultValue = 0;
        }

        private void button_Complete_Click_Clear(object sender, EventArgs e)
        {
            textBox_Result.Text = " ";
        }

        private void button_Click_Equals(object sender, EventArgs e)
        {
            switch(OperatorClicked)
            {
                case "+":
                            textBox_Result.Text = (ResultValue + Double.Parse(textBox_Result.Text)).ToString();
                break;

                case "-":
                    textBox_Result.Text = (ResultValue - Double.Parse(textBox_Result.Text)).ToString();
                break;

                case "*":
                    textBox_Result.Text = (ResultValue * Double.Parse(textBox_Result.Text)).ToString();
                break;

                case "/":
                    textBox_Result.Text = (ResultValue / Double.Parse(textBox_Result.Text)).ToString();
                break;

                default:

                break;
            }
            ResultValue = Double.Parse(textBox_Result.Text);
            labelOperation.Text = "";
        }
    }
}
