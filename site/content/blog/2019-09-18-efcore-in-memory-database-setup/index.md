---
title: "EFCore In Memory Database Setup"
date: "2019-09-18T20:00:00.000Z"
description: "Notes on how to setup Entity Framework Core in memory database in an ASP.NET Core web application."
---

## Notes for setting up EFCore with an ASP.NET Core app

### Prerequisites

- .NET Core 2.2 Target Framework
- Nuget Package: Microsoft.EntityFrameworkCore.InMemory (v2.2.26)

#### MyContext.cs

```csharp
public class MyContext : DbContext
{
    public MyContext(DbContextOptions<MyContext> options)
        : base(options)
    {
    }
}
```

#### Startup.cs

```csharp
public void ConfigureServices(IServiceCollection services)
{
    //...
    services.AddDbContext<Data.MyContext>(options => options.UseInMemoryDatabase(databaseName: "MyDatabaseName"));
}
```

#### Program.cs

```csharp
public static void Main(string[] args)
{
    var host = CreateWebHostBuilder(args).Build();

    //If we need to use the context in main, for seeding or whatever.
    using (var scope = host.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<Data.MyContext>();
        SeedData(context);
    }

    host.Run();
}
```
