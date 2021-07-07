﻿using System;
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
            calcu.NumA = DisplayBox.Text;
            calcu.operations();
            label.Text = System.Convert.ToString(calcu.NumA) + " " + calcu.Operation;
            DisplayBox.Text = calcu.NumA;
        }

        //METHOD FOR BUTTONS

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

        //OPERATIONS
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

        //SIGN & DECIMAL
        private void btnSign_Click(object sender, EventArgs e)
        {
            calcu.NumA = DisplayBox.Text;
            calcu.Sign();
            DisplayBox.Text = calcu.NumA;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            calcu.NumA = DisplayBox.Text;
            calcu.Decimal();
            DisplayBox.Text = calcu.NumA;         
        }

        //OTHER BUTTONS
        private void btnDel_Click(object sender, EventArgs e)
        {
            calcu.NumA = DisplayBox.Text;
            calcu.Del();
            DisplayBox.Text = calcu.NumA;
        }

        private void btnCE_Click(object sender, EventArgs e)///
        {
            DisplayBox.Text = String.Empty;
            label.Text = String.Empty;
        }

        private void btnClr_Click(object sender, EventArgs e)///
        {
            DisplayBox.Clear();  
            label.Text = String.Empty;
        }

        // MEMORY BUTTONS
        private void btnMStore_Click(object sender, EventArgs e)
        {
            calcu.Mstore1 = decimal.Parse(DisplayBox.Text);

            btnMClear.Enabled = true;
            btnMRecall.Enabled = true;
        }
        
        private void btnMClear_Click(object sender, EventArgs e)
        {
            calcu.Mstore1 = 0;

            btnMClear.Enabled = false;
            btnMRecall.Enabled = false;
        }
        private void btnMRecall_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = calcu.Mstore1.ToString();
        }

        private void btnMplus_Click(object sender, EventArgs e)
        {
            calcu.Mstore1 += decimal.Parse(DisplayBox.Text);
            DisplayBox.Text = calcu.Mstore1.ToString();
        }

        private void btnMminus_Click(object sender, EventArgs e)
        {
            calcu.Mstore1 -= decimal.Parse(DisplayBox.Text);
            DisplayBox.Text = calcu.Mstore1.ToString();
        }

        //MISCELLANEOUS
        private void DisplayBox_TextChanged(object sender, EventArgs e)
        {
            if (DisplayBox.Text.Length > 15)
            {
                DisplayBox.Font = new Font("Lucida Console", 12, FontStyle.Regular);
            }
            else
            {
                DisplayBox.Font = new Font("Lucida Console", 24, FontStyle.Regular);
            }
        }
    }
}
