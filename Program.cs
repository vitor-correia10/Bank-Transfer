using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account(AccountType.Personal, 0, 0, "Vitor");

            Console.WriteLine(myAccount.ToString());
        }
    }
}
