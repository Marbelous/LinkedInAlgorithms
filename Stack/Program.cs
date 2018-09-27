using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.ReadKey();
        }

        public class Stack
        {
            private int maxSize;
            private string[] stackArray;
            private int top;

            public Stack(int size)
            {
                maxSize = size;
                stackArray = new string[maxSize];
                top = -1;  // Index of element at the top of the stack.
            }
            public void Push(string m)
            {
                if (isFull())
                {
                    Console.WriteLine("This stack is full!");
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
