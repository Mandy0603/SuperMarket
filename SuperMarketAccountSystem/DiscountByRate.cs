using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketAccountSystem
{
    class DiscountByRate : DiscountFather
    {
        public double Rate
        {
            get;
            set;
        }
        public DiscountByRate(double rate)
        {
            this.Rate = rate;
        }
        public override double GetTotalMoney(double realMoney)
        {

            return realMoney * this.Rate;

        }
    }
    
      
}
