global using static PseudoLangwords.RandomNumberKeyword;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PseudoLangwords;

[EditorBrowsable(EditorBrowsableState.Never)]
internal static class RandomNumberKeyword
{
#pragma warning disable IDE1006 // Naming Styles

    public static sbyte rsbyte
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (sbyte)Random.Shared.Next(sbyte.MinValue, sbyte.MaxValue + 1);
    }

    public static byte rbyte
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (byte)Random.Shared.Next(byte.MinValue, byte.MaxValue + 1);
    }

    public static short rshort
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (short)Random.Shared.Next(short.MinValue, short.MaxValue + 1);
    }

    public static ushort rushort
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (ushort)Random.Shared.Next(ushort.MinValue, ushort.MaxValue + 1);
    }

    public static int rint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (int)Random.Shared.NextInt64(int.MinValue, (long)int.MaxValue + 1);
    }

    public static uint ruint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (uint)Random.Shared.NextInt64(uint.MinValue, (long)uint.MaxValue + 1);
    }

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

    public static float rfloat
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => Random.Shared.NextSingle();
    }

    public static double rdouble
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => Random.Shared.NextDouble();
    }

#pragma warning restore IDE1006 // Naming Styles
}
