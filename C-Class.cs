using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Calculator
{
    class C_Class
    {
        private String operation = "";
        private Boolean isOperationPressed = false;
        private Double num = 0;
        private String numA = "";

        private decimal Mstore = 0;
        private decimal result = 0;
        private string show;
        //public string Num 
       // { 
           // get => num; 
           // set => num = value; 
        //}
        public string Operation 
        { 
            get => operation; 
            set => operation = value; 
        }
        public bool IsOperationPressed 
        { 
            get => isOperationPressed; 
            set => isOperationPressed = value; 
        }
        public string NumA 
        { 
            get => numA; 
            set => numA = value; 
        }
        public decimal Mstore1 
        { 
            get => Mstore; 
            set => Mstore = value; 
        }
        public decimal Result 
        { 
            get => result; 
            set => result = value; 
        }
        public string Show 
        { 
            get => show; 
            set => show = value; 
        }
        public double Num { get => num; set => num = value; }

        //Sign & Decimal (Add-ons?)
        public void Sign()
        {
            if (NumA.Contains("-"))
            {
                NumA = NumA.Remove(0, 1);
            }
            else
            {
                NumA = "-" + NumA;
            }
        }

        public void Decimal()
        {
            if (!NumA.Contains("."))
            {
                NumA += ".";
            }
        }

        //MISCELLANEOUS
        public void Del()
        {
            if (NumA.Length > 0)
            {
                NumA = NumA.Remove(NumA.Length - 1, 1);
            }
        }

        //METHOD FOR OPERATIONS
        public void operations()
        {
            switch (Operation)
            {
                case "+":
                    NumA = (Num + double.Parse(NumA)).ToString();
                    Show = System.Convert.ToString(NumA) + " " + Operation;
                    break;
                case "-":
                    NumA = (Num - double.Parse(NumA)).ToString();
                    Show = System.Convert.ToString(NumA) + " " + Operation;
                    break;
                case "*":
                    NumA = (Num * double.Parse(NumA)).ToString();
                    Show = System.Convert.ToString(NumA) + " " + Operation;
                    break;
                case "/":
                    NumA = (Num / double.Parse(NumA)).ToString();
                    Show = System.Convert.ToString(NumA) + " " + Operation;
                    break;
                case "1/x":
                    NumA = (1 / double.Parse(NumA)).ToString();
                    Show = "1/" + System.Convert.ToString(Num);
                    break;
                case "x^2":
                    NumA = (double.Parse(NumA) * double.Parse(NumA)).ToString();
                    Show = "(" + System.Convert.ToString(Num) + ")^2";
                    break;
                case "sqrt":
                    double numero = double.Parse(NumA);
                    NumA = Math.Sqrt(numero).ToString();
                    Show = "sqrt(" + System.Convert.ToString(Num) + ")";
                    break;
                case "%":
                    NumA = (double.Parse(NumA) / 100).ToString();
                    Show = System.Convert.ToString(Num) + "/100";
                    break;
                default:
                    break;
            }
            Num = Double.Parse(NumA);
        }
    }
}
