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
        C_Class calcu = new C_Class();
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            AppendButtons("O");
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            AppendButtons("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            AppendButtons("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            AppendButtons("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            AppendButtons("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            AppendButtons("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            AppendButtons("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            AppendButtons("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            AppendButtons("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            AppendButtons("9");
        }


        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (calcu.Operation.Equals("+"))
            {
                calcu.NumA = DisplayBox.Text;
                calcu.Add();
                DisplayBox.Text = calcu.NumA;
            }

            if (calcu.Operation.Equals("-"))
            {
                calcu.NumA = DisplayBox.Text;
                calcu.Subtract();
                DisplayBox.Text = calcu.NumA;
            }
        }

        //method for buttons

        private void AppendButtons(String number)
        {
            if (calcu.IsOperationPressed)
            {
                calcu.Num = DisplayBox.Text;
                DisplayBox.Text = "";
            }

            DisplayBox.Text += number;
            calcu.IsOperationPressed = false;
        }

        //operations
        private void btnPlus_Click(object sender, EventArgs e)
        {


            calcu.Operation = "+";
            calcu.IsOperationPressed = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            calcu.Operation = "-";
            calcu.IsOperationPressed = true;
        }

    }
}
