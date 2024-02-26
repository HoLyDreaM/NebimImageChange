using System;

namespace NebimResimSiralama.Data
{
    [AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false)]
    public sealed class ExplicitConstructorAttribute : Attribute
    {
    }
}

