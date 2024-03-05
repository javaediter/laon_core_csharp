using AmortizationCore.Enum;
using AmortizationCore.Interfaces;
using AmortizationCore.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmortizationCore.Factory
{
    public class AmortizationFactory<T>
    {
        public static IAmortizationCalculus<T> CreateAmortizationCalculus(CalculusType Type, bool IsMonthly)
        {
            if (Type.Equals(CalculusType.FRENCH) && IsMonthly)
            {
                return (IAmortizationCalculus<T>)new FranceTableAmortizationByMonth();
            }
            else if (Type.Equals(CalculusType.FRENCH) && !IsMonthly)
            {
                return (IAmortizationCalculus<T>)new FranceTableAmortizationByYear();
            }
            else if (Type.Equals(CalculusType.FRENCH_MONT))
            {
                return (IAmortizationCalculus<T>)new FranceMontCalculus();
            }
            else if (Type.Equals(CalculusType.GERMAN) && IsMonthly)
            {
                return (IAmortizationCalculus<T>)new GermanTableAmortizationByMonth();
            }
            else if (Type.Equals(CalculusType.GERMAN) && !IsMonthly)
            {
                return (IAmortizationCalculus<T>)new GermanTableAmortizationByYear();
            }
            else
            {
                return (IAmortizationCalculus<T>)new GermanMontCalculus();
            }
        }
    }
}
