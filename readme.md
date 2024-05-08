# .NET - ARP Hardware Type Data
[![Nuget.org latest version](https://img.shields.io/nuget/v/NibblePoker.Data.ArpHardwareType?label=Latest%20version)](https://www.nuget.org/packages/NibblePoker.Data.ArpHardwareType)
[![Nuget.org downloads count](https://img.shields.io/nuget/dt/NibblePoker.Data.ArpHardwareType?label=Downloads)](https://www.nuget.org/packages/NibblePoker.Data.ArpHardwareType)
[![Repository's License](https://img.shields.io/github/license/aziascreations/DotNet-ArpHardwareType)](https://github.com/aziascreations/DotNet-ArpHardwareType/blob/master/LICENSE)

A small package containing all the *ARP Hardware Types* as defined by de IANA, RFC 1700 and Linux in
distinct and convenient enums.

## Features
* Distinct sets:
  * IANA - *Current [IANA](https://www.iana.org/assignments/arp-parameters/arp-parameters.xhtml) standard*
  * RFC 1700 - *Before [RFC 3232](https://datatracker.ietf.org/doc/html/rfc3232) On-line Database*
  * Linux - *Parts of [RFC 1700](https://datatracker.ietf.org/doc/html/rfc1700), conflicts with [IANA](https://www.iana.org/assignments/arp-parameters/arp-parameters.xhtml), used by WireShark*
* Provides friendly names for UI usage

## Requirements
* .NET v4.0 or newer

## Documentation
Go to [aziascreations.github.io/DotNet-ArpHardwareType/](https://aziascreations.github.io/DotNet-ArpHardwareType/) for the HTML documentation.

## Example
```csharp
using System;
using NibblePoker.Data.ArpHardwareType;

static class Program {
    private static void Main(string[] args) {
        Console.WriteLine("IANA ARP Hardware Types:");
        foreach(EIanaArpHardwareTypes hardwareType in Enum.GetValues(typeof(EIanaArpHardwareTypes))) {
            Console.WriteLine("* " + (ulong) hardwareType + " - " + ArpHardwareTypeName.GetFrom(hardwareType));
        }
    }
}
```

## Licenses
The code in this repository is licensed under
[CC0 1.0 Universal (CC0 1.0) (Public Domain)](https://github.com/aziascreations/DotNet-ArpHardwareType/blob/master/LICENSE).

The [doxygen-awesome-css](https://github.com/jothepro/doxygen-awesome-css) repository is used as a
submodule for Doxygen and is licensed under the [MIT license](https://github.com/jothepro/doxygen-awesome-css/blob/main/LICENSE).
