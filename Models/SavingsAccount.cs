namespace BankSystem.Models;

public class SavingsAccount : Account
{
    public SavingsAccount(string ownerName, decimal balance) : base(ownerName, balance)
    {
    }

    public override decimal Withdraw(decimal amount)
    {
        Console.WriteLine($"You have sent a withdrawal request for ${amount}.");
        Console.Write("This is the answer to the request: ");

        if (Balance < amount)
            Console.WriteLine("Not enough balance.");
        else
        {
            Balance -= amount;
            Console.WriteLine("Successful.");
        }

        return Balance;
    }

    public override void ShowBalance()
    {
        Console.WriteLine($"You have ${Balance} in your savings account.");
    }
}