using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmpsProject.Prototype;

namespace TmpsProject.Decorator
{
    public class OverdraftAccountDecorator : AccountDecorator
    {
        public OverdraftAccountDecorator(AccountPrototype account) : base(account) { }

        public override AccountPrototype Clone()
        {
            var clonedAccount = base.Clone();
            // Additional logic for overdraft account
            Console.WriteLine("Creating an overdraft account");
            return clonedAccount;
        }

        public override string GetAccountNumber()
        {
            return account.GetAccountNumber();
        }
    }
}
