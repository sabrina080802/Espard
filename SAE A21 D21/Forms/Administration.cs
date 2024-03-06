using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using SAE_A21_D21.Forms;
using SAE_A21_D21.UserControls;

namespace SAE_A21_D21
{
    public partial class Administration : CustomForm
    {
        // Référence vers le formulaire principal (main)
        Main main;
        public Administration(Main main)
        {
            // Affecter la référence vers le parent
            this.main = main;
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            main.changerFormulaire(this, new Menu(main));
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            main.changerFormulaire(this, new AdministrationAjouter(main));
        }

        private void btnExercices_Click(object sender, EventArgs e)
        {
            main.changerFormulaire(this, new AdministrationExercices(main));
        }

        private void btnProgression_Click(object sender, EventArgs e)
        {
            main.changerFormulaire(this, new AdministrationProgression(main));
        }

        private void btnExercices_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnTerminer_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Load(object sender, EventArgs e)
        {

        }

        private void btnTerminer_Click(object sender, EventArgs e)
        {
            main.changerFormulaire(this, new Menu(main));

        }

        private void userInfo1_Load(object sender, EventArgs e)
        {
            userInfo1.User = main.sessionNomUtilisateur;
            userInfo1.Lesson = main.dsDonnees.Tables["Cours"].Select("[numCours] = '" + main.sessionCodeCours + "'")[0]["titreCours"].ToString();

        }

        private void userInfo1_Click(object sender, EventArgs e)
        {
            main.deconnexion(this, main);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
