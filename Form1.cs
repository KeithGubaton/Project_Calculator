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
            btnMClear.Enabled = false;
            btnMRecall.Enabled = false;
            DisplayBox.Text = "0";
        }

        //METHOD FOR BUTTONS (Shortened)
        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            calcu.NumA = DisplayBox.Text;
            DisplayBox.Text = calcu.NumA;

            if ((calcu.NumA == "0") || (calcu.IsOperationPressed))
            {
                DisplayBox.Text = "";
            }

            DisplayBox.Text += num.Text;
            calcu.IsOperationPressed = false;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            calcu.NumA = DisplayBox.Text;
            calcu.operations();
            ShowBox.Text = calcu.Show;
            DisplayBox.Text = calcu.NumA;
        }

        //OPERATIONS
        private void operator_Click(object sender, EventArgs e)
        {
            Button operators = (Button)sender;

            if (calcu.Num != 0)
            {
                btnEquals.PerformClick();
                calcu.Operation = operators.Text;
                calcu.IsOperationPressed = true;
            }
            else
            {
                calcu.Operation = operators.Text;
                calcu.Num = Double.Parse(DisplayBox.Text);
                calcu.IsOperationPressed = true;
            }
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

        //OTHER BUTTONS (DEL,CE,CLR)
        private void btnDel_Click(object sender, EventArgs e)
        {
            calcu.Del();
            DisplayBox.Text = calcu.NumA;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = calcu.NumA;
            ShowBox.Text = String.Empty;
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            DisplayBox.Clear();
            ShowBox.Text = String.Empty;
            calcu.Num = 0;
        }

        // MEMORY BUTTONS
        private void btnMClear_Click(object sender, EventArgs e)
        {
            calcu.Mstore1 = 0;

            btnMClear.Enabled = false;
            btnMRecall.Enabled = false;
        }

        private void btnMStore_Click(object sender, EventArgs e)
        {
            calcu.Mstore1 += decimal.Parse(DisplayBox.Text);

            btnMClear.Enabled = true;
            btnMRecall.Enabled = true;
        }

        private void btnMRecall_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = calcu.Mstore1.ToString();
        }

        private void btnMminus_Click(object sender, EventArgs e)
        {
            calcu.Mstore1 -= decimal.Parse(DisplayBox.Text);
            DisplayBox.Text = calcu.Mstore1.ToString();
        }

        private void btnMplus_Click(object sender, EventArgs e)
        {
            calcu.Mstore1 += decimal.Parse(DisplayBox.Text);
            DisplayBox.Text = calcu.Mstore1.ToString();
        }

        //MISCELLANEOUS
        private void DisplayBox_TextChanged(object sender, EventArgs e)
        {
            if (DisplayBox.Text.Length > 15)
            {
                DisplayBox.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            }
            else
            {
                DisplayBox.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            }
        }

        private void ShowBox_TextChanged(object sender, EventArgs e)
        {
            if (ShowBox.Text.Length > 15)
            {
                ShowBox.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }
            else
            {
                DisplayBox.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }
        }
    }
}
