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
            calcu.NumA = DisplayBox.Text;
            calcu.swtch();
            DisplayBox.Text = calcu.NumA;
            calcu.NumA = DisplayBox.Text;
            label.Text = System.Convert.ToString(calcu.NumA) + " " + calcu.Operation;
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
            if (calcu.NumA != "0")
            {
                btnEquals.PerformClick();
                calcu.Operation = "+";
                calcu.IsOperationPressed = true;
            }
            else
            {
                calcu.Operation = "+";
                calcu.NumA = DisplayBox.Text;
                float value = float.Parse(DisplayBox.Text);
                DisplayBox.Text = value + " " + calcu.Operation;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (calcu.NumA != "0")
            {
                btnEquals.PerformClick();
                calcu.Operation = "-";
                calcu.IsOperationPressed = true;
            }
            else
            {
                calcu.Operation = "-";
                calcu.NumA = DisplayBox.Text;
                float value = float.Parse(DisplayBox.Text);
                DisplayBox.Text = value + " " + calcu.Operation;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (calcu.NumA != "0")
            {
                btnEquals.PerformClick();
                calcu.Operation = "*";
                calcu.IsOperationPressed = true;
            }
            else
            {
                calcu.Operation = "*";
                calcu.NumA = DisplayBox.Text;
                float value = float.Parse(DisplayBox.Text);
                DisplayBox.Text = value + " " + calcu.Operation;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (calcu.NumA != "0")
            {
                btnEquals.PerformClick();
                calcu.Operation = "/";
                calcu.IsOperationPressed = true;
            }
            else
            {
                calcu.Operation = "/";
                calcu.NumA = DisplayBox.Text;
                float value = float.Parse(DisplayBox.Text);
                DisplayBox.Text = value + " " + calcu.Operation;
            }
        }

        private void btnFrac_Click(object sender, EventArgs e)
        {
            if (calcu.NumA != "0")
            {
                btnEquals.PerformClick();
                calcu.Operation = "1/x";
                calcu.IsOperationPressed = true;
            }
            else
            {
                calcu.Operation = "1/x";
                calcu.NumA = DisplayBox.Text;
                float value = float.Parse(DisplayBox.Text);
                DisplayBox.Text = value + " " + calcu.Operation;
            }
        }

        private void btnSqrd_Click(object sender, EventArgs e)
        {
            if (calcu.NumA != "0")
            {
                btnEquals.PerformClick();
                calcu.Operation = "x^2";
                calcu.IsOperationPressed = true;
            }
            else
            {
                calcu.Operation = "x^2";
                calcu.NumA = DisplayBox.Text;
                float value = float.Parse(DisplayBox.Text);
                DisplayBox.Text = value + " " + calcu.Operation;
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (calcu.NumA != "0")
            {
                btnEquals.PerformClick();
                calcu.Operation = "sqrt";
                calcu.IsOperationPressed = true;
            }
            else
            {
                calcu.Operation = "sqrt";
                calcu.NumA = DisplayBox.Text;
                float value = float.Parse(DisplayBox.Text);
                DisplayBox.Text = value + " " + calcu.Operation;
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (calcu.NumA != "0")
            {
                btnEquals.PerformClick();
                calcu.Operation = "%";
                calcu.IsOperationPressed = true;
            }
            else
            {
                calcu.Operation = "%";
                calcu.NumA = DisplayBox.Text;
                float value = float.Parse(DisplayBox.Text);
                DisplayBox.Text = value + " " + calcu.Operation;
            }
        }

        //(Add-ons?)
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

        //Other Buttons
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
            //DisplayBox.Text = "0";
            float kyut = float.Parse(calcu.NumA);
            kyut = 0;
        }

        private void btnMplus_Click(object sender, EventArgs e)///
        {
            //Memory Add
            calcu.Mstore1 += calcu.Result;
            DisplayBox.Text = calcu.Mstore1.ToString();
        }

        private void btnMminus_Click(object sender, EventArgs e)///
        {
            //Memory minus
            calcu.Mstore1 -= calcu.Result;
            DisplayBox.Text = calcu.Mstore1.ToString();
        }

        private void btnMstore_Click(object sender, EventArgs e)
        {
            //Memory Store
            calcu.Mstore1 = Decimal.Parse(DisplayBox.Text);
            return;
        }

        private void btnMClear_Click(object sender, EventArgs e)
        {
            //Memory Clear
            calcu.Mstore1 = 0;
            return;
        }

        private void btnMRecall_Click(object sender, EventArgs e)
        {
            //Memory Recall
            DisplayBox.Text = calcu.Mstore1.ToString();
            return;
        }

        //Miscellaneous
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
