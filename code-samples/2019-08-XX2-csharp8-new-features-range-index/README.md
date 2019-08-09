# 2-csharp8-new-features-range-index

## New Operators
### The **^** Operator
- New syntactic sugar


var days = Enumerable.Range(1, System.DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));
var alphabet = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();
var secondFromLast = alphabet[alphabet.Length - 2];
var secondFromLast2 = alphabet[^2];

### The **..** (Range) Operator

