﻿// <auto-generated />
#pragma warning disable

#if !NET5_0_OR_GREATER

#nullable enable

namespace System.Runtime.Versioning;

using Diagnostics;
using Diagnostics.CodeAnalysis;

using Targets = AttributeTargets;

/// <summary>
/// Marks APIs that were removed in a given operating system version.
/// </summary>
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[AttributeUsage(
    validOn: Targets.Assembly |
             Targets.Class |
             Targets.Constructor |
             Targets.Enum |
             Targets.Event |
             Targets.Field |
             Targets.Interface |
             Targets.Method |
             Targets.Module |
             Targets.Property |
             Targets.Struct,
    AllowMultiple = true,
    Inherited = false)]
#if PolyPublic
public
#endif
sealed class UnsupportedOSPlatformAttribute :
    OSPlatformAttribute
{
    public UnsupportedOSPlatformAttribute(string platformName) :
        base(platformName)
    {
    }

    public UnsupportedOSPlatformAttribute(string platformName, string? message) :
        base(platformName) =>
        Message = message;

    public string? Message { get; }
}

#endif