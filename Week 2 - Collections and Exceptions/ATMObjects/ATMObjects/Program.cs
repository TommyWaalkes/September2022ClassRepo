using ATMObjects;

public class Program
{
    public static void Main()
    {
        Account a = new Account("Tommy", "password123", 12);

        Console.WriteLine("Name: "+ a.Name);
        Console.WriteLine("Password: "+ a.Password);
        Console.WriteLine("Balanace: " + a.Balance);

        ATM atm = new ATM();
        atm.CheckBalance();
        atm.Deposit(1000);
        atm.Withdraw(1000);
        atm.Register("Polly", "birdsArentReal");
        atm.PrintAccounts();

        atm.Login("Polly", "birdsArentReal");
        Console.WriteLine(atm.CurrentAccount.Name);

        atm.Login("Not a FBI", "BirdsAreVeryReal");
        Console.WriteLine(atm.CurrentAccount.Name);

        atm.CheckBalance();
        atm.Deposit(1000);
        atm.Withdraw(10000);
        atm.Withdraw(1000);
    }
}