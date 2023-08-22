// See https://aka.ms/new-console-template for more information


namespace Bank_exersize
{ 
class Program
{
    static void Main()
    {
            // Create instances of BankAccount and perform transactions
            // Display account information before and after each transaction
            Bank a = new Bank("tamar", 1200);
            Bank b = new Bank("batya", 5);
            Bank c = new Bank("chaim", 100000);

            /*a.addfundstotheaccount(60);
            a.subtractfundsfromaccount(100000);
            a.printDetails();*/

          
            Bank.Acouns_List.Add(a);//addea a to the list
            Bank.Acouns_List.Add(c);
            Bank.Acouns_List.Add(b);



            Bank.Print_List();           //print the list of accounts
            Console.WriteLine("***************");

          //  a.addfundstotheaccount(700);

            //var sortedByBalance = Bank.Acouns_List.OrderBy(Bank => Bank.Balance);//.ThenBy(Bank => Bank.AccountHolderName);


            Bank.sort_list();//sorting the list by balance
            Bank.Print_List();           //print the list of accounts


            Console.ReadKey();


        }


        /*public static void Print_List(List<Bank> L)
        {
            foreach (Bank b in L)
                b.printDetails();
        }*/
    }
}