using System;

namespace DelegatesAndEvents
{
    public delegate int Operation(int x, int y);//Delegate Declaration
    class Program
    {
        static int Addition(int a, int b)//Method that Passes as an argument(same as Delegate)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate");
            Operation obj = new Operation(Addition);//Delegate Installation
            Console.WriteLine("Addition is : {0}", obj(25, 67));
            Console.WriteLine("Using Single Cast Delegates");
            ArrayDelegates single = new ArrayDelegates();
            single.ImplementDelegates();
            Console.WriteLine("Using Multi Cast Delegates");
            MultiCastDelegates multi = new MultiCastDelegates();
            multi.ImplementDelegate();
        }        
    }
}