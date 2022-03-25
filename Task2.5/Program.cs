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

            if (_4reqemliEded>=999&&_4reqemliEded<=9999)//verilenler az olduguna gore length dan heleki istifade etmirem
            {
                Console.Write($"{_4reqemliEded} ededinin evveline 4, axirina 44 elave edirik:");

                _4reqemliEded = Convert.ToInt32(($"4{_4reqemliEded}44"));

                Console.WriteLine(_4reqemliEded);

                Console.Write($"alinan {_4reqemliEded}  reqeminin  44 faizini tapiriq:");

                Console.WriteLine((_4reqemliEded * 44) / 100);

            }
            else
            {
                Console.WriteLine("Verilenler duzgun deyil");
            }
            
            









        }
    }
}
