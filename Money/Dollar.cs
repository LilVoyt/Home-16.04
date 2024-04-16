using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class Dollar : Money
    {
        public Dollar(double value) : base(value)
        {
            IndexGold = 2074.3;
        }
    }
}
