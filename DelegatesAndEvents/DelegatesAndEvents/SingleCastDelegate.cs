using System;
namespace DelegatesAndEvents
{
    public class SingleCastDelegate
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition = {0}", a+b);
        }
        public static void Multiple(int a, int b)
        {
            Console.WriteLine("Multiplication = {0}", a * b);
        }
    }
    class ArrayDelegates
    {
        delegate void DelOp(int x, int y);
        public void ImplementDelegates()
        {
            DelOp[] obj =
            {
                new DelOp(SingleCastDelegate.Add),
                new DelOp(SingleCastDelegate.Multiple)
            };
            for (int i = 0; i < obj.Length; i++)
            {
                obj[i](2, 5);
                obj[i](3, 6);
                obj[i](4, 7);
                Console.WriteLine();
            }
        }
        
    }
}