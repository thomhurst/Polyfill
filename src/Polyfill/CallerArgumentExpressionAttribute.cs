// <auto-generated />
#pragma warning disable

#if NETFRAMEWORK || NETSTANDARD || NETCOREAPP2X

namespace System.Runtime.CompilerServices;

using Diagnostics;
using Diagnostics.CodeAnalysis;
using Link = ComponentModel.DescriptionAttribute;

/// <summary>
/// Indicates that a parameter captures the expression passed for another parameter as a string.
/// </summary>
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[AttributeUsage(AttributeTargets.Parameter)]
//Link: https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.callerargumentexpressionattribute
#if PolyPublic
public
#endif
sealed class CallerArgumentExpressionAttribute :
    Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CallerArgumentExpressionAttribute"/> class.
    /// </summary>
    /// <param name="parameterName">
    /// The name of the parameter whose expression should be captured as a string.
    /// </param>
    public CallerArgumentExpressionAttribute(string parameterName) =>
        ParameterName = parameterName;

    /// <summary>
    /// Gets the name of the parameter whose expression should be captured as a string.
    /// </summary>
    public string ParameterName { get; }
}

#else
using System.Runtime.CompilerServices;
[assembly: TypeForwardedTo(typeof(CallerArgumentExpressionAttribute))]
#endif