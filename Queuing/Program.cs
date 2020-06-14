using System;

namespace Queuing
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue MyQueue = new Queue();

            MyQueue.PrintTheQueue();

            MyQueue.Enqueue(":)");

            MyQueue.PrintTheQueue();

            MyQueue.Enqueue(":(");

            MyQueue.PrintTheQueue();


            Console.ReadLine();
        }
    }
}
