---
title: "C# 8 New Features - Range & Index Opeators"
date: "2019-08-17T00:00:00.000Z"
description: "C# 8 New Features - Range & Index Opeators"
---

## C# 8 Setup

- update your csproj file and add the line below.

```xml
<LangVersion>8.0</LangVersion>
```

## The Index Operator: **^**

- [https://docs.microsoft.com/en-us/dotnet/api/system.index?view=netstandard-2.1](https://docs.microsoft.com/en-us/dotnet/api/system.index?view=netstandard-2.1)
- This new operator is used to specifiy and index location from the END of a collection.
- This is opposed to *regular* indexing(array[index]) where you are indexing from the beginning of an array.

```csharp
//Index Operator Example
var alphabet = Enumerable.Range('a', 26).Select(x => (char) x).ToArray();
var secondFromLast = alphabet[alphabet.Length - 2];
Console.WriteLine(secondFromLast); //y
var secondFromLastNewIndex = alphabet[^2];
Console.WriteLine(secondFromLastNewIndex); //y
Console.WriteLine(secondFromLast == secondFromLastNewIndex); //True
```

## The Range Operator: **..**

- [https://docs.microsoft.com/en-us/dotnet/api/system.range?view=netstandard-2.1](https://docs.microsoft.com/en-us/dotnet/api/system.range?view=netstandard-2.1)
- This new operator is used to specify a range of indices, the start and end of a range.
- The tricky part of this operator is whether the range is inclusive or exclusive, it's actually both.
  - > The **start** of the range is **inclusive**.
  - > The **end** of the range is **exclusive**.

```csharp
//Range Operator Example
var alphabet = Enumerable.Range('a', 26).Select(x => (char) x).ToArray();
var last3Characters = alphabet[23..26];
Console.WriteLine(last3Characters); //xyz
```

In this example the end of the array looks like this:

| Value | Index |
| ----- | ---- |
| v   | 21 |
| w   | 22 |
| x   | 23 |
| y   | 24 |
| z   | 25 |

By using the range above of **[23..26]** we are getting the values in the 23rd, 24th and 25th index spots in our alphabet character array.
