using System;

namespace IUP.Toolkits
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public sealed class TypeViewAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
