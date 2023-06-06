using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmpsProject.Prototype
{
    public abstract class AccountPrototype
    {
        public abstract AccountPrototype Clone();
        public abstract double GetBalance();
        public abstract string GetAccountNumber();
    }
}
