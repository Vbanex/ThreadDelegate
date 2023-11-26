using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace ThreadDelegate
{
    public class ThreadD
    {
        private int a;
        private int b;
        Delegates.OperationDelegate operationDelegate;

        public ThreadD(int a, int b, Delegates.OperationDelegate operationDelegate)
        {
            this.a = a;
            this.b = b;
            this.operationDelegate = operationDelegate;
        }

        public void StartThreadOperation()
        {
            Console.WriteLine("\nThread delegate has started the operation.");
            if(operationDelegate != null)
            {
                operationDelegate(a, b);
            }
            Console.WriteLine("Thread delegate has finished the operation.\n");
        }

      

        public static void AdditionDelegate(int a, int b)
        {
            Thread.Sleep(2000);
            int sum = a + b;
            Console.WriteLine($"Addition of {a} and {b} is {sum}");
        }

        public static void MultiplyDelegate(int a, int b)
        {
            Thread.Sleep(2000);
            int sum = a * b;
            Console.WriteLine($"Multiplication of {a} and {b} is {sum}");
        }

        public static void SubtractionDelegate(int a, int b)
        {
            Thread.Sleep(2000);
            int sum = a * b;
            Console.WriteLine($"Subtraction of {a} and {b} is {sum}");
        }

    }

}
