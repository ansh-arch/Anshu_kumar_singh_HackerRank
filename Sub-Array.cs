
namespace ConsoleApp2
{
    internal class Sub_Array
    {
        public void All_Sub_Array(string[] strAr)
        {            
            for (int i = 0; i < strAr.Length; i++)
            {
                for (int j = i; j < strAr.Length; j++)
                {
                    int leng = j - i + 1;
                    string[] strResult = new string[leng];
                    Array.Copy(strAr, i, strResult, 0, leng);
                    Console.WriteLine(string.Join(", ", strResult));
                }
            }
            //--------------------------------- using LINQ ------------------------
            var subArrs = Enumerable.Range(0, strAr.Length)
                .SelectMany(i => Enumerable.Range(i, strAr.Length - i)
                .Select(j => strAr.Skip(i).Take(j - i + 1).ToArray()));

            foreach (var ar in subArrs)
            {
                Console.WriteLine(string.Join(", ", ar));
            }
        }
    }
}
