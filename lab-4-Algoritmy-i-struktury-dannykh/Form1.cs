using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_4_Algoritmy_i_struktury_dannykh
{
    public partial class Form1 : Form
    {
        private BinaryTree tree;

        public Form1()
        {
            InitializeComponent();
            tree = new BinaryTree();
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtNodeValue.Text, out float value))
            {
                tree.Add(value);
                MessageBox.Show("Вузол додано.");
                txtNodeValue.Clear();
                UpdateTreeView();
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть дійсне число.");
            }
        }

        private void btnPreOrderTraversal_Click(object sender, EventArgs e)
        {
            txtTraversalOutput.Text = tree.PreOrderTraversal(tree.Root);
        }

        private void btnRemoveNegativeNodes_Click(object sender, EventArgs e)
        {
            tree.Root = tree.RemoveNegativeNodes(tree.Root);
            MessageBox.Show("Вузли з негативними значеннями видалено.");
            UpdateTreeView();
        }

        private void UpdateTreeView()
        {
            treeView.Nodes.Clear();
            if (tree.Root != null)
            {
                var rootNode = CreateTreeNode(tree.Root);
                treeView.Nodes.Add(rootNode);
                treeView.ExpandAll();
            }
        }

        private TreeNode CreateTreeNode(BinaryTree.TreeNode node)
        {
            if (node == null) return null;

            TreeNode treeNode = new TreeNode(node.Value.ToString());
            if (node.Left != null)
            {
                treeNode.Nodes.Add(CreateTreeNode(node.Left));
            }
            if (node.Right != null)
            {
                treeNode.Nodes.Add(CreateTreeNode(node.Right));
            }

            return treeNode;
        }
    }
}
