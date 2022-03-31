using System;

namespace Task215
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
             * 
          3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi. //result1

          Sonra neticenin axirina 7 reqemini artir.//result2 Sonra cavabin ustune gel 5 reqemli ededlerin cemini.//result3

          Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.//result4

          Sonra alinan cavabin ustune gel 6 reqemli ededi./reslut5

          Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.//result6

          Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap.result 7

          Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.*/



            Console.WriteLine("Please enter three digit number:");

            int[] threeDigitNumbers = new int[2];


            for (int i = 0; i < 2; i++)
            {
                l1:
                Console.Write($"{i+1}:");

                int checkThreeDigitNumber=Convert.ToInt32(Console.ReadLine());

                if (Check3(checkThreeDigitNumber))
                {
                    threeDigitNumbers[i] = checkThreeDigitNumber;
                }

                else
                {
                    Console.WriteLine("Wrong digit number entered");

                    goto l1;
                }

            }

            static bool Check3(int a)
            {
                if (a>=100&&a<=999)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            Console.WriteLine("Please enter four digit number:");

            int[] fourDigitNumbers = new int[2];


            for (int i = 0; i < 2; i++)
            {
                l1:
                Console.Write($"{i+3}:");

                int checkFourDigitNumber=Convert.ToInt32(Console.ReadLine());

                if (Check4(checkFourDigitNumber))
                {
                    fourDigitNumbers[i] = checkFourDigitNumber;
                }

                else
                {
                    Console.WriteLine("Wrong digit number entered");

                    goto l1;
                }

            }

            static bool Check4(int a)
            {
                if (a>=1000&&a<=9999)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            Console.WriteLine("Please enter five digit number:");

            int[] fiveDigitNumbers = new int[2];


            for (int i = 0; i < 2; i++)
            {
                l1:
                Console.Write($"{i+5}:");

                int checkFiveDigitNumber=Convert.ToInt32(Console.ReadLine());

                if (Check5(checkFiveDigitNumber))
                {
                    fiveDigitNumbers[i] = checkFiveDigitNumber;
                }

                else
                {
                    Console.WriteLine("Wrong digit number entered");

                    goto l1;
                }

            }

            static bool Check5(int a)
            {
                if (a>=10000&&a<=99999)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            Console.WriteLine("Please enter Six digit number:");

            int[] sixDigitNumbers = new int[1];


            for (int i = 0; i < 1; i++)
            {
                l1:
                Console.Write($"{i+7}:");

                int checkSixDigitNumber=Convert.ToInt32(Console.ReadLine());

                if (Check6(checkSixDigitNumber))
                {
                    sixDigitNumbers[i] = checkSixDigitNumber;
                }

                else
                {
                    Console.WriteLine("Wrong digit number entered");

                    goto l1;
                }

            }

            static bool Check6(int a)
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

            int sum3 = 0;
            int mult3 = 1;

            foreach (var element in threeDigitNumbers)
            {
                sum3 = sum3 + element;
                mult3 = mult3 * element;
            }
            mult3 = mult3 * 10 + 1;

            int mult4 = 1;

            int sum4 = 0;

            foreach (var element in fourDigitNumbers)
            {
                mult4 = mult4 * element;
                sum4 = sum4 + element;
            }

            int result1 = sum3 + mult4;


            Console.WriteLine($"{sum3}+{mult4}={result1}");

            int result2 = result1 * 10 + 7;

            int sum5 = 0;

            foreach (var element in fiveDigitNumbers)
            {
                sum5= sum5+ element;    
            }

            int result3 = result2 + sum5;

            Console.WriteLine($"{result2}+{sum5}={result3}");

            int result4 = result3 - mult3;

            Console.WriteLine($"{result3}-{mult3}={result4}");

            int result5 = result4 + sixDigitNumbers[0];

            Console.WriteLine($"{result4}+{sixDigitNumbers[0]}={result5}");

            int result6 = result5 - sum3 - sum4;

            Console.WriteLine($"{result5}-{sum3}-{sum4}={result6}");

            int result7 = (((result6 * 18 / 100) * 3 / 100) * 1 / 100);

            Console.WriteLine($"{result6}*18%*3%*1%={result7}");

            int result8 = result7 + sum5;

            Console.WriteLine($"{result7}+{sum5}={result8}");
























        }


    }
}