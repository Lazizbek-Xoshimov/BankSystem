namespace BankSystem.Models;

public abstract class Account
{
    public string OwnerName { get; }
    protected decimal Balance { get; set; }
    
    public Account(string ownerName, decimal balance)
    {
        this.OwnerName = ownerName;
        this.Balance = balance;
    }

    public abstract decimal Withdraw(decimal amount);

    public decimal Deposit(decimal amount)
    {
        this.Balance += amount;

        return this.Balance;
    }

    public virtual void ShowBalance()
    {
        Console.WriteLine($"You have ${this.Balance} in your balance.");
    }
}