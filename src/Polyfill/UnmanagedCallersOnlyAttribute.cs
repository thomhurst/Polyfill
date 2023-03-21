#if !NET5_0_OR_GREATER

#nullable enable

// ReSharper disable RedundantUsingDirective
// ReSharper disable UnusedMember.Global

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace System.Runtime.InteropServices;

/// <summary>
/// Any method marked with <see cref="System.Runtime.InteropServices.UnmanagedCallersOnlyAttribute" /> can be directly called from
/// native code. The function token can be loaded to a local variable using the <see href="https://docs.microsoft.com/dotnet/csharp/language-reference/operators/pointer-related-operators#address-of-operator-">address-of</see> operator
/// in C# and passed as a callback to a native method.
/// </summary>
/// <remarks>
/// Methods marked with this attribute have the following restrictions:
///   * Method must be marked "static".
///   * Must not be called from managed code.
///   * Must only have <see href="https://docs.microsoft.com/dotnet/framework/interop/blittable-and-non-blittable-types">blittable</see> arguments.
/// </remarks>
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[AttributeUsage(
    AttributeTargets.Method,
    Inherited = false)]
public sealed class UnmanagedCallersOnlyAttribute :
    Attribute
{
    /// <summary>
    /// Optional. If omitted, the runtime will use the default platform calling convention.
    /// </summary>
    /// <remarks>
    /// Supplied types must be from the official "System.Runtime.CompilerServices" namespace and
    /// be of the form "CallConvXXX".
    /// </remarks>
    public Type[]? CallConvs;

    /// <summary>
    /// Optional. If omitted, no named export is emitted during compilation.
    /// </summary>
    public string? EntryPoint;
}

#endif