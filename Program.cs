using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exercise_2022._03._14_
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("請輸入數字：　");
            string num = Console.ReadLine();
            int x = int.Parse(num);

            if (x % 2 != 0)
            {
                Console.WriteLine("Weird\n");
            }
            else if (x % 2 == 0 && x >= 2 && x <= 5)
            {
                Console.WriteLine("Not Weird\n");
            }
            else if (x % 2 == 0 && x >= 6 && x <= 20)
            {
                Console.WriteLine("Weird\n");
            }
            else if (x % 2 == 0)
            {
                Console.WriteLine("Not Weird\n");
            }

            for (int i = 0; i < x; i++)
            {
                for (int j = 0;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }

            for (int k = 1; k <= 3; k++)
            {
                Console.WriteLine($"{x} * {k} = {x*k}");
            }
            Console.WriteLine("\n");

            for (int r=1;r <= 9; r++)
            {
                for(int g = 1; g <= 9; g++)
                {
                    Console.Write($"{r} * {g} = {r*g}\t");
                }
                Console.Write("\n");
            }
          
            Console.Read();
        }
    }
}
