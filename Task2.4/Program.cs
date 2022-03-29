using System;

namespace Task2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap;

            Console.Write("3 reqemli edidi daxil edin:");

            double _3reqemliEded = Convert.ToInt32(Console.ReadLine());

            _3reqemliEded = Math.Abs(_3reqemliEded); // eger menfi eded verilerse

            if (_3reqemliEded >= 100 & _3reqemliEded <= 999)
            {
                Console.Write($"{_3reqemliEded} ededinin sonuna 7 elave edirik ve 7%=");

                _3reqemliEded = (_3reqemliEded * 10 + 7)*7/100;

                Console.WriteLine($"{_3reqemliEded}");
                                
            }
            else
            {
                Console.WriteLine("Verilenler duzgun deyil");
            }


        }
    }
}
