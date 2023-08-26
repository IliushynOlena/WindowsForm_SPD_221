namespace _08_AdditionalForms
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginLb = new System.Windows.Forms.Label();
            this.passwordLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 27.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(502, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 109);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Form";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(223, 703);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(494, 109);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open new Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(235, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 89);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(533, 218);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(731, 47);
            this.nameTb.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(918, 703);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(508, 109);
            this.button2.TabIndex = 4;
            this.button2.Text = "Open Login Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 41);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password :";
            // 
            // loginLb
            // 
            this.loginLb.AutoSize = true;
            this.loginLb.Location = new System.Drawing.Point(533, 328);
            this.loginLb.Name = "loginLb";
            this.loginLb.Size = new System.Drawing.Size(74, 41);
            this.loginLb.TabIndex = 7;
            this.loginLb.Text = "........";
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Location = new System.Drawing.Point(533, 480);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(67, 41);
            this.passwordLb.TabIndex = 8;
            this.passwordLb.Text = ".......";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 885);
            this.Controls.Add(this.passwordLb);
            this.Controls.Add(this.loginLb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox nameTb;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label loginLb;
        private Label passwordLb;
    }
}