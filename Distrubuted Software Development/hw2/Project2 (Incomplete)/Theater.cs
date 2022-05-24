using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project2
{
    public delegate void priceCutEvent();
    class Theater
    {
        static Random num = new Random(); // To generate random numbers
        public static event priceCutEvent priceCut; // Link event to delegate
        public static bool threadIsRunning = true;


        private int t = 0;
        private static int ticketPrice = 0; //initial price
     
        public int getPrice() { return ticketPrice; }

        public int pricingModel() {
            int cost = num.Next(40, 200);
            return cost;
        }

        public static void changePrice(int cost)
        {

        }

        public void theaterFunction()
        {
            while (t < 20) // after 20 price cuts theater thread terminates
            {
                Thread.Sleep(num.Next(1000, 2000));
                int price = pricingModel();
                changePrice(price); //changes the price
            }
            threadIsRunning = false; 
        }
    }
}
