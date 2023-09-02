namespace _11_2_TreeView
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

            fileView.View = View.Details;
            fileView.Columns.Add("Name").Width = 500;
            fileView.Columns.Add("Extenions").Width = 200;
            fileView.Columns.Add("Date Create").Width = 500;


        }
        void LoadImages()
        {
            ImageList imageList = new ImageList();
            imageList.Images.Add(new Bitmap("Images/folder.png"));
            imageList.Images.Add(new Bitmap("Images/open.png"));
            imageList.Images.Add(new Bitmap("Images/select.png"));

            dirTree.ImageList = imageList;
            dirTree.ImageList.ImageSize = new Size(50, 50);
        }
        private void LoadDirectories(string dirPath, TreeNodeCollection nodes)
        {
            DirectoryInfo dir = new DirectoryInfo(dirPath);

            foreach (var subDir in dir.GetDirectories())
            {
                //dirTree.Nodes.Add(subDir.Name);
                TreeNode newNode = new TreeNode(subDir.Name, 0, 2);
                newNode.Tag = subDir.FullName;


                nodes.Add(newNode);
                if (subDir.GetDirectories().Length > 0)
                {
                    LoadDirectories(subDir.FullName, newNode.Nodes);
                }

            }
        }

        private void dirTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

            fileView.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(e.Node.Tag.ToString());
            foreach (var file in dir.GetFiles())
            {
                ListViewItem list = new ListViewItem(file.Name);
                list.SubItems.Add(file.Extension);
                list.SubItems.Add(file.CreationTime.ToString());

                fileView.Items.Add(list);
            }
        }

        private void dirTree_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

        private void dirTree_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0 ;
        }
    }
}