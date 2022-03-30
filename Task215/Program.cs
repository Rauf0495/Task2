using System;

namespace Task215
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
            3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
            Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
            Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
            Sonra alinan cavabin ustune gel 6 reqemli ededi.
            Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
            Sonra alinan cavabin 18 % -ni sonra 3 % -ni sonra 1 % tap.
            Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.*/


            Console.WriteLine("Please enter a number");

            int[] threeDigitNumbers = new int[2];   

            int[] fourDigitNumbers = new int[2];  
            
            int[] fiveDigitNumbers = new int[2];   

            int[] sixDigitNumbers = new int[1];

            /*for (int i = 0; i <7; i++)
            {
                Console.Write($"{i+1}:");

                int anyNumber=Convert.ToInt32(Console.ReadLine());

                if (check(anyNumber))
                {
                    int x = anyNumber;

                    int count = 0;

                    while (x>0)
                    {
                        int y = anyNumber % 10;

                        x = (x - y) / 10;

                        count++;

                        Console.WriteLine(count);

                       /* if (count==3)
                        {
                            threeDigitNumbers[i] = anyNumber;
                        }
                        else if (count==4)
                        {
                            fourDigitNumbers[i] = anyNumber;
                        }
                        else if (count==5)
                        {
                            fiveDigitNumbers[i] = anyNumber;
                        }

                        else if (count == 6)
                        {
                            sixDigitNumbers[i] = anyNumber;
                        }
                        else
                        {
                            Console.WriteLine("Wrong parametrs");
                        }*/
                    }             

                }


            }

          


            
        
        
        
        
        
        
        
        
        
        
        
        }

        static bool check (int a)
        {
            if (a>=100&&a<=999)
            {
                return true;
            }
            else if (a >= 1000 && a <= 9999)
            {
                return true;
            }
            else if (a >= 10000 && a <= 99999)
            {
                return true;
       
            }

            else if (a >= 100000 && a <= 999999)
            {
                return true;
            }
            else
            {
                return false ;
            }
       
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }   

    }
}