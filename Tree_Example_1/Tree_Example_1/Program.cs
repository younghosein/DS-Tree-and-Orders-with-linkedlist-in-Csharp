using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree b = new Tree();
            b.insert(1);
            b.insert(2);
            b.insert(3);
            b.insert(4);
            b.insert(5);
            b.insert(6);
            b.insert(7);
            b.insert(8);
            b.insert(9);
            b.insert(10);
            b.insert(11);
            Console.WriteLine("The Inorder Traversal:\n");
            b.inOrderTraversal();
            Console.WriteLine("\n\nThe Preorder Traversal:\n");
            b.preOrderTraversal();
            Console.WriteLine("\n\nThe Postorder Traversal:\n");
            b.postOrderTraversal();
            Console.WriteLine("\n\nThe Tree After Delete 'F' Is:\n");
            b.removeNode(5);
            Console.WriteLine("The Inorder Traversal:\n");
            b.inOrderTraversal();
            Console.WriteLine("\n\nThe Preorder Traversal:\n");
            b.preOrderTraversal();
            Console.WriteLine("\n\nThe Postorder Traversal:\n");
            b.postOrderTraversal();

            Console.ReadKey();
        }
    }
}
