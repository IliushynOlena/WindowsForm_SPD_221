namespace _11_ListView_TreeView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node8", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node7", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node5", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Level 1");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Level 2");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node4");
            this.dirTree = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // dirTree
            // 
            this.dirTree.Location = new System.Drawing.Point(12, 87);
            this.dirTree.Name = "dirTree";
            treeNode1.Name = "Node9";
            treeNode1.Text = "Node9";
            treeNode2.Name = "Node10";
            treeNode2.Text = "Node10";
            treeNode3.Name = "Node11";
            treeNode3.Text = "Node11";
            treeNode4.Name = "Node8";
            treeNode4.Text = "Node8";
            treeNode5.Name = "Node7";
            treeNode5.Text = "Node7";
            treeNode6.Name = "Node5";
            treeNode6.Text = "Node5";
            treeNode7.Name = "Node6";
            treeNode7.Text = "Node6";
            treeNode8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            treeNode8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            treeNode8.Name = "Node0";
            treeNode8.Text = "Node0";
            treeNode9.Name = "Node1";
            treeNode9.Text = "Level 1";
            treeNode10.Name = "Node2";
            treeNode10.Text = "Level 2";
            treeNode11.Name = "Node3";
            treeNode11.Text = "Node3";
            treeNode12.Name = "Node4";
            treeNode12.Text = "Node4";
            this.dirTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.dirTree.Size = new System.Drawing.Size(1101, 1037);
            this.dirTree.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(1144, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1132, 1037);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2288, 1136);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dirTree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView dirTree;
        private ListView listView1;
    }
}