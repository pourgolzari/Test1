using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, ans;
            char op;
            num1 = Convert.ToDouble(textBox1.Text);
            op = Convert.ToChar(textBox2.Text);
            num2 = Convert.ToDouble(textBox3.Text);
            ans = 0;
            switch (op)
            {
                case '+':
                    ans = num1 + num2;
                    break;
                case '-':
                    ans = num1 - num2;
                    break;
                case '*':
                    ans = num1 * num2;
                    break;
                case '/':
                    ans = num1 / num2;
                    break;
                default:
                    MessageBox.Show("Bad Operator!");
                    break;
            }
            textBox4.Text = ans.ToString();
        }

    }
}
