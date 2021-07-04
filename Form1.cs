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
            AppendButtons("0");
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

            if (calcu.Operation.Equals("*"))
            {
                calcu.NumA = DisplayBox.Text;
                calcu.Multiply();
                DisplayBox.Text = calcu.NumA;
            }

            if (calcu.Operation.Equals("/"))
            {
                calcu.NumA = DisplayBox.Text;
                calcu.Divide();
                DisplayBox.Text = calcu.NumA;
            }

            if (calcu.Operation.Equals("1/x"))
            {
                calcu.NumA = DisplayBox.Text;
                calcu.Frac();
                DisplayBox.Text = calcu.NumA;
            }

            if (calcu.Operation.Equals("x^2"))
            {
                calcu.NumA = DisplayBox.Text;
                calcu.Sqrd();
                DisplayBox.Text = calcu.NumA;
            }

            if (calcu.Operation.Equals("%"))
            {
                calcu.NumA = DisplayBox.Text;
                calcu.Percent();
                DisplayBox.Text = calcu.NumA;
            }

            if (calcu.Operation.Equals("sqrt"))
            {
                calcu.NumA = DisplayBox.Text;
                calcu.Sqrt();
                DisplayBox.Text = calcu.NumA;
            }

            if (calcu.Operation.Equals("+/-"))
            {
                calcu.NumA = DisplayBox.Text;
                calcu.Sign();
                DisplayBox.Text = calcu.NumA;
            }

            if (DisplayBox.Text.Length > 15)
            {
                DisplayBox.Font = new Font("Lucida Console", 12, FontStyle.Regular);
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

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            calcu.Operation = "*";
            calcu.IsOperationPressed = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            calcu.Operation = "/";
            calcu.IsOperationPressed = true;
        }

        private void btnFrac_Click(object sender, EventArgs e)
        {
            calcu.Operation = "1/x";
            calcu.IsOperationPressed = true;
        }

        private void btnSqrd_Click(object sender, EventArgs e)
        {
            calcu.Operation = "x^2";
            calcu.IsOperationPressed = true; 
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            calcu.Operation = "sqrt";
            calcu.IsOperationPressed = true;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            calcu.Operation = "%";
            calcu.IsOperationPressed = true;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            calcu.Operation = "+/-";
            calcu.IsOperationPressed = true;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!DisplayBox.Text.Contains("."))
            {
                DisplayBox.Text += "."; 
                // to avoid using the decimal point once it is clicked.
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text.Length > 0)
            {
                DisplayBox.Text = DisplayBox.Text.Remove(DisplayBox.Text.Length - 1, 1);//
            }
        }

        private void btnCE_Click(object sender, EventArgs e)//
        {
            DisplayBox.Text = String.Empty;
            DisplayBox.Font = new Font("Lucida Console", 24, FontStyle.Regular);
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            DisplayBox.Clear();
            DisplayBox.Font = new Font("Lucida Console", 24, FontStyle.Regular);//
        }

        private void btnMplus_Click(object sender, EventArgs e)
        {
            //Memory Add
        }

        private void btnMminus_Click(object sender, EventArgs e)
        {
            //Memory Remove
        }

        private void btnMsave_Click(object sender, EventArgs e)
        {
            //Memory Save
        }
    }
}
