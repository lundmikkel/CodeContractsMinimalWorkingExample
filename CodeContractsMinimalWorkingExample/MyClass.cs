using System.Diagnostics.Contracts;

namespace CodeContractsMinimalWorkingExample
{
    public class MyClass
    {
        public MyClass(bool value)
        {
            Contract.Requires(value);
        }

        public void MyMethod()
        {
            Contract.Requires(false);
        }
    }
}
