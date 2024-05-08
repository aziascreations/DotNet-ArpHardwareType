using NibblePoker.Data.ArpHardwareType;
using NUnit.Framework;

namespace NibblePoker.Data.ArpHardwareType.Tests {
    public class Tests {
        [SetUp]
        public void Setup() {
            // Nothing to set up.
        }

        [Test]
        public void TestEnumAttribute() {
            Assert.That(
                ArpHardwareTypeName.GetFrom(EIanaArpHardwareTypes.Reserved),
                Is.EqualTo("Reserved"));
        }
    }
}
