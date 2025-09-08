
namespace ConsoleApp2
{
    internal class Sparse_Arrays
    {
        public static List<int> matchingStrings(List<string> stringList, List<string> queries)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            List<int> lst = new List<int>();
            foreach (string s in stringList)
            {
                if (dic.ContainsKey(s))
                {
                    dic[s]++;
                }
                else
                {
                    dic[s] = 1;
                }
            }
            foreach (string ss in queries)
            {
                lst.Add(dic.ContainsKey(ss) ? dic[ss] : 0);
            }
            return lst;
        }
    }
}
