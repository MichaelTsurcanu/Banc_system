using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmpsProject.Prototype;

namespace TmpsProject.Observer
{
    public interface IObserver
    {
        void Update(AccountPrototype account);
    }
}
