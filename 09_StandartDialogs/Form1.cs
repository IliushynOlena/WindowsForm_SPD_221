namespace _09_StandartDialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bgBtn_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
           if( color.ShowDialog()== DialogResult.OK )
           {
                this.BackColor = color.Color;
           }
        }

        private void fontBtn_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if( font.ShowDialog()== DialogResult.OK )
            {
                var selected = font.Font;
                saveBtn.Font = selected;
                openBtn.Font = selected;
                openFolderBtn.Font = selected;
                fontBtn.Font = selected;
                bgBtn.Font = selected;
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            open.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt||";
            open.FilterIndex = 2;
            if(open.ShowDialog()== DialogResult.OK)
            {
                StreamReader reader = new StreamReader(open.FileName);
                textBox1.Text =  reader.ReadToEnd();
                reader.Close();
               
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog(); 
            save.CreatePrompt = true;
            save.DefaultExt = ".txt";
            save.OverwritePrompt = true;    
            if(save.ShowDialog()== DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                writer.Write(textBox1.Text);
                writer.Close();
            }
        }

        private void openFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.Desktop;
            if(dialog.ShowDialog()== DialogResult.OK)
            {
                listBox1.Items.Clear();
                foreach (string path in Directory.GetFiles(dialog.SelectedPath))
                {
                    listBox1.Items.Add(Path.GetFileName(path));
                }
            }
        }
    }
}