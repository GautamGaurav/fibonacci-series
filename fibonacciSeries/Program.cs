using System;

namespace fibbonicSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number of fibonacci terms");
                int n = int.Parse(Console.ReadLine());


                int i = 0, j = 1;
                if (n == 1)
                {
                    Console.Write("\nfibonacci series is : " + i);
                }
                else
                {
                    Console.Write("\nfibonacci series is : " + i + " " + j + " ");
                    for (int k = 2; k < n; k++)
                    {
                        int x = i + j;
                        i = j;
                        j = x;
                        Console.Write(x);
                        Console.Write("  ");
                    }
                }
                Console.Read();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
