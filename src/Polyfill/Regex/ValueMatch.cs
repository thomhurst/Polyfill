// <auto-generated />
#pragma warning disable
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if !NET7_0_OR_GREATER && FeatureMemory

namespace System.Text.RegularExpressions;

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

/// <summary>
/// Represents the results from a single regular expression match.
/// </summary>
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
#if PolyPublic
public
#endif
readonly ref struct ValueMatch
{
    /// <summary>
    /// Crates an instance of the <see cref="ValueMatch"/> type based on the passed in <paramref name="index"/> and <paramref name="length"/>.
    /// </summary>
    /// <param name="index">The position in the original span where the first character of the captured sliced span is found.</param>
    /// <param name="length">The length of the captured sliced span.</param>
    internal ValueMatch(int index, int length)
    {
        Index = index;
        Length = length;
    }

    /// <summary>
    /// Gets the position in the original span where the first character of the captured sliced span is found.
    /// </summary>
    public int Index { get; }

    /// <summary>
    /// Gets the length of the captured sliced span.
    /// </summary>
    public int Length { get; }
}

#endif