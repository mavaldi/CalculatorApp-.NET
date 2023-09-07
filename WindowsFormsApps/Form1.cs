using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void button10_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "9";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(textBox.Text);

            textBox.Clear();
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(textBox.Text);

            textBox.Clear();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(textBox.Text);

            textBox.Clear();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(textBox.Text);

            textBox.Clear();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            textBox.Text = result + "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
