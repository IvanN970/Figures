using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Figures
{
    public class Circle:Figure
    {
        public Circle(int a) : base(a) { }
        public override double CalculatePerimeter()
        {
            return Math.Round(2 * Math.PI * a, 2);
        }
        public override double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(a, 2), 2);
        }
    }
}
