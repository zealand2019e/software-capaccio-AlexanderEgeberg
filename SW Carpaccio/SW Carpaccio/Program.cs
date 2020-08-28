using System;
using System.Security.Cryptography.X509Certificates;

namespace SW_Carpaccio
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalPrice = 0;

            void Calculate(int itemprice, string stateCode, int itemamount) {
               
                double itemprice_afterDiscount = 0;
                double itemprice_afterTax = 0;

                if (itemprice >= 50000)
                {
                    itemprice_afterDiscount = itemprice * 0.85;
                }
                else if (itemprice >= 10000)
                {
                    itemprice_afterDiscount = itemprice * 0.90;
                }
                else if (itemprice >= 7000)
                {
                    itemprice_afterDiscount = itemprice * 0.93;
                }
                else if (itemprice >= 5000)
                {
                    itemprice_afterDiscount = itemprice * 0.95;
                }
                else if (itemprice >= 1000)
                {
                    itemprice_afterDiscount = itemprice * 0.97;
                }
                else
                {
                    itemprice_afterDiscount = itemprice;
                }

                if (stateCode == "UT")
                {
                    itemprice_afterTax = itemprice_afterDiscount * 0.9315;
                }
                else if (stateCode =="NV")
                {
                    itemprice_afterTax = itemprice_afterDiscount * 0.92;
                }
                else if (stateCode == "TX")
                {
                    itemprice_afterTax = itemprice_afterDiscount * 0.9375;
                }
                else if (stateCode == "AL")
                {
                    itemprice_afterTax = itemprice_afterDiscount * 0.96;
                }
                else if (stateCode == "CA")
                {
                    itemprice_afterTax = itemprice_afterDiscount * 0.9175;
                }
                else
                {
                    itemprice_afterTax = itemprice_afterDiscount;
                }

                for (int i = 0; i < itemamount; i++)
                {
                    totalPrice = totalPrice + itemprice_afterTax;
                }


            }
            void Purchase(){
                Console.WriteLine("Please enter the amount of items you'd like to purchase");
                int itemCount = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the price of the item you purchased");
                int itemPrice = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your StateCode");
                string stateCode = Console.ReadLine();

                Calculate(itemPrice, stateCode, itemCount);
                Console.WriteLine($"Your current total comes to {totalPrice}");

                Console.WriteLine("Would you like to make another purchase?");
                string answer = Console.ReadLine();
                if ( answer.ToLower() == "yes")
                {
                    Purchase();
                }
            }
            Purchase();
            Console.WriteLine($"your total price is {totalPrice}" );



        }
    }
}
