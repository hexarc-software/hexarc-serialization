# Serialization for advanced .NET types [![License](http://img.shields.io/:license-mit-blue.svg)](http://badges.mit-license.org)

The Hexarc Serialization project provides additional converters for the `System.Text.Json` serializer.

## Packages

|Package| Platform  |Version|Downloads|
|-------|-----------|-------|---------|
|`Hexarch.Serialization.Union`| .NET 7.0+ |[![NuGet](https://img.shields.io/nuget/v/Hexarc.Serialization.Union.svg)](https://www.nuget.org/packages/Hexarc.Serialization.Union)|[![Downloads](http://img.shields.io/nuget/dt/Hexarc.Serialization.Union.svg)](https://www.nuget.org/packages/Hexarc.Serialization.Union)|
|`Hexarch.Serialization.Tuple`| .NET 7.0+ |[![NuGet](https://img.shields.io/nuget/v/Hexarc.Serialization.Tuple.svg)](https://www.nuget.org/packages/Hexarc.Serialization.Tuple)|[![Downloads](http://img.shields.io/nuget/dt/Hexarc.Serialization.Tuple.svg)](https://www.nuget.org/packages/Hexarc.Serialization.Tuple)|

## Hexarc.Serialization.Union

The `Hexarc.Serialization.Union` package helps to serialize .NET/C# classes hierarchy as a tagged union (also known as a discriminated union).

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
    public required Double Radius { get; set; } 
}

public sealed class Square : Shape
{
    public override String Kind { get; } = nameof(Square);
    public required Double Side { get; set; }
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

## Hexarc.Serialization.Tuple

The `Hexarc.Serialization.Tuple` package helps to serialize .NET/C# value tuple types.

```c#
var settings = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };

var point = (10, 20);
Console.WriteLine(JsonSerializer.Serialize(point));

var (x, y) = JsonSerializer.Deserialize<(Int32, Int32)>(@"[10, 20]");
Console.Write($"Point coords: {x}, {y}");
```

## Acknowledgments
Built with JetBrains tools for [Open Source](https://jb.gg/OpenSourceSupport) projects.

![JetBrains Logo (Main) logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jb_beam.svg)

## License
MIT © [Hexarc Software and its contributors](https://github.com/hexarc-software)



