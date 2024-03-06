
namespace SAE_A21_D21
{
    partial class Exercices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercices));
            this.lblProgression = new System.Windows.Forms.Label();
            this.btnRetour = new SAE_A21_D21.UserControls.ButtonCustom();
            this.btnVider = new SAE_A21_D21.UserControls.ButtonCustom();
            this.btnAide = new SAE_A21_D21.UserControls.ButtonCustom();
            this.btnValider = new SAE_A21_D21.UserControls.ButtonCustom();
            this.userInfo1 = new SAE_A21_D21.UserControls.UserInfo();
            this.pnlExercice = new System.Windows.Forms.Panel();
            this.lblTypeExercice = new System.Windows.Forms.Label();
            this.lblEnonce = new System.Windows.Forms.Label();
            this.btnSuivant = new SAE_A21_D21.UserControls.ButtonCustom();
            this.ppb = new SAE_A21_D21.UserControls.PointedProgressBar();
            this.btnreinitiliser = new SAE_A21_D21.UserControls.ButtonCustom();
            this.SuspendLayout();
            // 
            // lblProgression
            // 
            this.lblProgression.AutoSize = true;
            this.lblProgression.BackColor = System.Drawing.Color.Transparent;
            this.lblProgression.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgression.ForeColor = System.Drawing.Color.Black;
            this.lblProgression.Location = new System.Drawing.Point(1688, 199);
            this.lblProgression.Name = "lblProgression";
            this.lblProgression.Size = new System.Drawing.Size(146, 26);
            this.lblProgression.TabIndex = 5;
            this.lblProgression.Text = "Exercice : 0 / 0";
            // 
            // btnRetour
            // 
            this.btnRetour.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnRetour.BtnText = "Menu";
            this.btnRetour.FgColor = System.Drawing.Color.White;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnRetour.Location = new System.Drawing.Point(137, 854);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnRetour.Size = new System.Drawing.Size(357, 57);
            this.btnRetour.TabIndex = 6;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            this.btnRetour.Load += new System.EventHandler(this.btnRetour_Load);
            // 
            // btnVider
            // 
            this.btnVider.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnVider.BtnText = "Réinitialiser l\'exercice";
            this.btnVider.FgColor = System.Drawing.Color.White;
            this.btnVider.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnVider.Location = new System.Drawing.Point(839, 955);
            this.btnVider.Margin = new System.Windows.Forms.Padding(4);
            this.btnVider.Name = "btnVider";
            this.btnVider.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnVider.Size = new System.Drawing.Size(227, 45);
            this.btnVider.TabIndex = 7;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // btnAide
            // 
            this.btnAide.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnAide.BtnText = "Aide";
            this.btnAide.FgColor = System.Drawing.Color.White;
            this.btnAide.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAide.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnAide.Location = new System.Drawing.Point(1350, 955);
            this.btnAide.Margin = new System.Windows.Forms.Padding(4);
            this.btnAide.Name = "btnAide";
            this.btnAide.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnAide.Size = new System.Drawing.Size(227, 45);
            this.btnAide.TabIndex = 8;
            this.btnAide.Click += new System.EventHandler(this.btnAide_Click);
            // 
            // btnValider
            // 
            this.btnValider.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnValider.BtnText = "Valider";
            this.btnValider.FgColor = System.Drawing.Color.White;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnValider.Location = new System.Drawing.Point(1615, 955);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4);
            this.btnValider.Name = "btnValider";
            this.btnValider.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnValider.Size = new System.Drawing.Size(227, 45);
            this.btnValider.TabIndex = 9;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // userInfo1
            // 
            this.userInfo1.BackColor = System.Drawing.Color.Transparent;
            this.userInfo1.Lesson = "Un cours tkt";
            this.userInfo1.Location = new System.Drawing.Point(97, 172);
            this.userInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.userInfo1.Name = "userInfo1";
            this.userInfo1.Size = new System.Drawing.Size(486, 241);
            this.userInfo1.TabIndex = 10;
            this.userInfo1.User = "";
            this.userInfo1.Click += new System.EventHandler(this.userInfo1_Click);
            this.userInfo1.Load += new System.EventHandler(this.userInfo1_Load_1);
            // 
            // pnlExercice
            // 
            this.pnlExercice.Location = new System.Drawing.Point(839, 242);
            this.pnlExercice.Name = "pnlExercice";
            this.pnlExercice.Size = new System.Drawing.Size(1003, 661);
            this.pnlExercice.TabIndex = 11;
            this.pnlExercice.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlExercice_Paint);
            // 
            // lblTypeExercice
            // 
            this.lblTypeExercice.AutoSize = true;
            this.lblTypeExercice.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeExercice.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeExercice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.lblTypeExercice.Location = new System.Drawing.Point(832, 129);
            this.lblTypeExercice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeExercice.Name = "lblTypeExercice";
            this.lblTypeExercice.Size = new System.Drawing.Size(250, 41);
            this.lblTypeExercice.TabIndex = 3;
            this.lblTypeExercice.Text = "Type d\'exercice";
            this.lblTypeExercice.Click += new System.EventHandler(this.lblTypeExercice_Click);
            // 
            // lblEnonce
            // 
            this.lblEnonce.AutoSize = true;
            this.lblEnonce.BackColor = System.Drawing.Color.Transparent;
            this.lblEnonce.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnonce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.lblEnonce.Location = new System.Drawing.Point(834, 189);
            this.lblEnonce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnonce.Name = "lblEnonce";
            this.lblEnonce.Size = new System.Drawing.Size(103, 30);
            this.lblEnonce.TabIndex = 2;
            this.lblEnonce.Text = "Enoncé :";
            // 
            // btnSuivant
            // 
            this.btnSuivant.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnSuivant.BtnText = "Suivant";
            this.btnSuivant.FgColor = System.Drawing.Color.White;
            this.btnSuivant.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnSuivant.Location = new System.Drawing.Point(1615, 955);
            this.btnSuivant.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnSuivant.Size = new System.Drawing.Size(227, 45);
            this.btnSuivant.TabIndex = 12;
            this.btnSuivant.Visible = false;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            this.btnSuivant.Load += new System.EventHandler(this.btnSuivant_Load);
            // 
            // ppb
            // 
            this.ppb.BackColor = System.Drawing.Color.Transparent;
            this.ppb.BarCurrentColor = System.Drawing.Color.Gray;
            this.ppb.BarFailColor = System.Drawing.Color.Red;
            this.ppb.BarNoneColor = System.Drawing.Color.White;
            this.ppb.BarSuccessColor = System.Drawing.Color.Green;
            this.ppb.Location = new System.Drawing.Point(772, 54);
            this.ppb.Name = "ppb";
            this.ppb.Size = new System.Drawing.Size(1108, 45);
            this.ppb.TabIndex = 13;
            // 
            // btnreinitiliser
            // 
            this.btnreinitiliser.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnreinitiliser.BtnText = "Réinitialiser tous les exercices";
            this.btnreinitiliser.FgColor = System.Drawing.Color.White;
            this.btnreinitiliser.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreinitiliser.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnreinitiliser.Location = new System.Drawing.Point(137, 943);
            this.btnreinitiliser.Margin = new System.Windows.Forms.Padding(4);
            this.btnreinitiliser.Name = "btnreinitiliser";
            this.btnreinitiliser.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnreinitiliser.Size = new System.Drawing.Size(357, 57);
            this.btnreinitiliser.TabIndex = 14;
            this.btnreinitiliser.Click += new System.EventHandler(this.btnreinitiliser_Click);
            this.btnreinitiliser.Load += new System.EventHandler(this.btnreinitiliser_Load);
            // 
            // Exercices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnreinitiliser);
            this.Controls.Add(this.lblEnonce);
            this.Controls.Add(this.lblTypeExercice);
            this.Controls.Add(this.ppb);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.pnlExercice);
            this.Controls.Add(this.userInfo1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAide);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblProgression);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Exercices";
            this.Text = "Exercice";
            this.Load += new System.EventHandler(this.Exercice_Load);
            this.Controls.SetChildIndex(this.lblProgression, 0);
            this.Controls.SetChildIndex(this.btnRetour, 0);
            this.Controls.SetChildIndex(this.btnVider, 0);
            this.Controls.SetChildIndex(this.btnAide, 0);
            this.Controls.SetChildIndex(this.btnValider, 0);
            this.Controls.SetChildIndex(this.userInfo1, 0);
            this.Controls.SetChildIndex(this.pnlExercice, 0);
            this.Controls.SetChildIndex(this.btnSuivant, 0);
            this.Controls.SetChildIndex(this.ppb, 0);
            this.Controls.SetChildIndex(this.lblTypeExercice, 0);
            this.Controls.SetChildIndex(this.lblEnonce, 0);
            this.Controls.SetChildIndex(this.btnreinitiliser, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProgression;
        private UserControls.ButtonCustom btnRetour;
        private UserControls.ButtonCustom btnVider;
        private UserControls.ButtonCustom btnAide;
        private UserControls.ButtonCustom btnValider;
        private UserControls.UserInfo userInfo1;
        private System.Windows.Forms.Panel pnlExercice;
        private UserControls.ButtonCustom btnSuivant;
        private System.Windows.Forms.Label lblTypeExercice;
        private System.Windows.Forms.Label lblEnonce;
        private UserControls.PointedProgressBar ppb;
        private UserControls.ButtonCustom btnreinitiliser;
    }
}