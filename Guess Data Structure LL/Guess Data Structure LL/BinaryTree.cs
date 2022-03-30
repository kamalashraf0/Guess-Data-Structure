using System;
using System.Collections.Generic;
using System.Text;

namespace Guess_Data_Structure_LL
{
    class BST
    {
        public BSTNode _head;

        public void Add(int value)
        {            
            if (_head == null)
            {
                _head = new BSTNode(value);
            }                   
            else
            {
                AddTo(_head, value);
            }

        }


        private void AddTo(BSTNode node, int value)
        {             
            if (value < node.Value)
            {
               
                if (node.Left == null)
                {
                    node.Left = new BSTNode(value);
                }
                else
                {                       
                    AddTo(node.Left, value);
                }

            }

           
            else
            {
               
                if (node.Right == null)
                {
                    node.Right = new BSTNode(value);
                }
                else
                {                     
                    AddTo(node.Right, value);
                }
            }
        }

        public void PostOrderTraversal()
        {
            PostOrderTraversal(_head);
        }
        private void PostOrderTraversal(BSTNode node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                Console.WriteLine(node.Value);
            }
        }

      
        private BSTNode FindWithParent(int value, out BSTNode parent)
        {
            BSTNode current = _head;

            parent = null;

            while (current != null)
            {
                if (value < current.Value)
                {

                    parent = current;
                    current = current.Left;
                }
                else if (value > current.Value)
                {
                    parent = current;
                    current = current.Right;
                }
                else
                    break;
            }
            return current;
        }


        public bool Remove(int value)
        {
            BSTNode current, parent;
            
            current = FindWithParent(value, out parent);
            if (current == null)
            {
                return false;
            }
           
            if (current.Right == null)
            {
                if (parent == null)
                    _head = current.Left;
                else
                {
                    if (parent.Value > current.Value)
                      
                        parent.Left = current.Left;
                    else if (parent.Value < current.Value)

                       
                        parent.Right = current.Left;
                }
            }



           
            else if (current.Right.Left == null)
            {
                current.Right.Left = current.Left;
                if (parent == null)
                    _head = current.Right;
                else
                {
                    if (parent.Value > current.Value)

                        
                        parent.Left = current.Right;
                    else if
                        (parent.Value < current.Value)
                       
                        parent.Right = current.Right;
                }
            }

            
            else
            {
                
                BSTNode leftmost = current.Right.Left;
                BSTNode leftmostParent = current.Right;
                while (leftmost.Left != null)
                {
                    leftmostParent = leftmost;
                    leftmost = leftmost.Left;
                }
                   
                leftmostParent.Left = leftmost.Right;
               
                leftmost.Left = current.Left;
                leftmost.Right = current.Right;
                if (parent == null)
                    _head = leftmost;
                else
                {
                    if (parent.Value > current.Value)
                      
                        parent.Left = leftmost;
                    else if (parent.Value < current.Value)
                       
                        parent.Right = leftmost;
                }

            }
            return true;

        }

    }
}
