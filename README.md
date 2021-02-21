# Hexarc Serialization

The Hexarc Serialization project provides additional converters for the `System.Text.Json` serializer.

## Hexarc.Serialization.Union

[![NuGet](https://img.shields.io/nuget/v/Hexarc.Serialization.Union.svg)](https://www.nuget.org/packages/Hexarc.Serialization.Union)
[![Downloads](http://img.shields.io/nuget/dt/Hexarc.Serialization.Union.svg)](https://www.nuget.org/packages/Hexarc.Serialization.Union)
[![License](http://img.shields.io/:license-mit-blue.svg)](http://badges.mit-license.org)

The `Hexarc.Serialization.Union` package helps to serialize .NET/C# classes as a tagged union (also known as discriminated union).

### A tagged union example
```c#
[UnionTag(nameof(Kind))]
[UnionCase(typeof(Circle), nameof(Circle))]
[UnionCase(typeof(Square), nameof(Square))]
public abstract class Shape
{
    public abstract String Kind { get; }
}

public sealed class Circle : Shape
{
    public override String Kind { get; } = nameof(Circle);
    public Double Radius { get; set; } 
}

public sealed class Square : Shape
{
    public override String Kind { get; } = nameof(Square);
    public Double Side { get; set; }
}
```

In the example above the `UnionTag` attribute marks the union tag and the `UnionCase` attribute 
marks a known subtype (or a case class) of the `Shape` class.

### Serialization and deserialization of the tagged union
```c#
var settings = new JsonSerializerOptions { Converters = { new UnionConverterFactory() } };

var square = new Square { Side = 15.0 };
Console.WriteLine(JsonSerializer.Serialize(square));

var shape = JsonSerializer.Deserialize<Shape>(@"{ ""Kind"": ""Circle"", ""Radius"": 10.0 }");
Console.Write((shape as Circle)!.Radius);
```

Some technical details about the tagged union converter implementation can be found in [this article](https://shadeglare.medium.com/mimic-discriminating-union-types-in-c-with-serialization-via-system-text-json-3da67ef58dc0).



