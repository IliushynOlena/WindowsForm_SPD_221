namespace _01_IntroToWinForm
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
            this.EnterBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftBtn = new System.Windows.Forms.Button();
            this.CSharpBtn = new System.Windows.Forms.Button();
            this.RightBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterBtn
            // 
            this.EnterBtn.BackColor = System.Drawing.Color.Lime;
            this.EnterBtn.Font = new System.Drawing.Font("Segoe UI", 15.9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EnterBtn.Location = new System.Drawing.Point(196, 210);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(429, 175);
            this.EnterBtn.TabIndex = 0;
            this.EnterBtn.Text = "Натисни на мене";
            this.EnterBtn.UseVisualStyleBackColor = false;
            this.EnterBtn.Click += new System.EventHandler(this.button1_Click);
            this.EnterBtn.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.EnterBtn.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Lime;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 15.9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.Location = new System.Drawing.Point(828, 224);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(300, 161);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Закрити";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(390, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 105);
            this.label1.TabIndex = 2;
            this.label1.Text = "Привіт Віндовс Форм";
            // 
            // LeftBtn
            // 
            this.LeftBtn.Location = new System.Drawing.Point(85, 645);
            this.LeftBtn.Name = "LeftBtn";
            this.LeftBtn.Size = new System.Drawing.Size(188, 58);
            this.LeftBtn.TabIndex = 3;
            this.LeftBtn.Text = "Move Left";
            this.LeftBtn.UseVisualStyleBackColor = true;
            this.LeftBtn.Click += new System.EventHandler(this.LeftBtn_Click);
            // 
            // CSharpBtn
            // 
            this.CSharpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CSharpBtn.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CSharpBtn.Location = new System.Drawing.Point(699, 596);
            this.CSharpBtn.Name = "CSharpBtn";
            this.CSharpBtn.Size = new System.Drawing.Size(150, 150);
            this.CSharpBtn.TabIndex = 4;
            this.CSharpBtn.Text = "C#";
            this.CSharpBtn.UseVisualStyleBackColor = false;
            this.CSharpBtn.Click += new System.EventHandler(this.CSharpBtn_Click);
            // 
            // RightBtn
            // 
            this.RightBtn.Location = new System.Drawing.Point(1287, 656);
            this.RightBtn.Name = "RightBtn";
            this.RightBtn.Size = new System.Drawing.Size(188, 58);
            this.RightBtn.TabIndex = 5;
            this.RightBtn.Text = "Move right";
            this.RightBtn.UseVisualStyleBackColor = true;
            this.RightBtn.Click += new System.EventHandler(this.RightBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1575, 1044);
            this.Controls.Add(this.RightBtn);
            this.Controls.Add(this.CSharpBtn);
            this.Controls.Add(this.LeftBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.EnterBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EnterBtn;
        private Button ExitBtn;
        private Label label1;
        private Button LeftBtn;
        private Button CSharpBtn;
        private Button RightBtn;
    }
}