using System;

namespace task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Verilmihs 6 reqemli ededdin evveline ve axirina 8 artir. 
    Alinan neticenin ilk 4 reqemi ile son 4 reqeminin yerini deyish
    Neticenin tek yerde dayanan reqemlerini 0 reqemi ile evez et.
             */
            l1:
            try
            {
                Console.WriteLine("6 reqemli eded daxil edin: ");
                int a=Convert.ToInt32(Console.ReadLine());
                if (a >=100000 && a<=1000000)
                {
                    a = 80000000 + a*10 + 8;
                    
                    int ilk4 = a / 10000;
                    
                    int son4 = a % 10000;
                    
                    a = son4 * 10000+ilk4 ;
                    
                    int ikinci = a / 1000000 % 10;
                    
                    int dorduncu = a / 10000 % 10;
                    
                    int altinci = a / 100 % 10;
                    
                    int sonuncu = a % 10;
                    
                    a = ikinci * 1000 + dorduncu * 100 + altinci * 10 + sonuncu;
                    Console.WriteLine($"Cavab: {a}");
                }
                else
                {
                    Console.WriteLine("eded 6 reqemli deyil");
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
