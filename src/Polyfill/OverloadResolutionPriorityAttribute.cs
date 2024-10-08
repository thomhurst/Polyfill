// <auto-generated />
#pragma warning disable

#if !NET9_0_OR_GREATER

namespace System.Runtime.CompilerServices;

using Diagnostics;
using Diagnostics.CodeAnalysis;
using Link = ComponentModel.DescriptionAttribute;

/// <summary>
/// Specifies the priority of a member in overload resolution. When unspecified, the default priority is 0.
/// </summary>
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[AttributeUsage(
    AttributeTargets.Method |
    AttributeTargets.Constructor |
    AttributeTargets.Property,
    Inherited = false)]
[Link("https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.overloadresolutionpriorityattribute")]
#if PolyPublic
public
#endif
sealed class OverloadResolutionPriorityAttribute :
    Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OverloadResolutionPriorityAttribute"/> class.
    /// </summary>
    /// <param name="priority">The priority of the attributed member. Higher numbers are prioritized,
    /// lower numbers are deprioritized. 0 is the default if no attribute is present.</param>
    public OverloadResolutionPriorityAttribute(int priority) =>
        Priority = priority;

    /// <summary>
    /// The priority of the member.
    /// </summary>
    public int Priority { get; }
}
#endif