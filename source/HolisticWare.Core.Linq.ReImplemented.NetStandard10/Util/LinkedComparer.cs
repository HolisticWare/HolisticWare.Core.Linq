﻿using System.Collections.Generic;

namespace Core.Linq.ReImplemented.Util
{
    /// <summary>
    /// Comparer to daisy-chain two existing comparers and 
    /// apply in sequence (i.e. sort by x then y)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class LinkedComparer<T> : IComparer<T>
    {
        readonly IComparer<T> primary, secondary;
        /// <summary>
        /// Create a new LinkedComparer
        /// </summary>
        /// <param name="primary">The first comparison to use</param>
        /// <param name="secondary">The next level of comparison if the primary returns 0 (equivalent)</param>
        public LinkedComparer
                            (
                                IComparer<T> primary,
                                IComparer<T> secondary
                            )
        {
            this.primary = primary;
            this.secondary = secondary;
        }

        int IComparer<T>.Compare(T x, T y)
        {
            int result = primary.Compare(x, y);
            return result == 0 ? secondary.Compare(x, y) : result;
        }
    }
}