using BankSystem.Models;

namespace BankSystem;

public class Program
{
    public static void Main(string[] args)
    {
        Account regularAccount = new SavingsAccount("Muhammadrasul", 300);
        Account creditAccount = new CreditAccount("Akbarshoh", 500);

        Console.WriteLine($"{regularAccount.OwnerName} is the owner of this account.");
        regularAccount.ShowBalance();
        
        Console.Write("Enter how much money you want to deposit: ");
        decimal amountDepositRegular = decimal.Parse(Console.ReadLine());
        regularAccount.Deposit(amountDepositRegular);

        Console.Write("Enter how much money do you want to withdraw: ");
        decimal amountWithdrawRegular = decimal.Parse(Console.ReadLine());
        regularAccount.Withdraw(amountWithdrawRegular);

        Console.WriteLine();

        Console.WriteLine($"{creditAccount.OwnerName} is the owner of this account.");
        creditAccount.ShowBalance();

        Console.Write("Enter how much money you want to deposit: ");
        decimal amountDepositCredit = decimal.Parse(Console.ReadLine());
        creditAccount.Deposit(amountDepositCredit);
        
        Console.Write("Enter how much money do you want to get credit: ");
        decimal amountWithdrawCredit = decimal.Parse(Console.ReadLine());
        creditAccount.Withdraw(amountWithdrawCredit);
    }
}