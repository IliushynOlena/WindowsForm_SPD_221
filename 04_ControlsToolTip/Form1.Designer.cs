namespace _04_ControlsToolTip
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.Language = new System.Windows.Forms.GroupBox();
            this.Language.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(305, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(581, 47);
            this.textBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBox1, "Enter you name");
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(39, 94);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(179, 45);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ukrainian";
            this.toolTip1.SetToolTip(this.radioButton1, "UA");
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(39, 200);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(149, 45);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "English";
            this.toolTip1.SetToolTip(this.radioButton2, "EN");
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(39, 316);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(160, 45);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "German";
            this.toolTip1.SetToolTip(this.radioButton3, "GN");
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(382, 632);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(234, 45);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Accept policy";
            this.toolTip3.SetToolTip(this.checkBox1, "Click to accept private policy");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 767);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 116);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirm";
            this.toolTip2.SetToolTip(this.button1, "Window will be close");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(614, 767);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(311, 116);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.toolTip2.SetToolTip(this.button2, "Window will be close");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Description";
            // 
            // toolTip2
            // 
            this.toolTip2.AutoPopDelay = 5000;
            this.toolTip2.InitialDelay = 1000;
            this.toolTip2.ReshowDelay = 100;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip2.ToolTipTitle = "Danger";
            // 
            // toolTip3
            // 
            this.toolTip3.AutoPopDelay = 5000;
            this.toolTip3.InitialDelay = 1000;
            this.toolTip3.ReshowDelay = 100;
            this.toolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.toolTip3.ToolTipTitle = "Atention";
            // 
            // Language
            // 
            this.Language.Controls.Add(this.radioButton2);
            this.Language.Controls.Add(this.radioButton1);
            this.Language.Controls.Add(this.radioButton3);
            this.Language.Location = new System.Drawing.Point(359, 210);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(465, 390);
            this.Language.TabIndex = 8;
            this.Language.TabStop = false;
            this.Language.Text = "Language";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1879, 1202);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Language.ResumeLayout(false);
            this.Language.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private ToolTip toolTip1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private GroupBox Language;
    }
}