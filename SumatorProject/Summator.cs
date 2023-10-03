

namespace SumatorProject
{
    public static class Summator
    {
        public static long Sum(long[] arr)
        {
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            
            return sum;
        }
        public static int Average(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
             
            }
            int average = sum / arr.Length;

            return average;
        }
    }
}
