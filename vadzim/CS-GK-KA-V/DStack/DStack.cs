using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DStack
{
    class DStack
    {
        static void Main(string[] args)
        {
            #region M8

            Console.WriteLine("\n # DECLARING STACKS #");
            // ===========================================================
            Console.WriteLine("\n ### constructor: Stack<T>() ###");
            Stack<string> stringStack = new Stack<string>();
            
            Console.WriteLine("\n # USING STACKS #");
            // ===========================================================
            Console.WriteLine("\n ### MyStack.Push() ###");
            stringStack.Push("Element1"); // return-value: void
            stringStack.Push("Element2");
            stringStack.Push("Element3");
            stringStack.Push("Element4");
            foreach (var item in stringStack)
            {
                Console.WriteLine($"item: {item}");
            }


            // ===========================================================
            Console.WriteLine("\n ### value of MyStack ###");
            Console.WriteLine($"stringStack: {stringStack}");


            // ===========================================================
            Console.WriteLine("\n ### value of MyStack.Count ###");
            Console.WriteLine($"stringStack.Count: {stringStack.Count}");


            // ===========================================================
            Console.WriteLine("\n ### MyStack.Peek() ###");
            Console.WriteLine($"stringStack.Peek(): {stringStack.Peek()}");
            Console.WriteLine("Our stack after the last command:");
            foreach (var item in stringStack)
            {
                Console.WriteLine($"item: {item}");
            }


            // ===========================================================
            Console.WriteLine("\n ### MyStack.Pop() ###");
            Console.WriteLine($"stringStack.Pop(): {stringStack.Pop()}");
            Console.WriteLine("Our stack after the last command:");
            foreach (var item in stringStack)
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
