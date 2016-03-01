using System;

namespace CodeContractsMinimalWorkingExample.Tests
{
    public static class TestFailureMethods
    {
        public static void Requires(bool condition, string userMessage, string conditionText)
        {
            if (!condition)
            {
                throw new Exception("Custom Failure Method");
            }
        }
        
        public static void Requires<TException>(bool condition, string userMessage, string conditionText) where TException : Exception
        {
            if (!condition)
            {
                throw new Exception("Custom Failure Method");
            }
        }
    }
}