using System;

namespace task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Verilmish ededdin sonuncu reqemi 
			 	1 olarsa-"I gun" sozunu 
				2 olarsa-"II gun" sozunu
				...
				7 olarsa-"VI gun" sozunu yaz
             */
            try
            {
                Console.Write("eded daxil edin: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int lastnum = a % 10;
                switch (lastnum)
                {


                    case 1:
                Console.WriteLine("1-ci gun");
                        break;
                    case 2:
                Console.WriteLine("2-ci gun");
                        break;

                    case 3:
                Console.WriteLine("3-cu gun");
                        break ;
                    case 4:
                        Console.WriteLine("4-cu gun");
                        break;
                    case 5:
                        Console.WriteLine("5-ci gun");
                        break;
                    case 6:
                        Console.WriteLine("6-ci gun");
                        break;
                    case 7:
                        Console.WriteLine("7-ci gun");
                        break;

                }


            }
            

            catch (Exception)
            {

                throw;
            }

        }


    } 
}