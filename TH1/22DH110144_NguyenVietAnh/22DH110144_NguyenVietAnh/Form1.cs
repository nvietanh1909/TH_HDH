using System.Diagnostics;
using System.Windows.Forms;
namespace _22DH110144_NguyenVietAnh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayProcess();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult ret = dlg.ShowDialog();
            if (ret == DialogResult.OK)
                txtPath.Text = dlg.FileName;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();
            try
            {
                myProcess.StartInfo.FileName = txtPath.Text;
                myProcess.Start();
                DisplayProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            String[] param = lbOutput.SelectedItem.ToString().Split(',');
            Process proc = Process.GetProcessById(Int32.Parse(param[1]));
            proc.Kill();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayProcess();
        }
        void DisplayProcess()
        {
            lbOutput.Items.Clear();
            Process[] splist = Process.GetProcesses();
            foreach(Process process in splist)
            {
                lbOutput.Items.Add(process.ProcessName + "," + process.Id);
            }
        }
    }
}