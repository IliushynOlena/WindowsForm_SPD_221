namespace _11_ListView_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dirTree.Nodes.Clear();
            LoadImages();
            LoadDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                dirTree.Nodes);
        }

        void LoadImages()
        {
            ImageList imageList = new ImageList();
            imageList.Images.Add(new Bitmap("folder.png"));
        }
        private void LoadDirectories(string dirPath, TreeNodeCollection nodes)
        {
             DirectoryInfo dir = new DirectoryInfo(dirPath);

            foreach (var subDir in dir.GetDirectories())
            {
                //dirTree.Nodes.Add(subDir.Name);
                TreeNode newNode = new TreeNode(subDir.Name);


                nodes.Add(newNode);
                if(subDir.GetDirectories().Length > 0)
                {
                    LoadDirectories(subDir.FullName, newNode.Nodes);
                }
                
            } 
        }
    }
}