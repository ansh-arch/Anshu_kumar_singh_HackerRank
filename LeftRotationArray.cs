
namespace ConsoleApp2
{
    internal class LeftRotationArray
    {
        public static List<int> rotateLeft(int d, List<int> arr)
        {
            int n = arr.Count;
            List<int> lst = new List<int>(new int[n]);
            for (int i = 0; i < n; i++)
            {
                int newIndex = (i + n - d) % n;
                lst[newIndex] = arr[i];
            }
            return lst;
        }
    }
}
