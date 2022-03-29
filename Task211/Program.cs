using System;

namespace Task211
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 dene 5 reqemli eded verilib. Her I ededin ustune III ededi gel . II ededin usutune IV ededi gel.Sonra cavablari vur birbirine. Alinan neticeden III ededin 3%-ni cix.

            Console.WriteLine("PLease enter five digit number");

            int[] fiveDigitNuber = new int[4];

            for (int i = 0; i <4; i++)
            {
                l1:
                Console.Write($"{i+1}:");

                int preCheck=Convert.ToInt32(Console.ReadLine());

                if (check(preCheck))
                {
                    fiveDigitNuber[i] = preCheck;
                }
                else
                {
                    Console.WriteLine("Not five digit number");

                    goto l1;

                }
            }

            int sum13 = fiveDigitNuber[0] + fiveDigitNuber[2];

            int sum24 = fiveDigitNuber[1] + fiveDigitNuber[3];

            Console.WriteLine($"{fiveDigitNuber[0]}+{fiveDigitNuber[2]}={sum13}");
        
            Console.WriteLine($"{fiveDigitNuber[1]}+{fiveDigitNuber[3]}={sum24}");
       

            int mult = sum13 * sum24;

            Console.WriteLine($"{sum13}*{sum24}={mult}");

            int result = mult - fiveDigitNuber[2];

            Console.WriteLine($"{mult}-{fiveDigitNuber[2]}={result}");








        }
        static bool check (int a)
        {
            if (a>=+10000&&a<=99999)
            {
                return true;    

            }
            else
            {
                return false;
            }



        }

    
    
    
    
    }
}
