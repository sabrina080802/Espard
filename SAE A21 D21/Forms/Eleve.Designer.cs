namespace SAE_A21_D21.Forms
{
    partial class Eleve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eleve));
            this.lblNom = new System.Windows.Forms.Label();
            this.cpbProgression = new SAE_A21_D21.UserControls.CircleProgessBar();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblLecon = new System.Windows.Forms.Label();
            this.lblCours = new System.Windows.Forms.Label();
            this.lblExo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNom.Location = new System.Drawing.Point(173, 62);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(102, 27);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Profil de ";
            // 
            // cpbProgression
            // 
            this.cpbProgression.BackColor = System.Drawing.Color.Transparent;
            this.cpbProgression.BarColor = System.Drawing.Color.White;
            this.cpbProgression.BarProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.cpbProgression.BarSize = 12;
            this.cpbProgression.Location = new System.Drawing.Point(565, 225);
            this.cpbProgression.Name = "cpbProgression";
            this.cpbProgression.Percentage = 10.5F;
            this.cpbProgression.PercentageVisible = true;
            this.cpbProgression.Size = new System.Drawing.Size(150, 150);
            this.cpbProgression.TabIndex = 5;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMail.Location = new System.Drawing.Point(192, 104);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(79, 26);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "Email : ";
            // 
            // lblLecon
            // 
            this.lblLecon.AutoSize = true;
            this.lblLecon.BackColor = System.Drawing.Color.Transparent;
            this.lblLecon.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLecon.Location = new System.Drawing.Point(83, 288);
            this.lblLecon.Name = "lblLecon";
            this.lblLecon.Size = new System.Drawing.Size(84, 26);
            this.lblLecon.TabIndex = 7;
            this.lblLecon.Text = "Leçon : ";
            // 
            // lblCours
            // 
            this.lblCours.AutoSize = true;
            this.lblCours.BackColor = System.Drawing.Color.Transparent;
            this.lblCours.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCours.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCours.Location = new System.Drawing.Point(83, 224);
            this.lblCours.Name = "lblCours";
            this.lblCours.Size = new System.Drawing.Size(82, 26);
            this.lblCours.TabIndex = 8;
            this.lblCours.Text = "Cours : ";
            // 
            // lblExo
            // 
            this.lblExo.AutoSize = true;
            this.lblExo.BackColor = System.Drawing.Color.Transparent;
            this.lblExo.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExo.Location = new System.Drawing.Point(83, 349);
            this.lblExo.Name = "lblExo";
            this.lblExo.Size = new System.Drawing.Size(104, 26);
            this.lblExo.TabIndex = 9;
            this.lblExo.Text = "Exercice : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(52, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Eleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblExo);
            this.Controls.Add(this.lblCours);
            this.Controls.Add(this.lblLecon);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.cpbProgression);
            this.Controls.Add(this.lblNom);
            this.Name = "Eleve";
            this.Text = "Eleve";
            this.ExitBtnClick += new System.EventHandler(this.Eleve_ExitBtnClick);
            this.Load += new System.EventHandler(this.Eleve_Load);
            this.Controls.SetChildIndex(this.lblNom, 0);
            this.Controls.SetChildIndex(this.cpbProgression, 0);
            this.Controls.SetChildIndex(this.lblMail, 0);
            this.Controls.SetChildIndex(this.lblLecon, 0);
            this.Controls.SetChildIndex(this.lblCours, 0);
            this.Controls.SetChildIndex(this.lblExo, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private UserControls.CircleProgessBar cpbProgression;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblLecon;
        private System.Windows.Forms.Label lblCours;
        private System.Windows.Forms.Label lblExo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}