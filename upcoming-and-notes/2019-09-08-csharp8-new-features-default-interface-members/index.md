---
title: "C# 8 New Features - Default Interface Members"
date: "2019-09-08T20:00:00.000Z"
description: "C# 8 New Features - Default Interface Members"
---

## C# 8 Setup

> Accompanying YouTube Video: [https://youtu.be/](https://youtu.be/)

- First we need to make sure we have an up to date version of the dot net runtime installed, check it on from the command line:

```cmd
    dotnet --version
```

- The latest version as of this writing: *SDK 3.0.100-preview8-013656*
- Update your csproj file and add the line below to enable the C# 8 features.

```xml
<LangVersion>8.0</LangVersion>
```

**Why would you want a default implementation of something in your interface?**

*I my opinion, having default implementations allows use to write more flexible code. We can now provide some defaults for our implemented classes without having to defer to some **messy** inheritance model.*

### Our widget Interface with two default members

```csharp
    public interface IWidget
    {
        string Name { get; set; }
        decimal Price { get; set; }

        decimal GetChargedPrice()
        {
            return Price;
        }

        string GetDisplay()
        {
            return $"{Name} : {GetChargedPrice().ToString("C")}";
        }
    }
```

**Regular widget which uses the defaults:**

```csharp
    public class RegularWidget : IWidget
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
```

**Special widget which uses its own "GetChargedPrice" method:**

```csharp
    public class SpecialWidget : IWidget
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public decimal GetChargedPrice()
        {
            return Price * 2M;
        }
    }
```

> Using the new default interface member from C# 8 we are able
