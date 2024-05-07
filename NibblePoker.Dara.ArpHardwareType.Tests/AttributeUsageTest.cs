using NibblePoker.Data.ArpHardwareType;
using NibblePoker.Data.ArpHardwareType.IANA;

namespace NibblePoker.Dara.ArpHardwareType.Tests;

public class Tests {
    [SetUp]
    public void Setup() {
        // Nothing to set up.
    }

    [Test]
    public void TestEnumAttribute() {
        Assert.That(
            ArpHardwareTypeName.GetFrom(EHardwareType.Reserved),
            Is.EqualTo("Reserved"));
    }
}
