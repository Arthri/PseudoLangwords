global using static PseudoLangwords.RandomNumberAlternativeKeywords;
using System.Runtime.CompilerServices;

namespace PseudoLangwords;

public static class RandomNumberAlternativeKeywords
{
#pragma warning disable IDE1006 // Naming Styles

    public static sbyte rint8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => rsbyte;
    }

    public static byte ruint8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => rbyte;
    }

    public static short rint16
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => rshort;
    }

    public static ushort ruint16
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => rushort;
    }

    public static int rint32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => rint;
    }

    public static uint ruint32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => ruint;
    }

    public static long rint64
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => rlong;
    }

    public static ulong ruint64
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => rulong;
    }

    public static float rsingle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => rfloat;
    }

#pragma warning restore IDE1006 // Naming Styles
}
