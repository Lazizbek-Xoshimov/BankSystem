namespace BankSystem.Models;

public abstract class Account
{
    public string OwnerName { get; set; }
    public decimal Balance { get; set; }
    
    public Account(string ownerName, decimal balance)
    {
        this.OwnerName = ownerName;
        this.Balance = balance;
    }

    public abstract void Withdraw(decimal amount);

    public decimal Deposit(decimal amount)
    {
        this.Balance += amount;

        return this.Balance;
    }
    
    public virtual void ShowBalance()
    {
        Console.WriteLine($"Your balance: {this.Balance}");
    }
}