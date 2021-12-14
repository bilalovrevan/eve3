using System;

namespace task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Verilmish 2 reqemli ededdin reqemleri cemi cut ededdirse o zaman 
	hemin 2 reqemli ededdin reqemlerinin hasilini ekrana cixart.

          */
            int b;
        l1:
            Console.Write("2 reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (a >= 10 && a < 100)
                {
                    b = a % 10;
                    a = a / 10;
                    if ((a+b)%2==0)
                    {
                        Console.WriteLine($"Cavab: {a*b}");
                    }
                    else
                    {
                        Console.WriteLine("reqemleri cemi cut deyil!");
                    }
                }
                else
                {
                    Console.WriteLine("eded 2 reqemli deyil!");
                    goto l1;
                }
            }
            catch (Exception)
            {

                throw;
            }
            goto l1;
        }
    }
}
