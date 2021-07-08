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
            if (calcu.Operation.Equals("1/x"))
            {
                calcu.NumA = DisplayBox.Text;
                calcu.operations();
                label.Text = calcu.Show;
                DisplayBox.Text = calcu.NumA;
            }
            else if (calcu.Operation.Equals("x^2"))
            {
                calcu.NumA = DisplayBox.Text;
                calcu.operations();
                label.Text = calcu.Show;
                DisplayBox.Text = calcu.NumA;
            }
            else if (calcu.Operation.Equals("sqrt"))
            {
                //calcu.NumA = DisplayBox.Text;
                calcu.operations();
                label.Text = calcu.Show;
                //DisplayBox.Text = calcu.NumA;
            }
            else if (calcu.Operation.Equals("%"))
            {
                //calcu.Num = DisplayBox.Text;
                calcu.operations();
                label.Text = calcu.Show;
                //DisplayBox.Text = calcu.Num;
            }

            calcu.NumA = DisplayBox.Text;
            calcu.operations();
            label.Text = calcu.Show;
            DisplayBox.Text = calcu.NumA;
        }

        //METHOD FOR BUTTONS

        private void AppendButtons(String number)
        {
            if (calcu.IsOperationPressed)
            {
                DisplayBox.Text = "";
            }

            DisplayBox.Text += number;
            calcu.IsOperationPressed = false;
        }

        //OPERATIONS

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (calcu.Num != 0)
            {
                btnEquals.PerformClick();
                calcu.Operation = button.Text;
                calcu.IsOperationPressed = true;
            }
            else
            {
                calcu.Operation = button.Text;
                calcu.Num = Double.Parse(DisplayBox.Text);
                calcu.IsOperationPressed = true;
            }

        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (calcu.Num != 0)
            {
                btnEquals.PerformClick();
                calcu.Operation = "+";
                calcu.IsOperationPressed = true;
            }
            else
            {
                calcu.Operation = "+";
                calcu.Num = Double.Parse(DisplayBox.Text);
                calcu.IsOperationPressed = true;
            }
           
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (calcu.Num != 0)
            {
                btnEquals.PerformClick();
                calcu.Operation = "-";
                calcu.IsOperationPressed = true;
            }
            else
            {
                calcu.Operation = "-";
                calcu.Num = Double.Parse(DisplayBox.Text);
                calcu.IsOperationPressed = true;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (calcu.Num != 0)
            {
                btnEquals.PerformClick();
                calcu.Operation = "*";
                calcu.IsOperationPressed = true;
            }
            else
            {
                calcu.Operation = "*";
                calcu.Num = Double.Parse(DisplayBox.Text);
                calcu.IsOperationPressed = true;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (calcu.Num != 0)
            {
                btnEquals.PerformClick();
                calcu.Operation = "/";
                calcu.IsOperationPressed = true;
            }
            else
            {
                calcu.Operation = "/";
                calcu.Num = Double.Parse(DisplayBox.Text);
                calcu.IsOperationPressed = true;
            }
        }
        //TO EDIT
        private void btnFrac_Click(object sender, EventArgs e)
        {
            Double frac;
            frac = Convert.ToDouble(1 / Convert.ToDouble(DisplayBox.Text));
            DisplayBox.Text = frac.ToString();
            calcu.Operation = "1/x";
            calcu.IsOperationPressed = true;
            label.Text = "1/" + calcu.NumA;
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

        private void btnClr_Click(object sender, EventArgs e)
        {
            DisplayBox.Clear();  
            label.Text = String.Empty;
            calcu.Num = 0;
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

        private void label_TextChanged(object sender, EventArgs e)
        {
            if (label.Text.Length > 15)
            {
                label.Font = new Font("Lucida Console", 9, FontStyle.Regular);
            }
            else
            {
                DisplayBox.Font = new Font("Lucida Console", 14, FontStyle.Regular);
            }
        }
    }
}
