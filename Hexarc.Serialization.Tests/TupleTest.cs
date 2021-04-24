using System;
using System.Text.Json;
using NUnit.Framework;
using Hexarc.Serialization.Tuple;

namespace Hexarc.Serialization.Tests
{
    public class TupleTests
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
            var value = JsonSerializer.Deserialize<(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)>(raw, options);
            Console.WriteLine(value);
        }

        [Test]
        public void ReadTupleT10()
        {
            var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
            var raw = "[1, 2, 3, 4, 5, 6, 7, 8, 9, 10]";
            var value = JsonSerializer.Deserialize<(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)>(raw, options);
            Console.WriteLine(value);
        }

        [Test]
        public void ReadTupleT11()
        {
            var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
            var raw = "[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11]";
            var value = JsonSerializer.Deserialize<(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)>(raw, options);
            Console.WriteLine(value);
        }

        [Test]
        public void ReadTupleT12()
        {
            var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
            var raw = "[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12]";
            var value = JsonSerializer.Deserialize<(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)>(raw, options);
            Console.WriteLine(value);
        }

        [Test]
        public void ReadTupleT13()
        {
            var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
            var raw = "[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]";
            var value = JsonSerializer.Deserialize<(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)>(raw, options);
            Console.WriteLine(value);
        }

        [Test]
        public void ReadTupleT14()
        {
            var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
            var raw = "[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14]";
            var value = JsonSerializer.Deserialize<(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)>(raw, options);
            Console.WriteLine(value);
        }

        [Test]
        public void ReadTupleT15()
        {
            var options = new JsonSerializerOptions { Converters = { new TupleConverterFactory() } };
            var raw = "[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15]";
            var value = JsonSerializer.Deserialize<(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)>(raw, options);
            Console.WriteLine(value);
        }
    }
}
