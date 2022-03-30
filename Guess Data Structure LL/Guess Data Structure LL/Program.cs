using System;

namespace Guess_Data_Structure_LL
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueLL<int> QLL = new QueueLL<int>();
            StackLL<int> SLL = new StackLL<int>();
            BST BT = new BST();
            Console.WriteLine("Enter Size");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Now ,Enter Data --> ");
               int data = int.Parse(Console.ReadLine());
                QLL.EnQueueLL(data);
                SLL.push(data);
                BT.Add(data);


            }
           

            while (true)
            {
                Console.WriteLine("1-If you want to remove the first element,then  Press 1 ");
                Console.WriteLine("\t\t******************************");

                Console.WriteLine("\t2-If you want to remove  the last element , then Press 2 ");
                Console.WriteLine("\t\t******************************");
                Console.WriteLine("\t\t2-If You Want To Remove  Any Element Except The First Element and The Last Element, then Press 3 ");


                int k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        QLL.DequeueLL();
                        Console.WriteLine("You Removed The First Element ");
                        Console.WriteLine("\n\t That Mean The Structure is **Queue** List");
                        Console.WriteLine("\n");

                        Console.WriteLine("The Display After Your Operation Will Be ");
                        Console.WriteLine("************************************");
                        QLL.Print();
                        Console.WriteLine("************************************");
                        Console.WriteLine();
                       
                        break;
                    case 2:

                        SLL.pop();
                        Console.WriteLine("You Removed The Last Element ");
                        
                        Console.WriteLine("\n\t That Mean The Structure is **Stack** List");
                        Console.WriteLine("\n");
                        Console.WriteLine("The Display After Your Operation Will Be ");
                        Console.WriteLine("************************************");

                        SLL.print();
                        Console.WriteLine("************************************");
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter The Element");
                        int data2 = int.Parse(Console.ReadLine());
                        BT.Remove(data2);
                        Console.WriteLine("The Display After Your Operation Will Be ");
                        Console.WriteLine("************************************");
                        BT.PostOrderTraversal();
                        Console.WriteLine("************************************");

                        Console.WriteLine("\n\t That Mean The Structure is **BinaryTree** ");
                        Console.WriteLine();

                        break;
                    default:
                        Console.WriteLine("Please Try Again ");
                        break;
                }
            }
         }
    }
}
