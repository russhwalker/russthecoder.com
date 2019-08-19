using System;
using System.Linq;

namespace CSharp8.RangeIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();
            //Console.WriteLine(alphabet);
            var rng = alphabet[23..26];
            //Console.WriteLine(rng);
            var rng2 = alphabet[20..^2];
            Console.WriteLine(rng2);
        }
    }
}