namespace _10_RichTextBox
{
    public partial class Form1 : Form
    {
        public string DesktopPath => Environment.GetFolderPath(Environment.SpecialFolder.Desktop);  
        public Form1()
        {
            InitializeComponent();
        }

        private void FontBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(FontFamily.GenericMonospace, 20, FontStyle.Bold);
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
        }

        private void BackGrBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Yellow;
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent++;
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionRightIndent++;
        }

        private void bulletCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = bulletCheckBox.Checked;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(DesktopPath + @"\document.rtf",
                RichTextBoxStreamType.RichText);
            MessageBox.Show("File saved!!!");
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(DesktopPath + @"\document.doc",
                RichTextBoxStreamType.RichText);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if( dialog.ShowDialog() == DialogResult.OK )
            {
                richTextBox1.SelectionFont = dialog.Font;

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bulletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = bulletToolStripMenuItem.Checked;
        }
    }
}