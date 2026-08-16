using System;

class BankAccount
{
    // Data members
    private string accountNumber;
    private string holderName;
    private double balance;

    // Constructor
    public BankAccount(string accountNumber, string holderName, double balance)
    {
        this.accountNumber = accountNumber;
        this.holderName = holderName;
        this.balance = balance;
    }

    // Deposit method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance = balance + amount;
            Console.WriteLine("Amount deposited: " + amount);
        }
        else
        {
            Console.WriteLine("Invalid amount.");
        }
    }

    // Withdraw method
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance = balance - amount;
            Console.WriteLine("Amount withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount.");
        }
    }

    // Display account details
    public void DisplayAccountDetails()
    {
        Console.WriteLine("\n--- Account Details ---");
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Holder Name: " + holderName);
        Console.WriteLine("Balance: " + balance);
    }
}

class Program
{
    static void Main()
    {
        // Creating BankAccount object
        BankAccount account = new BankAccount(
            "123456789",
            "Adarsh",
            10000
        );

        // Display initial details
        account.DisplayAccountDetails();

        // Deposit
        account.Deposit(7000);

        // Withdraw
        account.Withdraw(8000);

        // Display updated details
        account.DisplayAccountDetails();
    }
}