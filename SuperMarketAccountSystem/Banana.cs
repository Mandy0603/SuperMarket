using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketAccountSystem
{
    class Banana:ProductFather
    {
        public Banana(string ID, double price, string name) : base(ID, price, name)
        {

        }
    }
}
