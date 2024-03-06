using SAE_A21_D21.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_A21_D21
{
    public partial class ConfirmerQuitter : CustomForm
    {
        public ConfirmerQuitter()
        {
            InitializeComponent();
        }

        private void ConfirmerQuitter_Load(object sender, EventArgs e)
        {

        }

        private void btnNon_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOui_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
