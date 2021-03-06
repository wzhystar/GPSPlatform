﻿using System;
using System.Threading.Tasks;

namespace GPS.PubSub.Abstractions
{
    public interface IProducer:IPubSub, IDisposable
    {
        void ProduceAsync(string key, byte[] data);
    }
}
