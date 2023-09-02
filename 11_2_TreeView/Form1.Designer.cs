namespace _11_2_TreeView
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
            this.dirTree = new System.Windows.Forms.TreeView();
            this.fileView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // dirTree
            // 
            this.dirTree.Location = new System.Drawing.Point(12, 12);
            this.dirTree.Name = "dirTree";
            this.dirTree.Size = new System.Drawing.Size(902, 1207);
            this.dirTree.TabIndex = 0;
            this.dirTree.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.dirTree_BeforeCollapse);
            this.dirTree.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.dirTree_AfterExpand);
            this.dirTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dirTree_AfterSelect);
            // 
            // fileView
            // 
            this.fileView.Location = new System.Drawing.Point(935, 17);
            this.fileView.Name = "fileView";
            this.fileView.Size = new System.Drawing.Size(1512, 1202);
            this.fileView.TabIndex = 1;
            this.fileView.UseCompatibleStateImageBehavior = false;
            this.fileView.View = System.Windows.Forms.View.Tile;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2459, 1231);
            this.Controls.Add(this.fileView);
            this.Controls.Add(this.dirTree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView dirTree;
        private ListView fileView;
    }
}