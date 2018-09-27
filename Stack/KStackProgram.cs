using System;

namespace KStackNS
{
    class KStackClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- KStack Program -----");
            KStack stack1 = new KStack(4);

            stack1.Push("Item1");
            stack1.Push("Item2");
            stack1.Push("Item3");
            stack1.Push("Item4");
            stack1.Push("Item5");

            stack1.ShowStack();

            Console.WriteLine("Pop returns: " + stack1.Pop());
            Console.WriteLine("Pop returns: " + stack1.Pop());
            Console.WriteLine("Pop returns: " + stack1.Pop());

            stack1.ShowStack();

            Console.ReadKey();
        }

        public class KStack
        {
            private int maxSize;
            private string[] stackArray;
            private int top;

            public KStack(int size)
            {
                maxSize = size;
                stackArray = new string[maxSize];
                top = -1;  // Index of element at the top of the stack.
            }
            public void Push(string m)
            {
                if (isFull())
                {
                    Console.WriteLine($"Cannot push {m}.  This stack is full!");
                }
                else
                {
                    top++;
                    stackArray[top] = m;
                }
            }

            public string Pop()
            {
                if (isEmpty())
                {
                    Console.WriteLine("This stack is empty!");
                    return "---";
                }
                else
                {
                    int old_top = top; // Store temporary value of top.
                    top--;
                    return stackArray[old_top];
                }
            }

            public void ShowStack()
            {
                Console.WriteLine($"Current contents of {this}: ");
                foreach (var item in stackArray)
                {
                    Console.WriteLine(item);
                }
            }

            private bool isFull()
            {
                return (maxSize - 1 == top);
            }

            private bool isEmpty()
            {
                return (top == -1);
            }
        }
    }
}
