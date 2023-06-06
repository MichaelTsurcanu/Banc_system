using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmpsProject.Prototype;

namespace TmpsProject.Adapter
{
    public class BankServiceAdapter : IBankServiceAdapter
    {
        private readonly BankService bankService;

        public BankServiceAdapter()
        {
            bankService = new BankService();
        }

        public void ProcessAccount(AccountPrototype account)
        {
            bankService.ProcessAccount(account);
        }
    }
}
