using System;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Hexarc.Serialization.Tuple
{
    internal static class Utf8JsonWriterExtensions
    {
        public static void WriteTuple<T1>(
            this Utf8JsonWriter writer,
            ValueTuple<T1> tuple,
            JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            writer.WriteValue(tuple.Item1, options);
            writer.WriteEndArray();
        }

        public static void WriteTuple<T1, T2>(
            this Utf8JsonWriter writer,
            ValueTuple<T1, T2> tuple,
            JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            writer.WriteValue(tuple.Item1, options);
            writer.WriteValue(tuple.Item2, options);
            writer.WriteEndArray();
        }

        public static void WriteTuple<T1, T2, T3>(
            this Utf8JsonWriter writer,
            ValueTuple<T1, T2, T3> tuple,
            JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            writer.WriteValue(tuple.Item1, options);
            writer.WriteValue(tuple.Item2, options);
            writer.WriteValue(tuple.Item3, options);
            writer.WriteEndArray();
        }

        public static void WriteTuple<T1, T2, T3, T4>(
            this Utf8JsonWriter writer,
            ValueTuple<T1, T2, T3, T4> tuple,
            JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            writer.WriteValue(tuple.Item1, options);
            writer.WriteValue(tuple.Item2, options);
            writer.WriteValue(tuple.Item3, options);
            writer.WriteValue(tuple.Item4, options);
            writer.WriteEndArray();
        }

        public static void WriteTuple<T1, T2, T3, T4, T5>(
            this Utf8JsonWriter writer,
            ValueTuple<T1, T2, T3, T4, T5> tuple,
            JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            writer.WriteValue(tuple.Item1, options);
            writer.WriteValue(tuple.Item2, options);
            writer.WriteValue(tuple.Item3, options);
            writer.WriteValue(tuple.Item4, options);
            writer.WriteValue(tuple.Item5, options);
            writer.WriteEndArray();
        }

        public static void WriteTuple<T1, T2, T3, T4, T5, T6>(
            this Utf8JsonWriter writer,
            ValueTuple<T1, T2, T3, T4, T5, T6> tuple,
            JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            writer.WriteValue(tuple.Item1, options);
            writer.WriteValue(tuple.Item2, options);
            writer.WriteValue(tuple.Item3, options);
            writer.WriteValue(tuple.Item4, options);
            writer.WriteValue(tuple.Item5, options);
            writer.WriteValue(tuple.Item6, options);
            writer.WriteEndArray();
        }

        public static void WriteTuple<T1, T2, T3, T4, T5, T6, T7>(
            this Utf8JsonWriter writer,
            ValueTuple<T1, T2, T3, T4, T5, T6, T7> tuple,
            JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            writer.WriteValue(tuple.Item1, options);
            writer.WriteValue(tuple.Item2, options);
            writer.WriteValue(tuple.Item3, options);
            writer.WriteValue(tuple.Item4, options);
            writer.WriteValue(tuple.Item5, options);
            writer.WriteValue(tuple.Item6, options);
            writer.WriteValue(tuple.Item7, options);
            writer.WriteEndArray();
        }

        public static void WriteTuple<T1, T2, T3, T4, T5, T6, T7, TRest>(
            this Utf8JsonWriter writer,
            ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple,
            JsonSerializerOptions options) where TRest : struct
        {
            writer.WriteStartArray();
            writer.WriteValue(tuple.Item1, options);
            writer.WriteValue(tuple.Item2, options);
            writer.WriteValue(tuple.Item3, options);
            writer.WriteValue(tuple.Item4, options);
            writer.WriteValue(tuple.Item5, options);
            writer.WriteValue(tuple.Item6, options);
            writer.WriteValue(tuple.Item7, options);
            writer.WriteRestTuple((tuple.Rest as ITuple)!, options);
            writer.WriteEndArray();
        }

        private static void WriteRestTuple(this Utf8JsonWriter writer, ITuple tuple, JsonSerializerOptions options)
        {
            for (var i = 0; i < tuple.Length; i++)
            {
                writer.WriteValue(tuple[i], options);
            }
        }

        private static void WriteValue<T>(this Utf8JsonWriter writer, T value, JsonSerializerOptions options) =>
            JsonSerializer.Serialize(writer, value, options);
    }
}
