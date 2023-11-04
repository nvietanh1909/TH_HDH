using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;


namespace _22DH110144_NguyenVietAnh
{
    public partial class Form1 : Form
    {
        string path;
        bool isHex;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openDialog.FileName;
                path = openDialog.FileName;
            }
        }
        private byte[] ReadFile()
        {
            using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                var bytes = new byte[fileStream.Length];
                fileStream.Read(bytes, 0, bytes.Length);
                return bytes;
            }
        }
        private void ShowContent(byte[] bytes)
        {
            if (isHex)
            {
                lbResult.Items.Clear();
                foreach (var item in bytes)
                {
                    lbResult.Items.Add($"{item:X2}");
                }
            }
            else
            {
                lbResult.Items.Clear();
                foreach (var item in bytes)
                {
                    lbResult.Items.Add(item.ToString("D2").PadLeft(8, '0'));
                }
            }
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                isHex = true;
                var bytes = ReadFile();
                ShowContent(bytes);
            }
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                isHex = false;
                var bytes = ReadFile();
                ShowContent(bytes);
            }
        }
    }
}