using System;

namespace task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Verilmish 3 reqemli ededdin reqemleri cemi I reqemin kvadratina beraberdirmi?  Beli ve Xeyr cavabini yaz ekrana
          */l1:
            try
            {
                Console.Write("ededi daxil edin: ");
                int a= Convert.ToInt32(Console.ReadLine());
                if(a>=100 && a < 1000)
                {
                    int sum = 0;
                    int b = 0;
                    int num1;
                    int c = a;
                    while (c > 0)
                    {
                        b = c % 10;
                        c = c / 10;
                        sum += b;
                    }

                    Console.WriteLine($"Daxil etdiyiniz ededin reqemleri cemi:{sum}");
                    num1 =( a / 100 )* (a / 100);
                    if (num1 == sum)
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
                    Console.WriteLine("daxil etdiyiniz eded 3 reqemli deyil");
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
