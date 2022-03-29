using System;

namespace Task2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir. Example1: 333= 73338

            Console.Write("4 reqemli edidi daxil edin:");

            int _4reqemliEded = Convert.ToInt32(Console.ReadLine());

            _4reqemliEded = Math.Abs(_4reqemliEded); // eger menfi eded verilerse

            if (_4reqemliEded>=1000&_4reqemliEded<=9999)
            {
                _4reqemliEded = (70000 + _4reqemliEded) * 10 + 8;
                                
                Console.WriteLine(_4reqemliEded);
            }


            else
            {
                Console.WriteLine("Verilenler duzgun deyil");
            }


        }

    }
}
