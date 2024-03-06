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

namespace SAE_A21_D21.Forms
{
    public partial class AjoutParticipant : CustomForm
    {
        Main main;

        public AjoutParticipant(Main main)
        {
                // Affecter la référence vers le parent
            this.main = main;

            InitializeComponent();
        }

        private void btnValider_Load(object sender, EventArgs e)
        {

        }

        private void btnValider_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            main.changerFormulaire(this, new Administration(main));

        }
    }
}
