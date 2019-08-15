---
title: "ASP.NET Core View Components"
date: "2017-02-08T00:00:00.000Z"
description: "An introduction to ASP.NET Core View Components."
---

View Components were released as part of ASP.NET CORE to allow developers another way to add content within views. They are a great way to create chunks of page content without using child actions.  Unlike a controller action or child action, a view component is not mapped to a URL and cannot be reached directly.  View Components do not handle HTTP requests as they are not part of the controller flow or lifecycle.

A custom viewComponent can be created by either inheriting from the ViewComponent class(**Microsoft.AspNetCore.Mvc**) or decorating the class with the ViewComponentAttribute(**Microsoft.AspNetCore.Mvc**).

```csharp
public class UsersViewComponent : ViewComponent
{
    private readonly IUserService userService;      
    public UsersViewComponent(IUserService userService)
    {
        this.userService = userService;
    }
    public async Task<IViewComponentResult> InvokeAsync(int count)
    {
        var users = await this.userService.GetUsersAsync(count);
        var viewModel = new UsersViewModel
        {
            Users = users
        };
        return View(viewModel);
    }
}
```

By convention the framework will search for the view component views in two locations. If you are using this view component from multiple different controller views then using the Shared folder is preferred.

- /Views/[Current View Controller]/Components/**[Component Name]**/Default.cshtml
- /Views/Shared/Components/**[Component Name]**/Default.cshtml

#### Default.cshtml:
```csharp
@model DotNetCoreSandbox.Web.ViewModels.UsersViewModel
<table style="border: 1px solid black;">
    <thead>
        <tr>
            <th>Email</th>
            <th>Name</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var p in Model.Users)
        {
            <tr>
                <td>@p.Email</td>
                <td>@p.FirstName @p.LastName</td>
            </tr>
        }
    </tbody>
</table>
```

Using the ViewComponent is as simple as invoking it by name in a View. In this specific call we are also passing in a “count” parameter of 3 to show only three users.

```csharp
@await Component.InvokeAsync("Users", new { count= 3 })
```

Another great thing about ViewComponents is that they fully support the ASP.NET CORE dependency injection out of the box. Just setup your services in Startup.cs using the “ConfigureServices” method(below) and use your instances through constructer injection(as done in the View Component example above).

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddTransient<IUserRepository, UserRepository>();
    services.AddTransient<IUserService, UserService>();
    services.AddMvc();
}
```