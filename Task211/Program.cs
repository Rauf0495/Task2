using System;

namespace Task211
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 dene 5 reqemli eded verilib. Her I ededin ustune III ededi gel . II ededin usutune IV eeddi gel.Sonra cavablari vur birbirine. Alinan neticeden III ededin 3%-ni cix.

            Console.Write("Birinci  5 reqemli ededi daxil edin:");

            string _1incieded = Console.ReadLine();

            Console.Write("Ikinci  5 reqemli ededi daxil edin:");

            string _2incieded = Console.ReadLine();

            Console.Write("Ucuncu  5 reqemli ededi daxil edin:");

            string _3incieded = Console.ReadLine();

            Console.Write("Dorduncu  5 reqemli ededi daxil edin:");

            string _4incieded = Console.ReadLine();

            if (_1incieded.Length == 5 && _2incieded.Length == 5 && _3incieded.Length == 5&& _4incieded.Length==5)
            {
                double a = Convert.ToDouble(_1incieded);
                double b = Convert.ToDouble(_2incieded);
                double c = Convert.ToDouble(_3incieded);
                double d = Convert.ToDouble(_4incieded);

                Console.Write($"{a}+{c}=");
                double cemAC = a + c;
                Console.WriteLine(cemAC);
                Console.Write($"{b}+{d}=");
                double cemBD = b + d;
                Console.WriteLine(cemBD);
                Console.Write($"{cemAC}*{cemBD}=");
                double hasilACBD = cemAC * cemBD;
                Console.WriteLine(hasilACBD);

                Console.Write($"{hasilACBD}-({c}*7%)=");

                hasilACBD = (hasilACBD - ((c*7)/100));

                Console.WriteLine(hasilACBD);

                

            }
            else
            {
                Console.WriteLine("Verilenler duzgun deyil");
            }

        }
    }
}
