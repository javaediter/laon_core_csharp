using AmortizationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmortizationCore.Strategy
{
    public class FranceMontCalculus : IAmortizationMontCalculus
    {
        public double Calculate(int n, double v, double i)
        {
            double rate = i / 1200;
            double a = 1 + rate;
            double b = Math.Pow(a, n);
            double c = 1 / b;
            return ((1 - c) * v) / rate;
        }
    }
}
