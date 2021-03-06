﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OneHour.Linq
{
    public interface ILookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>
    {
        bool Contains(TKey key);
        int Count { get; }
        IEnumerable<TElement> this[TKey key] { get; }
    }
}
