using System;

public class Account
{
    private string name;
    private double balance;

    public Account(string name, double initialBalance)
    {
        this.name = name;
        this.balance = initialBalance < 0 ? 0 : initialBalance;
    }

    public string Name
    {
        get { return name; }
    }

    public double Balance
    {
        get { return balance; }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public void Withdrawal(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient funds for withdrawal.");
        }
        else
        {
            Console.WriteLine("Withdrawal amount must be positive.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Account heikkisAccount = new Account("Heikki's account", 100.00);
        Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);

        heikkisAccount.Withdrawal(20);
        Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.Balance);

        heikkisSwissAccount.Deposit(200);
        Console.WriteLine("The balance of Heikki's other account is now: " + heikkisSwissAccount.Balance);
    }
}
