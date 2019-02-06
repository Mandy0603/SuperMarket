using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketAccountSystem
{
    class Warehouse
    {
        List<List<ProductFather>> list = new List<List<ProductFather>>();

        /// <summary>
        /// show products
        /// </summary>
        public void ShowPros()
        {
            foreach (var item in list)
            {
                Console.WriteLine("We have "+item.Count+" "+item[0].Name+" in the supermarket, the unit price for each of them is $"+item[0].Price+".");
            }
        }
        //How to store the products:
        //list[0]:Acer
        //list[1]:SamSung
        //list[2]:SoySauce
        //list[3]:Banana


        /// <summary>
        /// create a warehouse
        /// </summary>
        public Warehouse()
        {
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }
        /// <summary>
        /// Procurement
        /// </summary>
        /// <param name="strType">Product Type</param>
        /// <param name="count">Product amount</param>
        public void BuyPros(string strType, int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        list[0].Add(new Acer(Guid.NewGuid().ToString(), 1000, "Acer laptop"));
                        break;
                    case "SamSung":
                        list[1].Add(new SamSung(Guid.NewGuid().ToString(), 2000, "SamSung phones"));
                        break;
                    case "SoySauce":
                        list[2].Add(new Acer(Guid.NewGuid().ToString(), 10, "Soy sauce"));
                        break;
                    case "Banana":
                        list[3].Add(new Acer(Guid.NewGuid().ToString(), 50, "Banana"));
                        break;

                }
            }
        }
        /// <summary>
        /// Fetch goods from the warehouse
        /// </summary>
        /// <param name="strType">product type</param>
        /// <param name="count">product amount</param>
        /// <returns></returns>
        public ProductFather[] SellPros(string strType, int count)
        {
            ProductFather[] pros = new ProductFather[count];
            for (int i = 0; i < pros.Length; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        if (list[0].Count == 0)
                        {
                            Console.WriteLine("There are no more Acer laptops in the warehouse");
                        }
                        else
                        {
                            pros[i] = list[0][0];
                            list[0].RemoveAt(0);
                        }

                        break;
                    case "SamSung":
                        if (list[1].Count == 0)
                        {
                            Console.WriteLine("There are no more Samsung phones in the warehouse");
                        }
                        else
                        {
                            pros[i] = list[1][0];
                            list[1].RemoveAt(0);
                        }

                        break;
                    case "SoySauce":
                        if (list[2].Count == 0)
                        {
                            Console.WriteLine("There are no more soy sauce in the warehouse");
                        }
                        else
                        {
                            pros[i] = list[2][0];
                            list[2].RemoveAt(0);
                        }
                        break;
                    case "Banana":
                        if (list[3].Count == 0)
                        {
                            Console.WriteLine("There are no more bananas in the warehouse");
                        }
                        else
                        {
                            pros[i] = list[3][0];
                            list[3].RemoveAt(0);
                        }
                        break;
                }
                
            }
            return pros;
        }
    }
}
