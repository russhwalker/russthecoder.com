---
title: "C# 8 New Features - Range & Index Opeators"
date: "2019-08-13T23:46:37.121Z"
description: "C# 8 New Features - Range & Index Opeators"
---

## The **^** (Index) Operator
- df

```csharp
var days = Enumerable.Range(1, System.DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));
var alphabet = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();
var secondFromLast = alphabet[alphabet.Length - 2];
var secondFromLast2 = alphabet[^2];
```

## The **..** (Range) Operator


---
[https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8)