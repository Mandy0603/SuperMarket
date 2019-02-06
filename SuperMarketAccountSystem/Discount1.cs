using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketAccountSystem
{
    class Discount1 : DiscountFather
    {
        public override double GetTotalMoney(double realMoney)
        {
            return realMoney;
        }
    }
}
