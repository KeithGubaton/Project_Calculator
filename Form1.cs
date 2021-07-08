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

        //TO EDIT OTHER OPERATIONS
        private void btnFrac_Click(object sender, EventArgs e)
        {
            Double frac;
            frac = Convert.ToDouble(1 / Convert.ToDouble(DisplayBox.Text));
            DisplayBox.Text = frac.ToString();
            calcu.Operation = "1/x";
            calcu.IsOperationPressed = true;
            ShowBox.Text = "1/" + calcu.Num;
        }

        private void btnSqrd_Click(object sender, EventArgs e)
        {
            Double sqrd;
            sqrd = double.Parse(DisplayBox.Text) * double.Parse(DisplayBox.Text);
            DisplayBox.Text = sqrd.ToString();
            calcu.Operation = "x^2";
            //label.Text = "(" + calcu.NumA + ")^2";
            calcu.IsOperationPressed = true;
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            Double sqrt = double.Parse(DisplayBox.Text);
            sqrt = Math.Sqrt(sqrt);
            calcu.Operation = "sqrt";
            DisplayBox.Text = sqrt.ToString();
            calcu.IsOperationPressed = true;
            //label.Text = "";
        
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            Double percent;
            percent = double.Parse(DisplayBox.Text) / 100;
            DisplayBox.Text = percent.ToString();
            calcu.Operation = "%";
            calcu.IsOperationPressed = true;
            //label
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
            calcu.Mstore1 += decimal.Parse(calcu.NumA);

            btnMClear.Enabled = true;
            btnMRecall.Enabled = true;
        }

        private void btnMRecall_Click(object sender, EventArgs e)
        {
            calcu.NumA = calcu.Mstore1.ToString();
        }

        private void btnMminus_Click(object sender, EventArgs e)
        {
            calcu.Mstore1 -= decimal.Parse(calcu.NumA);
            calcu.NumA = calcu.Mstore1.ToString();
        }

        private void btnMplus_Click(object sender, EventArgs e)
        {
            calcu.Mstore1 += decimal.Parse(calcu.NumA);
            calcu.NumA = calcu.Mstore1.ToString();
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

        private void ShowBox_TextChanged(object sender, EventArgs e)
        {
            if (ShowBox.Text.Length > 15)
            {
                ShowBox.Font = new Font("Lucida Console", 9, FontStyle.Regular);
            }
            else
            {
                DisplayBox.Font = new Font("Lucida Console", 14, FontStyle.Regular);
            }
        }
    }
}
