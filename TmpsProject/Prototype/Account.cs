using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmpsProject.Prototype
{
    public class Account : AccountPrototype
    {
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        private double balance;

        public Account(string accountNumber, string accountType, double balance)
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
            this.balance = balance;
        }

        public override AccountPrototype Clone()
        {
            return (AccountPrototype)this.MemberwiseClone();
        }

        public override double GetBalance()
        {
            return balance;
        }
        public override string GetAccountNumber()
        {
            return AccountNumber;
        }
    }
}
