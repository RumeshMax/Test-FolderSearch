using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_FolderSearch
{
    public partial class Form1 : Form
    {
        private string directoryPath = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = fbdSelectFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                generateAll(fbdSelectFolder.SelectedPath);
            }
        }

        private void txtSelectedPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                generateAll(this.txtSelectedPath.Text);
            }
        }

        private void generateAll(string path)
        {
            bool isErrorRaised = false;

            try
            {
                this.directoryPath = path;
                this.txtSelectedPath.Text = path;
                string[] extensions = { ".mp3", ".MP4" };

                lstFileList.Items.Clear();
                dgvFileList.Rows.Clear();
                try
                {
                    //foreach (string filePath in Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories))
                    foreach (string filePath in Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories).Where(s => extensions.Any(ext => ext.ToLower() == Path.GetExtension(s).ToLower())))
                    //foreach (string filePath in Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).Where(s => extensions.Any(ext => ext == Path.GetExtension(s))))
                    {
                        lstFileList.Items.Add(filePath);

                        String[] data = new String[] { Path.GetFileName(filePath), filePath, Path.GetExtension(filePath), "Show in Folder", "Play" };

                        dgvFileList.Rows.Add(data);
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    isErrorRaised = true;
                }

                ListDirectory(tvFolderNavigation, path);
                //tvFolderNavigation.ExpandAll();
            }
            catch (Exception e2)
            {
                if (!isErrorRaised)
                {
                    MessageBox.Show(e2.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void dgvFileList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((dgvFileList.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (e.RowIndex >= 0))
                {
                    if (e.ColumnIndex == 3) // Open Folder button press
                    {
                        String filePath = dgvFileList.Rows[e.RowIndex].Cells[1].Value.ToString();
                        Process.Start("explorer.exe", string.Format("/select,\"{0}\"", filePath));
                    }
                    else if (e.ColumnIndex == 4) // Open File button press
                    {
                        String filePath = dgvFileList.Rows[e.RowIndex].Cells[1].Value.ToString();
                        Process.Start(filePath);
                    }

                }
            }
            catch (Exception) { }
        }

        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);

            foreach (var directory in directoryInfo.GetDirectories())
            {
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            }

            foreach (var file in directoryInfo.GetFiles())
            {
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            }

            return directoryNode;
        }

    }
}
