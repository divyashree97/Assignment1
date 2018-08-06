using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            double a, b, c;
            shapes s = new shapes();

            Console.WriteLine("a.square:\nb.recatangle:\nc.triangle:\n d.circle:");
            ch = char.Parse(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                    {
                        Console.WriteLine("enter the side value");
                        a = double.Parse(Console.ReadLine());
                        s.displayarea(a, a);
                        break;
                    }
                case 'b':
                    {
                        Console.WriteLine("enter the height and breadth");
                        a = double.Parse(Console.ReadLine());
                        b = double.Parse(Console.ReadLine());
                        s.displayarea(a, b);
                        break;
                    }
                case 'c':
                    {
                        Console.WriteLine("enter the value");
                        a = double.Parse(Console.ReadLine());
                        b = double.Parse(Console.ReadLine());
                        c = 0.5;
                        s.displayarea(a, b, c);
                        break;
                    }
                case 'd':
                    {
                        Console.WriteLine("enter the  value");
                        a = double.Parse(Console.ReadLine());
                        s.displayarea(a);
                        break;
                    }

            }
        }
    }
}
