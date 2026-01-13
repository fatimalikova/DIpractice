

//DI => Dependency Injection

// IoC => Inversion of Control
// IoC Container => Inversion of Control Container
// NuGet Package: Microsoft.Extensions.DependencyInjection
//Tight Coupling vs Loose Coupling
//Dependency Injection => Constructor Injection, Property Injection, Method Injection   

using IoCandDI.Services;
using IoCandDI.Repositories;
using IoCandDI.Models;

StudentService studentService = new StudentService(new StudentRepository());
studentService.CreateStudent();
Console.WriteLine("Student created successfully.");


