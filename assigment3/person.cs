using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment3
{
    class person
    {

      
            string f_name, l_name, email;
            DateTime dob;
            int age;

            public person(string f_name, string l_name, string email, DateTime dob)
            {
                this.f_name = f_name;
                this.l_name = l_name;
                this.email = email;
                this.dob = dob;
            }


            public person(string f_name, string l_name, string email)
            {
                this.f_name = f_name;
                this.l_name = l_name;
                this.email = email;
                dob = DateTime.Now;
            }
            public person(string f_name, string l_name, DateTime dob)
            {
                this.f_name = f_name;
                this.l_name = l_name;
                this.dob = dob;

            }
            public void adult()
            {
                age = DateTime.Now.Year - dob.Year;
                if (DateTime.Now.DayOfYear < dob.DayOfYear)
                {
                    age = age - 1;

                }
                if (age >= 18)
                {
                    Console.WriteLine("the person is over 18");
                }
                else
                {
                    Console.WriteLine("the person is below 18");
                }
            }
            public void sunsign()

            {

                int month = dob.Month;

                int day = dob.Day;

                string txtZodiac = "";

                string str = string.Empty;

                if (((month == 3) && (day >= 21 || day <= 31)) || ((month == 4) && (day >= 01 || day <= 20)))

                {

                    txtZodiac = "Aires";

                }

                if (((month == 4) && (day >= 21 || day <= 31)) || ((month == 5) && (day >= 01 || day <= 21)))

                {

                    txtZodiac = "Taurus";

                }

                if (((month == 5) && (day >= 21 || day <= 31)) || ((month == 6) && (day >= 01 || day <= 21)))

                {

                    txtZodiac = "Gemini";

                }

                if (((month == 6) && (day >= 22 || day <= 31)) || ((month == 7) && (day >= 01 || day <= 22)))

                {

                    txtZodiac = "Cancer";

                }

                if (((month == 7) && (day >= 23 || day <= 31)) || ((month == 8) && (day >= 01 || day <= 22)))

                {

                    txtZodiac = "leo";

                }

                if (((month == 8) && (day >= 23 || day <= 31)) || ((month == 9) && (day >= 01 || day <= 21)))

                {

                    txtZodiac = "Virgo";

                }




                if (((month == 9) && (day >= 22 || day <= 30)) || ((month == 10) && (day >= 01 || day <= 22)))

                {

                    txtZodiac = "Libra";

                }

                if (((month == 10) && (day >= 23 || day <= 31)) || ((month == 11) && (day >= 01 || day <= 21)))

                {

                    txtZodiac = "Scorpio";

                }

                if (((month == 11) && (day >= 22 || day <= 30)) || ((month == 12) && (day >= 01 || day <= 21)))

                {

                    txtZodiac = "Sagittarius";

                }

                if (((month == 12) && (day >= 22 || day <= 31)) || ((month == 1) && (day >= 01 || day <= 20)))

                {

                    txtZodiac = "Capricorn";

                }

                if (((month == 1) && (day >= 21 || day <= 31)) || ((month == 2) && (day >= 01 || day <= 19)))

                {

                    txtZodiac = "Aquarius";

                }

                if (((month == 2) && (day >= 20 || day <= 29)) || ((month == 3) && (day >= 01 || day <= 20)))

                {

                    txtZodiac = "Pisces";

                }

                Console.WriteLine("sun sign" + txtZodiac);
            }
            public void birthday()
            {
                if (this.dob.DayOfYear == DateTime.Now.Year)
                {
                    Console.WriteLine("happy birthday");
                }

            }
        }
    }