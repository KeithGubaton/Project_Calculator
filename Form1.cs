using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Calculator
{
    public partial class Calculator : Form
    {
        String operation = "";
        Boolean isOperationPressed = false;
        String num = "";
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (isOperationPressed)
            {
                num = DisplayBox.Text;
                DisplayBox.Text = "";
            }

            DisplayBox.Text += "0";
            isOperationPressed = false;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (isOperationPressed)
            {
                num = DisplayBox.Text;
                DisplayBox.Text = "";
            }

            DisplayBox.Text += "1";
            isOperationPressed = false;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (isOperationPressed)
            {
                num = DisplayBox.Text;
                DisplayBox.Text = "";
            }

            DisplayBox.Text += "2";
            isOperationPressed = false;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (isOperationPressed)
            {
                num = DisplayBox.Text;
                DisplayBox.Text = "";
            }

            DisplayBox.Text += "3";
            isOperationPressed = false;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (isOperationPressed)
            {
                num = DisplayBox.Text;
                DisplayBox.Text = "";
            }

            DisplayBox.Text += "4";
            isOperationPressed = false;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (isOperationPressed)
            {
                num = DisplayBox.Text;
                DisplayBox.Text = "";
            }

            DisplayBox.Text += "5";
            isOperationPressed = false;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (isOperationPressed)
            {
                num = DisplayBox.Text;
                DisplayBox.Text = "";
            }

            DisplayBox.Text += "6";
            isOperationPressed = false;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (isOperationPressed)
            {
                num = DisplayBox.Text;
                DisplayBox.Text = "";
            }

            DisplayBox.Text += "7";
            isOperationPressed = false;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (isOperationPressed)
            {
                num = DisplayBox.Text;
                DisplayBox.Text = "";
            }

            DisplayBox.Text += "8";
            isOperationPressed = false;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (isOperationPressed)
            {
                num = DisplayBox.Text;
                DisplayBox.Text = "";
            }

            DisplayBox.Text += "9";
            isOperationPressed = false;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operation = "+";
            isOperationPressed = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = (float.Parse(num) + float.Parse(DisplayBox.Text)).ToString();
        }
    }
}
