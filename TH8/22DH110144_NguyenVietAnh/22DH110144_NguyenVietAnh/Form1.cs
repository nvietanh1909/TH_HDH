using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22DH110144_NguyenVietAnh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            cbDrives.Items.Clear();
            foreach(DriveInfo d in allDrives)
            {
                cbDrives.Items.Add(d.Name);
            }
            cbDrives.SelectedIndex = 0;
            dgvFiles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFiles.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvFiles.GridColor = Color.Black;
            dgvFiles.ColumnCount = 3;
            dgvFiles.Columns[0].Name = "Tên File";
            dgvFiles.Columns[1].Name = "Kích thước";
            dgvFiles.Columns[2].Name = "Cập nhật lần cuối lúc";
            dgvFiles.Font = new Font("Tahoma", 10f);
            dgvFiles.Name = "dgvFiles";
            dgvFiles.AutoResizeColumns();
            dgvFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFiles.MultiSelect = true;
            dgvFiles.AllowUserToResizeColumns = true;


        }

        private void cbDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sdrv = cbDrives.SelectedItem.ToString();
            tvFolders.Nodes.Clear();
            TreeNode FdNode = new TreeNode();
            FdNode.Text = sdrv;
            tvFolders.Nodes.Add(FdNode);
            Populate(FdNode, sdrv);
            FdNode.Expand();
            tvFolders.Refresh();
        }
        private void Populate(TreeNode FdNode, String sdir)
        {
            string[] sdlistw = Directory.GetDirectories(sdir);
            TreeNode ChildNode;
            FdNode.Nodes.Clear();
            foreach(string subdir in sdlistw)
            {
                string[] lstStr = subdir.Split('\\');
                ChildNode = new TreeNode();
                ChildNode.Text = lstStr[lstStr.Length - 1];
                ChildNode.Nodes.Add(new TreeNode());
                FdNode.Nodes.Add(ChildNode);
            }
        }

        private void tvFolders_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.X > e.Node.Bounds.Left)
            {
                DisplayFiles(getDir(e.Node));
            }
            else
            {
                tvFolders_NodeMouseClick(sender, e);
            }
        }
        private void DisplayFiles(String sdir)
        {
            dgvFiles.Rows.Clear();
            string[] flist = Directory.GetFiles(sdir);
            String[] sbuf = new String[3];
            String[] buf;
            foreach(string fname in flist)
            {
                FileInfo fi = new FileInfo(fname);
                sbuf[1] = fi.Length.ToString();
                sbuf[2] = fi.LastWriteTime.ToString();
                buf = fname.Split('\\');
                sbuf[0] = buf[buf.Length - 1];
                dgvFiles.Rows.Add(sbuf);
            }
        }
        private String getDir(TreeNode node)
        {
            String kq = node.Text;
            while(node.Parent != null)
            {
                node = node.Parent;
                if (node.Parent != null) kq = node.Text + '\\' + kq;
                else kq = node.Text + kq;
            }
            return kq;
        }

        private void tvFolders_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.NextNode != null && node.IsExpanded == false) node.Collapse();
            else
            {
                String sdir = getDir(node);
                Populate(node, sdir);
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int cx = ClientSize.Width;
            int cy = ClientSize.Height;
            int top = tvFolders.Top;
            int left = tvFolders.Left;
            tvFolders.Size = new Size(cx / 3 - left, cy - 8 - top);
            dgvFiles.Location = new Point(cx / 3, top);
            dgvFiles.Size = new Size(2 * cx / 3 - 8, cy - 8 - top);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
