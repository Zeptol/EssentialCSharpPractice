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
        Queued=2,
        Encrypted=4,
        Persisted=16,
        FaultTolerant=Transacted|Queued|Persisted
    }
}
