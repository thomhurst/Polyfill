// <auto-generated />
#pragma warning disable

#if !NET6_0_OR_GREATER

#pragma warning disable

namespace System.Runtime.Versioning;

using Diagnostics;
using Diagnostics.CodeAnalysis;

using Targets = AttributeTargets;

/// <summary>
/// Annotates the custom guard field, property or method with an unsupported platform name and optional version.
/// Multiple attributes can be applied to indicate guard for multiple unsupported platforms.
/// </summary>
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[AttributeUsage(
    validOn: Targets.Field |
             Targets.Method |
             Targets.Property,
    AllowMultiple = true,
    Inherited = false)]
#if PolyPublic
public
#endif
sealed class UnsupportedOSPlatformGuardAttribute(string platformName) :
    OSPlatformAttribute(platformName);
#else
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
[assembly: TypeForwardedTo(typeof(UnsupportedOSPlatformGuardAttribute))]
#endif