using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_A21_D21.UserControls
{
    public partial class CustomForm : Form
    {
        private bool isBtnVisible = true;

        public CustomForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public event EventHandler ExitBtnClick
        {
            add
            {
                btnExit.Click -= button1_Click;
                btnExit.Click += value;
            }

            remove
            {
                btnExit.Click -= value;
                btnExit.Click += button1_Click;
            }
        }

        // Gestion du déplacement de la fenêtre.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CustomForm_Load(object sender, EventArgs e)
        {
            
        }

        public bool BtnVisible
        {
            get => isBtnVisible;
            set
            {
                isBtnVisible = value;
                btnExit.Visible = isBtnVisible;
                btnMinimise.Visible = isBtnVisible;
            }
        }
    }
}
