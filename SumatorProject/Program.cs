using System;

namespace SumatorProject
{
 public class Program
    {
        static void Main(string[] args)
        {
            long result = Summator.Sum(new long[] { 1, 2, 3, 4, 5, 6,7 });
            if (result == 21)
            {
                Console.WriteLine("Test pass!");
            }
            else
            {
                Console.WriteLine("Test fail");
            }
        }
    }
}
