using System;
using StrategyPattern.ContextHolder;
using StrategyPattern.Strategy;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------- Start -----------");

            Context context;

            context = new Context(new SingleOwnerTaxStrategy());
            context.ContextTaxCalculate();

            context = new Context(new MultipleOwnerTaxStrategy());
            context.ContextTaxCalculate();

            context = new Context(new CorporateTaxStrategy());
            context.ContextTaxCalculate();
        }
    }
}
