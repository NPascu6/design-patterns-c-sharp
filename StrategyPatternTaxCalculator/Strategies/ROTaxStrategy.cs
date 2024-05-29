﻿namespace StrategyPatternTaxCalculator.Strategies
{
    internal class ROTaxStrategy : ITaxStrategy
    {
        public double CalculateTax(double amount)
        {
            return amount * 0.19;
        }
    }
}
