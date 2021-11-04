namespace Hexarc.Serialization.Union;

internal static class TypeExtensions
{
    public static Func<Type, Type> CreateConcreteTypeFactory(this Type type)
    {
        if (type.IsGenericType)
        {
            var genericArgs = type.GetGenericArguments();
            return givenType => givenType.MakeGenericType(genericArgs);
        }
        else
        {
            return givenType => givenType;
        }
    }
}
