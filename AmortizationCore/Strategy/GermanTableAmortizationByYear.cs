using AmortizationCore.Interfaces;
using AmortizationCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmortizationCore.Strategy
{
    public class GermanTableAmortizationByYear : IAmortizationTableCalculus
    {
        public List<Fee> Calculate(int n, double v, double i)
        {
            throw new NotImplementedException();
        }
    }
}
