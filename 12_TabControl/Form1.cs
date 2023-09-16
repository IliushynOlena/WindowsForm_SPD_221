namespace _12_TabControl
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            //tabControl1.TabPages.Clear();

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTb.Clear(); 
        }

        private void addNewPageBtn_Click(object sender, EventArgs e)
        {
           
            TabPage page = new TabPage($"New Tab {tabControl1.TabPages.Count+1}");
            page.Padding= new Padding(3);
            page.UseVisualStyleBackColor = true;
            // label1
            // 
            Label mainlabel = new Label();
            mainlabel.AutoSize = true;
            mainlabel.Font = new System.Drawing.Font("Segoe UI", 20.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            mainlabel.Location = new System.Drawing.Point(555, 208);
            mainlabel.Name = "label1";
            mainlabel.Size = new System.Drawing.Size(362, 89);
            mainlabel.TabIndex = 0;
            mainlabel.Text = "Hello User";
            // 
            // label2
            // 
            Label namelabel = new Label();
            namelabel.AutoSize = true;
            namelabel.Location = new System.Drawing.Point(199, 436);
            namelabel.Name = "label2";
            namelabel.Size = new System.Drawing.Size(112, 41);
            namelabel.TabIndex = 1;
            namelabel.Text = "Name :";
            // 
            // nameTb
            // 
            TextBox nametextBox = new TextBox();
            nametextBox.Location = new System.Drawing.Point(393, 436);
            nametextBox.Name = "nameTextBox";
            nametextBox.Size = new System.Drawing.Size(681, 47);
            nametextBox.TabIndex = 2;
            // 
            // clearBtn
            // 
            Button clearbutton = new Button();
            clearbutton.Location = new System.Drawing.Point(643, 647);
            clearbutton.Name = "clearBtn";
            clearbutton.Size = new System.Drawing.Size(188, 58);
            clearbutton.TabIndex = 3;
            clearbutton.Text = "Clear";
            clearbutton.UseVisualStyleBackColor = true;
            clearbutton.Click += (s, args) =>
            {
                nametextBox.Clear();
            
            };

            page.Controls.Add(mainlabel);
            page.Controls.Add(namelabel);
            page.Controls.Add(nametextBox);
            page.Controls.Add(clearbutton);
            //page.Controls.Add(nameTb);
            tabControl1.TabPages.Add(page);
        }

       

        private void removePageBtn_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != -1)
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
        }

        TextBox GetSelectedTextBox()
        {
            foreach (var item in tabControl1.SelectedTab.Controls.OfType<TextBox>())
            {
                if (item.Name == "nameTextBox")
                    return item;
            }
            return null;
        }
        private void showBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Name.....{GetSelectedTextBox().Text}");
        }
    }
}