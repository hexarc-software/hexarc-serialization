namespace Hexarc.Serialization.Union;

public sealed class UnionConverter<T> : JsonConverter<T> where T : class
{
    private String TagPropertyName { get; }

    private Dictionary<String, Type> UnionTypes { get; }

    public UnionConverter()
    {
        var type = typeof(T);
        var unionTag = type.GetCustomAttribute<UnionTagAttribute>();
        if (unionTag is null) throw new InvalidOperationException();

        var concreteTypeFactory = type.CreateConcreteTypeFactory();
        this.TagPropertyName = unionTag.TagPropertyName;
        this.UnionTypes = type.GetCustomAttributes<UnionCaseBaseAttribute>()
            .ToDictionary(k => k.TagPropertyValue, e => concreteTypeFactory(e.CaseType));
    }

    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var rootElement = document.RootElement;
        var propertyName = options.PropertyNamingPolicy?.ConvertName(this.TagPropertyName) ?? this.TagPropertyName;
        var property = rootElement.GetProperty(propertyName);
        var type = this.UnionTypes[property.GetString() ?? throw new InvalidOperationException()];
        return (T?)rootElement.Deserialize(type, options);
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options) =>
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
}
