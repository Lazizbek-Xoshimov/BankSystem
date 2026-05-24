namespace BankSystem.Models;

public class CreditAccount : Account
{
    public CreditAccount(string ownerName, decimal balance) : base(ownerName, balance)
    {
    }

    public override decimal Withdraw(decimal amount)
    {
        Console.WriteLine($"You have sent a withdrawal request for ${amount}.");
        Console.Write("This is the answer to the request: ");
        if (Balance - amount < -5000)
            Console.WriteLine("Credit limit exceeded.");
        else
        {
            Balance -= amount;
            Console.WriteLine("Successful.");
            Console.WriteLine(Balance < 0 ? $"You can get ${5000 + Balance} credit again."
                : $"You can get ${5000} credit.");
        }

        return Balance;
    }

    public override void ShowBalance()
    {
        Console.WriteLine($"You have ${Balance} in your credit account.");
    }
}