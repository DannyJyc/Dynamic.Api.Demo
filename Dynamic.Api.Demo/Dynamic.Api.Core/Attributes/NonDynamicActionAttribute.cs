namespace Dynamic.Api.Demo.Dynamic.Api.Core.Attributes
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class | AttributeTargets.Method)]
    public class NonDynamicActionAttribute : Attribute
    {
    }
}
