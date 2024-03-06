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
    public partial class UserInfo : UserControl
    {
        private string username = "";
        public UserInfo()
        {
            InitializeComponent();
        }

        public string User
        {
            get => username;
            set
            {
                username = value;
                user.Text = "Holà " + username + ",";
            }
        }

        public string Lesson
        {
            get => lesson.Text;
            set
            {
                lesson.Text = value;
            }
        }

        public new event EventHandler Click
        {
            add
            {
                disconnect.Click += value;
            }
            remove
            { 
                disconnect.Click -= value;
            }
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
