using System;

namespace task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /*6 dene eded verilib. Bu ededlerden hansi en boyukdur.
         */
        l1:
            try
            {
                Console.WriteLine("6 eded daxil edin");
                int a1 = Convert.ToInt32(Console.ReadLine());
                int a2 = Convert.ToInt32(Console.ReadLine());
                int a3 = Convert.ToInt32(Console.ReadLine());
                int a4 = Convert.ToInt32(Console.ReadLine());
                int a5 = Convert.ToInt32(Console.ReadLine());
                int a6 = Convert.ToInt32(Console.ReadLine());
                int[] a = { a1, a2, a3, a4, a5, a6 };
                int max = a[0];
                for (int i = 0; i < 6; i++)
                {
                    
                    if (a[i] > max)
                    {
                        max = a[i];

                    }

                }
                Console.WriteLine($"Cavab {max}");
            }
            catch (Exception)
            {

                throw;
            }
            goto l1;

        }
    }
}
