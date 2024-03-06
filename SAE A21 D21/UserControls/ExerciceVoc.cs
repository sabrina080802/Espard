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
    public partial class ExerciceVoc : Exercice
    {
        public ExerciceVoc(Main main, DataRow exo) : base(main, exo)
        {
            InitializeComponent();
            this.type = "Vocabulaire";
        }


        public override bool isValid()
        {
            return true;
        }

        public override List<string> printCorrection()
        {
            List<string> recap = new List<string>();

            foreach (DataRow numMot in main.dsDonnees.Tables["ConcerneMots"].Select("[numCours] = '" + main.sessionCodeCours + "' AND [numLecon] = '" + main.sessionCodeLecon + "' AND [numExo] = '" + getNumExo() + "'"))
            {
                recap.Add("Acquis|" + numMot["libMot"].ToString());
            }

            return recap;
        }

        protected override void setup()
        {

            foreach (DataRow numMot in main.dsDonnees.Tables["ConcerneMots"].Select("[numCours] = '" + main.sessionCodeCours + "' AND [numLecon] = '" + main.sessionCodeLecon + "' AND [numExo] = '" + getNumExo() + "'"))
            {
                DataRow mot = main.dsDonnees.Tables["Mots"].Select("[numMot] = '" + (int) numMot["numMot"] + "'")[0];

                Voc voc = new Voc();
                voc.PaddingWhiteBox = 25;
                voc.Word = (string)mot["libMot"];
                voc.WordTrad = (string)mot["traducMot"];
                voc.Origine = (string)mot["origine"];

                // Extraction de la photo correspondant au voc
                if(mot["cheminPhoto"].ToString() != "")
                {
                    voc.Image = Image.FromFile("../../Images/Mots/" + (string)mot["cheminPhoto"]);
                }
                else
                {
                    voc.Image = Image.FromFile("../../Images/Mots/_placeholder.png");
                }

                flpVoc.Controls.Add(voc);
            }
        }

        private void flpVoc_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
