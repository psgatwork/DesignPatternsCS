using System;

namespace StrategyPattern.Strategy
{
    public class SingleOwnerTaxStrategy : TaxStrategy
    {
        public override double calculateTax()
        {
            Console.WriteLine("Single Owner Tax 10%");
            return 0.1;
        }
    }
}
