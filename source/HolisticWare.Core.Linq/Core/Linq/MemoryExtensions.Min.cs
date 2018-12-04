﻿using System;

namespace Core.Linq
{
    public static class MemoryExtensionsMin
    {
        public static double Min(this Memory<byte> memory)
        {
            return memory.Span.Min();
        }

        public static double Min(this Memory<short> memory)
        {
            return memory.Span.Min();
        }

        public static double Min(this Memory<ushort> memory)
        {
            return memory.Span.Min();
        }

        public static double Min(this Memory<int> memory)
        {
            return memory.Span.Min();
        }

        public static double Min(this Memory<uint> memory)
        {
            return memory.Span.Min();
        }

        public static double Min(this Memory<long> memory)
        {
            return memory.Span.Min();
        }

        public static double Min(this Memory<ulong> memory)
        {
            return memory.Span.Min();
        }

        public static double Min(this Memory<float> memory)
        {
            return memory.Span.Min();
        }

        public static double Min(this Memory<double> memory)
        {
            return memory.Span.Min();
        }

        public static decimal Min(this Memory<decimal> memory)
        {
            return memory.Span.Min();
        }
    }
}
