global using static PseudoLangwords.GetLocationKeywords;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PseudoLangwords;

[EditorBrowsable(EditorBrowsableState.Never)]
internal static class GetLocationKeywords
{
#pragma warning disable IDE1006 // Naming Styles
    /// <summary>
    /// Returns the line number where this method is called.
    /// </summary>
    /// <param name="lineNumber">Do not specify.</param>
    /// <returns>The line number where this method is called.</returns>
    public static int linenum([CallerLineNumber] int lineNumber = 0)
    {
        return lineNumber;
    }

    /// <summary>
    /// Returns the file where this method is called.
    /// </summary>
    /// <param name="filePath">Do not specify.</param>
    /// <returns>The file where this method is called.</returns>
    public static string currentfile([CallerFilePath] string filePath = "")
    {
        return filePath;
    }
#pragma warning restore IDE1006 // Naming Styles
}
