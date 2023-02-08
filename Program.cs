using System;

namespace Eyylizer
{
    public class Program
    {
        internal static void Main()
        {
            Random r = new Random();
            for (int i = 0;i<10000;i++)
            {
                string s = "";
                for (int z = r.Next(1,9);z>0;z--)
                    s += " ";

                Console.Write($"ey{s}");
            }
            Console.WriteLine();
        }
    }
}
