using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XNBNodeUIWrapper
{
    public partial class UnpackForm : Form
    {
        public UnpackForm()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void UnpackForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Location.Y <= 30)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //UnpackFileBtn_Click
        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(SourceFileBox.Text))
            {
                MessageBox.Show("กรุณาเลือกไฟล์");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "YAML File|*.yml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                XNBHelper.Unpack(SourceFileBox.Text, sfd.FileName);
            }
        }

        private void UnpackDirBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SourceDirBox.Text))
            {
                MessageBox.Show("กรุณาเลือกโฟลเดอร์");
                return;
            }
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                XNBHelper.Unpack(SourceDirBox.Text, fbd.SelectedPath);
            }
        }

        private void BrowseSourceFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ไฟล์ XNB|*.xnb";
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                SourceFileBox.Text = ofd.FileName;
            }
        }

        private void BrowseSourceDirBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                SourceDirBox.Text = fbd.SelectedPath;
            }
        }
    }
}
