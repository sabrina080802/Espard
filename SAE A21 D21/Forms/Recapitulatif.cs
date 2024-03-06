using SAE_A21_D21.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SAE_A21_D21.Forms;
using System.Data.OleDb;



namespace SAE_A21_D21
{
    public partial class Recapitulatif : CustomForm
    {
        // Référence vers le formulaire principal (main)
        private Main main;

        // Listes des mots et leur statut
        private List<string> acquis = new List<string>();
        private List<string> nonAcquis = new List<string>();

        private int nbExoLecon;


        public Recapitulatif(Main main, string source)
        {
            // Affecter la référence vers le parent
            this.main = main;

            nbExoLecon = main.dsDonnees.Tables["Lecons"].Select("[numCours] = '" + main.sessionCodeCours + "'").Count();
            if (nbExoLecon > main.sessionCodeLecon)
            {
                main.sessionCodeLecon++;
                main.sessionCodeExo = 0;
            }
            InitializeComponent();
        }

        private void Recapitulatif_Load(object sender, EventArgs e)
        {

            foreach (DataRow eltRecap in main.recapitulatif.Rows)
            {
                // Création d'un label et alignement du mot au milieu
                Label lb = new Label();
                lb.AutoSize = false;
                lb.Font = new System.Drawing.Font("Helvetica", 10);
                lb.Dock = DockStyle.Top;
                lb.TextAlign = ContentAlignment.MiddleCenter;


                if (((string) eltRecap["statut"] == "Acquis"))
                {
                    acquis.Add(eltRecap["mot"].ToString());
                    lb.Text = (string) eltRecap["mot"];
                    pnlReussi.Controls.Add(lb);
   
                }
                else if ((string) eltRecap["statut"] == "Non acquis")
                {
                    lb.Text = (string) eltRecap["mot"];
                    pnlEchec.Controls.Add(lb);

                    nonAcquis.Add(eltRecap["mot"].ToString());
                }
            }

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            main.changerFormulaire(this, new Menu(main));
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
        

        }

        private void btnRetour_Load(object sender, EventArgs e)
        {


        }

        private void btnEnregistrer_Load(object sender, EventArgs e)
        {

            
        }

        private void btnEnregistrer_Load_1(object sender, EventArgs e)
        {

            try
            {
                // Generation du document PDF et accès avec FileStream
                string path = Path.Combine(Environment.CurrentDirectory + @"../../../../PDF/"+ main.sessionNomUtilisateur + "/" );

                // Creation du chemin si il est inexistant
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                // Extraction de la date actuelle
                DateTime thisDay = DateTime.Today;

                // Génération du pdf et ouverture pour ecrire dedans
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, new FileStream(path + main.sessionNomUtilisateur + " " + thisDay.ToString("D") + ".pdf", FileMode.Create));

                doc.Open();



                // Couleurs
                BaseColor blanc = new BaseColor(255, 255, 255);
                BaseColor noir = new BaseColor(0, 0, 0);
                BaseColor orange = new BaseColor(255, 140, 50);

                // Polices d'écritures
                iTextSharp.text.Font cours = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 23f);
                iTextSharp.text.Font lecon = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18f);
                iTextSharp.text.Font titreTab = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f);
                iTextSharp.text.Font tab = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f);


                Paragraph space = new Paragraph("\n");
 

                // Header du doc



                // Bannière en haut de la page avec logo + couleurs + nom "Bilan"
               iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Properties.Resources.Layer_1, System.Drawing.Imaging.ImageFormat.Png);
               logo.ScaleToFit(550f, 500f);
                logo.Alignment = Element.ALIGN_CENTER;
                doc.Add(logo);

                doc.Add(space);

                // Titres
                Chunk numCours = new Chunk("\t Cours : " + main.dsDonnees.Tables["Cours"].Select("[numCours] = '" + main.sessionCodeCours + "'")[0]["titreCours"].ToString(), cours);
                doc.Add(numCours);

                doc.Add(space);

                Chunk numLecon = new Chunk("\t Leçon : " + main.dsDonnees.Tables["Lecons"].Select("[numCours] = '" + main.sessionCodeCours + "' AND [numLecon] = '" + main.sessionCodeLecon + "'")[0]["titreLecon"].ToString(), lecon);
                doc.Add(numLecon);


                doc.Add(space);


                // Tableau

                // Redimensionner le tableau
                var tabPdf = new PdfPTable(2);

                tabPdf.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                tabPdf.DefaultCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

                PdfPCell header2 = new PdfPCell(new Phrase("Non acquis", titreTab));
                PdfPCell header1 = new PdfPCell(new Phrase("Acquis", titreTab));

                header1.PaddingBottom = 20;
                header2.PaddingBottom = 20;

                tabPdf.Rows.Add(new PdfPRow(new PdfPCell[] {header1, header2 }));
      

                Phrase cellLeft = new Phrase();
                Phrase cellRight = new Phrase();

                // Calcul de la liste la plus longue pour dimensionner les colonnes
                for (int i = 0; i < Math.Max(acquis.Count, nonAcquis.Count); i++)
                {
                    if (i < acquis.Count)
                    {
                        cellLeft = new Phrase(acquis[i], tab);
                    }
                    else
                    {
                        cellLeft = new Phrase("");
                    }

                    if (i < nonAcquis.Count)
                    {
                        cellRight = new Phrase(nonAcquis[i], tab);
                    }
                    else
                    {
                        cellRight = new Phrase("");
                    }

                    tabPdf.Rows.Add(new PdfPRow(new PdfPCell[] { new PdfPCell(cellLeft), new PdfPCell(cellRight) }));
                }

                // Bordures retirées
                foreach(PdfPRow row in tabPdf.Rows)
                {
                    row.GetCells()[0].Border = iTextSharp.text.Rectangle.NO_BORDER;
                    row.GetCells()[1].Border = iTextSharp.text.Rectangle.LEFT_BORDER;
                    row.GetCells()[0].HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    row.GetCells()[1].HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                }

                doc.Add(space);
                doc.Add(tabPdf); 

                doc.Close();
            }
            catch (Exception err) { 
                
                //MessageBox.Show(err.ToString());
          
            }

        }

        private void userInfo1_Load(object sender, EventArgs e)
        {
            userInfo1.User = main.sessionNomUtilisateur;
            userInfo1.Lesson = main.dsDonnees.Tables["Cours"].Select("[numCours] = '" + main.sessionCodeCours + "'")[0]["titreCours"].ToString();
        }

        private void userInfo1_Click(object sender, EventArgs e)
        {
            main.deconnexion(this, main);
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (nbExoLecon <= main.sessionCodeLecon)
            {
                main.changerFormulaire(this, new Menu(main));
            }
            else
            {
                main.changerFormulaire(this, new Exercices(main, false));
            }
        }

        private void btnSuivant_Load(object sender, EventArgs e)
        {

        }
    }
}
