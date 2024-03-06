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


namespace SAE_A21_D21
{
    public partial class Recapitulatif : CustomForm
    {
        // Référence vers le formulaire principal (main)
        Main main;
        string source;

        public Recapitulatif(Main main, string source)
        {
            // Affecter la référence vers le parent
            this.main = main;




            // Tests à enlever ¤¤¤¤¤¤
            main.recapitulatif.Rows.Add("Acquis", "titre", "un mot");
            main.recapitulatif.Rows.Add("Non acquis", "titre", "un premier");
            main.recapitulatif.Rows.Add("Non acquis", "titre", "un deuxieme");
            main.recapitulatif.Rows.Add("Acquis", "titre", "deux mots");
            main.recapitulatif.Rows.Add("En cours d'acquisition", "titre", "trois mots");
            main.recapitulatif.Rows.Add("Acquis", "titre", "quatre mots");
            main.recapitulatif.Rows.Add("Acquis", "titre", "cinq mots");
            main.recapitulatif.Rows.Add("Acquis", "titre", "six mots");





            // Source du formulaire ("menu" ou "exercice")
            this.source = source;
            InitializeComponent();
        }

        private void Recapitulatif_Load(object sender, EventArgs e)
        {
            int decalage = 50;
            int countA = 0;
            int countN = 0;
            int nbLimite = 15;


            foreach (DataRow eltRecap in main.recapitulatif.Rows)
            {

                Label lb = new Label();
                lb.AutoSize = true;
                lb.Location = new System.Drawing.Point(82, 90);
                lb.Name = "lb";
                lb.Size = new System.Drawing.Size(35, 13);
                lb.TabIndex = 6;


                if (countA < nbLimite && (eltRecap["statut"].ToString() == "Acquis") || (eltRecap["statut"].ToString() == "En cours d'acquisition"))
                {
                    // Pour les mots en cours d'acquisition
                    if ((eltRecap["statut"].ToString() == "En cours d'acquisition"))
                    {
                        // Changer la couleur en du beau orange foncé, là c'est du rose (trobo) :flushed:
                        lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    }

                    lb.Text = eltRecap["mot"].ToString();
                    lb.Location = new System.Drawing.Point(4, 15 + decalage * countA);

                    // A voir avec Sabrina comment ca marche ¤
                    tableLayoutPanel3.Controls.Add(lb);

                    countA++;


                }
                else if (countN < nbLimite && eltRecap["statut"].ToString() == "Non acquis")
                {

                    lb.Text += eltRecap["mot"].ToString();
                    lb.Location = new System.Drawing.Point(4, 15 + decalage * countN);

                    // A voir avec Sabrina comment ca marche ¤
                    tableLayoutPanel2.Controls.Add(lb);

                    countN++;


                }
            }

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            if (source == "menu")
            {
                main.changerFormulaire(this, new Menu(main));
            }
            else
            {
                main.changerFormulaire(this, new Exercice(main));
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
        

        }

        private void btnRetour_Load(object sender, EventArgs e)
        {


        }

        private void btnEnregistrer_Load(object sender, EventArgs e)
        {

            
            /*catch(Exception e)
            {

                Debug.WriteLine("Erreur génération PDF : " + e.ToString());

            } */
            
        }

        private void btnEnregistrer_Load_1(object sender, EventArgs e)
        {

            try
            {
                // Generation du document PDF et accès avec FileStream
                string path = Path.Combine(Environment.CurrentDirectory + @"\PDF\");

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                // Voir la génération
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, new FileStream(main.sessionNomUtilisateur + ".pdf", FileMode.Create));
                doc.Open();
                

                // Couleur
                BaseColor gris = new BaseColor(240, 240, 240);
                BaseColor blanc = new BaseColor(255, 255, 255);
                BaseColor noir = new BaseColor(0, 0, 0);


                // Polices d'écritures
                iTextSharp.text.Font titre = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 23f, iTextSharp.text.Font.BOLD, noir);
                iTextSharp.text.Font lecon = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18f, iTextSharp.text.Font.UNDERLINE, noir);
                iTextSharp.text.Font h3 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16f, iTextSharp.text.Font.UNDERLINE, noir);
                iTextSharp.text.Font pBlackBold = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, iTextSharp.text.Font.BOLD, noir);
                iTextSharp.text.Font nbPart = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9f, iTextSharp.text.Font.BOLD, noir);

                Paragraph space = new Paragraph("\n");
                string texte = "";
                int decalage = 50;
                int countA = 0;
                int countN = 0;
                int nbLimite = 15;

                // Header du doc

                // Bannière en haut de la page avec logo + couleurs + nom "Bilan"
                //iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Properties.Resources.PDFBG, System.Drawing.Imaging.ImageFormat.Png);
                //logo.Alignment = Element.ALIGN_LEFT;
                //doc.Add(logo);

                doc.Add(space);



                // Titres en haut ¤¤¤¤¤¤¤
                Chunk titreRecap = new Chunk("\t Recapitulatif ", titre);
                doc.Add(titreRecap);


                Chunk numCours = new Chunk("\t Cours : " + main.recapitulatif.Rows["titre"], lecon);
                doc.Add(numCours);
                Chunk numLecon = new Chunk("\t Leçon : " + main.recapitulatif.Rows["titre"], lecon);
                doc.Add(numLecon);

                doc.Add(space);


                // Tableau

                PdfPTable tabMots = new PdfPTable(2);
                tabMots.WidthPercentage = 50; //¤¤¤¤¤
                //Table table = new Table();

                /** this.addThToTab("Description", th, blue, tabPayeur, 2);
                this.addThToTab("Montant", th, blue, tabPayeur, 1); **/

                tabMots.AddCell(" X ");

                // Parcours de la bdd pour avoir les mots
                foreach (DataRow eltRecap in main.recapitulatif.Rows)
                {
                    
                    Paragraph retour = new Paragraph("\n");


                    // Tableau acquis/non acquis
                    // Progression
                    // Changement de couleurs mots ?
                    // Format paysage, portrait ?¤
                   
                    // texte += eltRecap["titre"].ToString() + retour;


                    if (countA < nbLimite && (eltRecap["statut"].ToString() == "Acquis") || (eltRecap["statut"].ToString() == "En cours d'acquisition"))
                    {
                        // Pour les mots en cours d'acquisition
                        if ((eltRecap["statut"].ToString() == "En cours d'acquisition"))
                        {
                            // Changer la couleur en du beau orange foncé, là c'est du rose (trobo) :flushed:
                            //eltRecap. = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                        }

                 
                        texte += eltRecap["mot"].ToString() + retour;
                        countA++;


                    }
                    else if (countN < nbLimite && eltRecap["statut"].ToString() == "Non acquis")
                    {
                        texte += eltRecap["titre"].ToString() + retour;
                        texte += eltRecap["mot"].ToString() + retour;

                        countN++;

                    }

                    // Ajout de p dans le doc
                    Paragraph p = new Paragraph(texte);
                    doc.Add(p);

                }

                doc.Close();
            }
            catch { }
        }
    }
}
