using System;

namespace Task2._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10% tap.

            Console.Write("Birinci  6 reqemli ededi daxil edin:");

            string _1incieded = Console.ReadLine();
            
            Console.Write("Ikinci  6 reqemli ededi daxil edin:");

            string _2incieded = Console.ReadLine();

            Console.Write("Ucuncu  6 reqemli ededi daxil edin:");

            string _3incieded = Console.ReadLine();

            if (_1incieded.Length==6&& _2incieded.Length == 6&&_3incieded.Length == 6)
            {
                double a = Convert.ToDouble(_1incieded);
                double b = Convert.ToDouble(_2incieded);
                double c = Convert.ToDouble(_3incieded);

                Console.Write($"{a}*10%=");
                a = ((a * 10) / 100);
                Console.WriteLine(a);
                Console.Write($"{b}*10%=");
                b = ((b * 10) / 100);
                Console.WriteLine(b);
                Console.Write($"{c}*10%=");
                c = ((c * 10) / 100);
                Console.WriteLine(c);

                Console.Write($"{a}+{b}+{c}=");

                double cem = a + b + c;

                Console.WriteLine(cem);

                Console.Write($"{cem}*10%=");

                cem = (cem * 10) / 100;

                Console.WriteLine(cem);

            }

            else
            {
                Console.WriteLine("Verilenler duzgun deyil");
            }

        }
   
    
    
    }
}
