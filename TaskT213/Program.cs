using System;

namespace TaskT213
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13) 5 dene eded verilib. Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir. 5 reqemli ededlerin 5% tap ,neticeleri vur bir birine.
            //Sonra 3 reqemli ededlerin 3 % tap ,neticeleri topla. Sonra yekunda alinan iki cavalarin her birinin 10 % -ni tapib topla.

            Console.WriteLine("Please enter five digit number");

            int[] fiveDigitNumbers = new int[3];

            for (int i = 0; i < 3; i++)
            {
            l1:
                Console.Write($"{i + 1}:");

                int pre5Check = Convert.ToInt32(Console.ReadLine());

                if (check5(pre5Check))
                {
                    fiveDigitNumbers[i] = pre5Check;
                }

                else
                {
                    Console.WriteLine("it is not six digit number");

                    goto l1;
                }
            }

            Console.WriteLine("Please enter three digit number");

            int[] threeDigitNumbers = new int[2];

            for (int i = 0; i < 2; i++)
            {
            l2:
                Console.Write($"{i + 4}:");

                int pre3Check = Convert.ToInt32(Console.ReadLine());

                if (check3(pre3Check))
                {
                    threeDigitNumbers[i] = pre3Check;
                }

                else
                {
                    Console.WriteLine("it is not three digit number");

                    goto l2;
                }
            }

            

           double each5 = 1;
                        
            foreach (double elements in fiveDigitNumbers)
            {

                each5 = each5 * elements * 5 / 100;
               
            }

            Console.WriteLine($"{fiveDigitNumbers[0]}*5%*{fiveDigitNumbers[1]}*5%{fiveDigitNumbers[1]}*5%={each5}");



            double each3 = 0;

            foreach (double elements in threeDigitNumbers)

            {

                each3 = each3 + elements;

            }

            Console.WriteLine($"{threeDigitNumbers[0]} + {threeDigitNumbers[1]}={each3}");

            double mult3 = each3 * 3 / 100;
            Console.WriteLine($"{each3}*3%={mult3}");

            Console.Write($"{each5}*10%=");

            Console.WriteLine(each5*10/100);

            Console.Write($"{mult3}*10%=");
            Console.WriteLine(mult3 * 10 / 100);

















            static bool check5(int a)
                {
                    if (a >= 10000 && a < 100000)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            static bool check3(int a)
            {
                if (a >= 100 && a < 1000)
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
}
