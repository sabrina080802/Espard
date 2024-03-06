
namespace SAE_A21_D21.Forms
{
    partial class AdministrationProgression
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrationProgression));
            this.btnRetour = new SAE_A21_D21.UserControls.ButtonCustom();
            this.userInfo1 = new SAE_A21_D21.UserControls.UserInfo();
            this.btnAdmini = new SAE_A21_D21.UserControls.ButtonCustom();
            this.pnlEleve = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnRetour.BtnText = "Retour";
            this.btnRetour.FgColor = System.Drawing.Color.White;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnRetour.Location = new System.Drawing.Point(1458, 943);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnRetour.Size = new System.Drawing.Size(357, 57);
            this.btnRetour.TabIndex = 2;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click_1);
            this.btnRetour.Load += new System.EventHandler(this.btnRetour_Load);
            // 
            // userInfo1
            // 
            this.userInfo1.BackColor = System.Drawing.Color.Transparent;
            this.userInfo1.Lesson = "Un cours tkt";
            this.userInfo1.Location = new System.Drawing.Point(97, 172);
            this.userInfo1.Name = "userInfo1";
            this.userInfo1.Size = new System.Drawing.Size(486, 241);
            this.userInfo1.TabIndex = 3;
            this.userInfo1.User = "";
            this.userInfo1.Click += new System.EventHandler(this.userInfo1_Click);
            this.userInfo1.Load += new System.EventHandler(this.userInfo1_Load);
            // 
            // btnAdmini
            // 
            this.btnAdmini.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnAdmini.BtnText = "Menu";
            this.btnAdmini.FgColor = System.Drawing.Color.White;
            this.btnAdmini.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmini.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnAdmini.Location = new System.Drawing.Point(137, 943);
            this.btnAdmini.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdmini.Name = "btnAdmini";
            this.btnAdmini.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnAdmini.Size = new System.Drawing.Size(357, 57);
            this.btnAdmini.TabIndex = 5;
            this.btnAdmini.Click += new System.EventHandler(this.btnAdmini_Click);
            this.btnAdmini.Load += new System.EventHandler(this.btnAdmini_Load);
            // 
            // pnlEleve
            // 
            this.pnlEleve.AutoScroll = true;
            this.pnlEleve.BackColor = System.Drawing.Color.Transparent;
            this.pnlEleve.Location = new System.Drawing.Point(945, 170);
            this.pnlEleve.Name = "pnlEleve";
            this.pnlEleve.Size = new System.Drawing.Size(830, 654);
            this.pnlEleve.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1006, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 91);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // AdministrationProgression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlEleve);
            this.Controls.Add(this.btnAdmini);
            this.Controls.Add(this.userInfo1);
            this.Controls.Add(this.btnRetour);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdministrationProgression";
            this.Text = "AdministrationProgression";
            this.Load += new System.EventHandler(this.AdministrationProgression_Load);
            this.Controls.SetChildIndex(this.btnRetour, 0);
            this.Controls.SetChildIndex(this.userInfo1, 0);
            this.Controls.SetChildIndex(this.btnAdmini, 0);
            this.Controls.SetChildIndex(this.pnlEleve, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ButtonCustom btnRetour;
        private UserControls.UserInfo userInfo1;
        private UserControls.ButtonCustom btnAdmini;
        private System.Windows.Forms.Panel pnlEleve;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}