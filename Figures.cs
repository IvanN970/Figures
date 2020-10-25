using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Figures
{
    class Program
    {
        static void Main()
        {
            Figure triangle = new Triangle(10, 20, 30);
            Figure rectangle = new Rectangle(5, 10);
            Figure circle = new Circle(5);
            PrintFigureInfo(triangle);
            PrintFigureInfo(rectangle);
            PrintFigureInfo(circle);
        }
        static void PrintFigureInfo(Figure figure)
        {
            Console.WriteLine("{0} perimeter is:{1}", figure.GetType().Name, figure.CalculatePerimeter());
            Console.WriteLine("{0} area is:{1}", figure.GetType().Name, figure.CalculateArea());
        }
    }
}
