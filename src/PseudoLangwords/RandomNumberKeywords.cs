using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PseudoLangwords;

internal static partial class RandomNumberKeywords
{
#pragma warning disable IDE1006 // Naming Styles

    /// <summary>
    /// A random number bigger than or equal to <see cref="sbyte.MinValue" /> and less than or equal to <see cref="sbyte.MaxValue" />.
    /// </summary>
    public static sbyte rsbyte
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (sbyte)Random.Shared.Next(sbyte.MinValue, sbyte.MaxValue + 1);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="byte.MinValue" /> and less than or equal to <see cref="byte.MaxValue" />.
    /// </summary>
    public static byte rbyte
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (byte)Random.Shared.Next(byte.MinValue, byte.MaxValue + 1);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="short.MinValue" /> and less than or equal to <see cref="short.MaxValue" />.
    /// </summary>
    public static short rshort
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (short)Random.Shared.Next(short.MinValue, short.MaxValue + 1);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="ushort.MinValue" /> and less than or equal to <see cref="ushort.MaxValue" />.
    /// </summary>
    public static ushort rushort
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (ushort)Random.Shared.Next(ushort.MinValue, ushort.MaxValue + 1);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="int.MinValue" /> and less than or equal to <see cref="int.MaxValue" />.
    /// </summary>
    public static int rint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (int)Random.Shared.NextInt64(int.MinValue, (long)int.MaxValue + 1);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="uint.MinValue" /> and less than or equal to <see cref="uint.MaxValue" />.
    /// </summary>
    public static uint ruint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (uint)Random.Shared.NextInt64(uint.MinValue, (long)uint.MaxValue + 1);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="long.MinValue" /> and less than or equal to <see cref="long.MaxValue" />.
    /// </summary>
    public static long rlong
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            long result = 0;
            var span = MemoryMarshal.Cast<long, byte>(MemoryMarshal.CreateSpan(ref result, 1));
            Random.Shared.NextBytes(span);
            return result;
        }
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="ulong.MinValue" /> and less than or equal to <see cref="ulong.MaxValue" />.
    /// </summary>
    public static ulong rulong
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ulong result = 0;
            var span = MemoryMarshal.Cast<ulong, byte>(MemoryMarshal.CreateSpan(ref result, 1));
            Random.Shared.NextBytes(span);
            return result;
        }
    }

    /// <summary>
    /// <inheritdoc cref="Random.NextSingle" path="/returns" />.
    /// </summary>
    public static float rfloat
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => Random.Shared.NextSingle();
    }

    /// <summary>
    /// <inheritdoc cref="Random.NextDouble" path="/returns" />.
    /// </summary>
    public static double rdouble
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => Random.Shared.NextDouble();
    }

    /// <inheritdoc cref="Random.Next(int)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int rnext(int maxValue) => Random.Shared.Next(maxValue);

    /// <inheritdoc cref="Random.Next(int, int)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int rnext(int minValue, int maxValue) => Random.Shared.Next(minValue, maxValue);

    /// <inheritdoc cref="Random.NextInt64(long)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long rnext(long maxValue) => Random.Shared.NextInt64(maxValue);

    /// <inheritdoc cref="Random.NextInt64(long, long)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long rnext(long minValue, long maxValue) => Random.Shared.NextInt64(minValue, maxValue);

    /// <inheritdoc cref="Random.Next(int)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int rnextint(int maxValue) => Random.Shared.Next(maxValue);

    /// <inheritdoc cref="Random.Next(int, int)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int rnextint(int minValue, int maxValue) => Random.Shared.Next(minValue, maxValue);

    /// <inheritdoc cref="Random.NextInt64(long)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long rnextlong(long maxValue) => Random.Shared.NextInt64(maxValue);

    /// <inheritdoc cref="Random.NextInt64(long, long)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long rnextlong(long minValue, long maxValue) => Random.Shared.NextInt64(minValue, maxValue);

#pragma warning restore IDE1006 // Naming Styles
}
