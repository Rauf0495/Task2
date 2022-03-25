using System;

namespace Task2._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 dene 4 reqemli eded verilib. I ededin 1%-ni, II ededin 2% , III ededin 3 % tap.Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7% faizini gel

            Console.Write("Birinci  4 reqemli ededi daxil edin:");

            string _1incieded = Console.ReadLine();

            Console.Write("Ikinci  4 reqemli ededi daxil edin:");

            string _2incieded = Console.ReadLine();

            Console.Write("Ucuncu  4 reqemli ededi daxil edin:");

            string _3incieded = Console.ReadLine();

            if (_1incieded.Length == 4 && _2incieded.Length == 4 && _3incieded.Length == 4)
            {
                double a = Convert.ToDouble(_1incieded);
                double b = Convert.ToDouble(_2incieded);
                double c = Convert.ToDouble(_3incieded);

                Console.Write($"{a}*1%=");
                a = ((a * 1) / 100);
                Console.WriteLine(a);
                Console.Write($"{b}*1%=");
                b = ((b * 1) / 100);
                Console.WriteLine(b);
                Console.Write($"{c}*1%=");
                c = ((c * 1) / 100);
                Console.WriteLine(c);

                Console.Write($"{a}-{b}-{c}=");

                double ferq = a - b - c;

                Console.WriteLine(ferq);

                Console.Write($"{ferq}+{c}*7%=");

                ferq = ferq + ((c * 7) / 100);

                Console.WriteLine(ferq);

            }
            else
            {
                Console.WriteLine("Verilenler duzgun deyil");
            }
        
        
        }
    }
}
