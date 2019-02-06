using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketAccountSystem
{
    class SuperMarket
    {
        Warehouse wh = new Warehouse();
        /// <summary>
        /// create a supermarket, put some products on the shelves
        /// </summary>
        public SuperMarket()
        {
            wh.BuyPros("Acer", 1000);
            wh.BuyPros("SamSung", 1000);
            wh.BuyPros("SoySauce", 1000);
            wh.BuyPros("Banana", 1000);
        }

        public void ServeCus()
        {
            Console.WriteLine("Welcome to our supermarket, what would you like to buy?");
            Console.WriteLine("We have Acer, SamSung, SoySauce, and Banana");
            string strType = Console.ReadLine();
            Console.WriteLine("How much would you like to buy?");
            int count = Convert.ToInt32(Console.ReadLine());
            ProductFather[] pros=wh.SellPros(strType, count);
            double realMoney = GetMoney(pros);
            Console.WriteLine("Total amount is ${0}",realMoney);
            Console.WriteLine("Please choosee an discount method: 1--no discount 2--10% off 3--15% off 4--$50 off out of every $300 5--$100 off out of every $500");
            string input = Console.ReadLine();
            DiscountFather df = GetDis(input);
            double totalMoney=df.GetTotalMoney(realMoney);
            Console.WriteLine("Please pay ${0}",totalMoney);
            Console.WriteLine("This is your receipt");
            foreach (var item in pros)
            {
                Console.WriteLine("Item:"+item.Name+"\t"+"Unit Price:"+item.Price+"\t"+"\t"+"Item ID:" +item.ID);
            }
        }
      

        public DiscountFather GetDis(string input)
        {
            DiscountFather df = null;
            switch (input)
            {
                case "1":df = new Discount1();
                    break;
                case "2":df = new DiscountByRate(0.9);
                    break;
                case "3":
                    df = new DiscountByRate(0.85);
                    break;
                case "4":
                    df = new DiscountMN(300,50);
                    break;
                case "5":
                    df = new DiscountMN(500, 100);
                    break;

            }
            return df;
        }
        /// <summary>
        /// Calculate total amount
        /// </summary>
        /// <param name="pros"></param>
        /// <returns></returns>
        public double GetMoney(ProductFather[] pros)
        {
            double realMoney = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                realMoney += pros[i].Price;
            }
            return realMoney;
        }

        public void ShowPros()
        {
            wh.ShowPros();
        }
    }
}
