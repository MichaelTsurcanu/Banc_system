using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmpsProject.Prototype;

namespace TmpsProject.Decorator
{
    public abstract class AccountDecorator : AccountPrototype
    {
        protected AccountPrototype account;

        public AccountDecorator(AccountPrototype account)
        {
            this.account = account;
        }

        public override AccountPrototype Clone()
        {
            return account.Clone();
        }

        public override double GetBalance()
        {
            return account.GetBalance();
        }
    }
}
