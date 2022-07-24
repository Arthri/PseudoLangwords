﻿global using static PseudoLangwords.PrintKeywords;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PseudoLangwords;

[EditorBrowsable(EditorBrowsableState.Never)]
internal static class PrintKeywords
{
#pragma warning disable IDE1006 // Naming Styles

    /// <inheritdoc cref="Console.Write(bool)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void print(bool value) => Console.Write(value);

    /// <inheritdoc cref="Console.Write(char)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void print(char value) => Console.Write(value);

    /// <inheritdoc cref="Console.Write(char[], int, int)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void print(char[] buffer, int index, int count) => Console.Write(buffer, index, count);

    /// <inheritdoc cref="Console.Write(char[])" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void print(char[]? buffer) => Console.Write(buffer);

    /// <inheritdoc cref="Console.Write(decimal)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void print(decimal value) => Console.Write(value);

    /// <inheritdoc cref="Console.Write(double)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void print(double value) => Console.Write(value);

    /// <inheritdoc cref="Console.Write(float)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void print(float value) => Console.Write(value);

    /// <inheritdoc cref="Console.Write(int)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void print(int value) => Console.Write(value);

    /// <inheritdoc cref="Console.Write(long)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void print(long value) => Console.Write(value);

    /// <inheritdoc cref="Console.Write(object?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void print(object? value) => Console.Write(value);

    /// <inheritdoc cref="Console.Write(string, object?, object?, object?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void print(string format, object? arg0, object? arg1, object? arg2) => Console.Write(format, arg0, arg1, arg2);

    /// <inheritdoc cref="Console.Write(string, object?, object?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void print(string format, object? arg0, object? arg1) => Console.Write(format, arg0, arg1);

    /// <inheritdoc cref="Console.Write(string, object?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void print(string format, object? arg0) => Console.Write(format, arg0);

    /// <inheritdoc cref="Console.Write(string, object?[])" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void print(string format, params object?[]? arg) => Console.Write(format, arg);

    /// <inheritdoc cref="Console.Write(string?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void print(string? value) => Console.Write(value);

    /// <inheritdoc cref="Console.Write(uint)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void print(uint value) => Console.Write(value);

    /// <inheritdoc cref="Console.Write(ulong)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void print(ulong value) => Console.Write(value);



    /// <inheritdoc cref="Console.Write(bool)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void write(bool value) => Console.Write(value);

    /// <inheritdoc cref="Console.Write(char)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void write(char value) => Console.Write(value);

    /// <inheritdoc cref="Console.Write(char[], int, int)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void write(char[] buffer, int index, int count) => Console.Write(buffer, index, count);

    /// <inheritdoc cref="Console.Write(char[])" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void write(char[]? buffer) => Console.Write(buffer);

    /// <inheritdoc cref="Console.Write(decimal)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void write(decimal value) => Console.Write(value);

    /// <inheritdoc cref="Console.Write(double)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void write(double value) => Console.Write(value);

    /// <inheritdoc cref="Console.Write(float)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void write(float value) => Console.Write(value);

    /// <inheritdoc cref="Console.Write(int)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void write(int value) => Console.Write(value);

    /// <inheritdoc cref="Console.Write(long)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void write(long value) => Console.Write(value);

    /// <inheritdoc cref="Console.Write(object?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void write(object? value) => Console.Write(value);

    /// <inheritdoc cref="Console.Write(string, object?, object?, object?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void write(string format, object? arg0, object? arg1, object? arg2) => Console.Write(format, arg0, arg1, arg2);

    /// <inheritdoc cref="Console.Write(string, object?, object?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void write(string format, object? arg0, object? arg1) => Console.Write(format, arg0, arg1);

    /// <inheritdoc cref="Console.Write(string, object?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void write(string format, object? arg0) => Console.Write(format, arg0);

    /// <inheritdoc cref="Console.Write(string, object?[])" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void write(string format, params object?[]? arg) => Console.Write(format, arg);

    /// <inheritdoc cref="Console.Write(string?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void write(string? value) => Console.Write(value);

    /// <inheritdoc cref="Console.Write(uint)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void write(uint value) => Console.Write(value);

    /// <inheritdoc cref="Console.Write(ulong)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void write(ulong value) => Console.Write(value);



    /// <inheritdoc cref="Console.WriteLine()" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void println() => Console.WriteLine();

    /// <inheritdoc cref="Console.WriteLine(bool)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void println(bool value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(char)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void println(char value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(char[], int, int)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void println(char[] buffer, int index, int count) => Console.WriteLine(buffer, index, count);

    /// <inheritdoc cref="Console.WriteLine(char[])" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void println(char[]? buffer) => Console.WriteLine(buffer);

    /// <inheritdoc cref="Console.WriteLine(decimal)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void println(decimal value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(double)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void println(double value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(float)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void println(float value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(int)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void println(int value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(long)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void println(long value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(object?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void println(object? value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(string, object?, object?, object?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void println(string format, object? arg0, object? arg1, object? arg2) => Console.WriteLine(format, arg0, arg1, arg2);

    /// <inheritdoc cref="Console.WriteLine(string, object?, object?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void println(string format, object? arg0, object? arg1) => Console.WriteLine(format, arg0, arg1);

    /// <inheritdoc cref="Console.WriteLine(string, object?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void println(string format, object? arg0) => Console.WriteLine(format, arg0);

    /// <inheritdoc cref="Console.WriteLine(string, object?[])" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void println(string format, params object?[]? arg) => Console.WriteLine(format, arg);

    /// <inheritdoc cref="Console.WriteLine(string?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void println(string? value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(uint)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void println(uint value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(ulong)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void println(ulong value) => Console.WriteLine(value);



    /// <inheritdoc cref="Console.WriteLine()" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeln() => Console.WriteLine();

    /// <inheritdoc cref="Console.WriteLine(bool)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeln(bool value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(char)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeln(char value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(char[], int, int)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeln(char[] buffer, int index, int count) => Console.WriteLine(buffer, index, count);

    /// <inheritdoc cref="Console.WriteLine(char[])" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeln(char[]? buffer) => Console.WriteLine(buffer);

    /// <inheritdoc cref="Console.WriteLine(decimal)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeln(decimal value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(double)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeln(double value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(float)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeln(float value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(int)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeln(int value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(long)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeln(long value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(object?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeln(object? value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(string, object?, object?, object?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeln(string format, object? arg0, object? arg1, object? arg2) => Console.WriteLine(format, arg0, arg1, arg2);

    /// <inheritdoc cref="Console.WriteLine(string, object?, object?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeln(string format, object? arg0, object? arg1) => Console.WriteLine(format, arg0, arg1);

    /// <inheritdoc cref="Console.WriteLine(string, object?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeln(string format, object? arg0) => Console.WriteLine(format, arg0);

    /// <inheritdoc cref="Console.WriteLine(string, object?[])" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeln(string format, params object?[]? arg) => Console.WriteLine(format, arg);

    /// <inheritdoc cref="Console.WriteLine(string?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeln(string? value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(uint)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeln(uint value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(ulong)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeln(ulong value) => Console.WriteLine(value);



    /// <inheritdoc cref="Console.WriteLine()" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeline() => Console.WriteLine();

    /// <inheritdoc cref="Console.WriteLine(bool)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeline(bool value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(char)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeline(char value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(char[], int, int)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeline(char[] buffer, int index, int count) => Console.WriteLine(buffer, index, count);

    /// <inheritdoc cref="Console.WriteLine(char[])" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeline(char[]? buffer) => Console.WriteLine(buffer);

    /// <inheritdoc cref="Console.WriteLine(decimal)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeline(decimal value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(double)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeline(double value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(float)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeline(float value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(int)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeline(int value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(long)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeline(long value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(object?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeline(object? value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(string, object?, object?, object?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeline(string format, object? arg0, object? arg1, object? arg2) => Console.WriteLine(format, arg0, arg1, arg2);

    /// <inheritdoc cref="Console.WriteLine(string, object?, object?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeline(string format, object? arg0, object? arg1) => Console.WriteLine(format, arg0, arg1);

    /// <inheritdoc cref="Console.WriteLine(string, object?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeline(string format, object? arg0) => Console.WriteLine(format, arg0);

    /// <inheritdoc cref="Console.WriteLine(string, object?[])" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeline(string format, params object?[]? arg) => Console.WriteLine(format, arg);

    /// <inheritdoc cref="Console.WriteLine(string?)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeline(string? value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(uint)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeline(uint value) => Console.WriteLine(value);

    /// <inheritdoc cref="Console.WriteLine(ulong)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void writeline(ulong value) => Console.WriteLine(value);

#pragma warning restore IDE1006 // Naming Styles
}
