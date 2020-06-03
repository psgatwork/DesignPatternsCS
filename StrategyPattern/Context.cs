using StrategyPattern.Strategy;

namespace StrategyPattern.ContextHolder
{
    public class Context
    {
        private TaxStrategy _taxStrategy; 

        public Context(TaxStrategy strategy)
        {
            this._taxStrategy = strategy;
        }

        public double ContextTaxCalculate()
        {
            return this._taxStrategy.calculateTax();
        }
    }
}
