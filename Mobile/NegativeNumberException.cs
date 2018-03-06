using System;

namespace Mobile
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message)
        {
        }
    }

    public class StackOverFlowException : Exception
    {
        public StackOverFlowException(string message)
        {
            
        }
    }
}