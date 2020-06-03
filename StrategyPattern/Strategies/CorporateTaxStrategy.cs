using System;

namespace StrategyPattern.Strategy
{
    public class CorporateTaxStrategy : TaxStrategy
    {
        public override double calculateTax()
        {
            Console.WriteLine("Single Owner Tax 40%");
            return 0.4;
        }
    }
}
