using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Figures
{
    public class Rectangle:Figure
    {
        private int b;
        public Rectangle()
        {
            b = 0;
        }
        public Rectangle(int a,int b):base(a)
        {
            this.b = b;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (a + b);
        }
        public override double CalculateArea()
        {
            return a * b;
        }
    }
}
