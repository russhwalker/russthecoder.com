---
title: "C# 8 New Features - Range & Index Opeators"
date: "2019-08-18T20:00:00.000Z"
description: "C# 8 New Features - Range & Index Opeators"
---

## C# 8 Setup
> Accompanying YouTube Video: [https://youtu.be/j7QQFAT50Og](https://youtu.be/j7QQFAT50Og)


- First we need to make sure we have an up to date version of the dot net runtime installed, check it on from the command line:
  - 
    ```
    dotnet --version
    ```
  - The latest version as of this writing: *SDK 3.0.100-preview8-013656*
- Update your csproj file and add the line below to enable the C# 8 features.

```xml
<LangVersion>8.0</LangVersion>
```

## The New Index Operator: **^**

- Also called the **hat** operator.
- This new operator is used to specifiy the index from the **END** of a collection.
- This is opposed to *regular* indexing(array[index]) where you are indexing from the beginning of an array.

```csharp
var alphabet = Enumerable.Range('a', 26).Select(x => (char) x).ToArray();
var secondFromLast = alphabet[alphabet.Length - 2];
Console.WriteLine(secondFromLast); //y
var secondFromLastNewIndex = alphabet[^2];
Console.WriteLine(secondFromLastNewIndex); //y
```

## The New Range Operator: **..**

- This new operator is used to specify a range of indices, the start and end of a range.
- The tricky part of this operator is whether the range is inclusive or exclusive, it's actually both.
  - The **start** of the range is **inclusive**.
  - The **end** of the range is **exclusive**.

```csharp
var alphabet = Enumerable.Range('a', 26).Select(x => (char) x).ToArray();
var last3Characters = alphabet[23..26];
Console.WriteLine(last3Characters); //xyz
var range = alphabet[20..^2];
Console.WriteLine(range);//uvwx
```

In this example the end of the array looks like this:

| Value | Index |
| ----- | ---- |
| v   | 21 |
| w   | 22 |
| x   | 23 |
| y   | 24 |
| z   | 25 |

- In the first example range above of **[23..26]** we are getting the values in the 23rd, 24th and 25th index spots in our alphabet character array, so the result is *xyz*.
- In the second range above **[20..^2]** we are starting from the index of 20 and until 2 from the last of the array, so the result is *uvwx*.
