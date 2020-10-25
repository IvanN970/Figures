using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Figures
{
    public abstract class Figure
    {
        protected int a;
        public Figure()
        {
            a = 0;
        }
        public Figure(int a)
        {
            this.a = a;
        }
        public int A
        {
            set {a = value;}
            get {return a;}
        }
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
            
    }
}
