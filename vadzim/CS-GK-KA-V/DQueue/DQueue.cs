using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DQueue
{
    class DQueue
    {
        static void Main(string[] args)
        {
            #region M8

            Console.WriteLine("\n # DECLARING QUEUES #");
            // ===========================================================
            Console.WriteLine("\n ### constructor Queue<T>() ###");
            Queue<string> stringQueue = new Queue<string>();


            Console.WriteLine("\n # USING QUEUES #");
            // ===========================================================
            Console.WriteLine("\n ### MyQueue.Enqueue(newEl) ###");
            stringQueue.Enqueue("Element1");
            stringQueue.Enqueue("Element2");
            stringQueue.Enqueue("Element3");
            stringQueue.Enqueue("Element4");
            Console.WriteLine("Our Queue after the last command:");
            foreach (var item in stringQueue)
            {
                Console.WriteLine($"item: {item}");
            }


            // ===========================================================
            Console.WriteLine("\n ### value of MyQueue ###");
            Console.WriteLine($"stringQueue: {stringQueue}");


            // ===========================================================
            Console.WriteLine("\n ### MyQueue.Peek() ###");
            Console.WriteLine($"stringQueue.Peek(): {stringQueue.Peek()}");
            Console.WriteLine("Our Queue after the last command:");
            foreach (var item in stringQueue)
            {
                Console.WriteLine($"item: {item}");
            }


            // ===========================================================
            Console.WriteLine("\n ### MyQueue.Dequeue() ###");
            Console.WriteLine($"stringQueue.Dequeue(): {stringQueue.Dequeue()}");
            Console.WriteLine("Our Queue after the last command:");
            foreach (var item in stringQueue)
            {
                Console.WriteLine($"item: {item}");
            }

            #endregion M8

            // #############################################################################
            // #############################################################################
            // #############################################################################

            #region MORE FANCY STUFF

            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            #endregion

            Console.ReadKey();
        }
    }
}
