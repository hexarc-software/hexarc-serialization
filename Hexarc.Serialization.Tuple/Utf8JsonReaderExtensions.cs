using System;
using System.Text.Json;

namespace Hexarc.Serialization.Tuple
{
    internal static class Utf8JsonReaderExtensions
    {
        public static ValueTuple<T1> ReadTuple<T1>(
            this ref Utf8JsonReader reader,
            JsonSerializerOptions options)
        {
            reader.ReadArrayStart();
            var t1 = reader.ReadTupleFirstItem<T1>(options);
            reader.ReadArrayEnd();
            return new ValueTuple<T1>(t1);
        }

        public static ValueTuple<T1, T2> ReadTuple<T1, T2>(
            this ref Utf8JsonReader reader,
            JsonSerializerOptions options)
        {
            reader.ReadArrayStart();
            var t1 = reader.ReadTupleFirstItem<T1>(options);
            var t2 = reader.ReadTupleNotFirsItem<T2>(options);
            reader.ReadArrayEnd();
            return new ValueTuple<T1, T2>(t1, t2);
        }

        public static ValueTuple<T1, T2, T3> ReadTuple<T1, T2, T3>(
            this ref Utf8JsonReader reader,
            JsonSerializerOptions options)
        {
            reader.ReadArrayStart();
            var t1 = reader.ReadTupleFirstItem<T1>(options);
            var t2 = reader.ReadTupleNotFirsItem<T2>(options);
            var t3 = reader.ReadTupleNotFirsItem<T3>(options);
            reader.ReadArrayEnd();
            return new ValueTuple<T1, T2, T3>(t1, t2, t3);
        }

        public static ValueTuple<T1, T2, T3, T4> ReadTuple<T1, T2, T3, T4>(
            this ref Utf8JsonReader reader,
            JsonSerializerOptions options)
        {
            reader.ReadArrayStart();
            var t1 = reader.ReadTupleFirstItem<T1>(options);
            var t2 = reader.ReadTupleNotFirsItem<T2>(options);
            var t3 = reader.ReadTupleNotFirsItem<T3>(options);
            var t4 = reader.ReadTupleNotFirsItem<T4>(options);
            reader.ReadArrayEnd();
            return new ValueTuple<T1, T2, T3, T4>(t1, t2, t3, t4);
        }

        public static ValueTuple<T1, T2, T3, T4, T5> ReadTuple<T1, T2, T3, T4, T5>(
            this ref Utf8JsonReader reader,
            JsonSerializerOptions options)
        {
            reader.ReadArrayStart();
            var t1 = reader.ReadTupleFirstItem<T1>(options);
            var t2 = reader.ReadTupleNotFirsItem<T2>(options);
            var t3 = reader.ReadTupleNotFirsItem<T3>(options);
            var t4 = reader.ReadTupleNotFirsItem<T4>(options);
            var t5 = reader.ReadTupleNotFirsItem<T5>(options);
            reader.ReadArrayEnd();
            return new ValueTuple<T1, T2, T3, T4, T5>(t1, t2, t3, t4, t5);
        }

        public static ValueTuple<T1, T2, T3, T4, T5, T6> ReadTuple<T1, T2, T3, T4, T5, T6>(
            this ref Utf8JsonReader reader,
            JsonSerializerOptions options)
        {
            reader.ReadArrayStart();
            var t1 = reader.ReadTupleFirstItem<T1>(options);
            var t2 = reader.ReadTupleNotFirsItem<T2>(options);
            var t3 = reader.ReadTupleNotFirsItem<T3>(options);
            var t4 = reader.ReadTupleNotFirsItem<T4>(options);
            var t5 = reader.ReadTupleNotFirsItem<T5>(options);
            var t6 = reader.ReadTupleNotFirsItem<T6>(options);
            reader.ReadArrayEnd();
            return new ValueTuple<T1, T2, T3, T4, T5, T6>(t1, t2, t3, t4, t5, t6);
        }

        public static ValueTuple<T1, T2, T3, T4, T5, T6, T7> ReadTuple<T1, T2, T3, T4, T5, T6, T7>(
            this ref Utf8JsonReader reader,
            JsonSerializerOptions options)
        {
            reader.ReadArrayStart();
            var t1 = reader.ReadTupleFirstItem<T1>(options);
            var t2 = reader.ReadTupleNotFirsItem<T2>(options);
            var t3 = reader.ReadTupleNotFirsItem<T3>(options);
            var t4 = reader.ReadTupleNotFirsItem<T4>(options);
            var t5 = reader.ReadTupleNotFirsItem<T5>(options);
            var t6 = reader.ReadTupleNotFirsItem<T6>(options);
            var t7 = reader.ReadTupleNotFirsItem<T7>(options);
            reader.ReadArrayEnd();
            return new ValueTuple<T1, T2, T3, T4, T5, T6, T7>(t1, t2, t3, t4, t5, t6, t7);
        }

        public static ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> ReadTuple<T1, T2, T3, T4, T5, T6, T7, TRest>(
            this ref Utf8JsonReader reader, JsonSerializerOptions options) where TRest : struct
        {
            reader.ReadArrayStart();
            var t1 = reader.ReadTupleFirstItem<T1>(options);
            var t2 = reader.ReadTupleNotFirsItem<T2>(options);
            var t3 = reader.ReadTupleNotFirsItem<T3>(options);
            var t4 = reader.ReadTupleNotFirsItem<T4>(options);
            var t5 = reader.ReadTupleNotFirsItem<T5>(options);
            var t6 = reader.ReadTupleNotFirsItem<T6>(options);
            var t7 = reader.ReadTupleNotFirsItem<T7>(options);
            var rest = reader.ReadRestTuple<TRest>(options);
            reader.ReadArrayEnd();
            return new ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>(t1, t2, t3, t4, t5, t6, t7, rest);
        }

        private static TRest ReadRestTuple<TRest>(this ref Utf8JsonReader reader, JsonSerializerOptions options)
            where TRest : struct => (TRest) reader.ReadRestTuple(typeof(TRest), options);

        private static Object ReadRestTuple(this ref Utf8JsonReader reader, Type restTupleType, JsonSerializerOptions options)
        {
            var args = restTupleType.GetGenericArguments();
            return args.Length switch
            {
                1 => reader.ReadTuple(args[0], options),
                2 => reader.ReadTuple(args[0], args[1], options),
                3 => reader.ReadTuple(args[0], args[1], args[2], options),
                4 => reader.ReadTuple(args[0], args[1], args[2], args[3], options),
                5 => reader.ReadTuple(args[0], args[1], args[2], args[3], args[4], options),
                6 => reader.ReadTuple(args[0], args[1], args[2], args[3], args[4], args[5], options),
                7 => reader.ReadTuple(args[0], args[1], args[2], args[3], args[4], args[5], args[6], options),
                8 => reader.ReadTuple(args[0], args[1], args[2], args[3], args[4], args[5], args[6], args[7], options),
                _ => throw new NotSupportedException()
            };
        }

        public static Object ReadTuple(
            this ref Utf8JsonReader reader,
            Type firstElementType,
            JsonSerializerOptions options)
        {
            var template = typeof(ValueTuple<>);
            var concrete = template.MakeGenericType(firstElementType);
            var t1 = reader.ReadTupleNotFirsItem(firstElementType, options);
            return Activator.CreateInstance(concrete, t1)!;
        }

        public static Object ReadTuple(
            this ref Utf8JsonReader reader,
            Type firstElementType,
            Type secondElementType,
            JsonSerializerOptions options)
        {
            var template = typeof(ValueTuple<,>);
            var concrete = template.MakeGenericType(firstElementType, secondElementType);
            var t1 = reader.ReadTupleNotFirsItem(firstElementType, options);
            var t2 = reader.ReadTupleNotFirsItem(secondElementType, options);
            return Activator.CreateInstance(concrete, t1, t2)!;
        }

        public static Object ReadTuple(
            this ref Utf8JsonReader reader,
            Type firstElementType,
            Type secondElementType,
            Type thirdElementType,
            JsonSerializerOptions options)
        {
            var template = typeof(ValueTuple<,,>);
            var concrete = template.MakeGenericType(firstElementType, secondElementType, thirdElementType);
            var t1 = reader.ReadTupleNotFirsItem(firstElementType, options);
            var t2 = reader.ReadTupleNotFirsItem(secondElementType, options);
            var t3 = reader.ReadTupleNotFirsItem(thirdElementType, options);
            return Activator.CreateInstance(concrete, t1, t2, t3)!;
        }

        public static Object ReadTuple(
            this ref Utf8JsonReader reader,
            Type firstElementType,
            Type secondElementType,
            Type thirdElementType,
            Type forthElementType,
            JsonSerializerOptions options)
        {
            var template = typeof(ValueTuple<,,,>);
            var concrete = template.MakeGenericType(
                firstElementType, secondElementType, thirdElementType, forthElementType);
            var t1 = reader.ReadTupleNotFirsItem(firstElementType, options);
            var t2 = reader.ReadTupleNotFirsItem(secondElementType, options);
            var t3 = reader.ReadTupleNotFirsItem(thirdElementType, options);
            var t4 = reader.ReadTupleNotFirsItem(forthElementType, options);
            return Activator.CreateInstance(concrete, t1, t2, t3, t4)!;
        }

        public static Object ReadTuple(
            this ref Utf8JsonReader reader,
            Type firstElementType,
            Type secondElementType,
            Type thirdElementType,
            Type forthElementType,
            Type fifthElementType,
            JsonSerializerOptions options)
        {
            var template = typeof(ValueTuple<,,,,>);
            var concrete = template.MakeGenericType(
                firstElementType, secondElementType, thirdElementType, forthElementType, fifthElementType);
            var t1 = reader.ReadTupleNotFirsItem(firstElementType, options);
            var t2 = reader.ReadTupleNotFirsItem(secondElementType, options);
            var t3 = reader.ReadTupleNotFirsItem(thirdElementType, options);
            var t4 = reader.ReadTupleNotFirsItem(forthElementType, options);
            var t5 = reader.ReadTupleNotFirsItem(fifthElementType, options);
            return Activator.CreateInstance(concrete, t1, t2, t3, t4, t5)!;
        }

        public static Object ReadTuple(
            this ref Utf8JsonReader reader,
            Type firstElementType,
            Type secondElementType,
            Type thirdElementType,
            Type forthElementType,
            Type fifthElementType,
            Type sixthElementType,
            JsonSerializerOptions options)
        {
            var template = typeof(ValueTuple<,,,,,>);
            var concrete = template.MakeGenericType(
                firstElementType, secondElementType, thirdElementType, forthElementType,
                fifthElementType, sixthElementType);
            var t1 = reader.ReadTupleNotFirsItem(firstElementType, options);
            var t2 = reader.ReadTupleNotFirsItem(secondElementType, options);
            var t3 = reader.ReadTupleNotFirsItem(thirdElementType, options);
            var t4 = reader.ReadTupleNotFirsItem(forthElementType, options);
            var t5 = reader.ReadTupleNotFirsItem(fifthElementType, options);
            var t6 = reader.ReadTupleNotFirsItem(sixthElementType, options);
            return Activator.CreateInstance(concrete, t1, t2, t3, t4, t5, t6)!;
        }

        public static Object ReadTuple(
            this ref Utf8JsonReader reader,
            Type firstElementType,
            Type secondElementType,
            Type thirdElementType,
            Type forthElementType,
            Type fifthElementType,
            Type sixthElementType,
            Type seventhElementType,
            JsonSerializerOptions options)
        {
            var template = typeof(ValueTuple<,,,,,,>);
            var concrete = template.MakeGenericType(
                firstElementType, secondElementType, thirdElementType, forthElementType,
                fifthElementType, sixthElementType, seventhElementType);
            var t1 = reader.ReadTupleNotFirsItem(firstElementType, options);
            var t2 = reader.ReadTupleNotFirsItem(secondElementType, options);
            var t3 = reader.ReadTupleNotFirsItem(thirdElementType, options);
            var t4 = reader.ReadTupleNotFirsItem(forthElementType, options);
            var t5 = reader.ReadTupleNotFirsItem(fifthElementType, options);
            var t6 = reader.ReadTupleNotFirsItem(sixthElementType, options);
            var t7 = reader.ReadTupleNotFirsItem(seventhElementType, options);
            return Activator.CreateInstance(concrete, t1, t2, t3, t4, t5, t6, t7)!;
        }

        public static Object ReadTuple(
            this ref Utf8JsonReader reader,
            Type firstElementType,
            Type secondElementType,
            Type thirdElementType,
            Type forthElementType,
            Type fifthElementType,
            Type sixthElementType,
            Type seventhElementType,
            Type restElementType,
            JsonSerializerOptions options)
        {
            var template = typeof(ValueTuple<,,,,,,,>);
            var concrete = template.MakeGenericType(
                firstElementType, secondElementType, thirdElementType, forthElementType, fifthElementType,
                sixthElementType, seventhElementType, restElementType);
            var t1 = reader.ReadTupleNotFirsItem(firstElementType, options);
            var t2 = reader.ReadTupleNotFirsItem(secondElementType, options);
            var t3 = reader.ReadTupleNotFirsItem(thirdElementType, options);
            var t4 = reader.ReadTupleNotFirsItem(forthElementType, options);
            var t5 = reader.ReadTupleNotFirsItem(fifthElementType, options);
            var t6 = reader.ReadTupleNotFirsItem(sixthElementType, options);
            var t7 = reader.ReadTupleNotFirsItem(seventhElementType, options);
            var t8 = reader.ReadRestTuple(restElementType, options);
            return Activator.CreateInstance(concrete, t1, t2, t3, t4, t5, t6, t7, t8)!;
        }

        private static T ReadTupleFirstItem<T>(this ref Utf8JsonReader reader, JsonSerializerOptions options) =>
            reader.ReadValue<T>(options)!;

        private static T ReadTupleNotFirsItem<T>(this ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            _ = reader.Read();
            return reader.ReadValue<T>(options)!;
        }

        private static Object ReadTupleNotFirsItem(this ref Utf8JsonReader reader, Type typeToRead, JsonSerializerOptions options)
        {
            _ = reader.Read();
            return reader.ReadValue(typeToRead, options)!;
        }

        private static void ReadArrayStart(this ref Utf8JsonReader reader)
        {
            if (reader.TokenType != JsonTokenType.StartArray) throw new JsonException();
            _ = reader.Read();
        }

        private static void ReadArrayEnd(this ref Utf8JsonReader reader)
        {
            _ = reader.Read();
            if (reader.TokenType != JsonTokenType.EndArray) throw new JsonException();
        }

        private static T? ReadValue<T>(this ref Utf8JsonReader reader, JsonSerializerOptions options) =>
            JsonSerializer.Deserialize<T>(ref reader, options);

        private static Object? ReadValue(this ref Utf8JsonReader reader, Type typeToRead, JsonSerializerOptions options) =>
            JsonSerializer.Deserialize(ref reader, typeToRead, options);
    }
}
