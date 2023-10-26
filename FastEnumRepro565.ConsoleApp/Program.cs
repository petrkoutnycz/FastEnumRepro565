// See https://aka.ms/new-console-template for more information

using FastEnumRepro565.Project1;
using FastEnumRepro565.Project2;
using FastEnumRepro565.Project3;

var referencingEnumInstance = new ReferencingEnum3Class(Enum3.Value1);

Console.WriteLine($"Hello, World {Enum1.Value1.ToStringFast()} and {Enum2.Value2.ToStringFast()} or {Enum3.Value1.ToStringFast()}!");