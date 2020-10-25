using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Figures
{
    public class Triangle:Figure
    {
        private int b;
        private int c;
        public Triangle()
        {
            b = 0;
            c = 0;
        }
        public Triangle(int a,int b,int c):base(a)
        {
            this.b = b;
            this.c = c;
        }
        public int B
        {
            set { b = value;}
            get { return b;}
        }
        public int C
        {
            set { c = value;}
            get { return c;}
        }
        public override double CalculatePerimeter()
        {
            return a + b + c;
        }
        public override double CalculateArea()
        {
            return (a * b) / 2;
        }
    }
}
