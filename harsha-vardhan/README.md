<details>
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#about-the-project">About The Project</a></li>
    <li><a href="#intoduction">Introduction</a></li>
  </ol>
</details>

&nbsp;

## About The Project

- C# 10 | Ultimate Guide - Beginner to Advanced | Master class
- Learn C# by doing | C# projects | Bootcamp for C# Interview | Advanced C# | Collections | LINQ | Interview Questions

&nbsp;

---

&nbsp;

## Introduction

- [For Homebrew: GitHub - isen-ng/homebrew-dotnet-sdk-versions](https://github.com/isen-ng/homebrew-dotnet-sdk-versions)
- [Microsoft - dotnet-sln](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-sln)
- [Microsoft - dotnet-new](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new)

```sh
dotnet new console --framework net5.0
dotnet run
# Mac ARM64 for .NET 5
dotnetx64 run

dotnet new sln
dotnet sln add 01-HarshaBank.Presentation
dotnet sln list

# clean solution
dotnet clean
```

- [What is the difference between a namespace, a class, an object and an instance?](https://stackoverflow.com/questions/819793/what-is-the-difference-between-a-namespace-a-class-an-object-and-an-instance)
- [What's the main difference between int.Parse() and Convert.ToInt32](https://stackoverflow.com/questions/199470/whats-the-main-difference-between-int-parse-and-convert-toint32)

&nbsp;

---

&nbsp;

> **indie:** Is it safe to use static field without singleton pattern?
> Singleton guarantee only one object access static field at given time.

> **Web University:** This question can't be generalized.
> It depends on type of app (desktop or web) that you are developing and the framework being used to make it.
>
> For example:
>
> In desktop apps: Either of static filed or singleton pattern would be fine.
>
> In web apps: Static fields are not recommended as the app runs on client / server (request / response) model. Alternatively, singleton with dependency injection is recommended there.

&nbsp;

---

&nbsp;

> **Michael:** Since the this keyword is optional in C# (unless like you say the parameter has the same name), what do most production quality code prefer?<br/>
> Is there a style standard for C#?

> **Web University:**
>
> **In constructors:**
> Constructor parameters (with same name as field names) is recommended in real-world projects (to easily identify which parameter is for which field).
>
> **In methods:**
> Accessing fields / properties from other places (from methods) would not require explicit usage of 'this' keyword - except in some rare cases you might have a local variable with same name.

&nbsp;

---

&nbsp;

> **Javier:** dot and comma in type conversion
> My question is about type conversion. I was wondering if the type conversion will take into account the national characters used as decimal point and as thousand separator. As you know this characters differs in several countries around the world. Thank you

> **Web University:**
>
> Natural languages (with specific to a country) is recognised as Culture in .net.
> The default culture is "InvariantCulture" (no specific language).
> You can set your specific culture as follows:

```c#
    using System.Globalization;

    CultureInfo ci = new CultureInfo("en-US");
    Thread.CurrentThread.CurrentCulture = ci;
    Thread.CurrentThread.CurrentUICulture = ci;
```

> Ref: [StackOverflow](https://stackoverflow.com/questions/13354211/how-to-set-default-culture-info-for-entire-c-sharp-application) & [Phrase Blog](https://phrase.com/blog/posts/all-you-need-to-know-about-cultureinfo-in-net-applications/)

&nbsp;

---

&nbsp;
