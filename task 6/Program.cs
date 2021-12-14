    using System;

namespace task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Verilmish 3 reqemli ededdin I ve III reqemlerinin cemi II reqeme beraberdirmi?  Beli ve Xeyr cavabini yaz ekrana

             */
            l1:
            try
            {
                Console.Write("ededi daxil edin: ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a>=100 && a<1000)
                {
                    if ((a / 100) + a % 10 == (a / 10) % 10)
                    {
                        Console.WriteLine("Beli");
                    }
                    else
                    {
                        Console.WriteLine("Xeyr");
                    }
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
