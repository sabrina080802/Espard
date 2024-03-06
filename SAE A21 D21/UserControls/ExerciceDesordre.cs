using SAE_A21_D21.Utils;
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
    public partial class ExerciceDesordre : Exercice
    {
        private List<string> correct = new List<string>();
        private List<string> answers = new List<string>();
        private Panel dropZone = null;
        private Button dragged = null;
        private List<Panel> dropZones = new List<Panel>();
        private bool isDisabled = false;

        public ExerciceDesordre(Main main, DataRow exo) : base(main, exo)
        {
            InitializeComponent();
            this.type = "Exercice dans le désordre";

        }

        public override List<string> printCorrection()
        {
            //PictureBox pb = new PictureBox();
            //pb.InitialImage = null;
            //pb.Name = "pb";
            //pb.Size = new System.Drawing.Size(20, 20);
            //pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            //pb.TabStop = false;

            //Controls.Add(pb);
            //vraiFauxPb.Add(pb);
            List<string> recap = new List<string>();
            isDisabled = true;

            for (int i = 0; i < correct.Count; i++)
            {
                string e = correct[i];
                if (dropZones[i].Controls.Count == 1)
                {
                    dropZones[i].Controls[0].BackColor = (correct[i] != dropZones[i].Controls[0].Text) ? Exercices.INVALID : Exercices.VALID;
                    e = "Non acquis|" + e;
                }
                else
                {
                    e = "Acquis|" + e;
                }
                recap.Add(e);
            }

            return recap;
        }

        public override bool isValid()
        {
            for(int i = 0; i < correct.Count; i++)
            {
                if (dropZones[i].Controls.Count != 1) return false;
                if (correct[i] != dropZones[i].Controls[0].Text) return false;
            }

            return true;
        }

        protected override void setup()
        {
            correct.Clear();
            answers.Clear();
            dropZone = null;
            dragged = null;
            dropZones.Clear();
            isDisabled = false;

            bool mettre = true;
            string phrase = (string)main.dsDonnees.Tables["Phrases"].Select("[codePhrase] = '" + exoRow["codePhrase"] + "'")[0]["textePhrase"];

            foreach (string mot in phrase.Split(Exercices.SEPARATORS))
            {
                if(mot.Trim().Length > 0) correct.Add(mot);
            }
            Random rdn = new Random();
            answers.AddRange(correct.OrderBy(item => rdn.Next()));

            // Traduction de la phrase
            Label trad = new Label();
            trad.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trad.Size = new System.Drawing.Size(700, 25);
            trad.Margin = new Padding(20,0,0,0);
            trad.TabIndex = 2;
            trad.Text = "Phrase : " + (string)main.dsDonnees.Tables["Phrases"].Select("[codePhrase] = '" + exoRow["codePhrase"] + "'")[0]["traducPhrase"];
            trad.Dock = DockStyle.Top;
            Controls.Add(trad);

            foreach (char c in phrase)
            {
                if (Exercices.SEPARATORS.Contains(c))
                {
                    // Mettre label du caractère
                    if (c != ' ')
                    {
                        Label lb = new Label();
                        lb.AutoSize = false;
                        lb.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lb.Size = new System.Drawing.Size(30, 30);
                        lb.TabIndex = 2;
                        lb.Text = c.ToString();
                        lb.TextAlign = ContentAlignment.BottomCenter;

                        flpExo.Controls.Add(lb);

                    }

                    mettre = true;
                }
                else if (mettre)
                {
                    // Mettre une zone
                    // Drag zones
                    Panel pnl = new Panel();
                    pnl.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnl.Size = new System.Drawing.Size(100, 30);
                    pnl.BackColor = Color.White;
                    pnl.BorderStyle = BorderStyle.FixedSingle;
                    pnl.MouseEnter += MouseEnterDropZone;
                    pnl.MouseLeave += MouseLeaveDropZone;
                    pnl.MouseMove += MouseMoveEvent;

                    dropZones.Add(pnl);
                    flpExo.Controls.Add(pnl);

                    mettre = false;
                }
            }

            foreach (string mot in answers)
            {
                Button btn = new Button();
                btn.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.Size = new System.Drawing.Size(100, 30);
                btn.Cursor = System.Windows.Forms.Cursors.SizeAll;
                btn.Text = mot;
                btn.BackColor = Color.White;
                //btn.UseVisualStyleBackColor = true;
                btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
                btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
                btn.MouseMove += MouseMoveEvent;
                MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);

                flpAnswers.Controls.Add(btn);
            }
        }
        private void MouseEnterDropZone(object sender, EventArgs e)
        {
            dropZone = (Panel)sender;
        }

        private void MouseLeaveDropZone(object sender, EventArgs e)
        {
            dropZone = null;
        }

        private void MouseMoveEvent(object sender, MouseEventArgs e)
        {
            if(dropZone != null)
            {
                if (!dropZone.ClientRectangle.Contains(dropZone.PointToClient(Cursor.Position)))
                {
                    dropZone = null;
                }
            }else
            {
                foreach(Panel p in dropZones)
                {
                    if (p.ClientRectangle.Contains(p.PointToClient(Cursor.Position)))
                    {
                        dropZone = p;
                        break;
                    }
                }
            }

            if (dragged != null)
            {
                Point loc = PointToClient(Cursor.Position);
                loc.X -= dragged.Width / 2;
                loc.Y -= dragged.Height / 2;
                dragged.Location = loc;
            }
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (!isDisabled)
            {
                dragged = (Button)sender;
                dragged.Dock = DockStyle.None;
                Controls.Add(dragged);
                Point loc = PointToClient(Cursor.Position);
                loc.X -= dragged.Width / 2;
                loc.Y -= dragged.Height / 2;
                dragged.Location = loc;
                dragged.BringToFront();
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            if (dropZone != null && dropZone.Controls.Count == 0)
            {
                dropZone.Controls.Add(dragged);
                dragged.Dock = DockStyle.Fill;
            }
            else
            {
                flpAnswers.Controls.Add(dragged);
            }
            dragged = null;
        }
    }
}
