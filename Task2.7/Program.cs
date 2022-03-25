using System;

namespace Task2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  2 dene 5 reqemli eded verilib. Bu ededleri toplayib. Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap

            Console.Write("1 ci 5 reqemli ededi daxil edin:");

            int _1ci5reqemliEded = Convert.ToInt32(Console.ReadLine());

            Console.Write("2 ci 5 reqemli ededi daxil edin:");

            int _2ci5reqemliEded = Convert.ToInt32(Console.ReadLine());

            _1ci5reqemliEded = Math.Abs(_1ci5reqemliEded);//eger menfi eded verilerse
            _2ci5reqemliEded = Math.Abs(_2ci5reqemliEded);// eger menfi eded verilerse

            if (_1ci5reqemliEded>=10000&& _1ci5reqemliEded<=99999&& _2ci5reqemliEded >= 10000&& _2ci5reqemliEded <= 99999)//verilenler az olduguna gore length dan heleki istifade etmirem
            {
                Console.Write($"Verilen ededleri toplayiriq:{_1ci5reqemliEded} + {_2ci5reqemliEded}=");

                int cem = _1ci5reqemliEded + _2ci5reqemliEded;
                
                Console.WriteLine(cem);

                Console.Write($"Alinan {cem} reqeminin  evveline ve axirina 5 reqemini artiriq:");

                cem = Convert.ToInt32($"5{cem}5");

                Console.WriteLine(cem);

                Console.Write($"Alinan {cem} ededinin 5 faizini tapiriq: ");

                Console.WriteLine((cem*5)/100);

            }
            else
            {
                Console.WriteLine("Verilenler duzgun deyil");
            }

        }
    }
}
