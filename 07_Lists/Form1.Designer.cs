namespace _07_Lists
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.orderCBox = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rivne",
            "Kyiv",
            "Odessa",
            "Mukolaiv"});
            this.comboBox1.Location = new System.Drawing.Point(71, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(407, 286);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Rivne",
            "Kyiv",
            "Odessa",
            "Mukolaiv"});
            this.comboBox2.Location = new System.Drawing.Point(526, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(407, 49);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Rivne",
            "Kyiv",
            "Odessa",
            "Mukolaiv"});
            this.comboBox3.Location = new System.Drawing.Point(998, 84);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(407, 49);
            this.comboBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select your city :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select your city :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(998, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select your city :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 96);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show city";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 41);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select order :";
            // 
            // orderCBox
            // 
            this.orderCBox.FormattingEnabled = true;
            this.orderCBox.Items.AddRange(new object[] {
            "Rivne",
            "Kyiv",
            "Odessa",
            "Mukolaiv"});
            this.orderCBox.Location = new System.Drawing.Point(93, 461);
            this.orderCBox.Name = "orderCBox";
            this.orderCBox.Size = new System.Drawing.Size(524, 49);
            this.orderCBox.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(744, 462);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(179, 47);
            this.numericUpDown1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 41);
            this.label5.TabIndex = 10;
            this.label5.Text = "Order Price :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(998, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(343, 96);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add New Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(998, 589);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(343, 96);
            this.button4.TabIndex = 12;
            this.button4.Text = "Remove Selected Order";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(998, 717);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(343, 96);
            this.button5.TabIndex = 13;
            this.button5.Text = "Show Selected Order";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 868);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderCBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private ComboBox orderCBox;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Button button2;
        private Button button4;
        private Button button5;
    }
}