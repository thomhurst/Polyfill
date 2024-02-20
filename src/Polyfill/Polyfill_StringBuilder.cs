// <auto-generated />

#pragma warning disable

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Link = System.ComponentModel.DescriptionAttribute;

static partial class Polyfill
{
#if FeatureMemory && (!NETSTANDARD2_1_OR_GREATER && !NETCOREAPP2_1_OR_GREATER)

    /// <summary>
    /// Copies the characters from a specified segment of this instance to a destination Char span.
    /// </summary>
    /// <param name="sourceIndex">The starting position in this instance where characters will be copied from. The index is zero-based.</param>
    /// <param name="destination">The writable span where characters will be copied.</param>
    /// <param name="count">The number of characters to be copied.</param>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.copyto#system-text-stringbuilder-copyto(system-int32-system-span((system-char))-system-int32)")]
    public static void CopyTo(
        this StringBuilder target,
        int sourceIndex,
        Span<char> destination,
        int count)
    {
        var destinationIndex = 0;
        while (true)
        {
            if (sourceIndex == target.Length)
            {
                break;
            }

            if (destinationIndex == count)
            {
                break;
            }

            destination[destinationIndex] = target[sourceIndex];
            destinationIndex++;
            sourceIndex++;
        }
    }

    /// <summary>
    /// Appends the string representation of a specified read-only character span to this instance.
    /// </summary>
    /// <param name="value">The read-only character span to append.</param>
    /// <returns>A reference to this instance after the append operation is completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.append#system-text-stringbuilder-append(system-readonlyspan((system-char)))")]
    public static StringBuilder Append(this StringBuilder target, ReadOnlySpan<char> value)
    {
        if (value.Length <= 0)
        {
            return target;
        }

#if AllowUnsafeBlocks
        unsafe
        {
            fixed (char* valueChars = value)
            {
                target.Append(valueChars, value.Length);
            }
        }
#else
        target.Append(value.ToString());
#endif
        return target;
    }

    /// <summary>
    /// Returns a value indicating whether the characters in this instance are equal to the characters in a specified
    /// read-only character span.
    /// </summary>
    /// <param name="span">The character span to compare with the current instance.</param>
    /// <remarks>
    /// The Equals method performs an ordinal comparison to determine whether the characters in the current instance
    /// and span are equal.
    /// </remarks>
    /// <returns>true if the characters in this instance and span are the same; otherwise, false.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.equals#system-text-stringbuilder-equals(system-readonlyspan((system-char)))")]
    public static bool Equals(this StringBuilder target, ReadOnlySpan<char> span)
    {
        if (target.Length != span.Length)
        {
            return false;
        }

        for (var index = 0; index < target.Length; index++)
        {
            var ch1 = target[index];
            var ch2 = span[index];
            if (ch1 != ch2)
            {
                return false;
            }
        }

        return true;
    }

#endif

#if FeatureMemory && !NET6_0_OR_GREATER
    /// <summary>Appends the specified interpolated string to this instance.</summary>
    /// <param name="handler">The interpolated string to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.append#system-text-stringbuilder-append(system-text-stringbuilder-appendinterpolatedstringhandler@)")]
    public static StringBuilder Append(
        StringBuilder target,
        [InterpolatedStringHandlerArgument(nameof(target))] ref AppendInterpolatedStringHandler handler) => target;

    /// <summary>Appends the specified interpolated string to this instance.</summary>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    /// <param name="handler">The interpolated string to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.append#system-text-stringbuilder-append(system-iformatprovider-system-text-stringbuilder-appendinterpolatedstringhandler@)")]
    public static StringBuilder Append(
        StringBuilder target,
        IFormatProvider? provider,
        [InterpolatedStringHandlerArgument(nameof(target), nameof(provider))] ref AppendInterpolatedStringHandler handler) => target;

    /// <summary>Appends the specified interpolated string followed by the default line terminator to the end of the current StringBuilder object.</summary>
    /// <param name="handler">The interpolated string to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendline#system-text-stringbuilder-appendline(system-text-stringbuilder-appendinterpolatedstringhandler@)")]
    public static StringBuilder AppendLine(
        StringBuilder target,
        [InterpolatedStringHandlerArgument(nameof(target))] ref AppendInterpolatedStringHandler handler) =>
        target.AppendLine();

    /// <summary>Appends the specified interpolated string followed by the default line terminator to the end of the current StringBuilder object.</summary>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    /// <param name="handler">The interpolated string to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendline#system-text-stringbuilder-appendline(system-iformatprovider-system-text-stringbuilder-appendinterpolatedstringhandler@)")]
    public static StringBuilder AppendLine(
        StringBuilder target,
        IFormatProvider? provider,
        [InterpolatedStringHandlerArgument(nameof(target), nameof(provider))] ref AppendInterpolatedStringHandler handler) =>
        target.AppendLine();

#elif  NET6_0_OR_GREATER

    /// <summary>Appends the specified interpolated string to this instance.</summary>
    /// <param name="handler">The interpolated string to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.append#system-text-stringbuilder-append(system-text-stringbuilder-appendinterpolatedstringhandler@)")]
    public static StringBuilder Append(
        StringBuilder target,
        [InterpolatedStringHandlerArgument(nameof(target))] ref StringBuilder.AppendInterpolatedStringHandler handler) =>
        target.Append(ref handler);

    /// <summary>Appends the specified interpolated string to this instance.</summary>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    /// <param name="handler">The interpolated string to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.append#system-text-stringbuilder-append(system-iformatprovider-system-text-stringbuilder-appendinterpolatedstringhandler@)")]
    public static StringBuilder Append(
        StringBuilder target,
        IFormatProvider? provider,
        [InterpolatedStringHandlerArgument(nameof(target), nameof(provider))] ref StringBuilder.AppendInterpolatedStringHandler handler) =>
        target.Append(provider, ref handler);

    /// <summary>Appends the specified interpolated string followed by the default line terminator to the end of the current StringBuilder object.</summary>
    /// <param name="handler">The interpolated string to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendline#system-text-stringbuilder-appendline(system-text-stringbuilder-appendinterpolatedstringhandler@)")]
    public static StringBuilder AppendLine(
        StringBuilder target,
        [InterpolatedStringHandlerArgument(nameof(target))] ref StringBuilder.AppendInterpolatedStringHandler handler) =>
        target.AppendLine(ref handler);

    /// <summary>Appends the specified interpolated string followed by the default line terminator to the end of the current StringBuilder object.</summary>
    /// <param name="provider">An object that supplies culture-specific formatting information.</param>
    /// <param name="handler">The interpolated string to append.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendline#system-text-stringbuilder-appendline(system-iformatprovider-system-text-stringbuilder-appendinterpolatedstringhandler@)")]
    public static StringBuilder AppendLine(
        StringBuilder target,
        IFormatProvider? provider,
        [InterpolatedStringHandlerArgument(nameof(target), nameof(provider))] ref StringBuilder.AppendInterpolatedStringHandler handler) =>
        target.AppendLine(provider, ref handler);
#endif

    #if NETSTANDARD2_0|| NETFRAMEWORK

    /// <summary>Concatenates the strings of the provided array, using the specified separator between each string, then appends the result to the current instance of the string builder.</summary>
    /// <param name="separator">The string to use as a separator. separator is included in the joined strings only if values has more than one element.</param>
    /// <param name="values">An array that contains the strings to concatenate and append to the current instance of the string builder.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendjoin?view=netcore-2.0#system-text-stringbuilder-appendjoin(system-string-system-string())")]
    public static StringBuilder AppendJoin(
        this StringBuilder target,
        string separator,
        params string[] values) =>
        target.Append(string.Join(separator, values));

    /// <summary>Concatenates the string representations of the elements in the provided array of objects, using the specified separator between each member, then appends the result to the current instance of the string builder.</summary>
    /// <param name="separator">The string to use as a separator. separator is included in the joined strings only if values has more than one element.</param>
    /// <param name="values">An array that contains the strings to concatenate and append to the current instance of the string builder.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendjoin?view=netcore-2.0#system-text-stringbuilder-appendjoin(system-string-system-object())")]
    public static StringBuilder AppendJoin(
        this StringBuilder target,
        string separator,
        params Object[] values) =>
        target.Append(string.Join(separator, values));

    /// <summary>Concatenates the strings of the provided array, using the specified char separator between each string, then appends the result to the current instance of the string builder.</summary>
    /// <param name="separator">The character to use as a separator. separator is included in the joined strings only if values has more than one element.</param>
    /// <param name="values">An array that contains the strings to concatenate and append to the current instance of the string builder.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendjoin?view=netcore-2.0#system-text-stringbuilder-appendjoin(system-char-system-string())")]
    public static StringBuilder AppendJoin(
        this StringBuilder target,
        char separator,
        params string[] values) =>
        target.Append(string.Join(separator.ToString(), values));

    /// <summary>Concatenates the string representations of the elements in the provided array of objects, using the specified char separator between each member, then appends the result to the current instance of the string builder.</summary>
    /// <param name="separator">The character to use as a separator. separator is included in the joined strings only if values has more than one element.</param>
    /// <param name="values">An array that contains the strings to concatenate and append to the current instance of the string builder.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendjoin?view=netcore-2.0#system-text-stringbuilder-appendjoin(system-char-system-object())")]
    public static StringBuilder AppendJoin(
        this StringBuilder target,
        char separator,
        params object[] values) =>
        target.Append(string.Join(separator.ToString(), values));

    /// <summary>Concatenates and appends the members of a collection, using the specified char separator between each member.</summary>
    /// <param name="separator">The character to use as a separator. separator is included in the joined strings only if values has more than one element.</param>
    /// <param name="values">A collection that contains the objects to concatenate and append to the current instance of the string builder.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendjoin?view=netcore-2.0#system-text-stringbuilder-appendjoin-1(system-char-system-collections-generic-ienumerable((-0)))")]
    public static StringBuilder AppendJoin<T>(
        this StringBuilder target,
        char separator,
        params T[] values) =>
        target.Append(string.Join(separator.ToString(), values));

    /// <summary>Concatenates and appends the members of a collection, using the specified char separator between each member.</summary>
    /// <param name="separator">The string to use as a separator. separator is included in the concatenated and appended strings only if values has more than one element.</param>
    /// <param name="values">A collection that contains the objects to concatenate and append to the current instance of the string builder.</param>
    /// <returns>A reference to this instance after the append operation has completed.</returns>
    [Link("https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendjoin?view=netcore-2.0#system-text-stringbuilder-appendjoin-1(system-string-system-collections-generic-ienumerable((-0)))")]
    public static StringBuilder AppendJoin<T>(
        this StringBuilder target,
        string separator,
        params T[] values) =>
        target.Append(string.Join(separator.ToString(), values));

#endif
}