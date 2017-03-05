using System;

namespace Delegate
{
    class Program
    {
        /* Delegate declaration determines the methods that can be referenced by the delegate. 
         * A delegate can refer to a method, which has the same signature as that of the delegate.
         * 
         * Instantiating Delegates
         * 
         * Once a delegate type is declared, a delegate object must be created with the new keyword and be associated with a particular method. 
         * When creating a delegate, the argument passed to the new expression is written similar to a method call, but without the arguments to the method.
         * 
         * For example:
         *  public delegate int NumberChanger(int n);
         *  ...
         *  NumberChanger nc1 = new NumberChanger(AddNum);
         *  NumberChanger nc2 = new NumberChanger(MultNum);
         */

        // Define the type.
        public delegate int NumberChanger(int n);

        class TestDelegate
        {
            static int num = 10;
            public static int AddNum(int p)
            {
                num += p;
                return num;
            }

            public static int MultNum(int q)
            {
                num *= q;
                return num;
            }

            public static int getNum()
            {
                return num;
            }

            static void Main(string[] args)
            {
                //create delegate instances
                NumberChanger nc;
                NumberChanger nc1 = new NumberChanger(AddNum);
                NumberChanger nc2 = new NumberChanger(MultNum);
                nc = nc1;
                nc += nc2;

                //calling multicast
                nc(5);
                Console.WriteLine("Value of Num: {0}", getNum());
                Console.ReadKey();
            }
        }
    }
}
