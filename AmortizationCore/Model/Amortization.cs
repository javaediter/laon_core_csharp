using AmortizationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmortizationCore.Model
{
    public class Amortization
    {
        public double Mont {  get; set; }
        public double RateInterest {  get; set; }
        public int Periods {  get; set; }
        public double Quote {  get; set; }
        public List<Fee> Fees { get; set; } = new List<Fee>();

        protected IAmortizationCalculus<List<Fee>> TableAmortizationCalculus;

        protected IAmortizationCalculus<double> MontAmortizationCalculus;

        public void PerformanceTableAmortizationCalculus()
        {
            Fees = TableAmortizationCalculus.Calculate(Periods, Mont, RateInterest);
        }

        public void PerformanceMontAmortizationCalculus()
        {
            Mont = MontAmortizationCalculus.Calculate(Periods, Quote, RateInterest);
        }
    }
}
