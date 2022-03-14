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
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }

            for (int k = 1; k <= 3; k++)
            {
                Console.WriteLine($"{x} * {k} = {x * k}");
            }
            Console.WriteLine("\n");

            for (int r = 1; r <= 9; r++)
            {
                for (int g = 1; g <= 9; g++)
                {
                    Console.Write($"{r} * {g} = {r * g}\t");
                }
                Console.Write("\n");
            }

            string[,] student = new string[5,4];
            for (int s = 0; s < 5; s++)
            {
                Console.WriteLine($"\n請輸入第{s + 1}位同學的姓名");
                string name = Console.ReadLine();
                student[s,0] = name;

                Console.WriteLine($"請輸入第{s + 1}位同學的電腦概論成績");
                string score01 = Console.ReadLine();
                student[s,1] = score01;

                Console.WriteLine($"請輸入第{s + 1}位同學的程式設計成績");
                string score02 = Console.ReadLine();
                student[s,2] = score02;

                Console.WriteLine($"請輸入第{s + 1}位同學的動畫設計成績");
                string score03 = Console.ReadLine();
                student[s,3] = score03;
            }

            Console.WriteLine($"\n請輸入座號：");
            string no = Console.ReadLine();
            int nonum = int.Parse(no)-1;

            try
            {
                Console.WriteLine($"同學姓名：{student[nonum, 0]}");
                Console.WriteLine($"電腦概論成績：{student[nonum, 1]}");
                Console.WriteLine($"程式設計成績：{student[nonum, 2]}");
                Console.WriteLine($"動畫設計成績：{student[nonum, 3]}");
            }
            catch
            {
                Console.WriteLine($"沒有座號{nonum+1}號這位同學");
            }
            




            Console.Read();
        }
    }
}
