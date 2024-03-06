using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAE_A21_D21.Forms;
using SAE_A21_D21.UserControls;

namespace SAE_A21_D21.Forms
{
    public partial class Eleve : CustomForm
    {
        // Référence vers le formulaire principal (main)
        private Main main;
        private string id;
        private string codeCours;
        private int codeLecon;
        private int codeExo;

        public Eleve(Main main, string id)
        {
            // Affecter la référence vers le parent
            this.main = main;
            this.id = id;
            codeCours = (string)main.dsDonnees.Tables["Utilisateurs"].Select("[codeUtil] = '" + id + "'")[0]["codeCours"];
            codeLecon = (int)main.dsDonnees.Tables["Utilisateurs"].Select("[codeUtil] = '" + id + "'")[0]["codeLeçon"];
            codeExo = (int)main.dsDonnees.Tables["Utilisateurs"].Select("[codeUtil] = '" + id + "'")[0]["codeExo"];
            InitializeComponent();
        }

        private void Eleve_ExitBtnClick(object sender, EventArgs e)
        {
            Dispose();
        }

        private double calculProgressionTotale()
        {
            int nbExos = main.dsDonnees.Tables["Exercices"].Select("[numCours] = '" + codeCours + "' AND [numLecon] = '" + codeLecon + "'").Count();

            return Math.Round(codeExo * 100.0 / nbExos, 1);
        }

        private int progressionLecon()
        {
            int idLecon = 0;

            // Exercices de la leçon actuelle, triés par exercice
            DataRow[] exercicesLecon = main.dsDonnees.Tables["Exercices"].DefaultView.ToTable().Select("[numCours] = '" + codeCours + "' AND [numLecon] = '" + codeLecon + "'");

            // Recherche de l'exercice
            int i = 0;
            // Parcours des exercices de la leçon actuelle
            foreach (DataRow exercice in exercicesLecon)
            {
                if ((int)exercice["numExo"] == codeExo)
                {
                    idLecon = i;
                }
                i++;
            }
            return idLecon + 1;
        }

        private void Eleve_Load(object sender, EventArgs e)
        {
            cpbProgression.Percentage = (float)calculProgressionTotale();

            lblNom.Text += main.dsDonnees.Tables["Utilisateurs"].Select("[codeUtil] = '" + id + "'")[0]["pnUtil"].ToString() + " " + main.dsDonnees.Tables["Utilisateurs"].Select("[codeUtil] = '" + id + "'")[0]["nomUtil"].ToString();
            lblMail.Text += main.dsDonnees.Tables["Utilisateurs"].Select("[codeUtil] = '" + id + "'")[0]["mailUtil"].ToString();

            DataRow[] exerciceSelectionne = main.dsDonnees.Tables["Exercices"].Select("[numCours] = '" + codeCours + "' AND [numLecon] = '" + codeLecon + "' AND [numExo] = '" + codeExo + "'");
            if (exerciceSelectionne.Length < 1)
            {
                MessageBox.Show("L'exercice enregistré pour cet utilisateur n'est pas valide.");
            }
            else
            {
                // L'exercice enregistré existe
                lblCours.Text += main.dsDonnees.Tables["Cours"].Select("[numCours] = '" + codeCours + "'")[0]["titreCours"].ToString();
                lblLecon.Text += main.dsDonnees.Tables["Lecons"].Select("[numLecon] = '" + codeLecon + "'")[0]["titreLecon"].ToString();
                lblExo.Text += progressionLecon().ToString() + " / " + main.dsDonnees.Tables["Exercices"].DefaultView.ToTable().Select("[numCours] = '" + codeCours + "' AND [numLecon] = '" + codeLecon + "'").Length.ToString();
            }
        }
    }
}
