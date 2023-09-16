namespace _15_Paint
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
            this.colorCb = new System.Windows.Forms.ComboBox();
            this.typeList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // colorCb
            // 
            this.colorCb.FormattingEnabled = true;
            this.colorCb.Location = new System.Drawing.Point(30, 16);
            this.colorCb.Name = "colorCb";
            this.colorCb.Size = new System.Drawing.Size(378, 49);
            this.colorCb.TabIndex = 0;
            // 
            // typeList
            // 
            this.typeList.FormattingEnabled = true;
            this.typeList.Location = new System.Drawing.Point(451, 19);
            this.typeList.Name = "typeList";
            this.typeList.Size = new System.Drawing.Size(510, 49);
            this.typeList.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2354, 1301);
            this.Controls.Add(this.typeList);
            this.Controls.Add(this.colorCb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox colorCb;
        private ComboBox typeList;
    }
}