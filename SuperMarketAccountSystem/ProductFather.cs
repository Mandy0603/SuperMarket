using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketAccountSystem
{
    class ProductFather
    {
        public double Price
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string ID
        {
            get;
            set;
        }
        public ProductFather(string ID,double price,string Name)
        {
            this.ID = ID;
            this.Price = price;
            this.Name=Name;
        }
    }
}
