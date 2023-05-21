using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Example_1
{
    class Node
    {
        public int id;
        public Node left;
        public Node right;
        public Node(int id)
        {
            this.id = id;
            left = right = null;
        }
    }
}
