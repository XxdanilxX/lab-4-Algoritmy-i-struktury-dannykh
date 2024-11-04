using System;
using System.Windows.Forms;

namespace lab_4_Algoritmy_i_struktury_dannykh
{
    internal class BinaryTree
    {
        public class TreeNode
        {
            public float Value;
            public TreeNode Left;
            public TreeNode Right;

            public TreeNode(float value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }

        public TreeNode Root;

        public BinaryTree()
        {
            Root = null;
        }

        public void Add(float value)
        {
            Root = AddRecursive(Root, value);
        }

        private TreeNode AddRecursive(TreeNode node, float value)
        {
            if (node == null)
            {
                return new TreeNode(value);
            }

            if (value < node.Value)
            {
                node.Left = AddRecursive(node.Left, value);
            }
            else
            {
                node.Right = AddRecursive(node.Right, value);
            }

            return node;
        }

        public string PreOrderTraversal(TreeNode node)
        {
            if (node == null) return "";

            string result = $"{node.Value} ";
            result += PreOrderTraversal(node.Left);
            result += PreOrderTraversal(node.Right);

            return result;
        }

        public TreeNode RemoveNegativeNodes(TreeNode node)
        {
            if (node == null) return null;

            node.Left = RemoveNegativeNodes(node.Left);
            node.Right = RemoveNegativeNodes(node.Right);

            // Видаляємо вузол, якщо значення негативне
            return node.Value < 0 ? (node.Left ?? node.Right) : node;
        }
    }
}
