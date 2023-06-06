using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmpsProject.Strategy
{
    public interface IInterestStrategy
    {
        double CalculateInterest(double balance);
    }
}
