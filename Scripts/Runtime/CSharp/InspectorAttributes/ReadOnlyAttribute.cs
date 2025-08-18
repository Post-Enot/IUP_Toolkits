using UnityEngine;

namespace IUP.Toolkits
{
    public sealed class ReadOnlyAttribute : PropertyAttribute
    {
        ReadOnlyAttribute() : base(true) {}
    }
}
