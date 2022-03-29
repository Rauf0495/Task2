using System;

namespace Task2._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 dene 4 reqemli eded verilib. I ededin 1%-ni, II ededin 2% , III ededin 3 % tap.Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7% faizini gel

            int[]fourDigitNumber= new int[3];

            Console.WriteLine("Please enter four digit number");

            for (int i = 0; i < 3; i++)
            {
                l1:
                Console.Write($"{i+1}:");

                int preCheck=Convert.ToInt32(Console.ReadLine());

                if (check(preCheck))
                {
                    fourDigitNumber[i] = preCheck;
                }

                else
                {
                    Console.WriteLine("it is not 4 digit number");
                    goto l1;


                }


            }

            int percentFourDigits = (fourDigitNumber[0] + fourDigitNumber[1] + fourDigitNumber[2])*7/100;


            Console.Write($"{fourDigitNumber[0]}*1%=");

            Console.WriteLine(fourDigitNumber[0] = fourDigitNumber[0] * 1 / 100);

           
            Console.Write($"{fourDigitNumber[1]}*2%=");

            Console.WriteLine(fourDigitNumber[1] = fourDigitNumber[1] * 2 / 100);

            Console.Write($"{fourDigitNumber[2]}*3%=");

            Console.WriteLine(fourDigitNumber[2] = fourDigitNumber[2] * 3 / 100);

            Console.Write($"{fourDigitNumber[0]}-{fourDigitNumber[1]}-{fourDigitNumber[2]}=");

            int result = fourDigitNumber[0] - fourDigitNumber[1] - fourDigitNumber[2];
                        
            Console.WriteLine(result);

            Console.Write($"{result}+{percentFourDigits}=");

            Console.WriteLine(result+ percentFourDigits);

        }   
        
        
        static bool check (int a)

        {
            if (a>=999&&a<=9999)
            {
                return true;
            }

            else
            {                
                return false;
                 
            }
        }


            
    }
}
