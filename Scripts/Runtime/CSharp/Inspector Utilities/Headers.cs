using System;
using UnityEngine;

namespace IUP.Toolkits
{
    public static class Headers
    {
        [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = true, AllowMultiple = true)]
        public sealed class References : HeaderAttribute
        {
            public References() : base("References") {}
        }


        [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = true, AllowMultiple = true)]
        public sealed class Params : HeaderAttribute
        {
            public Params() : base("Params") {}
        }
    }
}
