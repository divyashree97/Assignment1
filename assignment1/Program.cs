using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {

        static void Main(string[] args)
        {
            int no;
            string name, type;
            char ch;
            double amt;
            int count;

            Console.WriteLine("enter the account no:");
            no = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the name ");
            name = Console.ReadLine();
            Console.WriteLine("enter the account type");
            type = Console.ReadLine();
            do
            {
                Console.WriteLine("enter the transcation type");
                ch = char.Parse(Console.ReadLine());
                Console.WriteLine("enter the amount");
                amt = double.Parse(Console.ReadLine());

                account a1 = new account(no, name, type);
                a1.transcation(ch, amt);
                a1.ShowData();
                Console.WriteLine(" to continue the transcation please press 1");
                count = int.Parse(Console.ReadLine());
            } while (count == 1);
        }
    }
}

        






