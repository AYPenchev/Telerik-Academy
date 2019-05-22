namespace Task1
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class VersionAttribute : Attribute
    {
        public VersionAttribute()
        {
            this.Version = string.Empty;
        }

        public string Version { get; set; }
    }
}
