namespace BankSystem.Models;

public class CreditAccount : Account
{
    public CreditAccount(string ownerName, decimal balance) : base(ownerName, balance)
    {
    }

    public override void Withdraw(decimal amount)
    {
        if (Balance < -5000)
            Console.WriteLine("Credit limit exceeded.");
        else
            Balance -= amount;
    }
}