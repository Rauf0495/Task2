using System;

namespace Task2._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 dene 6 reqemli eded verilib. Ededlerin hamisinin 10 faizini tap ve topla. Sonra hamisinin 15 faizini tap ve topla.

            //Sonra yekunda alinanlar iki cavabi vur biri birine. Alinan neticenin evvel 10% tap sonra ise hemin cavabin 11% tap.


            int[] sixDigitNumbers = new int[6];

              

            Console.WriteLine("6 reqemli ededi daxil edin:");

            
            for (int i = 0; i < 4; i++)
            {
            l1:
                Console.Write($"{i + 1}:");

                int preCheck = Convert.ToInt32(Console.ReadLine());

                preCheck=Math.Abs(preCheck);


                if (check(preCheck))
                {
                    sixDigitNumbers[i] = preCheck;
                }

                else
                {
                    goto l1;
                }
            }


            int sum1 = 0;

            for (int i = 0; i < 4; i++)
            {
                sum1 = sum1 + sixDigitNumbers[i];

            }

            Console.WriteLine($"{sixDigitNumbers[0]}+{sixDigitNumbers[1]}+{sixDigitNumbers[2]}+{sixDigitNumbers[3]}={sum1}");


            Console.Write($"{sum1}*10%=");
            sum1 = sum1 * 10 / 100;
            Console.WriteLine(sum1);

            Console.Write($"{sum1}*15%=");
            int sum2 = sum1 * 15 / 100;
            Console.WriteLine(sum2);

            int mult = sum1 * sum2;
            Console.WriteLine($"{sum1}*{sum2}={mult}");

            Console.Write($"{mult}*10*11%=");

            mult = mult * 10 / 100 * 11 / 100;

            Console.WriteLine(mult);
            
            

        }


        static bool check(int a)
        {

            if (a >= 100000 && a <= 999999)
            {
                return true;
            }
            else
            {
                Console.WriteLine("6 reqemli deyil");
                return false;

            }
        }
    }
}
