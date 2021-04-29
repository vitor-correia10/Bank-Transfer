using System;

namespace DIO.Bank
{
    public class Account
    {
        private AccountType AccountType { get; set; }
        private double Balance { get; set; }
        private double Credit { get; set; }
        private string Name { get; set; }

        public Account(AccountType accountType, double balance, double credit, string name)
        {
            this.AccountType = accountType;
            this.Balance = balance;
            this.Credit = credit;
            this.Name = name;
        }

        public bool Withdraw(double withdrawValue)
        {
            if (this.Balance - withdrawValue < (this.Credit * -1)){
                Console.WriteLine("Insufficient funds ");
                return false;
            }

            this.Balance -= withdrawValue;

            // 0 -> this.Name
            // 1 -> this.Balance
            Console.WriteLine("Current balance {0} is {1}", this.Name, this.Balance);
            
            return true;
        }

        public void Deposit (double depositValue)
        {
            this.Balance += depositValue;

            Console.WriteLine("Current balance {0} is {1}", this.Name, this.Balance);
        }

        public void Transfer (double transferValue, Account destinationAccount)
        {
            if(this.Withdraw(transferValue))
            {
                destinationAccount.Deposit(transferValue);
            }
        }

        public override string ToString()
        {
            string accountData = "";
            accountData += "Account Type " + this.AccountType + " | ";
            accountData += "Name " + this.Name + " | ";
            accountData += "Balance " + this.Balance + " | ";
            accountData += "Credit " + this.Credit + " | ";
            return accountData;
        }
    }
}