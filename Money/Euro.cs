using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class Euro : Money
    {
        public Euro(double value) : base(value)
        {
            IndexGold = 1873.4697; 
        }
    }
}
