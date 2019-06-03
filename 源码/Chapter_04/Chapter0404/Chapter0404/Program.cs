using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter0404
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankAccount venusAccount = new SaverAccount();
            IBankAccount jupiterAccount = new GoldAccount();
            venusAccount.PayIn(200);
            jupiterAccount.PayIn(500);
            Console.WriteLine(venusAccount.ToString());
            jupiterAccount.PayIn(400);
            jupiterAccount.Withdraw(500);
            jupiterAccount.Withdraw(100);
            Console.WriteLine(jupiterAccount.ToString());
            Console.ReadKey();
        }
    }
    //定义账户类SaverAccount
    class SaverAccount : IBankAccount
    {
        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
        }
        public void PayIn(decimal amount)
        {
            balance += amount;
        }
        public bool Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            Console.WriteLine("Withdraw failed.");
            return false;
        }
        public override string ToString()
        {
            return String.Format("Venus Bank Saver:Balance={0,6:C}", balance);
        }
    }
    //定义账户类GoldAccount 
    class GoldAccount : IBankAccount
    {
        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
        }
        public void PayIn(decimal amount)
        {
            balance += amount;
        }
        public bool Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            Console.WriteLine("Withdraw failed.");
            return false;
        }
        public override string ToString()
        {
            return String.Format("Jupiter Bank Saver:Balance={0,6:C}", balance);
        }
    }

}
