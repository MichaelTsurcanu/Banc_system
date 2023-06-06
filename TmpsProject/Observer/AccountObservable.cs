using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmpsProject.Prototype;

namespace TmpsProject.Observer
{
    public class AccountObservable : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();
        private AccountPrototype account;

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(account);
            }
        }

        public void SetAccount(AccountPrototype account)
        {
            this.account = account;
            Notify();
        }
    }

}
