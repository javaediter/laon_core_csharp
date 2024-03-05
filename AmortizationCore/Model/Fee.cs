using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmortizationCore.Model
{
    public class Fee
    {
        public int Period { get; set; }
        public double Capital { get; set; }
        public double Interests {  get; set; }
        public double Partial {  get; set; }  
        public double Total {  get; set; }
    }
}
