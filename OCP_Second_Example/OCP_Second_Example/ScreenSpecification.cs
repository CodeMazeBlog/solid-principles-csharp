using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Second_Example
{
    public class ScreenSpecification : ISpecification<ComputerMonitor>
    {
        private readonly Screen _screen;

        public ScreenSpecification(Screen screen)
        {
            _screen = screen;
        }

        public bool isSatisfied(ComputerMonitor item) => item.Screen == _screen;
    }
}
