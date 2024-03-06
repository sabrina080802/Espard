
namespace SAE_A21_D21.Forms
{
    partial class LeconSuivante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeconSuivante));
            this.userInfo1 = new SAE_A21_D21.UserControls.UserInfo();
            this.btnRetour = new SAE_A21_D21.UserControls.ButtonCustom();
            this.btnReinitialiser = new SAE_A21_D21.UserControls.ButtonCustom();
            this.btnStop = new SAE_A21_D21.UserControls.ButtonCustom();
            this.btnCommencer = new SAE_A21_D21.UserControls.ButtonCustom();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitreLecon = new System.Windows.Forms.Label();
            this.lblTitreCours = new System.Windows.Forms.Label();
            this.lblCommentaireCours = new System.Windows.Forms.Label();
            this.lblCommentaireLecon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userInfo1
            // 
            this.userInfo1.BackColor = System.Drawing.Color.Transparent;
            this.userInfo1.Lesson = "Un cours tkt";
            this.userInfo1.Location = new System.Drawing.Point(97, 172);
            this.userInfo1.Name = "userInfo1";
            this.userInfo1.Size = new System.Drawing.Size(486, 241);
            this.userInfo1.TabIndex = 0;
            this.userInfo1.User = "";
            this.userInfo1.Click += new System.EventHandler(this.userInfo1_Click_1);
            this.userInfo1.Load += new System.EventHandler(this.userInfo1_Load);
            // 
            // btnRetour
            // 
            this.btnRetour.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnRetour.BtnText = "Menu";
            this.btnRetour.FgColor = System.Drawing.Color.White;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnRetour.Location = new System.Drawing.Point(137, 854);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnRetour.Size = new System.Drawing.Size(357, 57);
            this.btnRetour.TabIndex = 4;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            this.btnRetour.Load += new System.EventHandler(this.btnRetour_Load);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnReinitialiser.BtnText = "Réinitialiser";
            this.btnReinitialiser.FgColor = System.Drawing.Color.White;
            this.btnReinitialiser.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinitialiser.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnReinitialiser.Location = new System.Drawing.Point(137, 943);
            this.btnReinitialiser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnReinitialiser.Size = new System.Drawing.Size(357, 57);
            this.btnReinitialiser.TabIndex = 12;
            // 
            // btnStop
            // 
            this.btnStop.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnStop.BtnText = "Retour";
            this.btnStop.FgColor = System.Drawing.Color.White;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnStop.Location = new System.Drawing.Point(851, 943);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnStop.Size = new System.Drawing.Size(227, 57);
            this.btnStop.TabIndex = 13;
            this.btnStop.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnCommencer
            // 
            this.btnCommencer.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnCommencer.BtnText = "Commencer";
            this.btnCommencer.FgColor = System.Drawing.Color.White;
            this.btnCommencer.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommencer.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnCommencer.Location = new System.Drawing.Point(1559, 943);
            this.btnCommencer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCommencer.Name = "btnCommencer";
            this.btnCommencer.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnCommencer.Size = new System.Drawing.Size(227, 57);
            this.btnCommencer.TabIndex = 14;
            this.btnCommencer.Click += new System.EventHandler(this.btnSuivant_Click);
            this.btnCommencer.Load += new System.EventHandler(this.btnCommencer_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(985, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 50);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitreLecon
            // 
            this.lblTitreLecon.AutoSize = true;
            this.lblTitreLecon.BackColor = System.Drawing.Color.Transparent;
            this.lblTitreLecon.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreLecon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.lblTitreLecon.Location = new System.Drawing.Point(978, 333);
            this.lblTitreLecon.Name = "lblTitreLecon";
            this.lblTitreLecon.Size = new System.Drawing.Size(100, 37);
            this.lblTitreLecon.TabIndex = 16;
            this.lblTitreLecon.Text = "label1";
            // 
            // lblTitreCours
            // 
            this.lblTitreCours.AutoSize = true;
            this.lblTitreCours.BackColor = System.Drawing.Color.Transparent;
            this.lblTitreCours.Font = new System.Drawing.Font("Microsoft Tai Le", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreCours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.lblTitreCours.Location = new System.Drawing.Point(975, 226);
            this.lblTitreCours.Name = "lblTitreCours";
            this.lblTitreCours.Size = new System.Drawing.Size(146, 55);
            this.lblTitreCours.TabIndex = 18;
            this.lblTitreCours.Text = "label1";
            // 
            // lblCommentaireCours
            // 
            this.lblCommentaireCours.AutoSize = true;
            this.lblCommentaireCours.BackColor = System.Drawing.Color.Transparent;
            this.lblCommentaireCours.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentaireCours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.lblCommentaireCours.Location = new System.Drawing.Point(981, 419);
            this.lblCommentaireCours.Name = "lblCommentaireCours";
            this.lblCommentaireCours.Size = new System.Drawing.Size(63, 23);
            this.lblCommentaireCours.TabIndex = 19;
            this.lblCommentaireCours.Text = "label1";
            this.lblCommentaireCours.Click += new System.EventHandler(this.lblCommentaireCours_Click);
            // 
            // lblCommentaireLecon
            // 
            this.lblCommentaireLecon.AutoSize = true;
            this.lblCommentaireLecon.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentaireLecon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.lblCommentaireLecon.Location = new System.Drawing.Point(1013, 564);
            this.lblCommentaireLecon.Name = "lblCommentaireLecon";
            this.lblCommentaireLecon.Size = new System.Drawing.Size(0, 16);
            this.lblCommentaireLecon.TabIndex = 20;
            // 
            // LeconSuivante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.lblCommentaireLecon);
            this.Controls.Add(this.lblCommentaireCours);
            this.Controls.Add(this.lblTitreCours);
            this.Controls.Add(this.lblTitreLecon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCommencer);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.userInfo1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LeconSuivante";
            this.Text = "LeconSuivante";
            this.Load += new System.EventHandler(this.LeconSuivante_Load);
            this.Controls.SetChildIndex(this.userInfo1, 0);
            this.Controls.SetChildIndex(this.btnRetour, 0);
            this.Controls.SetChildIndex(this.btnReinitialiser, 0);
            this.Controls.SetChildIndex(this.btnStop, 0);
            this.Controls.SetChildIndex(this.btnCommencer, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.lblTitreLecon, 0);
            this.Controls.SetChildIndex(this.lblTitreCours, 0);
            this.Controls.SetChildIndex(this.lblCommentaireCours, 0);
            this.Controls.SetChildIndex(this.lblCommentaireLecon, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.UserInfo userInfo1;
        private UserControls.ButtonCustom btnRetour;
        private UserControls.ButtonCustom btnReinitialiser;
        private UserControls.ButtonCustom btnStop;
        private UserControls.ButtonCustom btnCommencer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitreLecon;
        private System.Windows.Forms.Label lblTitreCours;
        private System.Windows.Forms.Label lblCommentaireCours;
        private System.Windows.Forms.Label lblCommentaireLecon;
    }
}