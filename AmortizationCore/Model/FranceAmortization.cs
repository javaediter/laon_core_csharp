﻿using AmortizationCore.Enum;
using AmortizationCore.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmortizationCore.Model
{
    public class FranceAmortization : Amortization
    {
        public FranceAmortization(int Periods, double Mont, double RateInterest, bool Monthly)
        {
            this.Periods = Periods;
            this.Mont = Mont;
            this.RateInterest = RateInterest;
            TableAmortizationCalculus = AmortizationFactory<List<Fee>>.CreateAmortizationCalculus(CalculusType.FRENCH, Monthly);
        }
    }
}
