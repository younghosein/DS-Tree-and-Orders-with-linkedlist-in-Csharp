using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Tamrin_0
{
    class Trre
    {
        public Node root;

        public Trre(int rootdata)
        {
            root = new Node(rootdata);
        }

        public Trre()
        {
            root = null;
        }

        public void printPre(Node n)
        {
            if (n == null)
            {
                return;
            }
            Console.Write($"{n.data} . ");
            printPre(n.left);
            printPre(n.right);
        }

        public void printIn(Node n)
        {
            if (n == null)
            {
                return;
            }
            printIn(n.left);
            Console.Write($"{n.data} . ");
            printIn(n.right);
        }

        public void printPost(Node n)
        {
            if (n == null)
            {
                return;
            }
            printPost(n.left);
            printPost(n.right);
            Console.Write($"{n.data} . ");
        }

        public int count(Node n)
        {
            if (n == null)
            {
                return 0;
            }
            int c = (1 + (count(n.left) + (count(n.right))));
            return c;
        }

        public bool isleaf(Node n)
        {
            if (n == null)
            {
                return false;
            }
            if (n.left == null && n.right == null)
            {
                return true;
            }
            return false;
        }

        public bool complete(Node root, int i, int n)
        {
            if (root == null)
            {
                return true;
            }
            if (i >= n)
            {
                return false;
            }
            return (complete(root.left, 2 * i, n) && complete(root.right, 2 * i + 1, n));
        }
        public int sum(Node root)
        {
            int s = 0;
            if (root != null)
            {
                //left -> bargai samte chap
                //right -> bargai samte rast
                if (isleaf(root.left))
                {
                    s = s + root.left.data;
                }
                else
                {
                    s = s + sum(root.left);
                }
                s = s + sum(root.right);
            }
            return s;
        }
        public void insert(Node root, int data)
        {
            if (root == null)
            {
                this.root = new Node(data);
                return;
            }
            Queue<Node> Q = new Queue<Node>();
            Q.Enqueue(root);

            while (Q.Count != 0)
            {
                root = Q.Peek();
                Q.Dequeue();

                if (root.left == null)
                {
                    root.left = new Node(data);
                    break;
                }
                else
                    Q.Enqueue(root.left);

                if (root.right == null)
                {
                    root.right = new Node(data);
                    break;
                }
                else
                    Q.Enqueue(root.right);
            }
        }

        /*public int Len(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int lheight = Len(root.left);
                int rheight = Len(root.right);

                if (lheight > rheight)
                {
                    return (lheight + 1);
                }
                else
                {
                    return (rheight + 1);
                }
            }
        }*/

        public void printLO(Node root, int level)
        {
            if (root == null)
            {
                return;
            }
            if (level == 1)
            {
                Console.Write(root.data + " . ");
            }
            else if (level > 1)
            {
                printLO(root.left, level - 1);
                printLO(root.right, level - 1);
            }
        }
        public int max(Node node)
        {
            if (node == null)
            {
                return int.MinValue;
            }

            int m = node.data;
            int lm = max(node.left);
            int rm = max(node.right);

            if (lm > m)
            {
                m = lm;
            }
            if (rm > m)
            {
                m = rm;
            }
            return m;
        }
        public int min(Node node)
        {
            if (node == null)
                return int.MaxValue;

            int m = node.data;
            int lm = min(node.left);
            int rm = min(node.right);

            if (lm < m)
                m = lm;
            if (rm < m)
                m = rm;
            return m;
        }
        //del
        public void deleteDeepest(Node root,
                          Node delNode)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            Node temp = null;
            Node a = q.Peek();

            // Do level order traversal until last node
            while (q.Count!=0)
            {
                temp = a;
                q.Dequeue();

                if (temp == delNode)
                {
                    temp = null;
                    return;

                }
                if (temp.right != null)
                {
                    if (temp.right == delNode)
                    {
                        temp.right = null;
                        return;
                    }
                    else
                        q.Enqueue(temp.right);
                }

                if (temp.left != null)
                {
                    if (temp.left == delNode)
                    {
                        temp.left = null;
                        return;
                    }
                    else
                        q.Enqueue(temp.left);
                }
            }
        }

    }
}
