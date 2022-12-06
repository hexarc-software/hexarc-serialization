namespace Hexarc.Serialization.Union;

public abstract class UnionCaseBaseAttribute : Attribute
{
    public Type CaseType { get; }

    public String TagPropertyValue { get; }

    internal UnionCaseBaseAttribute(Type caseType, String tagPropertyValue) =>
        (this.CaseType, this.TagPropertyValue) = (caseType, tagPropertyValue);
}

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class UnionCaseAttribute : UnionCaseBaseAttribute
{
    public UnionCaseAttribute(Type caseType, String tagPropertyValue) : 
        base(caseType, tagPropertyValue) { }
}

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class UnionCaseAttribute<T> : UnionCaseBaseAttribute
{
    public UnionCaseAttribute(String tagPropertyValue) : 
        base(typeof(T), tagPropertyValue) { }
}