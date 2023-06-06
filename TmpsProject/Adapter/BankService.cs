using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmpsProject.Prototype;

namespace TmpsProject.Adapter
{
    public class BankService
    {
        public void ProcessAccount(AccountPrototype account)
        {
            Console.WriteLine("Processing account: " + account.GetBalance());
        }
    }
}
