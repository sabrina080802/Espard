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
    public partial class Main : CustomForm
    {
        Form formulaireSuivant;

        /****CODE A D3B1RUM4N****/
        // Variables de gestion de la BDD
        public OleDbConnection co;
        public string chaineConnexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\BDD\baseLangue.mdb";
        OleDbDataAdapter da;
        public DataSet dsDonnees;
        public DataTable recapitulatif; // statut, titre, mot

        // Variables de session (par utilisateur)
        public int sessionCodeUtil;
        public string sessionNomUtilisateur;
        public int sessionCodeExo;
        public int sessionCodeLecon;
        public string sessionCodeCours;

        public List<int> progressionLecon = new List<int>();

        public Main()
        {
            InitializeComponent();
        }

        public void creerRecapitulatif()
        {
            // Créer le récapitulatif / le reset
            recapitulatif = new DataTable();

            recapitulatif.Columns.Add("statut");
            recapitulatif.Columns.Add("titre");
            recapitulatif.Columns.Add("mot");

            // Ajouter une entrée :
            // recapitulatif.Rows.Add("statut", "titre", "mot");

        }

        public void ajouterRecap(string statut, string titre, string mot)
        {
            foreach(DataRow ligneRecap in recapitulatif.Rows)
            {
                if(ligneRecap["mot"].ToString() == mot)
                {
                    return;
                }
            }
            recapitulatif.Rows.Add(statut, titre, mot);
        }

        public double calculerProgressionTotale()
        {
            int nbExos = dsDonnees.Tables["Exercices"].Select("[numCours] = '" + sessionCodeCours + "' AND [numLecon] = '" + sessionCodeLecon + "'").Count();


            return Math.Round(sessionCodeExo * 100.0 / nbExos, 1);

        }

        public void enregistrerProgression()
        {
            try
            {
                // Enregistre la progression de l'utilisateur dans la BDD

                //MessageBox.Show("Enregistrer la progression, dans main.enregistrerProgression");

                // Requête
                co.Open();
                OleDbCommand com;
                string requete = "UPDATE Utilisateurs SET [codeCours] = '" + sessionCodeCours + "', [codeLeçon] = " + sessionCodeLecon + ", [codeExo] = " + sessionCodeExo + " WHERE [codeUtil] = " + sessionCodeUtil;
                // MessageBox.Show(requete);
                com = new OleDbCommand(requete, co);

                com.ExecuteNonQuery();
                co.Close();
            }
            catch(Exception err)
            {
                
                MessageBox.Show("Impossible d'enregistrer la progression");
                //MessageBox.Show(err.ToString());
            }
           
        }

        public void deconnexion(Form self, Main main)
        {
            // Affiche la confirmation de déconnexion
            ConfirmerQuitter deco = new ConfirmerQuitter();
            deco.StartPosition = FormStartPosition.CenterScreen;
            if (deco.ShowDialog() == DialogResult.OK)
            {
                // Supprime les variables de session de l'utilisateur
                sessionCodeUtil = -1;
                sessionNomUtilisateur = null;
                sessionCodeExo = -1;
                sessionCodeLecon = -1;
                sessionCodeCours = null;
                // Change le formulaire vers login
                changerFormulaire(self, new Login(main));
            }
        }

        /**** CODE PAR D3B1RUM4N ****/
        public void chargerDS()
        {
            // Chargement de la base de données
            try
            {
                co = new OleDbConnection(this.chaineConnexion);
                co.Open();
                dsDonnees = new DataSet();
                string req;
                DataTable schemaTable = co.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                for (int i = 0; i < schemaTable.Rows.Count; i++)
                {
                    // Le nom de la table se trouve dans la 3ème colonne
                    string nomTable = schemaTable.Rows[i][2].ToString();
                    req = "SELECT * FROM " + nomTable;

                    // Ajout dans le DataSet
                    OleDbCommand cd = new OleDbCommand(req, co);
                    da = new OleDbDataAdapter(cd);
                    da.Fill(dsDonnees, nomTable);
                    // MessageBox.Show(dsDonnees.Tables[nomTable].ToString()); // Affiche le nom de la table ajoutée
                }
            }
            catch (Exception err) { MessageBox.Show(err.ToString()); }

            co.Close();
        }

        public void changerFormulaire(Form self, Form suivant)
        {
            this.formulaireSuivant = suivant;
            self.DialogResult = DialogResult.OK;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Récupérer les données de la BDD, D3B1RUM4N
            chargerDS();
            // Trier la table Exercices par cours, leçon et n° exercice
            dsDonnees.Tables["Exercices"].DefaultView.Sort = "numCours ASC, numLecon ASC, numExo ASC";
            // Trier la table Terminaisons par personne
            dsDonnees.Tables["Terminaisons"].DefaultView.Sort = "Groupe ASC, numPersonne ASC";

            // Formulaire de départ
            formulaireSuivant = new Login(this);
            // Cacher le formulaire Main
            this.Hide();
            // Tant qu'on navigue dans l'application
            while(formulaireSuivant != null)
            {
                // Centrer le formulaire à l'écran
                formulaireSuivant.StartPosition = FormStartPosition.CenterScreen;
                // Afficher le formulaire
                formulaireSuivant.ShowDialog();
                // Si le formulaire est fermé :
                if (formulaireSuivant.DialogResult == DialogResult.Cancel)
                {
                    // Sortir de la boucle
                    formulaireSuivant = null;
                }
            }
            // On ne parcours plus les formulaires, quitter l'application
            Application.Exit();
        }
    }
}
