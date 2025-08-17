using System;

namespace IUP.Toolkits.Editor
{
    [Flags]
    public enum AcessModifier
    {
        Public = 1,
        Protected = 2,
        Private = 4,
        Internal = 8,
        ProtectedInternal = Private | Internal,
        PrivateProtected = Private | Protected
    }
}
