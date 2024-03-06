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
using System.Data.OleDb;

namespace SAE_A21_D21
{
    public partial class AdministrationExercices : CustomForm
    {
        // Référence vers le formulaire principal (main)
        Main main;
        // Savoir si les combo boxes sont chargées complètement avant de faire des opérations dessus
        bool charge = false;
        // Sélection actuelle
        string selectionCours;
        string selectionLecon;
        int selectionExo;
        int nbExosLecon;
        // DataSet exercices
        DataSet dsExo;
        public AdministrationExercices(Main main)
        {
            // Affecter la référence vers le parent
            this.main = main;
            InitializeComponent();

            // ajouter le usercontrol exerciceDes apres l'avoir coder en fonction des combobox
            //test 
            /*page.addPage(new Button());
            page.addPage(new TextBox());
            page.addPage(new CheckBox());*/
        }

        private void AdministrationExercices_Load(object sender, EventArgs e)
        {
            remplissageCBOcours();
            remplissageBindingSource();

            lierLabels();
        }

        private void lierLabels()
        {
            lblNumExo.DataBindings.Add(new Binding("text", bindingSource1, "numExo", true, DataSourceUpdateMode.OnPropertyChanged));
            lblEnonce.DataBindings.Add(new Binding("text", bindingSource1, "enonceExo", true, DataSourceUpdateMode.OnPropertyChanged));
            lblRegle.DataBindings.Add(new Binding("text", bindingSource1, "regle", true, DataSourceUpdateMode.OnPropertyChanged));
            lblPhrase.DataBindings.Add(new Binding("text", bindingSource1, "phrase", true, DataSourceUpdateMode.OnPropertyChanged));
            lblPhraseTrad.DataBindings.Add(new Binding("text", bindingSource1, "phraseTrad", true, DataSourceUpdateMode.OnPropertyChanged));
            lblCompleteON.DataBindings.Add(new Binding("text", bindingSource1, "completeON", true, DataSourceUpdateMode.OnPropertyChanged));
            lblListeMots.DataBindings.Add(new Binding("text", bindingSource1, "listeMots", true, DataSourceUpdateMode.OnPropertyChanged));
            lblVerbe.DataBindings.Add(new Binding("text", bindingSource1, "verbe", true, DataSourceUpdateMode.OnPropertyChanged));
            lblVerbeTrad.DataBindings.Add(new Binding("text", bindingSource1, "verbeTrad", true, DataSourceUpdateMode.OnPropertyChanged));
            lblTemps.DataBindings.Add(new Binding("text", bindingSource1, "temps", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void remplissageBindingSource()
        {
            string requete = @"SELECT
                e1.numExo AS numExo,
                e1.enonceExo AS enonceExo,
                (SELECT e2.texteRegle FROM Regles e2 WHERE e1.codeRegle = e2.codeRegle) AS regle,
                (SELECT e2.textePhrase FROM Phrases e2 WHERE e1.codePhrase = e2.codePhrase) AS phrase,
                (SELECT e2.traducPhrase FROM Phrases e2 WHERE e1.codePhrase = e2.codePhrase) AS phraseTrad,
                e1.completeON as completeON,
                e1.listeMots as listeMots,
                (SELECT e2.libMot FROM Mots e2 WHERE e1.codeVerbe = e2.numMot) AS verbe,
                (SELECT e2.libMot FROM Mots e2 WHERE e1.codeVerbe = e2.numMot) AS verbeTrad,
                (SELECT e2.libTemps FROM Temps e2 WHERE e1.codetemps = e2.codeTemps) AS temps 

                FROM Exercices e1 WHERE (e1.numCours = '" + selectionCours + "' AND e1.numLecon = " + selectionLecon + ")" + "ORDER BY e1.numCours, e1.numLecon, e1.numExo";


            OleDbCommand commande = new OleDbCommand(requete, main.co);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(commande);

            dsExo = new DataSet();

            if (dsExo.Tables.Contains("AdminExercices"))
            {
                dsExo.Tables.Remove("AdminExercices");
            }

            dataAdapter.Fill(dsExo, "AdminExercices");

            bindingSource1.DataSource = dsExo.Tables["AdminExercices"];
        }

        private void remplissageCBOcours()
        {
            // Remplir combo boxes

            cboCodeCours.DataSource = main.dsDonnees.Tables["Cours"];
            cboCodeCours.DisplayMember = "titreCours"; // colonnes code cours à afficher
            cboCodeCours.ValueMember = "numCours"; // ce que je veux retenir

            charge = true;

            // Remplir combo boxes des leçons
            remplissageCBOlecon();

            // Pour avoir le premier exercice
            cboCodeLecon_SelectedValueChanged_1(null, null);
        }

        private void remplissageCBOlecon()
        {
            charge = false;
            string choix = cboCodeCours.SelectedValue.ToString();
            //choix = cboCodeCours.SelectedItem.ToString();

            DataRow[] lecons = main.dsDonnees.Tables["Lecons"].Select("[numCours] = '" + choix + "'");
            
            // Convertir la liste des leçons en table
            DataTable mesLecons = lecons.CopyToDataTable<DataRow>();

            // Remplir combo boxes

            cboCodeLecon.DataSource = mesLecons;
            cboCodeLecon.DisplayMember = "titreLecon";
            cboCodeLecon.ValueMember = "numLecon";

            charge = true;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            main.changerFormulaire(this, new Administration(main));
        }

        private void buttonCustom1_Click(object sender, EventArgs e)
        {
            //page.first();
            selectionExo = 1;
            bindingSource1.MoveFirst();
        }

        private void buttonCustom2_Click(object sender, EventArgs e)
        {
            //page.prev();
            if(selectionExo > 1)
            {
                selectionExo--;
            }
            bindingSource1.MovePrevious();
        }

        private void buttonCustom3_Click(object sender, EventArgs e)
        {
            //page.next();
            if(selectionExo < nbExosLecon)
            {
                selectionExo++;
            }
            bindingSource1.MoveNext();
        }

        private void buttonCustom4_Click(object sender, EventArgs e)
        {
            //page.last();
            selectionExo = nbExosLecon;
            bindingSource1.MoveLast();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            lblMiniTitre.Text = "";
            lblListeMots.Visible = false;
            lblCompleteON.Visible = false;
            if (lblListeMots.Text.Length > 0)
            {
                lblMiniTitre.Text = "Mots à supprimer :";
                lblListeMots.Visible = true;
                lblCompleteON.Visible = false;
                lblListeMots.BringToFront();
            }
            else if(lblCompleteON.Text == "True")
            {
                lblMiniTitre.Text = "Phrase dans le désordre :";
                lblListeMots.Visible = false;
                lblCompleteON.Visible = true;
                lblCompleteON.BringToFront();
            }
        }

        private void cboCodeCours_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (charge)
            {
                remplissageCBOlecon();
            }
            selectionCours = cboCodeCours.SelectedValue.ToString();
        }

        private void cboCodeLecon_SelectedValueChanged_1(object sender, EventArgs e)
        {
            // Mettre premier exercice de la leçon
            if (charge)
            {
                selectionLecon = cboCodeLecon.SelectedValue.ToString();
                /*DataRow exo = main.dsDonnees.Tables["Exercices"].DefaultView.ToTable().Select("[numCours] = '" + selectionCours + "' AND [numLecon] = '" + selectionLecon + "'")[0];
                selectionExo = int.Parse(exo["numExo"].ToString());*/
                selectionExo = 1;
                nbExosLecon = main.dsDonnees.Tables["Exercices"].DefaultView.ToTable().Select("[numCours] = '" + selectionCours + "' AND [numLecon] = '" + selectionLecon + "'").Length;
                // Afficher le contenu au centre
                remplissageBindingSource();
            }
        }

        private void userInfo1_Load(object sender, EventArgs e)
        {
            userInfo1.User = main.sessionNomUtilisateur;
            userInfo1.Lesson = main.dsDonnees.Tables["Cours"].Select("[numCours] = '" + main.sessionCodeCours + "'")[0]["titreCours"].ToString();

        }

        private void lblEnonce_Click(object sender, EventArgs e)
        {

        }

        private void userInfo1_Click(object sender, EventArgs e)
        {
            main.deconnexion(this, main);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            main.changerFormulaire(this, new Menu(main));
        }
    }
}
