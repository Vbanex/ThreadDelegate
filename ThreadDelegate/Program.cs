using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadD thread = new ThreadD(5, 7,  new Delegates.OperationDelegate(ThreadD.AdditionDelegate));
            Thread thread1 = new Thread(new ThreadStart(thread.StartThreadOperation));
            thread1.Start();
            Console.WriteLine("Main thread has started, it will now wait for the thread delegate to work");
            thread1.Join();
            Console.WriteLine("Back to main thread, all operation have been concluded");
            Console.ReadKey();
        }
    }
}
