using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class SumCalculator
    {
        protected readonly int[] _numbers;

        public SumCalculator(int[] numbers)
        {
            _numbers = numbers;
        }

        public virtual int Calculate() => _numbers.Sum();
    }
}
