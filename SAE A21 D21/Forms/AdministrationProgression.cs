using SAE_A21_D21.UserControls;
using System;
using System.Data;

namespace SAE_A21_D21.Forms
{
    public partial class AdministrationProgression : CustomForm
    {
        // Référence vers le formulaire principal (main)
        Main main;
        public AdministrationProgression(Main main)
        {
            // Affecter la référence vers le parent
            this.main = main;
            InitializeComponent();
        }

        private void AdministrationProgression_Load(object sender, EventArgs e)
        {
            /*for(int i = 0; i < 5; i++)
            {
                ProgressionEleve eleve = new ProgressionEleve(main);
                eleve.Dock = System.Windows.Forms.DockStyle.Top;
                eleve.Username = "Eleve " + i;
                pnlEleve.Controls.Add(eleve);
            }*/

            // Tous les élèves
            foreach(DataRow utilisateur in main.dsDonnees.Tables["Utilisateurs"].Select())
            {
                ProgressionEleve eleve = new ProgressionEleve(main);
                eleve.Dock = System.Windows.Forms.DockStyle.Top;
                eleve.Username = utilisateur["pnUtil"].ToString() + " " + utilisateur["nomUtil"].ToString();
                eleve.Id = utilisateur["codeUtil"].ToString();
                pnlEleve.Controls.Add(eleve);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            main.changerFormulaire(this, new Administration(main));
        }

        private void btnReini_Load(object sender, EventArgs e)
        {

        }

        private void userInfo1_Load(object sender, EventArgs e)
        {
            userInfo1.User = main.sessionNomUtilisateur;
            userInfo1.Lesson = main.dsDonnees.Tables["Cours"].Select("[numCours] = '" + main.sessionCodeCours + "'")[0]["titreCours"].ToString();
        }

        private void btnRetour_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRetour_Click_1(object sender, EventArgs e)
        {
            main.changerFormulaire(this, new Administration(main));
        }

        private void userInfo1_Click(object sender, EventArgs e)
        {
            main.deconnexion(this, main);
        }

        private void btnAdmini_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdmini_Click(object sender, EventArgs e)
        {
            main.changerFormulaire(this, new Menu(main));
        }
    }
}
