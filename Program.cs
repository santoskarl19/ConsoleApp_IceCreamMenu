using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_IceCream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IceCream iceCream = new IceCream();

            int[,] iceCreamSold = new int[3, 3];

            iceCreamSold = iceCream.GetIceCreamOrders(iceCreamSold);

            iceCream.DisplayOrders(iceCreamSold);

            Console.ReadKey();
        }

        
    }
}
