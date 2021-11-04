namespace Hexarc.Serialization.Union;

public sealed class UnionConverterFactory : JsonConverterFactory
{
    public override Boolean CanConvert(Type typeToConvert) =>
        typeToConvert.GetCustomAttribute<UnionTagAttribute>(false) is not null;

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var converterType = typeof(UnionConverter<>).MakeGenericType(typeToConvert);
        return (JsonConverter?)Activator.CreateInstance(converterType);
    }
}
