
namespace SAE_A21_D21
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lblProgressionLecon = new System.Windows.Forms.Label();
            this.progessBarCustom1 = new SAE_A21_D21.UserControls.CircleProgessBar();
            this.userInfo1 = new SAE_A21_D21.UserControls.UserInfo();
            this.btnAdministration = new SAE_A21_D21.UserControls.ButtonCustom();
            this.btnJouer = new SAE_A21_D21.UserControls.ButtonCustom();
            this.btnRecapitulatif = new SAE_A21_D21.UserControls.ButtonCustom();
            this.lblprogression = new System.Windows.Forms.Label();
            this.lblLecon = new System.Windows.Forms.Label();
            this.lblCours = new System.Windows.Forms.Label();
            this.btnReinitialiser = new SAE_A21_D21.UserControls.ButtonCustom();
            this.SuspendLayout();
            // 
            // lblProgressionLecon
            // 
            this.lblProgressionLecon.AutoSize = true;
            this.lblProgressionLecon.BackColor = System.Drawing.Color.Transparent;
            this.lblProgressionLecon.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressionLecon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.lblProgressionLecon.Location = new System.Drawing.Point(1063, 530);
            this.lblProgressionLecon.Name = "lblProgressionLecon";
            this.lblProgressionLecon.Size = new System.Drawing.Size(238, 26);
            this.lblProgressionLecon.TabIndex = 7;
            this.lblProgressionLecon.Text = "PlecProgression leçonon";
            // 
            // progessBarCustom1
            // 
            this.progessBarCustom1.BackColor = System.Drawing.Color.Transparent;
            this.progessBarCustom1.BarColor = System.Drawing.Color.White;
            this.progessBarCustom1.BarProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.progessBarCustom1.BarSize = 12;
            this.progessBarCustom1.Location = new System.Drawing.Point(1365, 552);
            this.progessBarCustom1.Name = "progessBarCustom1";
            this.progessBarCustom1.Percentage = 10.5F;
            this.progessBarCustom1.PercentageVisible = true;
            this.progessBarCustom1.Size = new System.Drawing.Size(100, 100);
            this.progessBarCustom1.TabIndex = 12;
            // 
            // userInfo1
            // 
            this.userInfo1.BackColor = System.Drawing.Color.Transparent;
            this.userInfo1.Lesson = "Un cours tkt";
            this.userInfo1.Location = new System.Drawing.Point(97, 172);
            this.userInfo1.Name = "userInfo1";
            this.userInfo1.Size = new System.Drawing.Size(486, 241);
            this.userInfo1.TabIndex = 11;
            this.userInfo1.User = "";
            this.userInfo1.Click += new System.EventHandler(this.userInfo1_Click);
            this.userInfo1.Load += new System.EventHandler(this.userInfo1_Load);
            // 
            // btnAdministration
            // 
            this.btnAdministration.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnAdministration.BtnText = "Administration";
            this.btnAdministration.FgColor = System.Drawing.Color.White;
            this.btnAdministration.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministration.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnAdministration.Location = new System.Drawing.Point(137, 762);
            this.btnAdministration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdministration.Name = "btnAdministration";
            this.btnAdministration.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnAdministration.Size = new System.Drawing.Size(357, 57);
            this.btnAdministration.TabIndex = 10;
            this.btnAdministration.Visible = false;
            this.btnAdministration.Click += new System.EventHandler(this.btnAdministration_Click);
            // 
            // btnJouer
            // 
            this.btnJouer.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnJouer.BtnText = "Commencer";
            this.btnJouer.FgColor = System.Drawing.Color.White;
            this.btnJouer.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJouer.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnJouer.Location = new System.Drawing.Point(1489, 943);
            this.btnJouer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnJouer.Size = new System.Drawing.Size(357, 57);
            this.btnJouer.TabIndex = 9;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            this.btnJouer.Load += new System.EventHandler(this.btnJouer_Load);
            // 
            // btnRecapitulatif
            // 
            this.btnRecapitulatif.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnRecapitulatif.BtnText = "Récapitulatif";
            this.btnRecapitulatif.FgColor = System.Drawing.Color.White;
            this.btnRecapitulatif.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecapitulatif.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnRecapitulatif.Location = new System.Drawing.Point(137, 854);
            this.btnRecapitulatif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecapitulatif.Name = "btnRecapitulatif";
            this.btnRecapitulatif.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnRecapitulatif.Size = new System.Drawing.Size(357, 57);
            this.btnRecapitulatif.TabIndex = 13;
            this.btnRecapitulatif.Click += new System.EventHandler(this.btnRecapitulatif_Click);
            // 
            // lblprogression
            // 
            this.lblprogression.AutoSize = true;
            this.lblprogression.BackColor = System.Drawing.Color.Transparent;
            this.lblprogression.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprogression.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.lblprogression.Location = new System.Drawing.Point(1063, 588);
            this.lblprogression.Name = "lblprogression";
            this.lblprogression.Size = new System.Drawing.Size(244, 27);
            this.lblprogression.TabIndex = 14;
            this.lblprogression.Text = "VOTRE PROGRESSION :";
            // 
            // lblLecon
            // 
            this.lblLecon.AutoSize = true;
            this.lblLecon.BackColor = System.Drawing.Color.Transparent;
            this.lblLecon.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.lblLecon.Location = new System.Drawing.Point(879, 318);
            this.lblLecon.Name = "lblLecon";
            this.lblLecon.Size = new System.Drawing.Size(267, 61);
            this.lblLecon.TabIndex = 15;
            this.lblLecon.Text = "Titre leçon";
            // 
            // lblCours
            // 
            this.lblCours.AutoSize = true;
            this.lblCours.BackColor = System.Drawing.Color.Transparent;
            this.lblCours.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.lblCours.Location = new System.Drawing.Point(884, 249);
            this.lblCours.Name = "lblCours";
            this.lblCours.Size = new System.Drawing.Size(138, 34);
            this.lblCours.TabIndex = 17;
            this.lblCours.Text = "Titre cours";
            this.lblCours.Click += new System.EventHandler(this.lblCours_Click);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnReinitialiser.BtnText = "Réinitialiser tous les exercices";
            this.btnReinitialiser.FgColor = System.Drawing.Color.White;
            this.btnReinitialiser.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinitialiser.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnReinitialiser.Location = new System.Drawing.Point(137, 943);
            this.btnReinitialiser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnReinitialiser.Size = new System.Drawing.Size(357, 57);
            this.btnReinitialiser.TabIndex = 18;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.lblCours);
            this.Controls.Add(this.lblLecon);
            this.Controls.Add(this.lblprogression);
            this.Controls.Add(this.btnRecapitulatif);
            this.Controls.Add(this.progessBarCustom1);
            this.Controls.Add(this.userInfo1);
            this.Controls.Add(this.btnAdministration);
            this.Controls.Add(this.btnJouer);
            this.Controls.Add(this.lblProgressionLecon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Controls.SetChildIndex(this.lblProgressionLecon, 0);
            this.Controls.SetChildIndex(this.btnJouer, 0);
            this.Controls.SetChildIndex(this.btnAdministration, 0);
            this.Controls.SetChildIndex(this.userInfo1, 0);
            this.Controls.SetChildIndex(this.progessBarCustom1, 0);
            this.Controls.SetChildIndex(this.btnRecapitulatif, 0);
            this.Controls.SetChildIndex(this.lblprogression, 0);
            this.Controls.SetChildIndex(this.lblLecon, 0);
            this.Controls.SetChildIndex(this.lblCours, 0);
            this.Controls.SetChildIndex(this.btnReinitialiser, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProgressionLecon;
        private UserControls.ButtonCustom btnJouer;
        private UserControls.ButtonCustom btnAdministration;
        private UserControls.UserInfo userInfo1;
        private UserControls.CircleProgessBar progessBarCustom1;
        private UserControls.ButtonCustom btnRecapitulatif;
        private System.Windows.Forms.Label lblprogression;
        private System.Windows.Forms.Label lblLecon;
        private System.Windows.Forms.Label lblCours;
        private UserControls.ButtonCustom btnReinitialiser;
    }
}