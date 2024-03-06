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
    public partial class Menu : CustomForm
    {
        // Référence vers le formulaire principal (main)
        Main main;
        public Menu(Main main)
        {
            // Affecter la référence vers le parent
            this.main = main;
            InitializeComponent();
        }
        
        private void Menu_Load(object sender, EventArgs e)
        {
            if(main.sessionCodeUtil == 5 || main.sessionCodeUtil == 6)
            {
                btnAdministration.Visible = true;
            }
            progessBarCustom1.Percentage = (float)main.calculerProgressionTotale();

            lblProgressionLecon.Text = "Exercice : "+ main.sessionCodeExo.ToString() + " / " + nbExosLecon();
            lblLecon.Text = main.dsDonnees.Tables["Lecons"].Select("[numLecon] = '" + main.sessionCodeLecon + "'")[0]["titreLecon"].ToString();
            lblCours.Text = main.dsDonnees.Tables["Cours"].Select("[numCours] = '" + main.sessionCodeCours + "'")[0]["titreCours"].ToString();

        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            
            main.changerFormulaire(this, new Exercices(main));
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            main.deconnexion(this, main);
        }

        private void btnAdministration_Click(object sender, EventArgs e)
        {
            // Activer le bouton que si l'utilisateur a les droits ¤
            main.changerFormulaire(this, new Administration(main));
        }

        private void btnRecapitulatif_Click(object sender, EventArgs e)
        {
            main.changerFormulaire(this, new Recapitulatif(main, "menu"));
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

        private void btnJouer_Load(object sender, EventArgs e)
        {

        }

        private int nbExosLecon()
        {
            return main.dsDonnees.Tables["Exercices"].Select("[numCours] = '" + main.sessionCodeCours + "' AND [numLecon] = '" + main.sessionCodeLecon + "'").Length;
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            DataRow ex1 = main.dsDonnees.Tables["Exercices"].DefaultView.ToTable().Rows[0];
            main.sessionCodeCours = ex1["numCours"].ToString();
            main.sessionCodeLecon = (int)ex1["numLecon"];
            main.sessionCodeExo = int.Parse(ex1["numExo"].ToString());
            main.enregistrerProgression();

            main.changerFormulaire(this, new Menu(main));
        }

        private void lblCours_Click(object sender, EventArgs e)
        {

        }
    }
}
