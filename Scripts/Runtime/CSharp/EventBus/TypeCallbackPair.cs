using System;

namespace IUP.Toolkits
{
    public readonly struct TypeCallbackPair : IEquatable<TypeCallbackPair>
    {
        public TypeCallbackPair(Type type, Delegate callback)
        {
            Type = type;
            Callback = callback;
        }

        public readonly Type Type { get; }
        public readonly Delegate Callback { get; }

        public override int GetHashCode() => HashCode.Combine(Type, Callback);

        public override bool Equals(object obj)
        {
            if (obj is TypeCallbackPair other)
            {
                return Equals(other);
            }
            return false;
        }

        public bool Equals(TypeCallbackPair other)
            => (Type == other.Type) && (Callback == other.Callback);

        public static bool operator ==(TypeCallbackPair a, TypeCallbackPair b) => a.Equals(b);

        public static bool operator !=(TypeCallbackPair a, TypeCallbackPair b) => !a.Equals(b);
    }
}
