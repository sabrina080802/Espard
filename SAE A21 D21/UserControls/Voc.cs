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
    public partial class Voc : UserControl
    {
        private int witheBoxPadding = 10;
        public Voc()
        {
            InitializeComponent();
        }

        public string Word
        {
            get => lblWord.Text;
            set
            {
                lblWord.Text = value;
            }
        }

        public string WordTrad
        {
            get => lblWordTrad.Text;
            set
            {
                lblWordTrad.Text = value;
            }
        }

        public string Origine
        {
            get => lblOrigine.Text;
            set
            {
                lblOrigine.Text = value;
            }
        }

        public Image Image
        {
            get => pictureBox1.Image;
            set
            {
                pictureBox1.Image = value;
            }
        }

        public int PaddingWhiteBox
        {
            get => witheBoxPadding;
            set
            {
                witheBoxPadding = value;
                panel2.Padding = new Padding(witheBoxPadding, 0, witheBoxPadding, 0);
            }
        }

        private void Voc_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
