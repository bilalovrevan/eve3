using System;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2 eded verilib. Eger I eded II edede tam bolunurse o zaman cavabi cixart. 
    Eks halda  "bolunmur" sozunu cap et
             */
            l1:
            Console.Write("1-ci ededi daxil edin: ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("2-ci ededi daxil edin: ");
            int b=Convert.ToInt32(Console.ReadLine());
            try
            {
                if (a % b == 0)
                {
                    a = a / b;
                    Console.WriteLine($"Cavab = {a}");
                }
                else
                {
                    Console.WriteLine("1-ci  eded 2-ci edede tam bolunmur");
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
