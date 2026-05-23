namespace BankSystem.Models;

public abstract class Account
{
    public string OwnerName { get; set; }
    public decimal Balance { get; set; }

    public Account()
    {
    }
    
    public Account(string ownerName, decimal balance)
    {
        this.OwnerName = ownerName;
        this.Balance = balance;
    }
}