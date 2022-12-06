namespace Hexarc.Serialization.Tests;

using System;
using System.Text.Json;
using NUnit.Framework;
using Hexarc.Serialization.Tuple;

public sealed class TupleTests
{
    [Test]
    public void ReadTupleT1()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var value = JsonSerializer.Deserialize<ValueTuple<Int32>>("[1]", options);
        Console.WriteLine(value);
    }

    [Test]
    public void ReadTupleT2()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var raw = "[1, 2]";
        var value = JsonSerializer.Deserialize<(Int32, Int32)>(raw, options);
        Console.WriteLine(value);
    }

    [Test]
    public void ReadTupleT3()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var raw = "[1, 2, 3]";
        var value = JsonSerializer.Deserialize<(Int32, Int32, Int32)>(raw, options);
        Console.WriteLine(value);
    }

    [Test]
    public void ReadTupleT4()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var raw = "[1, 2, 3, 4]";
        var value = JsonSerializer.Deserialize<(Int32, Int32, Int32, Int32)>(raw, options);
        Console.WriteLine(value);
    }

    [Test]
    public void ReadTupleT5()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var raw = "[1, 2, 3, 4, 5]";
        var value = JsonSerializer.Deserialize<(Int32, Int32, Int32, Int32, Int32)>(raw, options);
        Console.WriteLine(value);
    }

    [Test]
    public void ReadTupleT6()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var raw = "[1, 2, 3, 4, 5, 6]";
        var value = JsonSerializer.Deserialize<(Int32, Int32, Int32, Int32, Int32, Int32)>(raw, options);
        Console.WriteLine(value);
    }

    [Test]
    public void ReadTupleT7()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var raw = "[1, 2, 3, 4, 5, 6, 7]";
        var value = JsonSerializer.Deserialize<(Int32, Int32, Int32, Int32, Int32, Int32, Int32)>(raw, options);
        Console.WriteLine(value);
    }

    [Test]
    public void ReadTupleT8()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var raw = "[1, 2, 3, 4, 5, 6, 7, 8]";
        var value = JsonSerializer.Deserialize<(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)>(raw, options);
        Console.WriteLine(value);
    }

    [Test]
    public void ReadTupleT9()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var raw = "[1, 2, 3, 4, 5, 6, 7, 8, 9]";
        var value =
            JsonSerializer.Deserialize<(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)>(raw, options);
        Console.WriteLine(value);
    }

    [Test]
    public void ReadTupleT10()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var raw = "[1, 2, 3, 4, 5, 6, 7, 8, 9, 10]";
        var value =
            JsonSerializer.Deserialize<(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)>(raw,
                options);
        Console.WriteLine(value);
    }

    [Test]
    public void ReadTupleT11()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var raw = "[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11]";
        var value = JsonSerializer
            .Deserialize<(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)>(raw, options);
        Console.WriteLine(value);
    }

    [Test]
    public void ReadTupleT12()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var raw = "[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12]";
        var value = JsonSerializer
            .Deserialize<(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)>(raw,
                options);
        Console.WriteLine(value);
    }

    [Test]
    public void ReadTupleT13()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var raw = "[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]";
        var value = JsonSerializer
            .Deserialize<(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)>(
                raw, options);
        Console.WriteLine(value);
    }

    [Test]
    public void ReadTupleT14()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var raw = "[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14]";
        var value = JsonSerializer
            .Deserialize<(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32,
                Int32)>(raw, options);
        Console.WriteLine(value);
    }

    [Test]
    public void ReadTupleT15()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var raw = "[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15]";
        var value = JsonSerializer
            .Deserialize<(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32,
                Int32, Int32)>(raw, options);
        Console.WriteLine(value);
    }

    [Test]
    public void ReadNestedTuple()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var expected = (1, 2, 3, 4, 5, 6, 7, 8, (1, 2, 3, 4, 5, 6, (1, 2, 3)));
        var raw = "[1,2,3,4,5,6,7,8,[1,2,3,4,5,6,[1,2,3]]]";
        var produced =
            JsonSerializer
                .Deserialize<(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, (Int32, Int32, Int32, Int32, Int32
                    , Int32, (Int32, Int32, Int32)))>(raw, options);
        Assert.AreEqual(expected, produced);
    }

    [Test]
    public void ReadTupleWithNullables()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var expected = (1, default(String), default(Int32?));
        var raw = "[1,null,null]";
        var produced = JsonSerializer.Deserialize<(Int32, String?, Int32?)>(raw, options);
        Assert.AreEqual(expected, produced);
        Console.WriteLine(produced);
    }

    [Test]
    public void WriteTupleT1()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var value = new ValueTuple<Int32>(231);
        var raw = JsonSerializer.Serialize(value, options);
        Console.WriteLine(raw);
    }

    [Test]
    public void WriteTupleT2()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var value = (1, 2);
        var raw = JsonSerializer.Serialize(value, options);
        Console.WriteLine(raw);
    }

    [Test]
    public void WriteTupleT3()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var value = (1, 2, 3);
        var raw = JsonSerializer.Serialize(value, options);
        Console.WriteLine(raw);
    }

    [Test]
    public void WriteTupleT4()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var value = (1, 2, 3, 4);
        var raw = JsonSerializer.Serialize(value, options);
        Console.WriteLine(raw);
    }

    [Test]
    public void WriteTupleT5()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var value = (1, 2, 3, 4, 5);
        var raw = JsonSerializer.Serialize(value, options);
        Console.WriteLine(raw);
    }

    [Test]
    public void WriteTupleT6()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var value = (1, 2, 3, 4, 5, 6);
        var raw = JsonSerializer.Serialize(value, options);
        Console.WriteLine(raw);
    }

    [Test]
    public void WriteTupleT7()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var value = (1, 2, 3, 4, 5, 6, 7);
        var raw = JsonSerializer.Serialize(value, options);
        Console.WriteLine(raw);
    }

    [Test]
    public void WriteTupleT8()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var value = (1, 2, 3, 4, 5, 6, 7, 8);
        var raw = JsonSerializer.Serialize(value, options);
        Console.WriteLine(raw);
    }

    [Test]
    public void WriteTupleT9()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var value = (1, 2, 3, 4, 5, 6, 7, 8, 9);
        var raw = JsonSerializer.Serialize(value, options);
        Console.WriteLine(raw);
    }

    [Test]
    public void WriteTupleT10()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var value = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        var raw = JsonSerializer.Serialize(value, options);
        Console.WriteLine(raw);
    }

    [Test]
    public void WriteTupleT11()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var value = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
        var raw = JsonSerializer.Serialize(value, options);
        Console.WriteLine(raw);
    }

    [Test]
    public void WriteTupleT12()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var value = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
        var raw = JsonSerializer.Serialize(value, options);
        Console.WriteLine(raw);
    }

    [Test]
    public void WriteTupleT13()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var value = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);
        var raw = JsonSerializer.Serialize(value, options);
        Console.WriteLine(raw);
    }

    [Test]
    public void WriteTupleT14()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var value = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);
        var raw = JsonSerializer.Serialize(value, options);
        Console.WriteLine(raw);
    }

    [Test]
    public void WriteTupleT15()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var value = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
        var raw = JsonSerializer.Serialize(value, options);
        Console.WriteLine(raw);
    }

    [Test]
    public void WriteNestedTuple()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var value = (1, 2, 3, 4, 5, 6, 7, 8, (1, 2, 3, 4, 5, 6, (1, 2, 3)));
        var expected = "[1,2,3,4,5,6,7,8,[1,2,3,4,5,6,[1,2,3]]]";
        var actual = JsonSerializer.Serialize(value, options);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void WriteTupleWithNullables()
    {
        var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
        var value = (1, default(String), default(Int32?));
        var expected = "[1,null,null]";
        var actual = JsonSerializer.Serialize(value, options);
        Assert.AreEqual(expected, actual);
        Console.WriteLine(actual);
    }
}
