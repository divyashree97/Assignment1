using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class shapes
    {
        double area;
        public void displayarea(double a)
        {
            area = 3.14 * a * a;
            Console.WriteLine("area:" + area);
        }
        public void displayarea(double a, double b)
        {
            area = a * b;
            Console.WriteLine("area:" + area);
        }
        public void displayarea(double h, double b, double half)
        {
            area = half * b * h;
            Console.WriteLine("area:" + area);
        }
    }
}
