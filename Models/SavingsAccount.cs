namespace BankSystem.Models;

public class SavingsAccount : Account
{
    public SavingsAccount(string ownerName, decimal balance) : base(ownerName, balance)
    {
    }

    public override void Withdraw(decimal amount)
    {
        if (Balance < amount)
            Console.WriteLine("Not enough balance.");
        else 
            Balance -= amount;
    }
}