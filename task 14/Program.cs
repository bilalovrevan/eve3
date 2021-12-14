using System;

namespace task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir eded daxil et. Bu eded maksimum 8 reqemli ola biler( bu o demekdirki 1,2,3,4,5,6,7 reqemlide ola biler)
    Bu ededin evvelin 1 reqemini artir
             */
            l1:
            Console.WriteLine("9 reqemli ededlerden kicik eded daxil et: ");
            int a = int.Parse(Console.ReadLine());
            if (a<100000000 && a>0)
            {
                Console.WriteLine($"1{a}");
            }
            else
            {
                Console.WriteLine("ededi duzgun daxil edin");
            }
            goto l1;
        }
    }
}
