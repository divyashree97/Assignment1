using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class account
    {
        private int acc_no;
        private string name, acc_type;
        private char trans_type;
        private static  double  balance;
        double amount;

     public    account( int acc_no, string name,string acc_type)
        {
            this.acc_no = acc_no;
            this.name = name;
            this.acc_type = acc_type;
                }
        public void transcation(char ch,double amount)
        {
            if(ch=='d')
            {
                balance = balance + amount;

            }
            if (ch=='w')
            {
                balance = balance - amount;
            }
        }
        public void ShowData()
        {
            Console.WriteLine("account no.:" + acc_no + "\nName :" + name + "\nAccount_type" + acc_type + "\n Balance" + balance);
        }
    }
}
