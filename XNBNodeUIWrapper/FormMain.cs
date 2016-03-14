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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        UnpackForm unpacker = new UnpackForm();
        RepackForm repacker = new RepackForm();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/secretdataz");
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UnpackBtn_Click(object sender, EventArgs e)
        {
            if (unpacker.IsDisposed) unpacker = new UnpackForm();
            unpacker.Show();
        }

        private void RepackerBtn_Click(object sender, EventArgs e)
        {
            if (repacker.IsDisposed) repacker = new RepackForm();
            repacker.Show();
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Location.Y <= 30)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
