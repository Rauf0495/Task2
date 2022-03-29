using System;

namespace Task2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 reqemli eded verilib. Bu ededin axirina hemin ededdin ozunu yapishdir. example: 333= 333333;

            Console.Write("3 reqemli edidi daxil edin:");

            int _3reqemliEded = Convert.ToInt32(Console.ReadLine());

            _3reqemliEded = Math.Abs(_3reqemliEded); // eger menfi eded verilerse

            if (_3reqemliEded >= 100 & _3reqemliEded <= 999)
            {
                _3reqemliEded = _3reqemliEded * 1001;

                Console.WriteLine(_3reqemliEded);
                            
            }


            else
            {
                Console.WriteLine("Verilenler duzgun deyil");
            }
        }
    }
}
