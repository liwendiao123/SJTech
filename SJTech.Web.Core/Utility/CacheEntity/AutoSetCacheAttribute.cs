using System;

namespace SJTech.Core.Utility
{
    [AttributeUsageAttribute(AttributeTargets.Property)]
    public class AutoSetCacheAttribute : Attribute
    {
        public AutoSetCacheAttribute()
        {
        }
    }
}