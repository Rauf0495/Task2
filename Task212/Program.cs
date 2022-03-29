using System;

namespace Task212
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 dene 6 reqemli eded verilib. Ededlerin hamisinin 10 faizini tap ve topla. Sonra hamisinin 15 faizini tap ve topla.
            //Sonra yekunda alinanlar iki cavabi vur biri birine. Alinan neticenin evvel 10% tap sonra ise hemin cavabin 11% tap.

            Console.WriteLine("Please enter six digit number");

            int[] sixDigitNumbers = new int[4];

            for (int i = 0; i < 4; i++)
            {
                l1:
                Console.Write($"{i+1}:");

                int preCheck = Convert.ToInt32(Console.ReadLine());

                if (check(preCheck))
                {
                    sixDigitNumbers[i] = preCheck;
                }

                else
                {
                    Console.WriteLine("it is not six digit number");

                    goto l1;
                }

            }


            double _10percent = 0;
            double _15percent = 0;
            
            foreach (double element in sixDigitNumbers)
            {
                _10percent = _10percent + element;
                                              
            }

            Console.WriteLine($"{sixDigitNumbers[0]}+{sixDigitNumbers[1]}+{sixDigitNumbers[2]}+{sixDigitNumbers[3]}={_10percent}");


            Console.Write($"{_10percent}*10%=");
            _10percent = _10percent * 10 / 100;
            Console.WriteLine(_10percent);


            foreach (double element in sixDigitNumbers)
            {
                _15percent = _15percent + element;

            }

            Console.WriteLine($"{sixDigitNumbers[0]}+{sixDigitNumbers[1]}+{sixDigitNumbers[2]}+{sixDigitNumbers[3]}={_15percent}");


            Console.Write($"{_15percent}*15%=");
            _15percent = _15percent * 15 / 100;
            Console.WriteLine(_15percent);


            Console.Write($"{_10percent}*{_15percent}=");

            double mult = _10percent *_15percent;

            Console.WriteLine(mult);

            Console.Write($"{mult}*10%*11%=");

            mult = (mult * 10 / 100) * 11 / 100;

            Console.WriteLine(mult);


















        }
        static bool check(int a)
        {
            if (a>=100000&&a<1000000)
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
