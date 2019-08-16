using System;
using System.Linq;

namespace CSharp8.RangeIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = Enumerable.Range('a', 26).Select(x => (char) x).ToArray();

            // var secondFromLast = alphabet[alphabet.Length - 2];
            // Console.WriteLine(secondFromLast); //y
            // var secondFromLastNewIndex = alphabet[^2];
            // Console.WriteLine(secondFromLastNewIndex); //y
            // Console.WriteLine(secondFromLast == secondFromLastNewIndex); //True

            var last3Characters = alphabet[23..26];
            Console.WriteLine(last3Characters); //xyz
        }
    }
}