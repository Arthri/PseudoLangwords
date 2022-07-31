# PseudoLangwords
[![Project License](https://img.shields.io/badge/license-MIT%20OR%20MIT--0%20OR%20Apache--2.0-green?style=flat-square "License")](https://github.com/Arthri/PseudoLangwords/blob/44a4d691faa514b2f16d870fac94f6f93ebe2dbb/LICENSE.md) [![NuGet](https://img.shields.io/nuget/v/PseudoLangwords?style=flat-square "Latest NuGet Release")](https://www.nuget.org/packages/PseudoLangwords/latest)

## Disclaimer
This project is not meant to be used seriously; it is merely a proof of concept

## Installation

### Requirements
- .NET 6+ or C#10+ project

### Install using Visual Studio Package Manager
1. Open Visual Studio
1. Right click the project in the Solution Explorer
1. Click on "Manage NuGet Packages"
1. Go to the "Browse" tab
1. Search for `PseudoLangwords`
1. Install

### Install using .NET CLI
1. Open a terminal
1. Navigate to the project's `.csproj`
1. Run `dotnet add package PseudoLangwords`

## Usage

### Type Aliases
```cs
Console.WriteLine(typeof(int8));     // Corresponds to System.SByte
Console.WriteLine(typeof(uint8));    // Corresponds to System.Byte
Console.WriteLine(typeof(int16));    // Corresponds to System.Int16
Console.WriteLine(typeof(uint16));   // Corresponds to System.UInt16
Console.WriteLine(typeof(int32));    // Corresponds to System.Int32
Console.WriteLine(typeof(uint32));   // Corresponds to System.UInt32
Console.WriteLine(typeof(int64));    // Corresponds to System.Int64
Console.WriteLine(typeof(uint64));   // Corresponds to System.UInt64
Console.WriteLine(typeof(half));     // Corresponds to System.Half
Console.WriteLine(typeof(fp16));     // Corresponds to System.Half
Console.WriteLine(typeof(float16));  // Corresponds to System.Half
Console.WriteLine(typeof(single));   // Corresponds to System.Single
Console.WriteLine(typeof(fp32));     // Corresponds to System.Single
Console.WriteLine(typeof(float32));  // Corresponds to System.Single
Console.WriteLine(typeof(fp64));     // Corresponds to System.Double
Console.WriteLine(typeof(float64));  // Corresponds to System.Double
Console.WriteLine(typeof(complex));  // Corresponds to System.Numerics.Complex
Console.WriteLine(typeof(bigint));   // Corresponds to System.Numerics.BigInteger
Console.WriteLine(typeof(boolean));  // Corresponds to System.Boolean
Console.WriteLine(typeof(datetime)); // Corresponds to System.DateTime
Console.WriteLine(typeof(time));     // Corresponds to System.TimeOnly
Console.WriteLine(typeof(date));     // Corresponds to System.DateOnly
Console.WriteLine(typeof(timespan)); // Corresponds to System.TimeSpan

int64 num = 43l;
long num2 = 43l;
Console.WriteLine(num == num2);     // true
Console.WriteLine(num is long);     // true
Console.WriteLine(num2 is int64);   // true
```

### Alternative Bool Literals
```cs
// All prints true
Console.WriteLine(True);
Console.WriteLine(true);
Console.WriteLine(On);
Console.WriteLine(on);
Console.WriteLine(Yes);
Console.WriteLine(yes);

// All prints false
Console.WriteLine(False);
Console.WriteLine(false);
Console.WriteLine(Off);
Console.WriteLine(off);
Console.WriteLine(No);
Console.WriteLine(no);
```

### Get Location
```cs
Console.WriteLine(linenum()); // Gets this line number where this is located
Console.WriteLine(currentfile()); // Gets the file where this is located
```

### Strongly-typed Expression Strings
```cs
int num = 3;
Console.WriteLine(nameofexpr(num)); // Prints num
Console.WriteLine(nameofexpr((int a, string b) => 3f)); // Prints (int a, string b) => 3f
```

### `Console.Write`/`Console.WriteLine` Aliases
```cs
print(2);
write(2);
Console.Write(2);
// 222

println(2);             // 2
writeln(2);             // 2
writeline(2);           // 2
Console.WriteLine(2);   // 2
```

### Print a Random Integer
```cs
Console.WriteLine(rint);
// Prints a random integer in the range(inclusive-inclusive) -2147483648..2147483647
```

## License
This work is available under three licenses: [MIT, MIT-0 and Apache 2.0](https://github.com/Arthri/PseudoLangwords/blob/44a4d691faa514b2f16d870fac94f6f93ebe2dbb/LICENSE.md)
