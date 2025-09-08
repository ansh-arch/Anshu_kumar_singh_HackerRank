

namespace ConsoleApp2
{
    internal class ArrManipulation
    {
        public static long arrayManipulation(int n, List<List<int>> queries)
        {
            long[] arr = new long[n + 2];
            long maxValue = 0;
            foreach (var query in queries)
            {
                int a = query[0];
                int b = query[1];
                int k = query[2];
                arr[a] += k; // Add element at a.
                arr[b + 1] -= k;//Subtract element at b           

            }

            long current = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                current += arr[i]; //Sum all the effective changes
                if (current > maxValue)
                {
                    maxValue = current;
                }
            }
            return maxValue;
        }
    }
}
