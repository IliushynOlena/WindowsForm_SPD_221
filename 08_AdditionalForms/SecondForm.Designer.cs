namespace _08_AdditionalForms
{
    partial class SecondForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nameLb = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 27.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(498, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 124);
            this.label1.TabIndex = 0;
            this.label1.Text = "Second Form";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(264, 733);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(446, 256);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Name";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Font = new System.Drawing.Font("Segoe UI", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLb.Location = new System.Drawing.Point(427, 462);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(315, 89);
            this.nameLb.TabIndex = 2;
            this.nameLb.Text = "Hello, ......";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(947, 733);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(446, 256);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 1075);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Label nameLb;
        private Button button2;
    }
}