using System;

namespace task_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Verilmish ededdin 1-ile 365 arasinda olugunu yoxla (1 ve 365 ozude daxil olmaq sherti ile)
    Ededin ilin hansi ayina dushduyunu tap. Ve hemin ay ve gune uygun hansi burc oldugunu goster
             */
            Console.Write("Gunu daxil et: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a>=1 && a<=365)
            {
                if (a>=1 && a<=39)
                {
                    if (a>=1 && a< 20)
                    {
                        Console.WriteLine("Oqlaq burcu");
                    }
                    else
                    { Console.WriteLine("Dolca burcu"); }
                    Console.WriteLine("Yanvar");
                }
                else if (a>=40 && a<=68)
                {
                    if (a>=40 && a<=50)
                    {
                        Console.WriteLine("Dolca burcu");


                    }
                    else
                    {
                        Console.WriteLine("Baliq burcu");
                    }
                    Console.WriteLine("Fevral");
                }
                else if (a>=69 && a<=100)
                {
                    if (a>=69 && a<=85)
                    {
                        Console.WriteLine("Baliq burcu");
                    }
                    else
                    {
                        Console.WriteLine("Qoc burcu");
                    }
                    Console.WriteLine("Mart");
                }
                else if (a >= 101 && a <= 131)
                {
                    if (a>=101 && a<=115)
                    {
                        Console.WriteLine("Qoc burcu");
                    }
                    else
                    {
                        Console.WriteLine("Buga burcu");
                    }
                    Console.WriteLine("Aprel");
                }
                else if (a >= 132 && a <= 143)
                {
                    if (a>=132 && a<=138)
                    {
                        Console.WriteLine("Buga burcu");
                    }
                    else
                    {
                        Console.WriteLine("Ekizler burcu");
                    }
                    Console.WriteLine("May");
                }
                else if (a >= 144 && a <= 174)
                {
                    if (a>=144 && a<=155)
                    {
                        Console.WriteLine("Ekizler burcu");
                    }
                    else
                    {
                        Console.WriteLine("Xerceng burcu");
                    }
                    Console.WriteLine("Iyun");
                }
                else if (a >= 175 && a <= 206)
                {
                    if (a>=175 && a<195)
                    {
                        Console.WriteLine("Xerceng burcu");
                    }
                    else
                    {
                        Console.WriteLine("Shir burcu");
                    }
                    Console.WriteLine("Iyul");
                }
                else if (a >= 207 && a <= 238)
                {
                    if (a>=207 && a<-215)
                    {
                        Console.WriteLine("Shir burcu");
                    }
                    else
                    {
                        Console.WriteLine("Qiz burcu");
                    }
                    Console.WriteLine("Avqust");
                }
                else if (a >= 239 && a <= 269)
                {
                    if (a>=239 && a<=250)
                    {
                        Console.WriteLine("Qiz burcu");
                    }
                    else
                    {
                        Console.WriteLine("Terezi burcu");
                    }
                    Console.WriteLine("Sentyabr");
                }
                else if (a >= 270 && a <= 301)
                {
                    if (a>=270 && a<=285)
                    {
                        Console.WriteLine("Terezi burcu");
                    }
                    else
                    {
                        Console.WriteLine("Eqreb burcu");
                    }
                    Console.WriteLine("Oktyabr");
                }
                else if (a >= 302 && a <= 333)
                {
                    if (a>=302 && a<315)
                    {
                        Console.WriteLine("Eqreb burcu");
                    }
                    else
                    {
                        Console.WriteLine("Oxatan burcu");
                    }
                    Console.WriteLine("Noyabr");
                }
                else if (a >= 334 && a <= 365)
                {
                    if (a>=334 && a<=350)
                    {
                        Console.WriteLine("Oxatan burcu");
                    }
                    else
                    {
                        Console.WriteLine("Oqlaq burcu");
                    }
                    Console.WriteLine("Dekabr");
                }
            }
        }
    }
}
