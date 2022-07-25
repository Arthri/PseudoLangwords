global using static PseudoLangwords.RandomNumberKeywords;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PseudoLangwords;

[EditorBrowsable(EditorBrowsableState.Never)]
internal static partial class RandomNumberKeywords
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

    /// <summary>
    /// A random number bigger than or equal to <see cref="sbyte.MinValue" /> and less than <see cref="sbyte.MaxValue" />.
    /// </summary>
    public static sbyte reint8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (sbyte)Random.Shared.Next(sbyte.MinValue, sbyte.MaxValue);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="byte.MinValue" /> and less than <see cref="byte.MaxValue" />.
    /// </summary>
    public static byte reuint8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (byte)Random.Shared.Next(byte.MinValue, byte.MaxValue);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="short.MinValue" /> and less than <see cref="short.MaxValue" />.
    /// </summary>
    public static short reint16
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (short)Random.Shared.Next(short.MinValue, short.MaxValue);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="ushort.MinValue" /> and less than <see cref="ushort.MaxValue" />.
    /// </summary>
    public static ushort reuint16
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (ushort)Random.Shared.Next(ushort.MinValue, ushort.MaxValue);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="int.MinValue" /> and less than <see cref="int.MaxValue" />.
    /// </summary>
    public static int reint32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => Random.Shared.Next(int.MinValue, int.MaxValue);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="uint.MinValue" /> and less than <see cref="uint.MaxValue" />.
    /// </summary>
    public static uint reuint32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (uint)Random.Shared.Next(int.MinValue, int.MaxValue);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="long.MinValue" /> and less than <see cref="long.MaxValue" />.
    /// </summary>
    public static long reint64
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => Random.Shared.NextInt64(long.MinValue, long.MaxValue);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="ulong.MinValue" /> and less than <see cref="ulong.MaxValue" />.
    /// </summary>
    public static ulong reuint64
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (ulong)Random.Shared.NextInt64(long.MinValue, long.MaxValue);
    }

    /// <inheritdoc cref="Random.Next(int)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int rnextint32(int maxValue) => Random.Shared.Next(maxValue);

    /// <inheritdoc cref="Random.Next(int, int)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int rnextint32(int minValue, int maxValue) => Random.Shared.Next(minValue, maxValue);

    /// <inheritdoc cref="Random.NextInt64(long)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long rnextint64(long maxValue) => Random.Shared.NextInt64(maxValue);

    /// <inheritdoc cref="Random.NextInt64(long, long)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long rnextint64(long minValue, long maxValue) => Random.Shared.NextInt64(minValue, maxValue);

#pragma warning restore IDE1006 // Naming Styles
}
