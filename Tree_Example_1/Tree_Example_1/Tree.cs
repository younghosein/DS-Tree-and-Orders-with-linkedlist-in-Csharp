using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Example_1
{
    class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }
        public void insert(int c)
        {
            addNode(c, ref root);
        }
        private void addNode(int c, ref Node rptr)
        {
            if (rptr == null)
                rptr = new Node(c);
            else if (rptr.left == null)
                addNode(c, ref rptr.left);
            else if (rptr.right == null)
                addNode(c, ref rptr.right);
            else
                addNode(c, ref rptr.left);
        }
        public void inOrderTraversal()
        {
            inOrderTraversalHelper(root);
        }
        private void inOrderTraversalHelper(Node r)
        {
            if (r != null)
            {
                inOrderTraversalHelper(r.left);
                Console.Write("{0}   ", r.id);
                inOrderTraversalHelper(r.right);
            }
        }
        public void preOrderTraversal()
        {
            preOrderTraversalHelper(root);
        }
        private void preOrderTraversalHelper(Node r)
        {
            if (r != null)
            {
                Console.Write("{0}   ", r.id);
                preOrderTraversalHelper(r.left);
                preOrderTraversalHelper(r.right);
            }
        }
        public void postOrderTraversal()
        {
            postOrderTraversalHelper(root);
        }
        private void postOrderTraversalHelper(Node r)
        {
            if (r != null)
            {
                postOrderTraversalHelper(r.left);
                postOrderTraversalHelper(r.right);
                Console.Write("{0}   ", r.id);
            }
        }
        public void removeNode(int c)
        {
            deleteNode(c, ref root);
        }

        private void deleteNode(int c, ref Node root)
        {
            if (root == null)
            {
                return;
            }
            else
            {
                if (root.left.id != c)
                {
                    removeNode(c);
                }
                else if (root.right.id != c)
                {
                    removeNode(c);
                }
                else if (root.left.id == c)
                {
                    root.left = root.left.left;
                }
                else if (root.right.id == c)
                {
                    root.right = root.right.right;
                }
            }

        }
    }
}
