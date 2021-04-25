using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Hexarc.Serialization.Tuple
{
    public sealed class TupleConverter<T1> : JsonConverter<ValueTuple<T1>>
    {
        public override ValueTuple<T1> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            reader.ReadTuple<T1>(options);

        public override void Write(Utf8JsonWriter writer, ValueTuple<T1> value, JsonSerializerOptions options) =>
            writer.WriteTuple(value, options);
    }

    public sealed class TupleConverter<T1, T2> : JsonConverter<ValueTuple<T1, T2>>
    {
        public override ValueTuple<T1, T2> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            reader.ReadTuple<T1, T2>(options);

        public override void Write(Utf8JsonWriter writer, ValueTuple<T1, T2> value, JsonSerializerOptions options) =>
            writer.WriteTuple(value, options);
    }

    public sealed class TupleConverter<T1, T2, T3> : JsonConverter<ValueTuple<T1, T2, T3>>
    {
        public override ValueTuple<T1, T2, T3> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            reader.ReadTuple<T1, T2, T3>(options);

        public override void Write(Utf8JsonWriter writer, ValueTuple<T1, T2, T3> value, JsonSerializerOptions options) =>
            writer.WriteTuple(value, options);
    }

    public sealed class TupleConverter<T1, T2, T3, T4> : JsonConverter<ValueTuple<T1, T2, T3, T4>>
    {
        public override ValueTuple<T1, T2, T3, T4> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            reader.ReadTuple<T1, T2, T3, T4>(options);

        public override void Write(Utf8JsonWriter writer, ValueTuple<T1, T2, T3, T4> value, JsonSerializerOptions options) =>
            writer.WriteTuple(value, options);
    }

    public sealed class TupleConverter<T1, T2, T3, T4, T5> : JsonConverter<ValueTuple<T1, T2, T3, T4, T5>>
    {
        public override ValueTuple<T1, T2, T3, T4, T5> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            reader.ReadTuple<T1, T2, T3, T4, T5>(options);

        public override void Write(Utf8JsonWriter writer, ValueTuple<T1, T2, T3, T4, T5> value, JsonSerializerOptions options) =>
            writer.WriteTuple(value, options);
    }

    public sealed class TupleConverter<T1, T2, T3, T4, T5, T6> : JsonConverter<ValueTuple<T1, T2, T3, T4, T5, T6>>
    {
        public override ValueTuple<T1, T2, T3, T4, T5, T6> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            reader.ReadTuple<T1, T2, T3, T4, T5, T6>(options);

        public override void Write(Utf8JsonWriter writer, ValueTuple<T1, T2, T3, T4, T5, T6> value, JsonSerializerOptions options) =>
            writer.WriteTuple(value, options);
    }

    public sealed class TupleConverter<T1, T2, T3, T4, T5, T6, T7> : JsonConverter<ValueTuple<T1, T2, T3, T4, T5, T6, T7>>
    {
        public override ValueTuple<T1, T2, T3, T4, T5, T6, T7> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            reader.ReadTuple<T1, T2, T3, T4, T5, T6, T7>(options);

        public override void Write(Utf8JsonWriter writer, ValueTuple<T1, T2, T3, T4, T5, T6, T7> value, JsonSerializerOptions options) =>
            writer.WriteTuple(value, options);
    }

    public sealed class TupleConverter<T1, T2, T3, T4, T5, T6, T7, TRest> : JsonConverter<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>> where TRest : struct
    {
        public override ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            reader.ReadTuple<T1, T2, T3, T4, T5, T6, T7, TRest>(options);

        public override void Write(Utf8JsonWriter writer, ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> value, JsonSerializerOptions options) =>
            writer.WriteTuple<T1, T2, T3, T4, T5, T6, T7, TRest>(value, options);
    }
}
