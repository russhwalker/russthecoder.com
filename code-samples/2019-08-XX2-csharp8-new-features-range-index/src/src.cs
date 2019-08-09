var alphabet = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();
var secondFromLast = alphabet[alphabet.Length - 2].Dump();
//var secondFromLast2 = alphabet[^ 2];