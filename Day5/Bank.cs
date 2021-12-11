using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    
    public delegate void LowBalDelegate();
    public delegate void WithdrawDelegate();
    public delegate void ZeroBalDelegate();
    
    class Bank
    {
        public event LowBalDelegate lowBalDelegate;
        public event ZeroBalDelegate zeroBalDelegate;
        public event WithdrawDelegate withdrawDelegate;
        

        double current_bal;
        public Bank(double crntbal)
        {
             current_bal = crntbal;
        }
        public string Check_Bal()
        {

            if(current_bal==0)
            {
                zeroBalDelegate(); 
            }
            return "your balance is :"+current_bal;
        }
        public void zeroBalDelegate_Method()
        {
            Console.WriteLine("your bal is zero");
        }


        public  string  AcceptWithdrawAmnt(double amount)
        {
            if (amount > current_bal)
            {
                withdrawDelegate();
            }
            current_bal = current_bal - amount;
            return "Withdraw amount is:" + amount + " and current bal is :" + current_bal;
        }
        public void Cant_Withdraw()
        {
            Console.WriteLine("cant withdraw as your bal is not sufficient"); ;
        }

        public void LowBal()
        {
            if(current_bal<3000)
            {
                lowBalDelegate();
            }
            else
            {
                Console.WriteLine("your available balance is"+current_bal);
            }

        }
        public void Low_Bal()
        {
            Console.WriteLine("your bal is less than 3000");
        }

        


    }
}
