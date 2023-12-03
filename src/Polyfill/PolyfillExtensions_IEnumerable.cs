// <auto-generated />

#pragma warning disable

using System;
using System.Collections.Generic;
using Link = System.ComponentModel.DescriptionAttribute;
using System.Linq;

static partial class PolyfillExtensions
{
    /// <summary>
    /// Produces a set items excluding <paramref name="item"/> by using the default equality comparer to compare values.
    /// </summary>
    /// <param name="target">An <see cref="IEnumerable&lt;TSource&gt;"/> whose elements that are not equal to <paramref name="item"/> will be returned.</param>
    /// <param name="item">An <see cref="TSource"/> that is elements equal it will cause those elements to be removed from the returned sequence.</param>
    /// <typeparam name="TSource">The type of the elements of <paramref name="target" />.</typeparam>
    /// <returns>A sequence that contains the items of <paramref name="target"/> but excluding <paramref name="item"/>.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.except?view=net-8.0#system-linq-enumerable-except-1(system-collections-generic-ienumerable((-0))-system-collections-generic-ienumerable((-0)))")]
    public static IEnumerable<TSource> Except<TSource>(
        this IEnumerable<TSource> target,
        TSource item) =>
        Except<TSource>(target, item, null);

    /// <summary>
    /// Produces the set difference of two sequences by using the default equality comparer to compare values.
    /// </summary>
    /// <param name="target">An <see cref="IEnumerable&lt;TSource&gt;"/> whose elements that are not equal to <paramref name="item"/> will be returned.</param>
    /// <param name="item">An <see cref="TSource"/> that is elements equal it will cause those elements to be removed from the returned sequence.</param>
    /// <typeparam name="TSource">The type of the elements of <paramref name="target" />.</typeparam>
    /// <returns>A sequence that contains the items of <paramref name="target"/> but excluding <paramref name="item"/>.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.except?view=net-8.0#system-linq-enumerable-except-1(system-collections-generic-ienumerable((-0))-system-collections-generic-ienumerable((-0)))")]
    public static IEnumerable<TSource> Except<TSource>(
        this IEnumerable<TSource> target,
        params TSource[] items) =>
        target.Except((IEnumerable<TSource>)items);

    /// <summary>
    /// Produces a set items excluding <paramref name="item"/> by using <paramref name="comparer"/> to compare values.
    /// </summary>
    /// <param name="target">An <see cref="IEnumerable&lt;TSource&gt;"/> whose elements that are not equal to <paramref name="item"/> will be returned.</param>
    /// <param name="item">An <see cref="TSource"/> that is elements equal it will cause those elements to be removed from the returned sequence.</param>
    /// <param name="comparer">An <see cref="IEqualityComparer&lt;TSource&gt;"/> to compare values.</param>
    /// <typeparam name="TSource">The type of the elements of <paramref name="target" />.</typeparam>
    /// <returns>A sequence that contains the items of <paramref name="target"/> but excluding <paramref name="item"/>.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.except#system-linq-enumerable-except-1(system-collections-generic-ienumerable((-0))-system-collections-generic-ienumerable((-0))-system-collections-generic-iequalitycomparer((-0)))")]
    public static IEnumerable<TSource> Except<TSource>(
        this IEnumerable<TSource> target,
        TSource item,
        IEqualityComparer<TSource>? comparer)
    {
        var set = new HashSet<TSource>(comparer);
        set.Add(item);
        foreach (TSource element in target)
        {
            if (set.Add(element))
            {
                yield return element;
            }
        }
    }

    /// <summary>
    /// Produces the set difference of two sequences by <paramref name="comparer"/> to compare values.
    /// </summary>
    /// <param name="target">An <see cref="IEnumerable&lt;TSource&gt;"/> whose elements that are not equal to <paramref name="item"/> will be returned.</param>
    /// <param name="item">An <see cref="TSource"/> that is elements equal it will cause those elements to be removed from the returned sequence.</param>
    /// <typeparam name="TSource">The type of the elements of <paramref name="target" />.</typeparam>
    /// <returns>A sequence that contains the items of <paramref name="target"/> but excluding <paramref name="item"/>.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.except#system-linq-enumerable-except-1(system-collections-generic-ienumerable((-0))-system-collections-generic-ienumerable((-0))-system-collections-generic-iequalitycomparer((-0)))")]
    public static IEnumerable<TSource> Except<TSource>(
        this IEnumerable<TSource> target,
        IEqualityComparer<TSource> comparer,
        params TSource[] items) =>
        target.Except((IEnumerable<TSource>)items, comparer);


#if NETSTANDARD || NETCOREAPPX || NETFRAMEWORK || NET5_0

    /// <summary>
    /// Split the elements of a sequence into chunks of size at most <paramref name="size"/>.
    /// </summary>
    /// <remarks>
    /// Every chunk except the last will be of size <paramref name="size"/>.
    /// The last chunk will contain the remaining elements and may be of a smaller size.
    /// </remarks>
    /// <param name="source">An <see cref="IEnumerable{T}"/> whose elements to chunk.</param>
    /// <param name="size">Maximum size of each chunk.</param>
    /// <typeparam name="TSource">The type of the elements of source.</typeparam>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains the elements the input sequence split into chunks of size <paramref name="size"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="size"/> is below 1.</exception>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.chunk")]
    public static IEnumerable<TSource[]> Chunk<TSource>(this IEnumerable<TSource> source, int size)
    {
        if (source is null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        if (size < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(size), size, "Size must be greater than 0.");
        }

        return ChunkIterator(source, size);

        static IEnumerable<TSource[]> ChunkIterator<TSource>(IEnumerable<TSource> source, int size)
        {
            using IEnumerator<TSource> e = source.GetEnumerator();

            // Before allocating anything, make sure there's at least one element.
            if (e.MoveNext())
            {
                // Now that we know we have at least one item, allocate an initial storage array. This is not
                // the array we'll yield.  It starts out small in order to avoid significantly overallocating
                // when the source has many fewer elements than the chunk size.
                int arraySize = Math.Min(size, 4);
                int i;
                do
                {
                    var array = new TSource[arraySize];

                    // Store the first item.
                    array[0] = e.Current;
                    i = 1;

                    if (size != array.Length)
                    {
                        // This is the first chunk. As we fill the array, grow it as needed.
                        for (; i < size && e.MoveNext(); i++)
                        {
                            if (i >= array.Length)
                            {
                                arraySize = (int)Math.Min((uint)size, 2 * (uint)array.Length);
                                Array.Resize(ref array, arraySize);
                            }

                            array[i] = e.Current;
                        }
                    }
                    else
                    {
                        // For all but the first chunk, the array will already be correctly sized.
                        // We can just store into it until either it's full or MoveNext returns false.
                        // avoid bounds checks by using cached local (`array` is lifted to iterator object as a field)
                        TSource[] local = array;
                        for (; (uint)i < (uint)local.Length && e.MoveNext(); i++)
                        {
                            local[i] = e.Current;
                        }
                    }

                    if (i != array.Length)
                    {
                        Array.Resize(ref array, i);
                    }

                    yield return array;
                }
                while (i >= size && e.MoveNext());
            }
        }
    }

    /// <summary>
    /// Returns the maximum value in a generic sequence according to a specified key selector function.
    /// </summary>
    /// <typeparam name="TSource">The type of the elements of <paramref name="target" />.</typeparam>
    /// <typeparam name="TKey">The type of key to compare elements by.</typeparam>
    /// <param name="source">A sequence of values to determine the maximum value of.</param>
    /// <param name="keySelector">A function to extract the key for each element.</param>
    /// <returns>The value with the maximum key in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException">No key extracted from <paramref name="source" /> implements the <see cref="IComparable" /> or <see cref="System.IComparable{TKey}" /> interface.</exception>
    /// <remarks>
    /// <para>If <typeparamref name="TKey" /> is a reference type and the source sequence is empty or contains only values that are <see langword="null" />, this method returns <see langword="null" />.</para>
    /// </remarks>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.maxby#system-linq-enumerable-maxby-2(system-collections-generic-ienumerable((-0))-system-func((-0-1)))")]
    public static TSource? MaxBy<TSource, TKey>(
        this IEnumerable<TSource> target,
        Func<TSource, TKey> keySelector) =>
        MaxBy(target, keySelector, null);

    /// <summary>Returns the maximum value in a generic sequence according to a specified key selector function.</summary>
    /// <typeparam name="TSource">The type of the elements of <paramref name="target" />.</typeparam>
    /// <typeparam name="TKey">The type of key to compare elements by.</typeparam>
    /// <param name="source">A sequence of values to determine the maximum value of.</param>
    /// <param name="keySelector">A function to extract the key for each element.</param>
    /// <param name="comparer">The <see cref="IComparer{TKey}" /> to compare keys.</param>
    /// <returns>The value with the maximum key in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException">No key extracted from <paramref name="source" /> implements the <see cref="IComparable" /> or <see cref="IComparable{TKey}" /> interface.</exception>
    /// <remarks>
    /// <para>If <typeparamref name="TKey" /> is a reference type and the source sequence is empty or contains only values that are <see langword="null" />, this method returns <see langword="null" />.</para>
    /// </remarks>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.maxby?view=net-8.0#system-linq-enumerable-maxby-2(system-collections-generic-ienumerable((-0))-system-func((-0-1))-system-collections-generic-icomparer((-1)))")]
    public static TSource? MaxBy<TSource, TKey>(
        this IEnumerable<TSource> target,
        Func<TSource, TKey> keySelector,
        IComparer<TKey>? comparer) =>
        target
            .OrderByDescending(keySelector, comparer)
            .FirstOrDefault();

    /// <summary>
    /// Returns the minimum value in a generic sequence according to a specified key selector function.
    /// </summary>
    /// <typeparam name="TSource">The type of the elements of <paramref name="target" />.</typeparam>
    /// <typeparam name="TKey">The type of key to compare elements by.</typeparam>
    /// <param name="source">A sequence of values to determine the minby value of.</param>
    /// <param name="keySelector">A function to extract the key for each element.</param>
    /// <returns>The value with the minimum key in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException">No key extracted from <paramref name="source" /> implements the <see cref="IComparable" /> or <see cref="System.IComparable{TKey}" /> interface.</exception>
    /// <remarks>
    /// <para>If <typeparamref name="TKey" /> is a reference type and the source sequence is empty or contains only values that are <see langword="null" />, this method returns <see langword="null" />.</para>
    /// </remarks>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.minby#system-linq-enumerable-minby-2(system-collections-generic-ienumerable((-0))-system-func((-0-1)))")]
    public static TSource? MinBy<TSource, TKey>(
        this IEnumerable<TSource> target,
        Func<TSource, TKey> keySelector) =>
        MinBy(target, keySelector, null);

    /// <summary>Returns the minimum value in a generic sequence according to a specified key selector function.</summary>
    /// <typeparam name="TSource">The type of the elements of <paramref name="target" />.</typeparam>
    /// <typeparam name="TKey">The type of key to compare elements by.</typeparam>
    /// <param name="source">A sequence of values to determine the minimum value of.</param>
    /// <param name="keySelector">A function to extract the key for each element.</param>
    /// <param name="comparer">The <see cref="IComparer{TKey}" /> to compare keys.</param>
    /// <returns>The value with the minimum key in the sequence.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException">No key extracted from <paramref name="target" /> implements the <see cref="IComparable" /> or <see cref="IComparable{TKey}" /> interface.</exception>
    /// <remarks>
    /// <para>If <typeparamref name="TKey" /> is a reference type and the source sequence is empty or contains only values that are <see langword="null" />, this method returns <see langword="null" />.</para>
    /// </remarks>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.minby?view=net-8.0#system-linq-enumerable-minby-2(system-collections-generic-ienumerable((-0))-system-func((-0-1))-system-collections-generic-icomparer((-1)))")]
    public static TSource? MinBy<TSource, TKey>(
        this IEnumerable<TSource> target,
        Func<TSource, TKey> keySelector,
        IComparer<TKey>? comparer) =>
        target
            .OrderBy(keySelector, comparer)
            .FirstOrDefault();

#endif

#if NET46X || NET47

    /// <summary>
    /// Appends a value to the end of the sequence.
    /// </summary>
    /// <param name="source">A sequence of values.</param>
    /// <param name="element">The value to append to <paramref name="target" />.</param>
    /// <typeparam name="TSource">The type of the elements of source.</typeparam>
    /// <returns>A new sequence that ends with element.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.append")]
    public static IEnumerable<TSource> Append<TSource>(
        this IEnumerable<TSource> target,
        TSource element)
    {
        foreach (var item in target)
        {
            yield return item;
        }

        yield return element;
    }
#endif

#if NETFRAMEWORK || NETSTANDARD2_0
    /// <summary>
    /// Returns a new enumerable collection that contains the elements from source with the last count elements of the
    /// source collection omitted.
    /// </summary>
    /// <param name="source">An enumerable collection instance.</param>
    /// <param name="count">The number of elements to omit from the end of the collection.</param>
    /// <typeparam name="TSource">The type of the elements in the enumerable collection.</typeparam>
    /// <returns>A new enumerable collection that contains the elements from source minus count elements from the end
    /// of the collection.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.skiplast")]
    public static IEnumerable<TSource> SkipLast<TSource>(
        this IEnumerable<TSource> target,
        int count) =>
        target.Reverse().Skip(count).Reverse();
#endif
}