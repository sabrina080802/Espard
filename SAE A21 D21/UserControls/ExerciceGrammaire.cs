using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_A21_D21.UserControls
{
    public partial class ExerciceGrammaire : Exercice
    {
        Dictionary<string, string> correct = new Dictionary<string, string>();
        private List<Label> labels = new List<Label>();
        private List<ComboBoxCustom> answers = new List<ComboBoxCustom>();
        public ExerciceGrammaire(Main main, DataRow exo) : base(main, exo)
        {
            InitializeComponent();
            labels.Add(lbl1);
            labels.Add(lbl2);
            labels.Add(lbl3);
            labels.Add(lbl4);
            labels.Add(lbl5);
            labels.Add(lbl6);
            answers.Add(cbo1);
            answers.Add(cbo2);
            answers.Add(cbo3);
            answers.Add(cbo4);
            answers.Add(cbo5);
            answers.Add(cbo6);

            this.type = "Exercice de grammaire";

        }

        public override List<string> printCorrection()
        {
            List<string> recap = new List<string>();
            foreach (ComboBoxCustom cbo in answers)
            {
                cbo.Enabled = false;
            }
            for (int i = 0; i < answers.Count; i++)
            {
                answers[i].BackColor = (answers[i].Texts == correct[(i + 1).ToString()]) ? Exercices.VALID : Exercices.INVALID;
            }
            return recap;
        }

        public override bool isValid()
        {
            //for (int i = 0; i < correct.Count; i++)
            //{
            //    string e = correct[i];
            //    if (e == comboBoxes[i].Text)
            //    {
            //        // Juste
            //        vraiFauxPb[i].Image = Image.FromFile("../../Images/Interfaces/juste.png");
            //    }
            //    else
            //    {
            //        // Faux
            //        estJuste = false;
            //        vraiFauxPb[i].Image = Image.FromFile("../../Images/Interfaces/faux.png");
            //    }
            //    vraiFauxPb[i].BringToFront();
            //}
            for(int i = 0; i < answers.Count; i++)
            {
                if (answers[i].Texts != correct[(i + 1).ToString()]) return false;
            }

            return true;
        }

        protected override void setup()
        {
            foreach(Label lbl in labels)
            {
                lbl.Text = "";
            }
            foreach(ComboBoxCustom cbo in answers)
            {
                cbo.Enabled = true;
                cbo.DataSource = null;
            }
            correct.Clear();

            string libTemps = (string)main.dsDonnees.Tables["Temps"].Select("[codeTemps] = '" + (int)exoRow["codeTemps"] + "'")[0]["libTemps"];
            string traducTemps = (string)main.dsDonnees.Tables["Temps"].Select("[codeTemps] = '" + (int)exoRow["codeTemps"] + "'")[0]["traducTemps"];


            int numMotConcerne = (int)exoRow["codeVerbe"];
            string motConcerne = (string)main.dsDonnees.Tables["Mots"].Select("[numMot] = '" + numMotConcerne + "'")[0]["libMot"];


            // Verbe
            int groupe;

            // Déterminer le groupe
            if (motConcerne.EndsWith("ar"))
            {
                groupe = 1;
            }
            else if (motConcerne.EndsWith("er"))
            {
                groupe = 2;
            }
            else
            {
                groupe = 3;
            }

            DataRow[] terminaisons = main.dsDonnees.Tables["Terminaisons"].Select("[numTemps] = '" + (int)exoRow["codeTemps"] + "' AND [Groupe] = '" + groupe + "'"); // Code groupe temporaire, à voir ¤
            foreach (DataRow term in terminaisons)
            {
                correct.Add((string)term["numPersonne"], (string)term["term"]);
            }
            Random rdn = new Random();

            foreach(ComboBoxCustom cbo in answers)
            {
                cbo.DataSource = new BindingSource(correct.OrderBy(item => rdn.Next()), null);
                cbo.DisplayMember = "Value";
                cbo.ValueMember = "Key";
            }

            for(int i = 0; i < labels.Count; i++)
            {
                DataRow personne = main.dsDonnees.Tables["Personne"].Select("[codePersonne] = '" + (i+1) + "'")[0];

                labels[i].Text = (string)personne["traducPersonne"] + " (" + (string)personne["libPersonne"] + ") " + ((groupe == 3) ? motConcerne : motConcerne.Substring(0, motConcerne.Length - 2));
            }

            //// Conjugaison de Verbe au temps X
            //foreach (string mot in possibles)
            //{
            //    Label lbVerbe = new Label();
            //    lbVerbe.AutoSize = true;
            //    lbVerbe.Location = new System.Drawing.Point(origineX + 200, origineY + decalage + 185);
            //    lbVerbe.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //    lbVerbe.Name = "lbVerbe";
            //    lbVerbe.Size = new System.Drawing.Size(35, 13);
            //    lbVerbe.TabIndex = 0;
            //    string verbe = main.dsDonnees.Tables["Mots"].Select("[numMot] = '" + exercice["codeVerbe"].ToString() + "'")[0]["libMot"].ToString();
            //    // Enlever ar ¤
            //    lbVerbe.Text = verbe; // Verbe infinitif
            //    lbVerbe.TextAlign = System.Drawing.ContentAlignment.TopRight;

            //    pnlExercice.Controls.Add(lbVerbe);

            //    Label lbPersonne = new Label();
            //    lbPersonne.AutoSize = true;
            //    lbPersonne.Location = new System.Drawing.Point(origineX, origineY + decalage + 185);
            //    lbPersonne.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //    lbPersonne.Name = "lbVerbe";
            //    lbPersonne.Size = new System.Drawing.Size(35, 13);
            //    lbPersonne.TabIndex = 0;
            //    DataRow personne = main.dsDonnees.Tables["Personne"].Select("[codePersonne] = '" + indexPersonne + "'")[0];
            //    lbPersonne.Text = personne["traducPersonne"].ToString() + " (" + personne["libPersonne"].ToString() + ")"; // Je, Yo, Verbe infinitif ¤

            //    pnlExercice.Controls.Add(lbPersonne);

            //    indexPersonne++;

            //    ComboBox cboTerminaison = new ComboBox();
            //    cboTerminaison.FormattingEnabled = true;
            //    cboTerminaison.Cursor = System.Windows.Forms.Cursors.Hand;
            //    cboTerminaison.Location = new System.Drawing.Point(origineX + 275, origineY + decalage + 180);
            //    cboTerminaison.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //    cboTerminaison.Name = "comboBox1";
            //    cboTerminaison.Size = new System.Drawing.Size(86, 21);
            //    cboTerminaison.TabIndex = 2;
            //    foreach (string term in possibles)
            //    {
            //        cboTerminaison.Items.Add(term);
            //    }
            //    cboTerminaison.SelectedIndex = 0;
            //    cboTerminaison.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            //    comboBoxes.Add(cboTerminaison); // Garder une référence de chaque ComboBox
            //                                    // ? ¤ comboBoxes[decalage/30].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))); // ¤
            //    pnlExercice.Controls.Add(cboTerminaison);

            //    PictureBox pb = new PictureBox();
            //    pb.InitialImage = null;
            //    pb.Name = "pb";
            //    pb.Size = new System.Drawing.Size(20, 20);
            //    pb.Location = new System.Drawing.Point(origineX + 275 + cboTerminaison.Size.Width - 2, origineY + decalage + 185);
            //    pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            //    pb.TabIndex = 2;
            //    pb.TabStop = false;

            //    pnlExercice.Controls.Add(pb);
            //    vraiFauxPb.Add(pb);


            //    decalage += 30;
            //}
        }
    }
}
