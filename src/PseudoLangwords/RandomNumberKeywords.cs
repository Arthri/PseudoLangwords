global using static PseudoLangwords.RandomNumberKeywords;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PseudoLangwords;

internal static partial class RandomNumberKeywords
{
#pragma warning disable IDE1006 // Naming Styles

    #region Random Inclusive

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

    #endregion

    #region Random Exclusive

    /// <summary>
    /// A random number bigger than or equal to <see cref="sbyte.MinValue" /> and less than <see cref="sbyte.MaxValue" />.
    /// </summary>
    public static sbyte resbyte
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (sbyte)Random.Shared.Next(sbyte.MinValue, sbyte.MaxValue);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="byte.MinValue" /> and less than <see cref="byte.MaxValue" />.
    /// </summary>
    public static byte rebyte
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (byte)Random.Shared.Next(byte.MinValue, byte.MaxValue);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="short.MinValue" /> and less than <see cref="short.MaxValue" />.
    /// </summary>
    public static short reshort
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (short)Random.Shared.Next(short.MinValue, short.MaxValue);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="ushort.MinValue" /> and less than <see cref="ushort.MaxValue" />.
    /// </summary>
    public static ushort reushort
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (ushort)Random.Shared.Next(ushort.MinValue, ushort.MaxValue);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="int.MinValue" /> and less than <see cref="int.MaxValue" />.
    /// </summary>
    public static int reint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => Random.Shared.Next(int.MinValue, int.MaxValue);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="uint.MinValue" /> and less than <see cref="uint.MaxValue" />.
    /// </summary>
    public static uint reuint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (uint)Random.Shared.Next(int.MinValue, int.MaxValue);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="long.MinValue" /> and less than <see cref="long.MaxValue" />.
    /// </summary>
    public static long relong
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => Random.Shared.NextInt64(long.MinValue, long.MaxValue);
    }

    /// <summary>
    /// A random number bigger than or equal to <see cref="ulong.MinValue" /> and less than <see cref="ulong.MaxValue" />.
    /// </summary>
    public static ulong reulong
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (ulong)Random.Shared.NextInt64(long.MinValue, long.MaxValue);
    }

    #endregion

    #region Random Positive Inclusive

    /// <summary>
    /// A random non-negative number less than or equal to <see cref="sbyte.MaxValue" />.
    /// </summary>
    public static sbyte rpsbyte
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (sbyte)Random.Shared.Next(0, sbyte.MaxValue + 1);
    }

    /// <summary>
    /// A random non-negative number less than or equal to <see cref="short.MaxValue" />.
    /// </summary>
    public static short rpshort
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (short)Random.Shared.Next(0, short.MaxValue + 1);
    }

    /// <summary>
    /// A random non-negative number less than or equal to <see cref="int.MaxValue" />.
    /// </summary>
    public static int rpint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (int)Random.Shared.NextInt64(0, (long)int.MaxValue + 1);
    }

    /// <summary>
    /// A random non-negative number less than or equal to <see cref="long.MaxValue"/>.
    /// </summary>
    public static long rplong
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => Random.Shared.NextInt64(-1, long.MaxValue) + 1;
    }

    #endregion

    #region Random Positive Exclusive

    /// <summary>
    /// A random non-negative number less than <see cref="sbyte.MaxValue"/>.
    /// </summary>
    public static sbyte rpesbyte
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (sbyte)Random.Shared.Next(0, sbyte.MaxValue);
    }

    /// <summary>
    /// A random non-negative number less than <see cref="short.MaxValue"/>.
    /// </summary>
    public static short rpeshort
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (short)Random.Shared.Next(0, short.MaxValue);
    }

    /// <summary>
    /// A random non-negative number less than <see cref="int.MaxValue"/>.
    /// </summary>
    public static int rpeint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => Random.Shared.Next();
    }

    /// <summary>
    /// A random non-negative number less than <see cref="long.MaxValue"/>.
    /// </summary>
    public static long rpelong
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => Random.Shared.NextInt64();
    }

    #endregion

    #region Random.Next

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

    #region Collections

    /// <summary>
    /// Returns a random integer that is less than the specified <paramref name="collection"/>'s <see cref="ICollection.Count"/>.
    /// </summary>
    /// <param name="collection">The collection.</param>
    /// <returns>A random integer that is less than the specified <paramref name="collection"/>'s <see cref="ICollection.Count"/>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int rnext(ICollection collection) => Random.Shared.Next(collection.Count);

    /// <summary>
    /// Returns a random index less than the specified <paramref name="list"/>'s <see cref="ICollection.Count"/>.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="element">The element at the returned index.</param>
    /// <returns>A random index less than the specified <paramref name="list"/>'s <see cref="ICollection.Count"/>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int rnext(IList list, out object? element)
    {
        var index = Random.Shared.Next(list.Count);
        element = list[index];
        return index;
    }

    /// <summary>
    /// Returns a random element inside the specified <paramref name="list"/>.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <returns>A random element inside the specified <paramref name="list"/>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static object? rnextelement(IList list) => list[Random.Shared.Next(list.Count)];

    /// <summary>
    /// Returns a random element inside the specified <paramref name="list"/>.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="index">The returned element's index.</param>
    /// <returns>A random element inside the specified <paramref name="list"/>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static object? rnextelement(IList list, out int index)
    {
        index = Random.Shared.Next(list.Count);
        return list[index];
    }

    /// <summary>
    /// Returns a random integer that is less than the specified <paramref name="collection"/>'s <see cref="ICollection{T}.Count"/>.
    /// </summary>
    /// <typeparam name="T"><inheritdoc cref="ICollection{T}"/></typeparam>
    /// <param name="collection">The collection.</param>
    /// <returns>A random integer that is less than the specified <paramref name="collection"/>'s <see cref="ICollection{T}.Count"/>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int rnext<T>(ICollection<T> collection) => Random.Shared.Next(collection.Count);

    /// <summary>
    /// Returns a random index less than the specified <paramref name="list"/>'s <see cref="ICollection{T}.Count"/>.
    /// </summary>
    /// <typeparam name="T"><inheritdoc cref="IList{T}"/></typeparam>
    /// <param name="list">The list.</param>
    /// <param name="element">The element at the returned index.</param>
    /// <returns>A random index less than the specified <paramref name="list"/>'s <see cref="ICollection{T}.Count"/>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int rnext<T>(IList<T> list, out T element)
    {
        var index = Random.Shared.Next(list.Count);
        element = list[index];
        return index;
    }

    /// <summary>
    /// Returns a random element inside the specified <paramref name="list"/>.
    /// </summary>
    /// <typeparam name="T"><inheritdoc cref="IList{T}"/></typeparam>
    /// <param name="list">The list.</param>
    /// <returns>A random element inside the specified <paramref name="list"/>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T rnextelement<T>(IList<T> list) => list[Random.Shared.Next(list.Count)];

    /// <summary>
    /// Returns a random element inside the specified <paramref name="list"/>.
    /// </summary>
    /// <typeparam name="T"><inheritdoc cref="IList{T}"/></typeparam>
    /// <param name="list">The list.</param>
    /// <param name="index">The returned element's index.</param>
    /// <returns>A random element inside the specified <paramref name="list"/>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T rnextelement<T>(IList<T> list, out int index)
    {
        index = Random.Shared.Next(list.Count);
        return list[index];
    }

    #endregion

    #endregion

    #region Random.Next Explicit Type

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

    #region Collections

    /// <summary>
    /// Returns a random integer that is less than the specified <paramref name="collection"/>'s <see cref="ICollection.Count"/>.
    /// </summary>
    /// <param name="collection">The collection.</param>
    /// <returns>A random integer that is less than the specified <paramref name="collection"/>'s <see cref="ICollection.Count"/>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int rnextindex(ICollection collection) => Random.Shared.Next(collection.Count);

    /// <summary>
    /// Returns a random index less than the specified <paramref name="list"/>'s <see cref="ICollection.Count"/>.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="element">The element at the returned index.</param>
    /// <returns>A random index less than the specified <paramref name="list"/>'s <see cref="ICollection.Count"/>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int rnextindex(IList list, out object? element)
    {
        var index = Random.Shared.Next(list.Count);
        element = list[index];
        return index;
    }

    /// <summary>
    /// Returns a random integer that is less than the specified <paramref name="collection"/>'s <see cref="ICollection{T}.Count"/>.
    /// </summary>
    /// <typeparam name="T"><inheritdoc cref="ICollection{T}"/></typeparam>
    /// <param name="collection">The collection.</param>
    /// <returns>A random integer that is less than the specified <paramref name="collection"/>'s <see cref="ICollection{T}.Count"/>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int rnextindex<T>(ICollection<T> collection) => Random.Shared.Next(collection.Count);

    /// <summary>
    /// Returns a random index less than the specified <paramref name="list"/>'s <see cref="ICollection{T}.Count"/>.
    /// </summary>
    /// <typeparam name="T"><inheritdoc cref="IList{T}"/></typeparam>
    /// <param name="list">The list.</param>
    /// <param name="element">The element at the returned index.</param>
    /// <returns>A random index less than the specified <paramref name="list"/>'s <see cref="ICollection{T}.Count"/>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int rnextindex<T>(IList<T> list, out T element)
    {
        var index = Random.Shared.Next(list.Count);
        element = list[index];
        return index;
    }

    #endregion

    #endregion

#pragma warning restore IDE1006 // Naming Styles
}
