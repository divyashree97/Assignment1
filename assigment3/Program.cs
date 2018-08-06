using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment3
{
    class Program
    {
        static void Main(string[] args)
        {

            string f_name, l_name, email;
            DateTime dob;
            Console.WriteLine("enter the first and last name ,dob");
            f_name = Console.ReadLine();
            l_name = Console.ReadLine();
            email = Console.ReadLine();
            dob = DateTime.Parse(Console.ReadLine());
            person p = new person(f_name, l_name, email, dob);
            p.adult();
            p.sunsign();
            p.birthday();
            person p2 = new person(f_name, l_name, email);
            p2.adult();
            p2.sunsign();
            p2.birthday();
            person p3 = new person(f_name, l_name, dob);
            p3.adult();
            p3.sunsign();
            p3.birthday();

        }
    }
}
