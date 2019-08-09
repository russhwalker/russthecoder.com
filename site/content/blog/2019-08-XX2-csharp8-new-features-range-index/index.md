---
title: "C# 8 New Features - Range & Index"
date: "2019-08-13T23:46:37.121Z"
description: "testtsts"
---

## The **^** Operator
- New syntactic sugar

```csharp
var days = Enumerable.Range(1, System.DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));
var alphabet = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();
var secondFromLast = alphabet[alphabet.Length - 2];
var secondFromLast2 = alphabet[^2];
```

## The **..** (Range) Operator

