using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMObjects
{
    public class ATM
    {
        //For this lab the null account means no one is logged in 
        //And we can do null checks to look for that
        public Account CurrentAccount { get; set; } = null;

        //I like initializing properties up top since there will come when we have multiple constructors 
        //Initializing it here means we don't have to remember to do it in each contructor 
        //C# and JS will both allow you to do this. 
        public List<Account> Accounts { get; set; } = new List<Account>();

        public ATM()
        {
            Accounts.Add(new Account("Jimmy", "ilikemoney10", 90000));
            Accounts.Add(new Account("Frank", "green42", 4000));
            Accounts.Add(new Account("Sarah", "wolfie122", 1000000000));
        }

        public void Register(string Name, string Password)
        {
            Account a = new Account(Name, Password, 0);

            Accounts.Add(a);
        }

        public void Login(string Name, string Password)
        {
            if (CurrentAccount == null)
            {
                //we need to search so that generally means either use Linq or a loop
                //Let's assume each username/password combo is unique
                Account match = Accounts.Where(a => a.Name == Name && a.Password == Password).FirstOrDefault();
                CurrentAccount = match;
            }
            else
            {
                Console.WriteLine("Another user is currently logged in");
            }
        }

        public void Logout()
        {
            bool logged = IsLoggedIn();

            if (logged==true)
            {
                CurrentAccount = null;
            }
        }

        public void CheckBalance()
        {
            bool logged = IsLoggedIn(); 
            if(logged == true)
            {
                Console.WriteLine($"{CurrentAccount.Name}'s balance is {CurrentAccount.Balance}");
            }
            else
            {
                Console.WriteLine("No balance to show, no one is currently logged in");
            }
        }

        public void Deposit(int amount)
        {
            bool logged = IsLoggedIn();
            if(logged == true)
            {
                CurrentAccount.Balance += amount;
                Console.WriteLine($"{amount} added to {CurrentAccount.Name}'s account");
            }
            else
            {
                Console.WriteLine("Money not added, no one is logged in");
            }
        }

        public void Withdraw(int amount)
        {
            bool logged = IsLoggedIn();
            if (logged == true)
            {
                if(CurrentAccount.Balance >= amount)
                {
                    CurrentAccount.Balance -= amount;
                }
                else
                {
                    Console.WriteLine($"{CurrentAccount.Name}'s balance is too low at {CurrentAccount.Balance}");
                }
            }
        }

        public bool IsLoggedIn()
        {
            if(CurrentAccount == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void PrintAccounts()
        {
            foreach(Account a in Accounts)
            {
                Console.WriteLine(a.Name);
            }
        }

    }
}
