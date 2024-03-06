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
    public partial class LeconSuivante : CustomForm
    {
        // Référence vers le formulaire principal (main)
        Main main;
        public LeconSuivante(Main main)
        {
            // Affecter la référence vers le parent
            this.main = main;
            InitializeComponent();
        }

        private void LeconSuivante_Load(object sender, EventArgs e)
        {
            DataRow ligneLecon = main.dsDonnees.Tables["Lecons"].Select("[numLecon] = '" + main.sessionCodeLecon + "' AND [numCours] = '" + main.sessionCodeCours + "'")[0];
            DataRow ligneCours = main.dsDonnees.Tables["Cours"].Select("[numCours] = '" + main.sessionCodeCours + "'")[0];
            lblTitreLecon.Text = ligneLecon["titreLecon"].ToString(); // Titre de la leçon
            lblCommentaireLecon.Text = ligneLecon["commentLecon"].ToString(); // Sera rien si aucun commentaire
            lblTitreCours.Text = ligneCours["titreCours"].ToString(); // Titre du cours
            lblCommentaireCours.Text = ligneCours["commentCours"].ToString(); // Sera rien si aucun commentaire
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            main.changerFormulaire(this, new Exercices(main, true));
        }

        private void btnRetour_Click(object sender, EventArgs e)
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

        private void btnCommencer_Load(object sender, EventArgs e)
        {

        }

        private void userInfo1_Click_1(object sender, EventArgs e)
        {
            main.deconnexion(this, main);
        }

        private void lblCommentaireCours_Click(object sender, EventArgs e)
        {

        }

        private void btnRetour_Load(object sender, EventArgs e)
        {

        }
    }
}
