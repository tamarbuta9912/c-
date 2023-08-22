using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Bank_exersize
{
    internal class Bank
    {
        public static List<Bank> Acouns_List = new List<Bank>();//build a list of accounts

        private static int num_of_users=0;

        private readonly int AccountNumber;
        private string AccountHolderName;
        private double Balance;


        //public static List<Bank> Acouns_List = new List<Bank>();//build a list of accounts

        public Bank( string accountHolderName, double balance)
        {
            AccountNumber = num_of_users+1;
            AccountHolderName = accountHolderName;
            Balance = balance;
            num_of_users++;
        }

        public void addfundstotheaccount(double moneytoadd)
        {
            Balance += moneytoadd;
            Console.WriteLine("The new balance is:"+Balance);
        }
        public bool subtractfundsfromaccount(double moneytosubtract)
        {
            if (Balance > moneytosubtract)
            {
                Balance-=moneytosubtract;
                return true;
            }

            Console.WriteLine("There is not enough money");
            return false;
           
        }

        public void printDetails()
        {
            Console.WriteLine("AccountHolderName: " + this.AccountHolderName);
            Console.WriteLine("AccountNumber : " + this.AccountNumber);
            Console.WriteLine("Balance : " + this.Balance);
        }

        public static void Print_List()
        {
            foreach (Bank b in Acouns_List)
                b.printDetails();//for every account in the list print his details
        }

        public static void sort_list()
        {

            var sortedByBalance = Acouns_List.OrderBy(Bank => Bank.Balance);//.ThenBy(Bank => Bank.AccountHolderName);



            //Acouns_List = sort.OrderBy(Bank => Bank.Balance);
            //.ThenBy(Bank => Bank.AccountHolderName);

        }




    }
}
