using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._5kyu
{
    public class Node
    {
        private Node _nextNode;
        public Node next
        {
            get => _nextNode;
            set
            {
                _nextNode = value;
            }
        }
    }

    public static partial class Kata5
    {
        public static Node createChain(int chain, int loop)
        {
            Node[] nodes = Enumerable.Range(0, chain).Select(i => new Node()).ToArray();
            for (int i = 0; i < nodes.Count() - 1; i++)
            {
                nodes[i].next = nodes[i + 1];
            }

            nodes.Last().next = nodes[chain - loop];

            return nodes[0];
        }

        public static int getLoopSize(Node startNode)
        {
            if (startNode == null)
            {
                return 0;
            }

            int id = 1;
            var nodes = new Dictionary<Node, int>();

            var node = startNode;
            while (!nodes.ContainsKey(node))
            {
                nodes[node] = id;
                id++;
                node = node.next;
            }

            return id - nodes[node];
        }
    }
}