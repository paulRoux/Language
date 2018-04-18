using System;
using System.Collections.Generic;
using System.Text;

namespace PerfectNum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] p = new long[300];
            long i, num, count, s, c = 0;
            for (num = 2; num <= 100000; num++)
            {
                count = 0;
                s = num;
                for (i = 1; i < num / 2 + 1; i++)
                {
                    if (num % i == 0)
                    {
                        p[count++] = i;
                        s -= i;
                    }
                }
                if (s == 0)
                {
                    Console.Write(num + "是一个完数，因子是:");
                    Console.Write(num + "=" + p[0]);
                    for (i = 1; i < count; i++)
                    {
                        Console.Write("+" + p[i]);
                    }
                    Console.WriteLine();
                    c++;
                }

            }
            Console.WriteLine("总共找到完数" + c + "个!");
            Console.ReadKey();

        }
    }
}