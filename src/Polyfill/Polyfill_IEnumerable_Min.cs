// <auto-generated />
#pragma warning disable

namespace Polyfills;

using System;
using System.Collections.Generic;
using System.Linq;

static partial class Polyfill
{

#if !NET6_0_OR_GREATER

    /// <summary>Returns the minimum value in a generic sequence.</summary>
    /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
    /// <param name="source">A sequence of values to determine the minimum value of.</param>
    /// <param name="comparer">The <see cref="IComparer{T}" /> to compare values.</param>
    /// <returns>The minimum value in the sequence.</returns>
    //Link: https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.min#system-linq-enumerable-min-1(system-collections-generic-ienumerable((-0))-system-collections-generic-icomparer((-0)))
    public static TSource? Min<TSource>(
        this IEnumerable<TSource> source,
        IComparer<TSource>? comparer) =>
        source
            .MinBy(_ => _, comparer);

#endif

}