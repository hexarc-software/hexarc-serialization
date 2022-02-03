using System;
using System.Text.Json;
using Hexarc.Annotations;
using Hexarc.Serialization.Union;
using NUnit.Framework;

namespace Hexarc.Serialization.Tests;

public class DuTests
{
    [Test]
    public void SerializeCircle()
    {
        var options = new JsonSerializerOptions { Converters = { new UnionConverterFactory() } };
        var circle = new Circle { Radius = 20.0 };
        Console.WriteLine(JsonSerializer.Serialize(circle, options));
    }

    [Test]
    public void SerializeSquare()
    {
        var options = new JsonSerializerOptions { Converters = { new UnionConverterFactory() } };
        var circle = new Square { SideLength = 12.0 };
        Console.WriteLine(JsonSerializer.Serialize(circle, options));
    }

    [Test]
    public void SerializeNullCase()
    {
        var options = new JsonSerializerOptions { Converters = { new UnionConverterFactory() } };
        var circle = default(Circle);
        Console.WriteLine(JsonSerializer.Serialize(circle, options));
    }

    [Test]
    public void DeserializeCircle()
    {
        var options = new JsonSerializerOptions { Converters = { new UnionConverterFactory() } };
        var raw = @"{""Kind"":""Circle"",""Radius"":20}";
        var figure = JsonSerializer.Deserialize<Figure>(raw, options);
        Assert.AreEqual(JsonSerializer.Serialize(figure, options), raw);
    }

    [Test]
    public void DeserializeSquare()
    {
        var options = new JsonSerializerOptions { Converters = { new UnionConverterFactory() } };
        var raw = @"{""Kind"":""Square"",""SideLength"":12}";
        var figure = JsonSerializer.Deserialize<Figure>(raw, options);
        Assert.AreEqual(JsonSerializer.Serialize(figure, options), raw);
    }

    [Test]
    public void DeserializeNullCase()
    {
        var options = new JsonSerializerOptions { Converters = { new UnionConverterFactory() } };
        var raw = @"null";
        var figure = JsonSerializer.Deserialize<Figure>(raw, options);
        Assert.AreEqual(JsonSerializer.Serialize(figure, options), raw);
    }
}

[UnionTag(nameof(Kind))]
[UnionCase(typeof(Circle), nameof(Circle))]
[UnionCase(typeof(Square), nameof(Square))]
public abstract class Figure
{
    public abstract String Kind { get; }
}

public sealed class Circle : Figure
{
    public override String Kind => nameof(Circle);

    public Double Radius { get; init; }
}

public sealed class Square : Figure
{
    public override String Kind => nameof(Square);

    public Double SideLength { get; init; }
}
