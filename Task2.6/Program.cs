using System;

namespace Task2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // 4 reqemli eded verilib. Bu ededin evvel 20%-ni , sonra ise cavabin 10% tap. Alinan cavabin kvadratini tap

            Console.Write("4 reqemli ededi daxil edin:");

            int _4reqemliEded = Convert.ToInt32(Console.ReadLine());

            _4reqemliEded = Math.Abs(_4reqemliEded); // eger menfi eded verilerse

            if (_4reqemliEded >= 999 && _4reqemliEded <= 9999)
            {
                Console.Write($"{_4reqemliEded}*20%=");

                _4reqemliEded = ((_4reqemliEded * 20) / 100);

                Console.WriteLine(_4reqemliEded);

                Console.Write($"{_4reqemliEded}*10%=");

                _4reqemliEded = ((_4reqemliEded * 10) / 100);

                Console.WriteLine(_4reqemliEded);

                Console.Write($"{_4reqemliEded}*{_4reqemliEded}=");
                            
                Console.WriteLine(Math.Pow(_4reqemliEded,2));
            }
            else
            {
                Console.WriteLine("Verilenler duzgun deyil");
            }
        }
    }    }
