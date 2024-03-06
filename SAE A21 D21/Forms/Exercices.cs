using SAE_A21_D21.Forms;
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
    public partial class Exercices : CustomForm
    {
        // Référence vers le formulaire principal (main)
        private Main main;
        public static char[] SEPARATORS = { ' ', '?', '¿', '!', '¡', '.', ',', '"' };
        public static Color VALID = Color.FromArgb(54, 145, 119);
        public static Color INVALID = Color.FromArgb(165, 45, 17);

        private Queue<UserControls.Exercice> exs = new Queue<UserControls.Exercice>();
        private Exercice current = null;
        private bool isHelpUsed = false;
        private bool vuSuivant;
        private int nbExoLecon = 0;


        public Exercices(Main main, bool vuSuivant = false)
        {
            // Affecter la référence vers le parent
            this.main = main;
            this.vuSuivant = vuSuivant;

            // MessageBox.Show("seed : " + seedModifier.ToString());
            InitializeComponent();

            //pointedProgressBar1.BarStates.Add(PointedProgressBarState.NONE);
            //pointedProgressBar1.BarStates[2] = PointedProgressBarState.NONE;

        }

        private void Exercice_Load(object sender, EventArgs e)
        {
            if (main.sessionCodeExo == 1 && !vuSuivant)
            {
                main.changerFormulaire(this, new LeconSuivante(main));
            }
            else
            {
                //foreach (DataRow exo in main.dsDonnees.Tables["Exercices"].Select("[numCours] = '" + main.sessionCodeCours + "' AND [numLecon] = '" + main.sessionCodeLecon + "' AND [numExo] >= '" + main.sessionCodeExo + "'"))
                foreach (DataRow exo in main.dsDonnees.Tables["Exercices"].Select("[numCours] = '" + main.sessionCodeCours + "' AND [numLecon] = '" + main.sessionCodeLecon + "'").OrderBy(row => row["numExo"]))
                {
                    if ((int)exo["numExo"] >= main.sessionCodeExo)
                    {
                        if (main.dsDonnees.Tables["ConcerneMots"].Select("[numCours] = '" + main.sessionCodeCours + "' AND [numLecon] = '" + main.sessionCodeLecon + "' AND [numExo] = '" + (int)exo["numExo"] + "'").Length > 0)
                        {
                            // Exercice de vocabulaire
                            exs.Enqueue(new ExerciceVoc(main, exo));
                            ppb.BarStates.Add(PointedProgressBarState.NONE);
                        }
                        else if ((int)exo["codePhrase"] != 0 && (bool)exo["completeON"])
                        {
                            // Exercice dans le désordre
                            exs.Enqueue(new ExerciceDesordre(main, exo));
                            ppb.BarStates.Add(PointedProgressBarState.NONE);
                        }
                        else if ((int)exo["codePhrase"] != 0 && ((string)exo["listeMots"]).Length > 0)
                        {
                            // Exercice à trous
                            exs.Enqueue(new ExerciceTrous(main, exo));
                            ppb.BarStates.Add(PointedProgressBarState.NONE);
                        }
                        else if (((int)exo["codeVerbe"] != 0) && ((int)exo["codetemps"]) != 0)
                        {
                            // Exercice de conjugaison
                            exs.Enqueue(new ExerciceGrammaire(main, exo));
                            ppb.BarStates.Add(PointedProgressBarState.NONE);
                        }
                    }else
                    {
                        ppb.BarStates.Add(PointedProgressBarState.NONE);
                    }
                }
                nbExoLecon = main.dsDonnees.Tables["Exercices"].Select("[numCours] = '" + main.sessionCodeCours + "' AND [numLecon] = '" + main.sessionCodeLecon + "'").Count();

                // ¤ MessageBox.Show(exs.Count.ToString() + " - " + nbExosLecon().ToString() + " - " + main.sessionCodeExo.ToString());
                nextExecice();
            }
            
        }

        private void nextExecice()
        {
            if (current != null)
            {
                pnlExercice.Controls.Remove(current);
            }
            if (exs.Count > 0)
            {
                current = exs.Dequeue();
                pnlExercice.Controls.Add(current);
                btnAide.Visible = current.isHelpAvailable();
                isHelpUsed = false;
                btnValider.Visible = !current.isValid();
                btnSuivant.Visible = current.isValid();
                lblEnonce.Text = current.getEnonce();
                lblTypeExercice.Text = current.getType();
                main.sessionCodeExo = current.getNumExo();
                //MessageBox.Show((current.getNumExo() - 1).ToString()); // ¤
                ppb.BarStates[current.getNumExo() - 1] = PointedProgressBarState.CURRENT;
                lblProgression.Text = "Exercice : " + current.getNumExo() + " / " + nbExoLecon;
            }
            else
            {
                main.changerFormulaire(this, new Recapitulatif(main, "exercice"));

            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            main.changerFormulaire(this, new Menu(main));
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            List<string> recap = current.printCorrection();
            foreach(string eltR in recap)
            {
                string[] elements = eltR.Split('|');
                main.ajouterRecap(elements[0], "", elements[1]);
            }
            ppb.BarStates[current.getNumExo() - 1] = current.isValid() ? PointedProgressBarState.SUCCESS : PointedProgressBarState.FAIL;
            btnValider.Visible = false;
            btnSuivant.Visible = true;
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (isHelpUsed)
            {
                btnSuivant.BtnText = "Suivant";
                current.reload();
                isHelpUsed = false;
                btnSuivant.Visible = false;
                btnValider.Visible = true;
            }
            else
            {
                ppb.BarStates[current.getNumExo() - 1] = current.isValid() ? PointedProgressBarState.SUCCESS : PointedProgressBarState.FAIL;
                nextExecice();
                main.enregistrerProgression();
            }
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            // Vider tous les champs (relancer l'exercice)
            current.reload();
            btnSuivant.BtnText = "Suivant";
            btnAide.Visible = current.isHelpAvailable();
            isHelpUsed = false;
            btnValider.Visible = !current.isValid();
            btnSuivant.Visible = current.isValid();
            lblEnonce.Text = current.getEnonce();
            main.sessionCodeExo = current.getNumExo();
            ppb.BarStates[current.getNumExo() - 1] = PointedProgressBarState.CURRENT;
        }

        private void btnAide_Click(object sender, EventArgs e)
        {
            // Afficher un message box avec un texte d'aide
            MessageBox.Show(current.getHelp());

            btnSuivant.BtnText = "Recommencer";
            isHelpUsed = true;
        }

        private void pointedProgressBar1_Load(object sender, EventArgs e)
        {

        }

        private void userInfo1_Load(object sender, EventArgs e)
        {
            userInfo1.User = main.sessionNomUtilisateur;
            userInfo1.Lesson = (string)main.dsDonnees.Tables["Cours"].Select("[numCours] = '" + main.sessionCodeCours + "'")[0]["titreCours"];
        }

        private void userInfo1_Click(object sender, EventArgs e)
        {
            main.deconnexion(this, main);
        }

        private void lblTypeExercice_Click(object sender, EventArgs e)
        {

        }

        private void btnreinitiliser_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Load(object sender, EventArgs e)
        {

        }

        private void btnreinitiliser_Click(object sender, EventArgs e)
        {
            main.sessionCodeCours = "DEBUT1";
            main.sessionCodeLecon = 1;
            main.sessionCodeExo = 1;
            main.enregistrerProgression();

            main.changerFormulaire(this, new Menu(main));
        }

        private void btnSuivant_Load(object sender, EventArgs e)
        {

        }

        private void userInfo1_Load_1(object sender, EventArgs e)
        {
            userInfo1.User = main.sessionNomUtilisateur;
            userInfo1.Lesson = main.dsDonnees.Tables["Cours"].Select("[numCours] = '" + main.sessionCodeCours + "'")[0]["titreCours"].ToString();
        }

        private void pnlExercice_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
