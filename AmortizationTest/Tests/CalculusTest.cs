using AmortizationCore.Model;
using Xunit;

namespace AmortizationTest.Tests
{
    public class CalculusTest
    {
        [Fact]
        public void Test_FrenchTableAmortizationByYear()
        {
            Amortization amortization = new FranceAmortization(3, 10000, 3, false);
            amortization.PerformanceTableAmortizationCalculus();
            double sum = amortization.Fees.Select(x => x.Interests).Sum();
            Assert.Equal(605.91, sum);
        }

        [Fact]
        public void Test_FrenchTableAmortizationByMonth()
        {            
            Amortization amortization = new FranceAmortization(24, 12528.28, 13.5, true);
            amortization.PerformanceTableAmortizationCalculus();
            double sum = Math.Round(amortization.Fees.Select(x => x.Interests).Sum(), 2);
            Assert.Equal(1837.24, sum);            
        }
    }
}
