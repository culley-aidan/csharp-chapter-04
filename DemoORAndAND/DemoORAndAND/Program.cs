using System;

namespace DemoORAndAND
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ZONE1 = 1, ZONE2 = 2;
            const int LOW_QUANTITY = 10;
            string inputString;
            int quantity;
            int deliveryZone;

            Console.WriteLine("Delivery is free for zone {0} or {1}", ZONE1, ZONE2);
            Console.WriteLine("when the number of boxes is less than {0}", LOW_QUANTITY);
            Console.WriteLine("Enter delivery zone: ");
            inputString = Console.ReadLine();
            deliveryZone = Convert.ToInt32(inputString);
            Console.WriteLine("Enter the number of boxes in the shipment");
            inputString = Console.ReadLine();
            quantity = Convert.ToInt32(inputString);
            if ((deliveryZone == ZONE1 || deliveryZone == ZONE2) && quantity < LOW_QUANTITY) {
                Console.WriteLine("Delivery is free");
            } else {
                Console.WriteLine("A delivery charge applies");
            }
        }
    }
}
