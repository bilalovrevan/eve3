using System;

namespace task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Verilmish 6 reqemli ededin ilk 3 reqeminin cemi son 3 reqeminin cemine beraberdirse
    o zaman
    	bu ededdin ilk 2 reqemini son 2 reqemine yapishdir.
        Neticenin ustune ortaya dushen 2 reqemini gel. 
             */
            l1:
            try
            {
                Console.WriteLine("6 reqemli eded daxil edin: ");
                int a=Convert.ToInt32(Console.ReadLine());
                if (a >=100000 && a<=1000000)
                {
                    int orta2reqem = (a / 100) % 100;
                    int ilk3 = a / 1000;
                    int son3 = a % 1000;
                    int ilk2 = a / 10000;
                    int son2 = a % 100;
                    if(ilk3==son3)
                    {
                        a = ilk2 * 100 + son2 + orta2reqem;
                        Console.WriteLine($"Cavab: {a}");
                    }
                    else
                    {
                        Console.WriteLine("ilk 3 reqem son 3 reqeme beraber deyil");
                    }
                }
                else
                {
                    Console.WriteLine("eded 6 reqemli deyil! yeniden cehd edin");
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
