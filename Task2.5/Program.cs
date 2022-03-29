using System;

namespace Task2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 reqemli eded verilib. Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir. Alinan cavabin 44 % tap.


            Console.Write("4 reqemli ededi daxil edin:");

            int _4reqemliEded = Convert.ToInt32(Console.ReadLine());

            _4reqemliEded = Math.Abs(_4reqemliEded); // eger menfi eded verilerse

            if (_4reqemliEded>=999&&_4reqemliEded<=9999)
            {
                Console.Write($"{_4reqemliEded} ededin evveline 4 artiraq");

                _4reqemliEded = (_4reqemliEded + 40000); 

                Console.WriteLine(_4reqemliEded);

                Console.Write($"{_4reqemliEded} ededin sonuna 44 artiraq");

                _4reqemliEded = (_4reqemliEded  * 100 + 44);

                Console.WriteLine(_4reqemliEded);

                Console.Write($"{_4reqemliEded}*44%=");

                _4reqemliEded = (_4reqemliEded*44/100);

                Console.WriteLine(_4reqemliEded);


            }
            else
            {
                Console.WriteLine("Verilenler duzgun deyil");
            }
            
            









        }
    }
}
