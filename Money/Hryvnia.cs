using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class Hryvnia : Money
    {
        public Hryvnia(double value) : base(value)
        {
            IndexGold = 77947.5886;
        }
    }
}
