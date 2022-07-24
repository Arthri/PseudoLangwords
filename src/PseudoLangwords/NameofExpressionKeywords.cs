global using static PseudoLangwords.NameofExpressionKeywords;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PseudoLangwords;

[EditorBrowsable(EditorBrowsableState.Never)]
internal static class NameofExpressionKeywords
{
#pragma warning disable IDE1006 // Naming Styles

    /// <summary>
    /// Returns the specified expression's string representation.
    /// </summary>
    /// <param name="obj">The expression.</param>
    /// <param name="expression">Do not specify.</param>
    /// <returns>The expression's string representation.</returns>
    public static string nameofexpr(object obj, [CallerArgumentExpression("obj")] string expression = "")
    {
        return expression;
    }

#pragma warning restore IDE1006 // Naming Styles
}
