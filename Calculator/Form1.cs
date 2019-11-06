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
        bool isOperationPerformed = false;
         String Clear = "0";

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || (isOperationPerformed))
            {

            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;

        }
      
        private void operator_click(object sender, EventArgs e)
        {

            currentoperation.Text = resultValue + " " + operationPerformed;
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox1.Text);
            isOperationPerformed = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;

        }

        private void button9_Click(object sender, EventArgs e)
        {

            switch (operationPerformed)
            {
                case "+":
                    textBox1.Text =(resultValue +Double.Parse(textBox1.Text)).ToString();     
                    break;

                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;


                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;

            }
        }
    }
}
