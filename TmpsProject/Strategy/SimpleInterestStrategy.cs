using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmpsProject.Strategy
{
    public class SimpleInterestStrategy : IInterestStrategy
    {
        public double CalculateInterest(double balance)
        {
            return balance * 0.05; // 5% interest rate
        }
    }
}
