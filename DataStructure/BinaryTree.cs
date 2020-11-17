using System;
namespace DataStructure
{
    public class BinaryTree
    {
        internal Node currentObject { get; set; }
        public static void Main()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(40);
            binaryTree.Add(20);
            binaryTree.Add(50);
            binaryTree.Add(25);
            binaryTree.Add(60);
            binaryTree.Add(100);
            binaryTree.Add(1);

            Console.WriteLine(" finding 1 : " +  binaryTree.Find(1).ToString());
            Console.WriteLine(" finding 100 : " + binaryTree.Find(100).ToString());
            Console.WriteLine(" finding 1000 : " + binaryTree.Find(1000).ToString());
            Console.WriteLine(" finding 50 : " + binaryTree.Find(50).ToString());

            Console.WriteLine("Preorder traversal : "); binaryTree.PreOrderTraversal(binaryTree.currentObject);
            Console.WriteLine("InOrder Traverssal : "); binaryTree.InOrderTraversal(binaryTree.currentObject);
            Console.WriteLine("PostOrder Traversal : "); binaryTree.PostOrderTraversal(binaryTree.currentObject);
            Console.ReadLine();
        }
        private void Add(int value)
        {
            if(currentObject == null)
            {
                currentObject = new Node(value);
                return;
            }
            currentObject.Add(value);
        }
        public bool Find(int value)
        {
            Node presentNode =this.currentObject;
            while (presentNode != null)
            {
                if(value < presentNode.Value)
                {
                    if (presentNode.LeftNode != null) { presentNode = presentNode.LeftNode; } else return false;
                    
                }
                if (value > presentNode.Value)
                {
                    if (presentNode.RightNode != null) { presentNode = presentNode.RightNode; } else return false;
                    
                }
                if(value == presentNode.Value)
                {
                    presentNode = null;
                    return true;
                }
            }
            return false;
        }
        internal void PreOrderTraversal(Node sendNode)
        {
            Node presentNode = sendNode;
            Console.Write(presentNode.Value + ",");
            if (presentNode.LeftNode != null)
            {
                PreOrderTraversal(presentNode.LeftNode);
            }
            if(presentNode.RightNode != null)
            { PreOrderTraversal(presentNode.RightNode); }
        }
        internal void InOrderTraversal(Node sendNode)
        {
            Node presentNode = sendNode;
            if (presentNode.LeftNode != null)
            {
                InOrderTraversal(presentNode.LeftNode);
            }
            Console.Write(presentNode.Value + ",");
            if (presentNode.RightNode != null)
            { InOrderTraversal(presentNode.RightNode); }
        }
        internal void PostOrderTraversal(Node sendNode)
        {
            Node presentNode = sendNode;
            if (presentNode.LeftNode != null)
            {
                PostOrderTraversal(presentNode.LeftNode);
            }
            if (presentNode.RightNode != null)
            { PostOrderTraversal(presentNode.RightNode); }
            Console.Write(presentNode.Value + ",");
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
