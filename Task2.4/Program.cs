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

            if (_3reqemliEded >= 100 & _3reqemliEded <= 999)//verilenler az olduguna gore length dan heleki istifade etmirem
            {
                Console.Write($"{_3reqemliEded} ededinin axirina 7 elave edirik:");

                _3reqemliEded =Convert.ToInt32($"{_3reqemliEded}7");

                Console.WriteLine($"{_3reqemliEded}");

                Console.WriteLine($"alinan {_3reqemliEded}  reqeminin  7 faizini tapiriq:");

                Console.Write($"{_3reqemliEded} ededinin 7 faizi=");

                Console.WriteLine((_3reqemliEded *7)/100);




            }
            else
            {
                Console.WriteLine("Verilenler duzgun deyil");
            }


        }
    }
}
