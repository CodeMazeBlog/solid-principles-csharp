using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class SumCalculator : Calculator
    {
        public SumCalculator(int[] numbers)
            :base(numbers)
        {
        }

        public override int Calculate() => _numbers.Sum();
    }
}
