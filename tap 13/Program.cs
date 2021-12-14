
using System;

namespace task_13
    {
        internal class Program
        {
            static void Main(string[] args)
            {
            /*Verilmish 7 reqemli eded polindromdursa  o zaman onun daxilnde nece dene 0 reqemi oldugunu tap?
             */
            l1:
            try
            {
                int n, r, c, sum = 0, temp;
                Console.Write("Eded daxil edin: ");
                n = int.Parse(Console.ReadLine());
                temp = n;
                c = n;
                if (n >= 1000000 && n < 10000000)
                {
                    while (c > 0)
                    {
                        r = c % 10;
                        sum = (sum * 10) + r;
                        c = c / 10;
                    }
                    if (temp == sum)
                    {
                        int counter = 0;
                        Console.WriteLine("Eded polindromedur.");
                        while (n > 0)
                        {
                            r = n % 10;

                            n = n / 10;
                            if (r == 0)
                            {
                                counter++;
                                
                            }
                            

                        }
                        Console.WriteLine($"Sifirlarin sayi: {counter}");
                    }
                    else
                        Console.WriteLine("Eded Palindrome deyil");
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

