using System;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Verilmish ededdin sonuncu reqemi 7 ile qurtarirmi? Beli ve Xeyr cavabini yaz ekrana
          */
            l1:
            Console.Write("eded daxil edin: ");
            int a=Convert.ToInt32(Console.ReadLine());
            try
            {
                if (a % 10 == 7)
                {
                    Console.WriteLine("Beli");
                }
                else
                {
                    Console.WriteLine("Xeyr");
                }
                goto l1;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
