using System;

namespace Task2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 reqemli eded verilib. Bu ededin evvel 18 % sonra ise 3 % tap.

            Console.Write("5 reqemli edidi daxil edin:");

            int _5reqemliEded = Convert.ToInt32(Console.ReadLine());

            _5reqemliEded =Math.Abs(_5reqemliEded); // eger menfi eded verilerse
            
            if (_5reqemliEded >= 10000 & _5reqemliEded <= 99999)
            {
                int netice = (((_5reqemliEded * 18) / 100) * 3 / 100);

                Console.WriteLine($"({_5reqemliEded}*18%)*3%={netice}");
            }


            else
            {
                Console.WriteLine("Verilenler duzgun deyil");
            }


           









        }
    }
}
