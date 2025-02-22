// <auto-generated />
#pragma warning disable

namespace Polyfills;

using System;

static partial class Polyfill
{
#if (NETSTANDARD || NETFRAMEWORK || NETCOREAPP2_0) && FeatureMemory
    /// <summary>
    /// Fills the elements of a specified span of bytes with random numbers.
    /// </summary>
    /// <param name="index">The array to be filled with random numbers.</param>
    //Link: https://learn.microsoft.com/en-us/dotnet/api/system.random.nextbytes#system-random-nextbytes(system-span((system-byte)))
    public static void NextBytes(
        this Random target,
        Span<byte> buffer)
    {
        var array = new byte[buffer.Length];
        target.NextBytes(array);
        array.CopyTo(buffer);
    }
#endif

#if !NET8_0_OR_GREATER

    /// <summary>
    /// Performs an in-place shuffle of an array.
    /// </summary>
    /// <param name="index">The array to shuffle.</param>
    /// <typeparam name="T">The type of array.</typeparam>
    //Link: https://learn.microsoft.com/en-us/dotnet/api/system.random.nextbytes#system-random-nextbytes(system-span((system-byte)))
    public static void Shuffle<T>(
        this Random target,
        T[] values)
    {
        int n = values.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int j = target.Next(i, n);

            if (j != i)
            {
                T temp = values[i];
                values[i] = values[j];
                values[j] = temp;
            }
        }
    }
#if FeatureMemory

    /// <summary>
    /// Performs an in-place shuffle of a span.
    /// </summary>
    /// <param name="index">The span to shuffle.</param>
    /// <typeparam name="T">The type of span.</typeparam>
    //Link: https://learn.microsoft.com/en-us/dotnet/api/system.random.nextbytes#system-random-nextbytes(system-span((system-byte)))
    public static void Shuffle<T>(
        this Random target,
        Span<T> values)
    {
        int n = values.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int j = target.Next(i, n);

            if (j != i)
            {
                T temp = values[i];
                values[i] = values[j];
                values[j] = temp;
            }
        }
    }
#endif
#endif
}