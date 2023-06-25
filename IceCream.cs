using System;

namespace Assignment_IceCream
{
    public class IceCream
    {
        // get number of orders from user and store in 2D Array
        public int[,] GetIceCreamOrders(int[,] iceCreamArray)
        {
            for (int i = 0; i < iceCreamArray.GetLength(0); i++)
            {
                switch (i + 1)
                {

                    case 1:
                        Console.WriteLine("[Chocolate Flavor]");
                        break;
                    case 2:
                        Console.WriteLine("[Vanilla Flavor]");
                        break;
                    case 3:
                        Console.WriteLine("[Strawberry Flavor]");
                        break;
                    default:
                        break;
                }

                for (int j = 0; j < iceCreamArray.GetLength(1); j++)
                {
                    switch (j + 1)
                    {
                        case 1:
                            Console.Write("Total small scoops sold: ");
                            iceCreamArray[i, j] = Int32.Parse(Console.ReadLine());
                            break;
                        case 2:
                            Console.Write("Total medium scoops sold: ");
                            iceCreamArray[i, j] = Int32.Parse(Console.ReadLine());
                            break;
                        case 3:
                            Console.Write("Total large scoops sold: ");
                            iceCreamArray[i, j] = Int32.Parse(Console.ReadLine());
                            break;
                        default:
                            break;

                    }
                }

                Console.WriteLine();
            }

            return iceCreamArray;
        }

        // display data from 2D array
        public void DisplayOrders(int[,] iceCreamArray)
        {
            PrintLineBreak();

            Console.WriteLine("\t\t --ICE CREAM ORDERS--");
            Console.WriteLine();
            Console.WriteLine("\t\t SMALL \t MEDIUM  LARGE");

            for (int i = 0; i < iceCreamArray.GetLength(0); i++)
            {
                switch (i + 1)
                {

                    case 1:
                        Console.Write("[Chocolate]");
                        break;
                    case 2:
                        Console.Write("[Vanilla]");
                        break;
                    case 3:
                        Console.Write("[Strawberry]");
                        break;
                    default:
                        break;
                }

                for (int j = 0; j < iceCreamArray.GetLength(1); j++)
                {
                    Console.Write($"\t {iceCreamArray[i, j]}");

                }
                Console.WriteLine();
            }

            Console.WriteLine();
            PrintLineBreak();
        }
        
        // line break
        static void PrintLineBreak()
        {
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
