using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Browser
{
    public partial class Form1 : Form { 
    List<String> listfiles = new List<string>();
        public Form1()
        {
            InitializeComponent();
            listfiles.Clear();
            listView1.Items.Clear();
            ListDirectory(treeView1, "C:\\humber");
        }

        private void ListDirectory(TreeView treeView, String path)
        {
            treeView1.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView1.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));

            foreach(var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            return directoryNode;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listfiles.Clear();
            listView1.Items.Clear();
            //MessageBox.Show(treeView1.SelectedNode.ToString());
            TreeNode currentNode = e.Node;
            String fpath = currentNode.FullPath;
           //MessageBox.Show(fpath);
            foreach (string item in System.IO.Directory.GetFiles("C:\\"+fpath))
            {
                imageList1.Images.Add(Icon.ExtractAssociatedIcon(item));
                System.IO.FileInfo fi = new System.IO.FileInfo(item);
                listfiles.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.FocusedItem!= null)
            {
                Process.Start(listfiles[listView1.FocusedItem.Index]);
            }
        }
    }
}
