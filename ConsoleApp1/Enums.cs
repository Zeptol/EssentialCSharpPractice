using System;

namespace ConsoleApp1
{
    enum MyEnum:byte
    {
       A,B,C
    }

    [Flags]
    public enum DistributedChannel
    {
        None=0,
        Transacted=1,
        Queued=1<<1,
        Encrypted=1<<2,
        Persisted=1<<3,
        FaultTolerant=Transacted|Queued|Persisted
    }
}
