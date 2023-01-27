﻿using System;

namespace Skateboard3Server.Common;

public static class TimeUtil
{
    public static uint GetUnixTimestamp()
    {
        //https://stackoverflow.com/a/17632585
        return (uint)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
    }

    public static ulong GetUnixTimestampMilliseconds()
    {
        return (ulong)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
    }
}