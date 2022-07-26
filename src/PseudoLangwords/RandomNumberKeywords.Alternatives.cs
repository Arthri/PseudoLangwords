﻿global using static PseudoLangwords.RandomNumberKeywords;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PseudoLangwords;

[EditorBrowsable(EditorBrowsableState.Never)]
internal static partial class RandomNumberKeywords
{
#pragma warning disable IDE1006 // Naming Styles

    #region Random Inclusive

    /// <summary>
    /// A random number bigger than or equal to <see cref="sbyte.MinValue" /> and less than or equal to <see cref="sbyte.MaxValue" />.
    /// </summary>
    public static sbyte rint8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (sbyte)Random.Shared.Next(sbyte.MinValue, sbyte.MaxValue + 1);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="byte.MinValue" /> and less than or equal to <see cref="byte.MaxValue" />.
    /// </summary>
    public static byte ruint8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (byte)Random.Shared.Next(byte.MinValue, byte.MaxValue + 1);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="short.MinValue" /> and less than or equal to <see cref="short.MaxValue" />.
    /// </summary>
    public static short rint16
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (short)Random.Shared.Next(short.MinValue, short.MaxValue + 1);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="ushort.MinValue" /> and less than or equal to <see cref="ushort.MaxValue" />.
    /// </summary>
    public static ushort ruint16
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (ushort)Random.Shared.Next(ushort.MinValue, ushort.MaxValue + 1);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="int.MinValue" /> and less than or equal to <see cref="int.MaxValue" />.
    /// </summary>
    public static int rint32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (int)Random.Shared.NextInt64(int.MinValue, (long)int.MaxValue + 1);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="uint.MinValue" /> and less than or equal to <see cref="uint.MaxValue" />.
    /// </summary>
    public static uint ruint32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (uint)Random.Shared.NextInt64(uint.MinValue, (long)uint.MaxValue + 1);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="long.MinValue" /> and less than or equal to <see cref="long.MaxValue" />.
    /// </summary>
    public static long rint64
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
    public static ulong ruint64
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
    public static float rsingle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => rfloat;
    }

    #endregion

    #region Random Exclusive

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

    #endregion

    #region Random Positive Inclusive

    /// <summary>
    /// A random non-negative number less than or equal to <see cref="sbyte.MaxValue" />.
    /// </summary>
    public static sbyte rpint8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (sbyte)Random.Shared.Next(0, sbyte.MaxValue + 1);
    }

    /// <summary>
    /// A random non-negative number less than or equal to <see cref="short.MaxValue" />.
    /// </summary>
    public static short rpint16
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (short)Random.Shared.Next(0, short.MaxValue + 1);
    }

    /// <summary>
    /// A random non-negative number less than or equal to <see cref="int.MaxValue" />.
    /// </summary>
    public static int rpint32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (int)Random.Shared.NextInt64(0, (long)int.MaxValue + 1);
    }

    /// <summary>
    /// A random non-negative number less than or equal to <see cref="long.MaxValue"/>.
    /// </summary>
    public static long rpint64
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => Random.Shared.NextInt64(-1, long.MaxValue) + 1;
    }

    #endregion

    #region Random Positive Exclusive

    /// <summary>
    /// A random non-negative number less than <see cref="sbyte.MaxValue" />.
    /// </summary>
    public static sbyte rpeint8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (sbyte)Random.Shared.Next(0, sbyte.MaxValue);
    }

    /// <summary>
    /// A random non-negative number less than <see cref="short.MaxValue" />.
    /// </summary>
    public static short rpeint16
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (short)Random.Shared.Next(0, short.MaxValue);
    }

    /// <summary>
    /// A random non-negative number less than <see cref="int.MaxValue" />.
    /// </summary>
    public static int rpeint32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => Random.Shared.Next();
    }

    /// <summary>
    /// A random non-negative number less than <see cref="long.MaxValue"/>.
    /// </summary>
    public static long rpeint64
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => Random.Shared.NextInt64();
    }

    #endregion

    #region Random.Next Explicit Type

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

    #endregion

#pragma warning restore IDE1006 // Naming Styles
}
