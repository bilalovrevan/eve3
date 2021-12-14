using System;

namespace task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Verilmish ededdin 1-ile 12 arasinda olugunu yoxla.(1 ve 12 ozude daxil olmaq sherti ile)
   Eger bu eded 
			 	1 olarsa-"Yanvar" sozunu 
				2 olarsa-"Fevral" sozunu
				...
				12 olarsa-"Dekabr" sozunu yaz
             */
            l1:
            Console.Write("eded daxil edin: ");
            int a=Convert.ToInt32(Console.ReadLine());
            if(a>=1 && a<=12)
            {
                switch(a)
                {
                    case 1:
                        Console.WriteLine("Yanvar");
                        break;
                    case 2:
                        Console.WriteLine("Fevral");
                        break;
                    case 3:
                        Console.WriteLine("Mart");
                        break;
                    case 4:
                        Console.WriteLine("Aprel");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 6:
                        Console.WriteLine("Iyun");
                        break;
                    case 7:
                        Console.WriteLine("Iyul");
                        break;
                    case 8:
                        Console.WriteLine("Avqust");
                        break;
                    case 9:
                        Console.WriteLine("Sentyabr");
                        break;
                    case 10:
                        Console.WriteLine("Oktyabr");
                        break;
                    case 11:
                        Console.WriteLine("Noyabr");
                        break;
                    case 12:
                        Console.WriteLine("Dekabr");
                        break;

                }

            }
            else
            {
                Console.WriteLine("eded 1 ve 12 arasinda deyil");
            }
            goto l1;
        }
    }
}
