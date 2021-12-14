using System;

namespace eve3
{
    internal class Task1
    {
        static void Main(string[] args)
        {
        /*
         * verilmish ededin tek ve ya cut eded oldugunu yoxla
         */
        l1:
            Console.Write("eded daxil edin: ");
            int a=Convert.ToInt32(Console.ReadLine());
            
            try
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("Daxil etdiyiniz eded cutdur");
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz eded tekdir");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Zehmet olmasa duzgun eded daxil edin");
            }
            goto l1;
        }
    }
}
