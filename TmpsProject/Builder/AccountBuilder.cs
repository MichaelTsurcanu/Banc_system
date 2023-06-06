using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmpsProject.Prototype;

namespace TmpsProject.Builder
{
    public class AccountBuilder
    {
        private string accountNumber;
        private string accountType;
        private double balance;

        public AccountBuilder SetAccountNumber(string accountNumber)
        {
            this.accountNumber = accountNumber;
            return this;
        }

        public AccountBuilder SetAccountType(string accountType)
        {
            this.accountType = accountType;
            return this;
        }

        public AccountBuilder SetBalance(double balance)
        {
            this.balance = balance;
            return this;
        }

        public Account Build()
        {
            return new Account(accountNumber, accountType, balance);
        }
    }
}
