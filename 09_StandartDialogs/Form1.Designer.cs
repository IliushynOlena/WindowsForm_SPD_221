namespace _09_StandartDialogs
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
            this.openBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.openFolderBtn = new System.Windows.Forms.Button();
            this.bgBtn = new System.Windows.Forms.Button();
            this.fontBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(85, 63);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(188, 58);
            this.openBtn.TabIndex = 0;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(361, 63);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(188, 58);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // openFolderBtn
            // 
            this.openFolderBtn.Location = new System.Drawing.Point(1294, 63);
            this.openFolderBtn.Name = "openFolderBtn";
            this.openFolderBtn.Size = new System.Drawing.Size(307, 58);
            this.openFolderBtn.TabIndex = 2;
            this.openFolderBtn.Text = "Open Folder";
            this.openFolderBtn.UseVisualStyleBackColor = true;
            this.openFolderBtn.Click += new System.EventHandler(this.openFolderBtn_Click);
            // 
            // bgBtn
            // 
            this.bgBtn.Location = new System.Drawing.Point(111, 940);
            this.bgBtn.Name = "bgBtn";
            this.bgBtn.Size = new System.Drawing.Size(337, 58);
            this.bgBtn.TabIndex = 3;
            this.bgBtn.Text = "BackgroundColor";
            this.bgBtn.UseVisualStyleBackColor = true;
            this.bgBtn.Click += new System.EventHandler(this.bgBtn_Click);
            // 
            // fontBtn
            // 
            this.fontBtn.Location = new System.Drawing.Point(598, 940);
            this.fontBtn.Name = "fontBtn";
            this.fontBtn.Size = new System.Drawing.Size(188, 58);
            this.fontBtn.TabIndex = 4;
            this.fontBtn.Text = "Font";
            this.fontBtn.UseVisualStyleBackColor = true;
            this.fontBtn.Click += new System.EventHandler(this.fontBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 201);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1143, 701);
            this.textBox1.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 41;
            this.listBox1.Location = new System.Drawing.Point(1294, 201);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(772, 701);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2215, 1061);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fontBtn);
            this.Controls.Add(this.bgBtn);
            this.Controls.Add(this.openFolderBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.openBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button openBtn;
        private Button saveBtn;
        private Button openFolderBtn;
        private Button bgBtn;
        private Button fontBtn;
        private TextBox textBox1;
        private ListBox listBox1;
    }
}