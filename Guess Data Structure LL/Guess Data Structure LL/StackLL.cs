using System;
using System.Collections.Generic;
using System.Text;

namespace Guess_Data_Structure_LL
{
    class StackLL<T>
    {

        public Node<T> top=null , MyNode;



        public void print()
        {
            Node<T> Mynode = top;
            if (top == null)
            {
                Console.WriteLine("Stack is empty");

            }
            else
            {
               
                while (Mynode  != null)
                {

                    Console.WriteLine(Mynode .Data);
                    
                    Mynode  = Mynode .Next;

                }
            }
        }

        public void push(T value)
        {
            if (top == null)
            {
                top = new Node<T>(value);
            }

         else
            {
                MyNode = new Node<T>(value);
                MyNode.Next = top;
                top = MyNode;
            }
           
        }

        public void pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack UnderFlow");

            }
            else
            {
                Console.WriteLine("You Removed  --> "+top.Data);
                top = top.Next;
            }
        }
    }
}
