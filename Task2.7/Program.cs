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

            if (_1ci5reqemliEded>=10000&& _1ci5reqemliEded<=99999&& _2ci5reqemliEded >= 10000&& _2ci5reqemliEded <= 99999)
            {
                Console.Write($"{_1ci5reqemliEded} + {_2ci5reqemliEded}=");

                int cem = _1ci5reqemliEded + _2ci5reqemliEded;
                
                Console.WriteLine(cem);

                Console.Write($"{cem} reqeminin  evveline ve axirina 5 reqemini artiraq:");
                int a1 = 0;
                

                if (cem >= 10000 && cem<=99999)
                {
                    a1 = (cem + 500000) * 10 + 5;
                    Console.WriteLine(a1);
                }
                else if (cem >= 100000 && cem <= 999999)
                {
                    a1 = (cem + 5000000) * 10 + 5;
                    Console.WriteLine(a1);
                }
               

                Console.Write($"{a1}*5%=");

                Console.WriteLine((a1 * 5)/100);

            }
            else
            {
                Console.WriteLine("Verilenler duzgun deyil");
            }

        }
    }
}
