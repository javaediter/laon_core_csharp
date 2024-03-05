using AmortizationCore.Interfaces;
using AmortizationCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmortizationCore.Strategy
{
    public class FranceTableAmortizationByYear : IAmortizationTableCalculus
    {
        public List<Fee> Calculate(int n, double v, double i)
        {
            List<Fee> fees = new List<Fee>();

            double balance = v;
            double rate = i / 100;
            double quote = GetQuote(n, rate, balance);

            for (int k = 0; k < n; k++)
            {
                double interests = balance * rate;
                double partial = quote - interests;
                fees.Add(new Fee
                {
                    Period = k + 1,
                    Capital = Math.Round(balance, 2),
                    Interests = Math.Round(interests, 2),
                    Partial = Math.Round(partial, 2),
                    Total = Math.Round(quote, 2)
                });

                balance -= partial;
            }

            return fees;
        }

        private static double GetQuote(double N, double Rate, double Balance)
        {
            double a = 1 + Rate;
            double b = Math.Pow(a, N);
            double c = 1 / b;
            double d = 1 - c;
            double e = Rate / d;
            return Balance * e;
        }
    }
}
