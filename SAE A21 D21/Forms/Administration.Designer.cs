namespace SAE_A21_D21
{
    partial class Administration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administration));
            this.btnRetour = new SAE_A21_D21.UserControls.ButtonCustom();
            this.btnTerminer = new SAE_A21_D21.UserControls.ButtonCustom();
            this.userInfo1 = new SAE_A21_D21.UserControls.UserInfo();
            this.btnAjouter = new SAE_A21_D21.UserControls.ButtonCustom();
            this.btnExercices = new SAE_A21_D21.UserControls.ButtonCustom();
            this.btnProgression = new SAE_A21_D21.UserControls.ButtonCustom();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnRetour.BtnText = "Menu";
            this.btnRetour.FgColor = System.Drawing.Color.White;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnRetour.Location = new System.Drawing.Point(137, 943);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnRetour.Size = new System.Drawing.Size(357, 57);
            this.btnRetour.TabIndex = 7;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            this.btnRetour.Load += new System.EventHandler(this.btnRetour_Load);
            // 
            // btnTerminer
            // 
            this.btnTerminer.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnTerminer.BtnText = "Terminer";
            this.btnTerminer.FgColor = System.Drawing.Color.White;
            this.btnTerminer.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminer.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnTerminer.Location = new System.Drawing.Point(1475, 943);
            this.btnTerminer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTerminer.Name = "btnTerminer";
            this.btnTerminer.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnTerminer.Size = new System.Drawing.Size(357, 57);
            this.btnTerminer.TabIndex = 11;
            this.btnTerminer.Click += new System.EventHandler(this.btnTerminer_Click);
            this.btnTerminer.Load += new System.EventHandler(this.btnTerminer_Load);
            // 
            // userInfo1
            // 
            this.userInfo1.BackColor = System.Drawing.Color.Transparent;
            this.userInfo1.Lesson = "Un cours tkt";
            this.userInfo1.Location = new System.Drawing.Point(97, 172);
            this.userInfo1.Name = "userInfo1";
            this.userInfo1.Size = new System.Drawing.Size(486, 241);
            this.userInfo1.TabIndex = 12;
            this.userInfo1.User = "";
            this.userInfo1.Click += new System.EventHandler(this.userInfo1_Click);
            this.userInfo1.Load += new System.EventHandler(this.userInfo1_Load);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnAjouter.BtnText = "Ajouter un utilisateur";
            this.btnAjouter.FgColor = System.Drawing.Color.White;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnAjouter.Location = new System.Drawing.Point(1173, 581);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnAjouter.Size = new System.Drawing.Size(357, 57);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnExercices
            // 
            this.btnExercices.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnExercices.BtnText = "Voir exercices";
            this.btnExercices.FgColor = System.Drawing.Color.White;
            this.btnExercices.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercices.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnExercices.Location = new System.Drawing.Point(1173, 479);
            this.btnExercices.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnExercices.Name = "btnExercices";
            this.btnExercices.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnExercices.Size = new System.Drawing.Size(357, 57);
            this.btnExercices.TabIndex = 5;
            this.btnExercices.Click += new System.EventHandler(this.btnExercices_Click);
            this.btnExercices.Load += new System.EventHandler(this.btnExercices_Load);
            // 
            // btnProgression
            // 
            this.btnProgression.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnProgression.BtnText = "Progression des utilisateurs";
            this.btnProgression.FgColor = System.Drawing.Color.White;
            this.btnProgression.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgression.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnProgression.Location = new System.Drawing.Point(1173, 374);
            this.btnProgression.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnProgression.Name = "btnProgression";
            this.btnProgression.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnProgression.Size = new System.Drawing.Size(357, 57);
            this.btnProgression.TabIndex = 6;
            this.btnProgression.Click += new System.EventHandler(this.btnProgression_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1027, 93);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(649, 51);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.userInfo1);
            this.Controls.Add(this.btnTerminer);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnProgression);
            this.Controls.Add(this.btnExercices);
            this.Controls.Add(this.btnAjouter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Administration";
            this.Text = "Administration";
            this.Controls.SetChildIndex(this.btnAjouter, 0);
            this.Controls.SetChildIndex(this.btnExercices, 0);
            this.Controls.SetChildIndex(this.btnProgression, 0);
            this.Controls.SetChildIndex(this.btnRetour, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.btnTerminer, 0);
            this.Controls.SetChildIndex(this.userInfo1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.ButtonCustom btnRetour;
        private UserControls.ButtonCustom btnTerminer;
        private UserControls.UserInfo userInfo1;
        private UserControls.ButtonCustom btnAjouter;
        private UserControls.ButtonCustom btnExercices;
        private UserControls.ButtonCustom btnProgression;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}