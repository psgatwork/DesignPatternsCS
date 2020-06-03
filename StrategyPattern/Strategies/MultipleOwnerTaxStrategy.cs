using System;

namespace StrategyPattern.Strategy
{
    public class MultipleOwnerTaxStrategy : TaxStrategy
    {
        public override double calculateTax()
        {
            Console.WriteLine("Single Owner Tax 20%");
            return 0.2;
        }
    }
}
