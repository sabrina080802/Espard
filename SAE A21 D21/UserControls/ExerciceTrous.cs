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
    public partial class ExerciceTrous : Exercice
    {
        private List<string> correct = new List<string>();
        private List<TextBox> answers = new List<TextBox>();

        public ExerciceTrous(Main main, DataRow exo) : base(main, exo)
        {
            InitializeComponent();
            this.type = "Exercice à trou";
        }

        public override List<string> printCorrection()
        {
            //PictureBox pb = new PictureBox();
            //pb.InitialImage = null;
            //pb.Name = "pb";
            //pb.Size = new System.Drawing.Size(20, 20);
            //pb.Location = new System.Drawing.Point(origineX + decalageX + 50 - pb.Size.Width / 2, origineY + decalageY - 12);
            //pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            //pb.TabIndex = 2;
            //pb.TabStop = false;

            //pnlExercice.Controls.Add(pb);
            //vraiFauxPb.Add(pb);
            List<string> recap = new List<string>();

            foreach (TextBox txt in answers)
            {
                txt.ReadOnly = true;
            }

            for (int i = 0; i < correct.Count; i++)
            {
                string e = correct[i];
                if (removeSpeChar(correct[i].Trim().ToLower()).Equals(removeSpeChar(answers[i].Text.Trim().ToLower())))
                {
                    e = "Acquis|" + e;
                }
                else
                {
                    e = "Non acquis|" + e;
                }
                answers[i].BackColor = (removeSpeChar(correct[i].Trim().ToLower()).Equals(removeSpeChar(answers[i].Text.Trim().ToLower()))) ? Exercices.VALID : Exercices.INVALID;
                recap.Add(e);
            }

            return recap;
        }

        public override bool isValid()
        {
            for (int i = 0; i < correct.Count; i++)
            {
                if (!removeSpeChar(correct[i].Trim().ToLower()).Equals(removeSpeChar(answers[i].Text.Trim().ToLower()))) return false;
            }

            return true;
        }

        protected override void setup()
        {
            correct.Clear();
            answers.Clear();

            string tradPhrase = (string)main.dsDonnees.Tables["Phrases"].Select("[codePhrase] = '" + exoRow["codePhrase"] + "'")[0]["traducPhrase"];
            string phrase = (string)main.dsDonnees.Tables["Phrases"].Select("[codePhrase] = '" + exoRow["codePhrase"] + "'")[0]["textePhrase"];
            string[] mots = phrase.Split(Exercices.SEPARATORS).Where(mot => mot.Trim().Length != 0).ToArray();

            string listeMots = (string)exoRow["listeMots"];

            foreach (string indiceMot in listeMots.Split('/'))
            {
                correct.Add(mots[int.Parse(indiceMot) - 1]);
            }

            // Traduction de la phrase
            Label trad = new Label();
            trad.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trad.Size = new System.Drawing.Size(700, 25);
            trad.Text = "Phrase : " + tradPhrase;
            trad.Dock = DockStyle.Top;
            Controls.Add(trad);

            for (int i = 0; i < mots.Length; i++)
            {
                if (!correct.Contains(mots[i]))
                {
                    // Label
                    Label lb = new Label();
                    lb.AutoSize = true;
                    lb.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lb.Size = new System.Drawing.Size(38, 30);
                    lb.TabIndex = 2;
                    lb.Text = mots[i];

                    flpExo.Controls.Add(lb);
                }
                else
                {
                    // Mot à remplir
                    TextBox txt = new TextBox();
                    txt.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    txt.Size = new System.Drawing.Size(100, 30);
                    answers.Add(txt);

                    flpExo.Controls.Add(txt);
                }
            }
        }

        private string removeSpeChar(string text)
        {
            Dictionary<char, char> espToFr = new Dictionary<char, char>();
            espToFr['á'] = 'a';
            espToFr['é'] = 'e';
            espToFr['í'] = 'i';
            espToFr['ó'] = 'o';
            espToFr['ú'] = 'u';
            espToFr['ñ'] = 'n';
            espToFr['ü'] = 'u';

            foreach (KeyValuePair<char, char> kvp in espToFr)
            {
                text = text.Replace(kvp.Key, kvp.Value);
            }

            return text;
        }
    }
}
