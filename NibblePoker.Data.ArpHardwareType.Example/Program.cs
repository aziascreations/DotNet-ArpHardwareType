using System;
using NibblePoker.Data.ArpHardwareType;

namespace NibblePoker.Data.ArpHardwareType.Example {
    static class Program {
        private static void Main(string[] args) {
            Console.WriteLine("IANA:");
            foreach(EIanaArpHardwareTypes hardwareType in Enum.GetValues(typeof(EIanaArpHardwareTypes))) {
                Console.WriteLine($"* {(ulong) hardwareType} - '{ArpHardwareTypeName.GetFrom(hardwareType)}'");
            }
        }
    }
}
