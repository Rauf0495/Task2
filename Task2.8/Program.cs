using System;

namespace Task2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.I ededin 4%-ni tap.Sonra II ededin 9% ni tap.Sonra Cavalari toplayib 10 %ni tap.

            Console.Write("Birinci 4reqemli ededi daxil edin:");
            
            int _1incieded = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ikinci 7 reqemli ededi daxil edin:");

            int _2incieded = Convert.ToInt32(Console.ReadLine());

            _1incieded = Math.Abs(_1incieded);//eger menfi eded verilerse
            _2incieded = Math.Abs(_2incieded);//eger menfi eded verilerse

            if (_1incieded >= 1000 && _1incieded <= 9999 && _2incieded >= 1000000 && _2incieded < 10000000)//verilenler az olduguna gore length dan heleki istifade etmirem
            {
                Console.Write($"{_1incieded}in 4 %-i:");
                _1incieded = ((_1incieded * 4) / 100);
                Console.WriteLine(_1incieded);

                Console.Write($"{_2incieded}in 9 %-i:");
                _2incieded = ((_2incieded * 9) / 100);
                Console.WriteLine(_2incieded);
                Console.Write($"({_1incieded}+{_2incieded})*10%=:");
                int cemHasil = ((_1incieded + _2incieded) * 10) / 100;
                Console.WriteLine(cemHasil);
            }
            else
            {
                Console.WriteLine("Verilenler duzgun deyil");
            }           
                
        
        }       
    }
}
