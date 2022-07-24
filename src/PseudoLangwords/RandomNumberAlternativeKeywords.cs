﻿global using static PseudoLangwords.RandomNumberAlternativeKeywords;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PseudoLangwords;

[EditorBrowsable(EditorBrowsableState.Never)]
internal static class RandomNumberAlternativeKeywords
{
#pragma warning disable IDE1006 // Naming Styles

    /// <summary>
    /// A random number bigger than or equal to <see cref="sbyte.MinValue" /> and less than or equal to <see cref="sbyte.MaxValue" />.
    /// </summary>
    public static sbyte rint8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => rsbyte;
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="byte.MinValue" /> and less than or equal to <see cref="byte.MaxValue" />.
    /// </summary>
    public static byte ruint8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => rbyte;
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="short.MinValue" /> and less than or equal to <see cref="short.MaxValue" />.
    /// </summary>
    public static short rint16
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => rshort;
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="ushort.MinValue" /> and less than or equal to <see cref="ushort.MaxValue" />.
    /// </summary>
    public static ushort ruint16
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => rushort;
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="int.MinValue" /> and less than or equal to <see cref="int.MaxValue" />.
    /// </summary>
    public static int rint32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => rint;
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="uint.MinValue" /> and less than or equal to <see cref="uint.MaxValue" />.
    /// </summary>
    public static uint ruint32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => ruint;
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="long.MinValue" /> and less than or equal to <see cref="long.MaxValue" />.
    /// </summary>
    public static long rint64
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => rlong;
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="ulong.MinValue" /> and less than or equal to <see cref="ulong.MaxValue" />.
    /// </summary>
    public static ulong ruint64
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => rulong;
    }

    /// <summary>
    /// <inheritdoc cref="Random.NextSingle" path="/returns" />.
    /// </summary>
    public static float rsingle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => rfloat;
    }

#pragma warning restore IDE1006 // Naming Styles
}
