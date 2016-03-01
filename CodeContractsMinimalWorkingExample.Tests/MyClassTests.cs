using NUnit.Framework;

namespace CodeContractsMinimalWorkingExample.Tests
{
    [TestFixture]
    public class MyClassTests
    {
        [Test]
        public void Constructor_ViolatesPrecondition()
        {
            var classWithPreconditions = new MyClass(false);
        }

        [Test]
        public void Method_ViolatesPrecondition()
        {
            var classWithPreconditions = new MyClass(true);

            classWithPreconditions.MyMethod();
        }
    }
}
