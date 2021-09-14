using System;

namespace INClass_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you wnat to count by? >>");
            int countBy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What do you wnat to count up to? >>");
            int ceiling = Convert.ToInt32(Console.ReadLine());

            for (int i = countBy; i < ceiling; i = i + countBy)
            {
                if ((i)
                {
                    Console.Write(i.ToString("N0"));
                } 

            }

            
        }
    }
}
