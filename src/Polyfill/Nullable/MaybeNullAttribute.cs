// <auto-generated />
#pragma warning disable

#if NETSTANDARD2_0 || NETFRAMEWORK || NETCOREAPP2X

namespace System.Diagnostics.CodeAnalysis;

using Targets = AttributeTargets;

/// <summary>
///   Specifies that an output may be <see langword="null"/> even if the
///   corresponding type disallows it.
/// </summary>
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[AttributeUsage(
    validOn: Targets.Field |
             Targets.Parameter |
             Targets.Property |
             Targets.ReturnValue)]
#if PolyPublic
public
#endif
sealed class MaybeNullAttribute :
    Attribute;
#else
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;
[assembly: TypeForwardedTo(typeof(MaybeNullAttribute))]
#endif