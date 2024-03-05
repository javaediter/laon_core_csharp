using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmortizationCore.Interfaces
{
    public interface IAmortizationCalculus<T>
    {
        public T Calculate(int n, double v, double i);
    }
}
