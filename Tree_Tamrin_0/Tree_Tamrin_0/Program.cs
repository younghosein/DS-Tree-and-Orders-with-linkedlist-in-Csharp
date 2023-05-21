using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Tamrin_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Trre tree = new Trre(1);
            //tree.root = new Node(1);

            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            tree.root.right.left = new Node(6);
            tree.root.right.right = new Node(7);
            /*
                                      (1)
                                    /     \
                                 (2)       (3)
                                /  \       /  \
                             (4)   (5)   (6)   (7)
             */

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The Tree With Preorder Traversal Is :");
            tree.printPre(tree.root);
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The Tree With Inorder Traversal Is :");
            tree.printIn(tree.root);
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("The Tree With Postorder Traversal Is :");
            tree.printPost(tree.root);
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("The Count Of Tree Is : ");
            int c = tree.count(tree.root);
            Console.Write(c);
            Console.ResetColor();
            Console.WriteLine("\n");

            //Console.ForegroundColor = ConsoleColor.Blue;
            //bool leaf = tree.isleaf(tree.root.left.left);
            //if (leaf == true)
            //{
            //    Console.WriteLine($"{tree.root.left.left.data} Is a Leave...");
            //}
            //else if (leaf == false)
            //{
            //    Console.WriteLine($"{tree.root.left.left.data} Isn't Leave...");
            //}
            //Console.ResetColor();
            //Console.WriteLine("\n");

            //Console.ForegroundColor = ConsoleColor.Gray;
            //int s = tree.sum(tree.root);
            //Console.WriteLine(s);
            //Console.ResetColor();
            //Console.WriteLine("\n");

            //Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Console.WriteLine("Please Enter a Number To Add In Tree : ");
            //int d1 = int.Parse(Console.ReadLine());
            //tree.insert(tree.root, d1);
            //tree.printIn(tree.root);
            //Console.ResetColor();
            //Console.WriteLine("\n");
            ///*
            //                           (1)
            //                         /     \
            //                      (2)       (3)
            //                     /  \       /  \
            //                  (4)   (5)   (6)   (7)
            //                 /
            //              (d1)    
            // */
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            //Console.WriteLine("Please Enter a Number To Add In Tree : ");
            //int d2 = int.Parse(Console.ReadLine());
            //tree.insert(tree.root, d2);
            //tree.printIn(tree.root);
            //Console.ResetColor();
            //Console.WriteLine("\n");
            ///*
            //                           (1)
            //                         /     \
            //                      (2)       (3)
            //                     /  \       /  \
            //                  (4)   (5)   (6)   (7)
            //                 /  \   
            //              (d1)  (d2)  
            // */
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("The Tree With Levelorder Traversal Is :");
            int l = tree.count(tree.root);
            int i;
            for (i = 1; i <= l; i++)
            {
                tree.printLO(tree.root, i);
            }
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            int mx = tree.max(tree.root);
            Console.WriteLine($"The Maximum Of Tree Is : {mx}");
            int mn = tree.min(tree.root);
            Console.WriteLine($"The Minimum Of Tree Is : {mn}");
            Console.ResetColor();
            Console.WriteLine("\n");

            //Console.ForegroundColor = ConsoleColor.Magenta;
            //int k = 4;
            //tree.delete(tree.root, k);
            //tree.printPre(tree.root);
            //Console.ResetColor();
            //Console.WriteLine("\n");

            Console.ReadKey();


        }
    }
}
