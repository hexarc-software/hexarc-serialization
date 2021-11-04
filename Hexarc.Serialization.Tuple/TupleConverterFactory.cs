namespace Hexarc.Serialization.Tuple;

public sealed class TupleConverterFactory : JsonConverterFactory
{
    private static readonly String TupleTypeName = typeof(ValueTuple).FullName!;

    public override Boolean CanConvert(Type typeToConvert) =>
        typeToConvert.FullName!.StartsWith(TupleTypeName);

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var arguments = typeToConvert.GetGenericArguments();
        var converterType = arguments.Length switch
        {
            1 => typeof(TupleConverter<>),
            2 => typeof(TupleConverter<,>),
            3 => typeof(TupleConverter<,,>),
            4 => typeof(TupleConverter<,,,>),
            5 => typeof(TupleConverter<,,,,>),
            6 => typeof(TupleConverter<,,,,,>),
            7 => typeof(TupleConverter<,,,,,,>),
            8 => typeof(TupleConverter<,,,,,,,>),
            _ => throw new NotSupportedException()
        };
        return Activator.CreateInstance(converterType.MakeGenericType(arguments)) as JsonConverter;
    }
}
