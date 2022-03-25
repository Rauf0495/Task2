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

            if (_4reqemliEded >= 999 && _4reqemliEded <= 9999)//verilenler az olduguna gore length dan heleki istifade etmirem
            {
                Console.Write($"{_4reqemliEded} ededinin evvel 20%-ni:");

                _4reqemliEded = ((_4reqemliEded * 20) / 100);

                Console.WriteLine(_4reqemliEded);

                Console.Write($"Sonra {_4reqemliEded} ededinin 10%-ni:");

                _4reqemliEded = ((_4reqemliEded * 10) / 100);

                Console.WriteLine(_4reqemliEded);

                Console.Write($"alinan {_4reqemliEded} ededinin kvadratini tapiriq:");
                            
                Console.WriteLine(Math.Pow(_4reqemliEded,2));
            }
            else
            {
                Console.WriteLine("Verilenler duzgun deyil");
            }
        }
    }    }
