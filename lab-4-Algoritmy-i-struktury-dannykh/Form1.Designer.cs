namespace lab_4_Algoritmy_i_struktury_dannykh
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNodeValue;
        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.Button btnPreOrderTraversal;
        private System.Windows.Forms.Button btnRemoveNegativeNodes;
        private System.Windows.Forms.TextBox txtTraversalOutput;
        private System.Windows.Forms.TreeView treeView;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNodeValue = new System.Windows.Forms.TextBox();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.btnPreOrderTraversal = new System.Windows.Forms.Button();
            this.btnRemoveNegativeNodes = new System.Windows.Forms.Button();
            this.txtTraversalOutput = new System.Windows.Forms.TextBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();

            // txtNodeValue
            this.txtNodeValue.Location = new System.Drawing.Point(20, 20);
            this.txtNodeValue.Name = "txtNodeValue";
            this.txtNodeValue.Size = new System.Drawing.Size(150, 27);
            this.txtNodeValue.TabIndex = 0;

            // btnAddNode
            this.btnAddNode.Location = new System.Drawing.Point(190, 20);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(100, 30);
            this.btnAddNode.TabIndex = 1;
            this.btnAddNode.Text = "Додати вузол";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);

            // btnPreOrderTraversal
            this.btnPreOrderTraversal.Location = new System.Drawing.Point(20, 70);
            this.btnPreOrderTraversal.Name = "btnPreOrderTraversal";
            this.btnPreOrderTraversal.Size = new System.Drawing.Size(150, 30);
            this.btnPreOrderTraversal.TabIndex = 2;
            this.btnPreOrderTraversal.Text = "Обхід дерева";
            this.btnPreOrderTraversal.UseVisualStyleBackColor = true;
            this.btnPreOrderTraversal.Click += new System.EventHandler(this.btnPreOrderTraversal_Click);

            // btnRemoveNegativeNodes
            this.btnRemoveNegativeNodes.Location = new System.Drawing.Point(190, 70);
            this.btnRemoveNegativeNodes.Name = "btnRemoveNegativeNodes";
            this.btnRemoveNegativeNodes.Size = new System.Drawing.Size(200, 30);
            this.btnRemoveNegativeNodes.TabIndex = 3;
            this.btnRemoveNegativeNodes.Text = "Видалити негативні вузли";
            this.btnRemoveNegativeNodes.UseVisualStyleBackColor = true;
            this.btnRemoveNegativeNodes.Click += new System.EventHandler(this.btnRemoveNegativeNodes_Click);

            // txtTraversalOutput
            this.txtTraversalOutput.Location = new System.Drawing.Point(20, 120);
            this.txtTraversalOutput.Multiline = true;
            this.txtTraversalOutput.Name = "txtTraversalOutput";
            this.txtTraversalOutput.Size = new System.Drawing.Size(370, 100);
            this.txtTraversalOutput.TabIndex = 4;

            // treeView
            this.treeView.Location = new System.Drawing.Point(420, 20);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(350, 300);
            this.treeView.TabIndex = 5;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.txtTraversalOutput);
            this.Controls.Add(this.btnRemoveNegativeNodes);
            this.Controls.Add(this.btnPreOrderTraversal);
            this.Controls.Add(this.btnAddNode);
            this.Controls.Add(this.txtNodeValue);
            this.Name = "Form1";
            this.Text = "Бінарне дерево";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
