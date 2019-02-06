using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketAccountSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMarket sm = new SuperMarket();
            sm.ShowPros();
            sm.ServeCus();
            Console.ReadKey();

        }
    }
}
