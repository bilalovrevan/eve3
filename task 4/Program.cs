using System;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Verilmihs 2 reqemli ededin reqemleri eynidirmi?   Beli ve Xeyr cavabini yaz ekrana
          */
            l1:
            Console.Write("2 reqemli eded daxil edin: ");
            int a=Convert.ToInt32(Console.ReadLine());
            try
            {
                if (a>=10 && a<100)
                {
                    if (a%10==a/10)
                    {
                        Console.WriteLine("Beli");
                    }
                    else
                    {
                        Console.WriteLine("Xeyr");
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
