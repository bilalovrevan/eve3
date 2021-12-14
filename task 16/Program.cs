using System;

namespace task_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Verilmish 6 reqemli ededde nece unikal reqem var ? ( UNIKAL- Ededin daxilde her reqemden bir numayende secilecek. Yekunda nece numayende olacaq?)
             */
            Console.WriteLine("6 reqemli eded daxil edin");
            int a=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[0];
            while (a>0)
            {
                int reqem = a % 10;
                a = a / 10;
                
                if (Array.IndexOf(arr,a)==-1)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = reqem;
                }
            }
            Console.WriteLine(arr.Length);
        }
    }
}
