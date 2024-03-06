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
    public partial class AdministrationAjouter : CustomForm
    {
        // Référence vers le formulaire principal (main)
        Main main;
        public AdministrationAjouter(Main main)
        {
            // Affecter la référence vers le parent
            this.main = main;
            InitializeComponent();
        }

        private void AdministrationAjouter_Load(object sender, EventArgs e)
        {
            remplissageCBOUser();
            pnlAvance.Visible = false;

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            main.changerFormulaire(this, new Administration(main));
        }




        /******** Code Par D3B1RUM4N ******/




        /** Code Par D3B1RUM4N **/


        private void remplissageCBOUser()
        {
            //pour la cbo du choix du cours
            cboCodeCours.DataSource = main.dsDonnees.Tables["Cours"];
            cboCodeCours.DisplayMember = "titreCours"; // colones code cours
            cboCodeCours.ValueMember = "numCours"; // ce que je veux retenir
        }




        //remplissage du cbo CodeCours

        private void cboCodeCours_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //cboCodeLeçon.Items.Clear();
            string choix = (string)cboCodeCours.SelectedValue;
            DataRow[] lecons = main.dsDonnees.Tables["Lecons"].Select("numCours = '" + choix + "'");
            //MessageBox.Show(choix + lecons.Count().ToString());
            DataTable mesLecons = lecons.CopyToDataTable<DataRow>();
            mesLecons.TableName = "mesLecon";

            cboCodeLecon.DataSource = mesLecons;
            cboCodeLecon.DisplayMember = "titreLecon";
            cboCodeLecon.ValueMember = "numLecon";
        }

        private void cboCodeLecon_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            int choix = (int)cboCodeLecon.SelectedValue;
            string cours = (string)cboCodeCours.SelectedValue;
            //MessageBox.Show(choix + cours);
            DataRow[] exos = main.dsDonnees.Tables["Exercices"].Select("numCours = '" + cours + "' AND numLecon = '" + choix + "'");
            //MessageBox.Show(choix + cours.Count().ToString());
            DataTable mesExos = exos.CopyToDataTable<DataRow>();
            //MessageBox.Show(exos.Count().ToString());
            mesExos.TableName = "mesExo";

            cboCodeExo.DataSource = mesExos;
            cboCodeExo.DisplayMember = "enonceExo";
            cboCodeExo.ValueMember = "numExo";
        }








        /***** CODE PAR D3B1RUM4N *****/
        // Ajout des eleves a la base de donnée
        // Mode connecté
        // fonction qui ajoute un nouvel USER a la BDD
        private void btnValider_Click(object sender, EventArgs e)
        {
            //recuperation des cases remplis
            string nom = "";
            string prenom = "";
            string email = "";
            string cours = "";
            int lecon = -1;
            int exo = -1;
            int codeUtil = -1;

            try
            {

                nom = txtboNom.Text;
                prenom = txtboPrenom.Text;
                email = txtboEmail.Text;
                cours = (string)cboCodeCours.SelectedValue;
                lecon = (int)cboCodeLecon.SelectedValue;
                exo = (int)cboCodeExo.SelectedValue;

                //MessageBox.Show("nom : " + nom + "\nPrenom : " + prenom + "\nEmail : " + email + "\nCours :" + cours + "\nLeçon : " + lecon + "\nexo : " + exo);
            }
            catch(System.NullReferenceException)
            {
                main.changerFormulaire(this, new AdministrationAjouter(main));
                MessageBox.Show("remplissez toutes les saisie");
            }

            // recuperation de codeUtil
            try
            {
                // Ouverture de la connexion
                main.co.ConnectionString = main.chaineConnexion;
                main.co.Open();
                //MessageBox.Show(connec.State.ToString());
                string requete = @"SELECT max(codeUtil) FROM Utilisateurs";
                OleDbCommand cd = new OleDbCommand();
                cd.Connection = main.co;
                cd.CommandType = CommandType.Text;
                cd.CommandText = requete;
                //MessageBox.Show(requete);
                codeUtil = (int)cd.ExecuteScalar();
                codeUtil++;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Erreur de connexion à la base");
                main.changerFormulaire(this, new AdministrationAjouter(main));
            }
            catch (OleDbException)
            {
                MessageBox.Show("Erreur dans la requête SQL");
                main.changerFormulaire(this, new AdministrationAjouter(main));
            }
            finally
            {
                if (main.co.State == ConnectionState.Open)
                    main.co.Close();
            }

            //MessageBox.Show(codeUtil.ToString());

            // ajout des donnée
            try
            {
                // Ouverture de la connexion
                main.co.ConnectionString = main.chaineConnexion;
                main.co.Open();
                //MessageBox.Show(connec.State.ToString());
                string requete = "";
                //if pour verifier si l'on est en mode avancé ou normal
                if(rdbAvance.Checked)
                {
                    requete = @"INSERT INTO Utilisateurs (codeUtil, nomUtil, pnUtil, mailUtil, codeExo, codeLeçon, codeCours) VALUES ('" + codeUtil.ToString() + "', '" + nom + "', '" + prenom + "', '" + email + "', '" + exo + "', '" + lecon + "', '" + cours + "')";
                }
                else
                {
                    requete = @"INSERT INTO Utilisateurs (codeUtil, nomUtil, pnUtil, mailUtil, codeExo, codeLeçon, codeCours) VALUES ('" + codeUtil.ToString() + "', '" + nom + "', '" + prenom + "', '" + email + "', '1', '1', 'DEBUT1')";
                }
                OleDbCommand cd = new OleDbCommand();
                cd.Connection = main.co;
                cd.CommandType = CommandType.Text;
                cd.CommandText = requete;
                //MessageBox.Show(requete);
                cd.ExecuteScalar();
                

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Erreur de connexion à la base");
            }
            catch (OleDbException)
            {
                MessageBox.Show("Erreur dans la requête SQL");
            }
            finally
            {
                if (main.co.State == ConnectionState.Open)
                    main.co.Close();
            }

            AjoutParticipant var = new AjoutParticipant(main);
            var.StartPosition = FormStartPosition.CenterScreen;
            var.ShowDialog();


            main.changerFormulaire(this, new Administration(main));
        }



        /******** CODE PAR D3B11111111RUMAN **********/

        private void AdministrationAjouter_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            main.changerFormulaire(this, new Menu(main));

        }

        private void btnTerminer_Load(object sender, EventArgs e)
        {

        }

        private void lblPrenom_Click(object sender, EventArgs e)
        {

        }

        private void cboCodeExo_SelectedIndexChanged(object sender, EventArgs e)
        {

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

    




        private void rdbAvance_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rdbAvance_CheckStateChanged(object sender, EventArgs e)
        {
            if (rdbAvance.Checked)
            {
                pnlAvance.Visible = true;
            }
            else
            {
                pnlAvance.Visible = false;
            }
        }

        private void userInfo1_Load(object sender, EventArgs e)
        {
            userInfo1.User = main.sessionNomUtilisateur;
            userInfo1.Lesson = main.dsDonnees.Tables["Cours"].Select("[numCours] = '" + main.sessionCodeCours + "'")[0]["titreCours"].ToString();
        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
