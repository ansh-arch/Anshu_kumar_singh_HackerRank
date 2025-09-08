

namespace ConsoleApp2
{
    internal class makingAnagrams
    {
        public static int makeAnagrams(string s1, string s2)
        {
            int result = 0;
            Dictionary<char, int> freq = new Dictionary<char, int>();
            Dictionary<char, int> freq1 = new Dictionary<char, int>();
            foreach (char c in s1)
            {
                if (freq.ContainsKey(c))
                {
                    freq[c]++;
                }
                else
                {
                    freq[c] = 1;
                }
            }
            foreach (char c in s2)
            {
                if (freq1.ContainsKey(c))
                {
                    freq1[c]++;
                }
                else
                {
                    freq1[c] = 1;
                }
            }
            HashSet<char> allChars = new HashSet<char>(freq.Keys);
            allChars.UnionWith(freq1.Keys); //Map freq1 unique keys also.

            foreach (char c in allChars)
            {
                int count1 = freq.ContainsKey(c) ? freq[c] : 0;
                int count2 = freq1.ContainsKey(c) ? freq1[c] : 0;

                result += Math.Abs(count1 - count2);
            }
            return result;
        }
    }
}
