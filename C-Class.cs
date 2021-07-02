using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Calculator
{
    class C_Class
    {
        // class for calculator which have the methods
        // turn private into public
        // encapsulate private variables

        private String operation = "";
        private Boolean isOperationPressed = false;
        private String num = "";
        private String numA = "";
        
        public string Num 
        { 
            get => num; 
            set => num = value; 
        }
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
 
        //methods for operations
        public void Add()
        {
            NumA = (float.Parse(Num) + float.Parse(NumA)).ToString();
        }

        public void Subtract()
        {
            NumA = (float.Parse(Num) - float.Parse(NumA)).ToString();
        }

        public void Multiply()
        {
            NumA = (float.Parse(Num) * float.Parse(NumA)).ToString();
        }

        public void Divide()
        {
            NumA = (float.Parse(Num) / float.Parse(NumA)).ToString();
        }

        public void Frac()
        {
            NumA = (1 / float.Parse(NumA)).ToString();
        }

        public void Sqrd()
        {
            NumA = (float.Parse(NumA) * float.Parse(NumA)).ToString();
        }

        public void Sqrt()
        {
            double numero = float.Parse(NumA);
            NumA = Math.Sqrt(numero).ToString();
        }

        public void Percent()
        {
            NumA = (float.Parse(NumA) / 100).ToString();
        }

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
    }
}
