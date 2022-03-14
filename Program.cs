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
                Console.WriteLine("Weird");
            }
            else if (x % 2 == 0 && x >= 2 && x <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (x % 2 == 0 && x >= 6 && x <= 20)
            {
                Console.WriteLine("Weird");
            }
            else if (x % 2 == 0)
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
