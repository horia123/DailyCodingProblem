using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Days.Day3
{
    /*Given the root to a binary tree, implement serialize(root), which serializes the tree into a string, and deserialize(s),
     *which deserializes the string back into the tree. For example, given the following Node class:
     * class Node:
     *      def __init__(self, val, left=None, right=None):
     *      self.val = val
     *      self.left = left
     *      self.right = right
     *
     *The following test should pass:
     *  node = Node('root', Node('left', Node('left.left')), Node('right'))
     *  assert deserialize(serialize(node)).left.left.val == 'left.left'
     */
    public class Day3
    {
        private const string Empty_Marker = "1";

        public void SerializeDeserializeBinaryTree()
        {
            var node = new Node("root", new Node("left", new Node("left.left")), new Node("right"));
            var serializedNode = SerializeNode(node);

            Console.WriteLine(serializedNode);

            var deserializedNode = DeserializeNode(serializedNode);

            Console.WriteLine(deserializedNode.Left.Left.Value);
        }

        public string SerializeNode(Node node)
        {
            if (node == null)
            {
                return "-";
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(node.Value + "-");            
            sb.Append(SerializeNode(node.Left));            
            sb.Append(SerializeNode(node.Right));

            return sb.ToString();
        }

        static int index = 0;
        static bool leftFinished = false;
        static Node DeserializeNode(string serializedNode)
        {
            string[] serializedStringArray = serializedNode.Split('-');

            if (serializedStringArray[index] == "1" || serializedStringArray[index] == "")
            {
                index++;
                return null;
            }

            var deserializedNode = new Node(serializedStringArray[index]);
            if (!leftFinished)
            {
                index++;
                while (serializedStringArray[index] != "")
                {
                    deserializedNode.Left = DeserializeNode(serializedNode);                    
                }

                leftFinished = true;
            }

            index++;
            deserializedNode.Right = DeserializeNode(serializedNode);               
                

            return deserializedNode;
        }

        public class Node
        {
            public string Value;
            public Node Left;
            public Node Right;

            public Node(string value = null, Node left = null, Node right = null)
            {
                Value = value;
                Left = left;
                Right = right;
            }
        }
    }
}
