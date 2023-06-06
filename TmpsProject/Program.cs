using TmpsProject.Adapter;
using TmpsProject.Builder;
using TmpsProject.Decorator;
using TmpsProject.Models;
using TmpsProject.Observer;
using TmpsProject.Strategy;

public class Program
{
    public static void Main(string[] args)
    {
        // Builder pattern
        var accountBuilder = new AccountBuilder();
        var account1 = accountBuilder.SetAccountNumber("123456")
                                    .SetAccountType("Savings")
                                    .SetBalance(1000)
                                    .Build();

        var account2 = accountBuilder.SetAccountNumber("987654")
                                    .SetAccountType("Checking")
                                    .SetBalance(5000)
                                    .Build();

        // Prototype pattern
        var clonedAccount = account1.Clone();

        // Decorator pattern
        var overdraftAccount = new OverdraftAccountDecorator(account1);
        var clonedOverdraftAccount = overdraftAccount.Clone();
        Console.WriteLine();
        // Adapter pattern
        var bankServiceAdapter = new BankServiceAdapter();
        bankServiceAdapter.ProcessAccount(clonedAccount);
        Console.WriteLine();
        // Observer pattern
        var accountObservable = new AccountObservable();
        var accountObserver = new AccountObserver();
        accountObservable.Attach(accountObserver);
        accountObservable.SetAccount(clonedAccount);
        Console.WriteLine();
        // Strategy pattern
        var interestStrategy = new SimpleInterestStrategy();
        var interestAmount = interestStrategy.CalculateInterest(clonedAccount.GetBalance());
        Console.WriteLine("Calculated interest amount: " + interestAmount);
        Console.WriteLine();
        // Banking system
        var customer = new Customer("John Doe");
        customer.AddAccount(account1);
        customer.AddAccount(account2);
        customer.DisplayAccounts();
    }
}
