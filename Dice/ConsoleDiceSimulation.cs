using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class ConsoleDiceSimulation
    {
        private readonly ConsoleQuickNumericWriter _cqw;
        private readonly Random _random;

        public ConsoleDiceSimulation()
        {
            _random = new();
            _cqw = new(1, 6, _random.Next(), _random.Next(), _random.Next());
        }

        public void Proceed()
        {

        }
    }
}
