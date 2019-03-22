using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderDelivery
{
    class Program
    {
        static void Main()
        {
            //test function for pre-written code to return true or false based on whether an instacart shopper can take an order or not with time restrictions given by the user.

        }

        bool[] delivery(int[] order, int[][] shoppers)
        {
            bool[] results = new bool[shoppers.Length];

            int order_distance = order[0];
            int order_waitTime = order[1];
            int order_buffer = order[2];
            int index = 0;

            foreach (int[] shopper in shoppers)
            {
                double shopper_distance = shopper[0];
                double shopper_travelSpeed = shopper[1];
                double shopper_storeTime = shopper[2];
                double shopper_TimeNeed = (((shopper_distance + order_distance) / shopper_travelSpeed) + shopper_storeTime);


                if (shopper_TimeNeed == order_waitTime)
                {

                    results[index] = true;
                    //Console.WriteLine("Hello");
                    //return results;

                }
                if (shopper_TimeNeed > order_waitTime && shopper_TimeNeed <= (order_waitTime + order_buffer))
                {
                    results[index] = true;
                    //return results;
                }

                index++;

            }

            return results;
        }

    }
}
