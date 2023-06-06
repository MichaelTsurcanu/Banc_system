using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmpsProject.Strategy
{
    public class CompoundInterestStrategy : IInterestStrategy
    {
        public double CalculateInterest(double balance)
        {
            return balance * 0.1; // 10% interest rate
        }
    }
}
