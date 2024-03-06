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
using SAE_A21_D21.UserControls;

namespace SAE_A21_D21
{
    public partial class Login : CustomForm
    {

        // Référence vers le formulaire principal (main)
        Main main;
        public Login(Main main)
        {
            // Affecter la référence vers le parent
            this.main = main;
            InitializeComponent();
        }

        private void remplirCbo()
        {
            // Mode connecté

            try
            {
                main.co = new OleDbConnection(main.chaineConnexion);
                main.co.Open();

                // Sélection des utilisateurs de la BDD
                string requete = "SELECT [codeUtil], [pnUtil], [nomUtil] FROM [Utilisateurs]";
                OleDbCommand com = new OleDbCommand(requete, main.co);

                // Dictionnaire qui contient chaque utilisateur avec comme clé son numéro et valeur son prénom et nom
                Dictionary<int, string> utilisateurs = new Dictionary<int, string>();

                OleDbDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    // <codeUtil, pnUtil + nomUtil>
                    utilisateurs.Add((int)dr[0], dr[1].ToString() + " " + dr[2].ToString());
                }
                
                // Utilisation du dictionnaire comme DataSource
                cboUtilisateurs.DataSource = new BindingSource(utilisateurs, null);
                cboUtilisateurs.DisplayMember = "Value"; // Valeur du dictionnaire
                cboUtilisateurs.ValueMember = "Key"; // Clé du dictionnaire
            }
            catch (Exception err) { MessageBox.Show(err.ToString()); }

            main.co.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            remplirCbo();
            pictureBox1.BackColor = Color.Transparent;

        }

        private void cboUtilisateurs_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCustom1_Click(object sender, EventArgs e)
        {
            // Changement d'utilisateur
            main.sessionCodeUtil = (int)cboUtilisateurs.SelectedValue;

            // Récupérer le nom d'utilisateur, l'exercice et vérifier si l'exercice est valide dans la table
            try
            {
                string filtre = "[codeUtil] = " + main.sessionCodeUtil;
                // Ligne de l'utilisateur
                DataRow ligneUtilisateur = main.dsDonnees.Tables["Utilisateurs"].Select(filtre)[0];
                // Récupération des variables
                main.sessionNomUtilisateur = ligneUtilisateur["pnUtil"].ToString() + " " + ligneUtilisateur["nomUtil"].ToString();
                main.sessionCodeExo = (int)ligneUtilisateur["codeExo"];
                main.sessionCodeLecon = (int)ligneUtilisateur["codeLeçon"];
                main.sessionCodeCours = (string)ligneUtilisateur["codeCours"];
                //main.enregistrerProgression();
                main.creerRecapitulatif();

                // Teste la présence de l'exercice dans la table Exercices
                // MessageBox.Show(main.sessionCodeExo + " " + main.sessionCodeLecon + " " + main.sessionCodeCours);
                DataRow[] exerciceSelectionne = main.dsDonnees.Tables["Exercices"].Select("[numCours] = '" + main.sessionCodeCours + "' AND [numLecon] = '" + main.sessionCodeLecon + "' AND [numExo] = '" + main.sessionCodeExo + "'");
                if (exerciceSelectionne.Length < 1)
                {
                    main.changerFormulaire(this, new Login(main));
                }

                // Afficher la progression
                //lblProgressionTotale.Text = "Progression totale : " + main.calculerProgressionTotale().ToString() + " %";
                //lblProgressionLecon.Text = "Progression la leçon : " + main.calculerProgressionLecon().ToString() + " / " + (main.dsDonnees.Tables["Exercices"].Select("[numCours] = '" + main.sessionCodeCours + "' AND [numLecon] = '" + main.sessionCodeLecon + "'").Length).ToString();
            }
            catch (Exception err)
            {
                //MessageBox.Show(err.ToString());
            }

            main.changerFormulaire(this, new Menu(main));
        }

        private void buttonCustom1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
