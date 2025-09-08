
namespace ConsoleApp2
{
    internal class dynamicArray
    {
        public List<int> dynamicArray_2D(int n, List<List<int>> queries)
        {
            //Declare a 2-D array
            List<List<int>> arr = new List<List<int>>();
            //Store n array in 2-D arr
            for (int i = 0; i < n; i++)
            {
                arr.Add(new List<int>());
            }
            //Declare an integer lastAnswer with 0 value.
            int lastAnswer = 0;
            //Answer Array
            List<int> ansArray = new List<int>();
            //int idx=0;
            foreach (var query in queries)
            {
                int type = query[0];
                int x = query[1];
                int y = query[2];
                int idx = (x ^ lastAnswer) % n;
                if (type == 1)
                {
                    arr[idx].Add(y);//Store value of y in arr
                }
                else if (type == 2)
                {
                    lastAnswer = arr[idx][y % (arr[idx].Count)];
                    ansArray.Add(lastAnswer); //Store lastAnswer in Answer Array
                }
            }
            return ansArray;
        }
    }
}
