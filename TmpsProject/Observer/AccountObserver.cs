using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmpsProject.Prototype;

namespace TmpsProject.Observer
{
    public class AccountObserver : IObserver
    {
        public void Update(AccountPrototype account)
        {
            Console.WriteLine("Account balance updated: " + account.GetBalance());
        }
    }

}
