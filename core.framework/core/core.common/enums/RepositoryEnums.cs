using System;

namespace core.common.enums
{
    [Flags]
    public enum ModuleAction : byte
    {
        None = 0,
        Get = 1,
        Insert = 2,
        Update = 4,
        Delete = 8,
        Purge = 16
    }
}
