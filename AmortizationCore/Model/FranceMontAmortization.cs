using AmortizationCore.Enum;
using AmortizationCore.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmortizationCore.Model
{
    public class FranceMontAmortization : Amortization
    {
        public FranceMontAmortization(int Periods, double Quote, double RateInterest)
        {
            this.Periods = Periods;
            this.Quote = Quote;
            this.RateInterest = RateInterest;
            MontAmortizationCalculus = AmortizationFactory<double>.CreateAmortizationCalculus(CalculusType.FRENCH_MONT, false);
        }
    }
}
