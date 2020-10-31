using System;
namespace DataStructure
{
    public class BinaryTree
    {
        public static void Main()
        {
            Node n1 = new Node(40);
            n1.Add(20);
            n1.Add(50);
            n1.Add(10);
            n1.Add(60);
        }
    }

    internal class Node
    {
        public int Value { get; set; }
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        internal Node(int value)
        {
            this.Value = value;
        }

        internal void Add(int value)
        {
            if (value < this.Value)
            {
                if (this.LeftNode == null)
                {
                    this.LeftNode = new Node(value);
                }
                else
                {
                    this.LeftNode.Add(value);
                }
            }
            if (value > this.Value)
            {
                if(this.RightNode == null)
                {
                    this.RightNode = new Node(value);
                }
                else
                {
                    this.RightNode.Add(value);
                }
            }
        }
    }
}
