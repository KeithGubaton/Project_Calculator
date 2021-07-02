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
        //encapsulate private variables

        private String operation = "";
        private Boolean isOperationPressed = false;
        private String num = "";
        private String numA = "";
        private float a;
        private float b;
        private string sqr = "";
        private Double dobol;
        private string result = "";

        
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
        public double Dobol 
        { 
            get => dobol; 
            set => dobol = value; 
        }
        public float B { get => b; set => b = value; }
        public float A { get => a; set => a = value; }
        public string Sqr { get => sqr; set => sqr = value; }
        public string Result { get => result; set => result = value; }

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
            double y = float.Parse(NumA);
            NumA = Math.Sqrt(y).ToString();
        }
    }

}
