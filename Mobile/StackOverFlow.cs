using System;

namespace Mobile
{
    class Example
    {
        public int value = 0;

        void Recursive()
        {
            // Write call number and call this method again.
            // ... The stack will eventually overflow.
            //Console.WriteLine(value);
            value++;
            try
            {
                if (value < 10000)
                {
                    Recursive();
                }
                else
                {
                    throw new StackOverFlowException("StackOverFlowException");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public static void main()
        {
            Example ex = new Example();
            // Begin the infinite recursion.
            ex.Recursive();
        }
    }
}