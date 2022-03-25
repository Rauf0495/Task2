using System;

namespace Task212
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 dene 6 reqemli eded verilib. Ededlerin hamisinin 10 faizini tap ve topla. Sonra hamisinin 15 faizini tap ve topla.
            //Sonra yekunda alinanlar iki cavabi vur biri birine. Alinan neticenin evvel 10% tap sonra ise hemin cavabin 11% tap.

            Console.Write("Birinci  6 reqemli ededi daxil edin:");

            string _1incieded = Console.ReadLine();

            Console.Write("Ikinci  6 reqemli ededi daxil edin:");

            string _2incieded = Console.ReadLine();

            Console.Write("Ucuncu  6 reqemli ededi daxil edin:");

            string _3incieded = Console.ReadLine();

            Console.Write("Dorduncu  6 reqemli ededi daxil edin:");

            string _4incieded = Console.ReadLine();

            if (_1incieded.Length == 6 && _2incieded.Length == 6 && _3incieded.Length == 6 && _4incieded.Length == 6)
            {
                double a = Convert.ToDouble(_1incieded);                               
                double b = Convert.ToDouble(_2incieded);
                double c = Convert.ToDouble(_3incieded);
                double d = Convert.ToDouble(_4incieded);

                Console.Write($"{a}*10%=");

                double a10 = ((a * 10) / 100);

                Console.WriteLine(a10);

                Console.Write($"{b}*10%=");

                double b10 = ((b * 10) / 100);

                Console.WriteLine(b10);

                Console.Write($"{c}*10%=");

                double c10= ((c * 10) / 100);

                Console.WriteLine(c10);

                Console.Write($"{d}*10%=");
                double d10 = ((d * 10) / 100);    

                Console.WriteLine(d10);

                double cemABCD10 = a10 + b10 + c10 + d10;

                ////////////////////////////////////////////////////////////////////////////
                Console.Write($"{a}*15%=");

                double a15 = ((a * 15) / 100);

                Console.WriteLine(a15);

                Console.Write($"{b}*15%=");

                double b15 = ((b * 15) / 100);

                Console.WriteLine(b15);

                Console.Write($"{c}*15%=");

                double c15 = ((c * 15) / 100);

                Console.WriteLine(c15);

                Console.Write($"{d}*15%=");
                double d15 = ((d * 15) / 100);

                Console.WriteLine(d15);

                double cemABCD15 = a15 + b15 + c15 + d15;

                Console.Write($"{cemABCD15}*{cemABCD10}=");

                double hasil = cemABCD15 * cemABCD10;

                Console.WriteLine(hasil);

                Console.Write($"{hasil}*10%=");

                hasil= ((hasil*10)/100);

                Console.WriteLine(hasil);

                Console.Write($"{hasil}*11%=");

                hasil = ((hasil * 11) / 100);

                Console.WriteLine(hasil);

            }
            else
            {
                Console.WriteLine("Verilenler duzgun deyil");
            }

        }
    }
}
