using System.Linq;

namespace FindTheOddInt
{
    public class Kata
    {
        public static int find_it(int[] seq)
        {
            return seq.GroupBy(x => x).Where(y => y.Count() % 2 != 0).ToList()[0].Key;
        }
    }
}
