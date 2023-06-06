using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmpsProject.Prototype;

namespace TmpsProject.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public List<AccountPrototype> Accounts { get; set; }

        public Customer(string name)
        {
            Name = name;
            Accounts = new List<AccountPrototype>();
        }

        public void AddAccount(AccountPrototype account)
        {
            Accounts.Add(account);
        }

        public void RemoveAccount(AccountPrototype account)
        {
            Accounts.Remove(account);
        }

        public void DisplayAccounts()
        {
            Console.WriteLine("Customer: " + Name);
            foreach (var account in Accounts)
            {
                Console.WriteLine("Account Number: " + account.GetAccountNumber());
                Console.WriteLine("Balance: " + account.GetBalance());
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
