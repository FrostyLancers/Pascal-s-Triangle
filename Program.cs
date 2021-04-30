using System;

namespace Pascal_s_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int level = int.Parse(Console.ReadLine());
            while (level < 0)
            {
                Console.WriteLine("Invalid Pascal’s triangle row number.");
                level = int.Parse(Console.ReadLine());
            }

            PascalForLoop(level);
        }       
        
        static int PascalForLoop (int level)
        {
            int num = 1;
            for (int i = 0; i < level + 1; i++)
            {
                for (int space = 1; space <= (level + 1) - i; space++)
                    Console.Write("");
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                    {
                        num = 1;
                    }
                    else
                    {
                        num = num * (i - j + 1) / j;
                    }
                    Console.Write(num);
                }
                Console.WriteLine();
            }
            return num;
        }
    }
}
