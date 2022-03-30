using System;

namespace Task214
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6 dene 6 reqemli eded verilib. Evvel hamisini topla . Sonra I ve III ededi bir birine yapishdir ve bir eded al.
            // I neticeden II neticeni cix.Alinan cavabin 10 % tap.Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11 % tap.


            Console.WriteLine("Please enter six digit number");

            int[] sixDigitNumber = new int[6];

            for (int i = 0; i <6; i++)
            {
                l1:
                Console.Write($"{i+1}:");

                int preCheck=Convert.ToInt32(Console.ReadLine());
                

                if (check(preCheck))
                {
                    sixDigitNumber[i] = preCheck;
                }

                else
                {
                    Console.WriteLine("it is not six digit number");

                    goto l1;
                }
            }

            
            double sum6 = 0;

            foreach (double item in sixDigitNumber)
            {

                sum6=sum6+item;

            }
            

            Console.WriteLine($"{sixDigitNumber[0]} + {sixDigitNumber[1]}+ {sixDigitNumber[2]}+ {sixDigitNumber[3]}+ {sixDigitNumber[4]}+ {sixDigitNumber[5]}={sum6}");


            long mult1and3 = sixDigitNumber[0] * 1000000 + sixDigitNumber[2];

            Console.WriteLine($"{sixDigitNumber[0]} U {sixDigitNumber[2]}={mult1and3}");

            double result1 = sum6 - mult1and3;

            Console.WriteLine($"{sum6}-{mult1and3}={result1}");
                        
            Console.Write($"{result1}*10%=");

            result1 = result1 * 10 / 100;

            Console.WriteLine(result1);

            Console.Write($"{result1}+{sixDigitNumber[4]+ sixDigitNumber[5]}=");
            double sum56 = result1 + sixDigitNumber[4] + sixDigitNumber[5];
            Console.WriteLine(sum56);
                     
            Console.Write($"{sum56}*11%=");
            sum56 = sum56 * 11 / 100;

            Console.WriteLine(sum56);

        }
        static bool check   (int a)
        {
            if (a>=100000&&a<=999999)
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
