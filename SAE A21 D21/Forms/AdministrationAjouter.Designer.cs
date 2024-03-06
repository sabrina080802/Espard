
namespace SAE_A21_D21
{
    partial class AdministrationAjouter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrationAjouter));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtboNom = new System.Windows.Forms.TextBox();
            this.txtboPrenom = new System.Windows.Forms.TextBox();
            this.txtboEmail = new System.Windows.Forms.TextBox();
            this.btnRetour = new SAE_A21_D21.UserControls.ButtonCustom();
            this.userInfo1 = new SAE_A21_D21.UserControls.UserInfo();
            this.btnMenu = new SAE_A21_D21.UserControls.ButtonCustom();
            this.btnValider = new SAE_A21_D21.UserControls.ButtonCustom();
            this.pnlAvance = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCodeCours = new SAE_A21_D21.UserControls.ComboBoxCustom();
            this.cboCodeLecon = new SAE_A21_D21.UserControls.ComboBoxCustom();
            this.cboCodeExo = new SAE_A21_D21.UserControls.ComboBoxCustom();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbAvance = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlAvance.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(959, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(774, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(1216, 262);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(61, 27);
            this.lblNom.TabIndex = 9;
            this.lblNom.Text = "Nom";
            this.lblNom.Click += new System.EventHandler(this.lblNom_Click);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(1196, 324);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(81, 23);
            this.lblPrenom.TabIndex = 10;
            this.lblPrenom.Text = "Prénom";
            this.lblPrenom.Click += new System.EventHandler(this.lblPrenom_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(1220, 383);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 23);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // txtboNom
            // 
            this.txtboNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboNom.Location = new System.Drawing.Point(1283, 263);
            this.txtboNom.Name = "txtboNom";
            this.txtboNom.Size = new System.Drawing.Size(156, 26);
            this.txtboNom.TabIndex = 13;
            // 
            // txtboPrenom
            // 
            this.txtboPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboPrenom.Location = new System.Drawing.Point(1283, 322);
            this.txtboPrenom.Name = "txtboPrenom";
            this.txtboPrenom.Size = new System.Drawing.Size(156, 26);
            this.txtboPrenom.TabIndex = 14;
            // 
            // txtboEmail
            // 
            this.txtboEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboEmail.Location = new System.Drawing.Point(1283, 383);
            this.txtboEmail.Name = "txtboEmail";
            this.txtboEmail.Size = new System.Drawing.Size(156, 26);
            this.txtboEmail.TabIndex = 15;
            // 
            // btnRetour
            // 
            this.btnRetour.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnRetour.BtnText = "Retour";
            this.btnRetour.FgColor = System.Drawing.Color.White;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnRetour.Location = new System.Drawing.Point(137, 943);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnRetour.Size = new System.Drawing.Size(357, 57);
            this.btnRetour.TabIndex = 17;
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
            this.userInfo1.TabIndex = 16;
            this.userInfo1.User = "";
            this.userInfo1.Click += new System.EventHandler(this.userInfo1_Click);
            this.userInfo1.Load += new System.EventHandler(this.userInfo1_Load);
            // 
            // btnMenu
            // 
            this.btnMenu.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnMenu.BtnText = "Menu";
            this.btnMenu.FgColor = System.Drawing.Color.White;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnMenu.Location = new System.Drawing.Point(137, 854);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnMenu.Size = new System.Drawing.Size(357, 57);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnValider
            // 
            this.btnValider.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnValider.BtnText = "Valider";
            this.btnValider.FgColor = System.Drawing.Color.White;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnValider.Location = new System.Drawing.Point(1467, 943);
            this.btnValider.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnValider.Name = "btnValider";
            this.btnValider.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnValider.Size = new System.Drawing.Size(357, 57);
            this.btnValider.TabIndex = 5;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            this.btnValider.Load += new System.EventHandler(this.btnTerminer_Load);
            // 
            // pnlAvance
            // 
            this.pnlAvance.BackColor = System.Drawing.Color.Transparent;
            this.pnlAvance.Controls.Add(this.label5);
            this.pnlAvance.Controls.Add(this.label4);
            this.pnlAvance.Controls.Add(this.cboCodeCours);
            this.pnlAvance.Controls.Add(this.cboCodeLecon);
            this.pnlAvance.Controls.Add(this.cboCodeExo);
            this.pnlAvance.Controls.Add(this.label3);
            this.pnlAvance.Controls.Add(this.label2);
            this.pnlAvance.Controls.Add(this.label1);
            this.pnlAvance.Location = new System.Drawing.Point(1176, 469);
            this.pnlAvance.Name = "pnlAvance";
            this.pnlAvance.Size = new System.Drawing.Size(380, 226);
            this.pnlAvance.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = " l\'exercice pour l\'utilisateur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(348, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Le mode Avancé permet de regler manuellement";
            // 
            // cboCodeCours
            // 
            this.cboCodeCours.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cboCodeCours.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cboCodeCours.BackColor = System.Drawing.Color.Black;
            this.cboCodeCours.BGColor = System.Drawing.Color.White;
            this.cboCodeCours.BorderColor = System.Drawing.Color.Black;
            this.cboCodeCours.BordeSize = 1;
            this.cboCodeCours.DataSource = null;
            this.cboCodeCours.DisplayMember = "";
            this.cboCodeCours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboCodeCours.ForeColor = System.Drawing.Color.DimGray;
            this.cboCodeCours.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.cboCodeCours.ListBGColor = System.Drawing.Color.WhiteSmoke;
            this.cboCodeCours.ListFGColor = System.Drawing.Color.Black;
            this.cboCodeCours.Location = new System.Drawing.Point(107, 16);
            this.cboCodeCours.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboCodeCours.Name = "cboCodeCours";
            this.cboCodeCours.Padding = new System.Windows.Forms.Padding(1);
            this.cboCodeCours.SelectedIndex = -1;
            this.cboCodeCours.SelectedItem = null;
            this.cboCodeCours.SelectedValue = null;
            this.cboCodeCours.Size = new System.Drawing.Size(200, 30);
            this.cboCodeCours.TabIndex = 19;
            this.cboCodeCours.ValueMember = "";
            this.cboCodeCours.SelectionChangeCommitted += new System.EventHandler(this.cboCodeCours_SelectionChangeCommitted);
            // 
            // cboCodeLecon
            // 
            this.cboCodeLecon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cboCodeLecon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cboCodeLecon.BackColor = System.Drawing.Color.Black;
            this.cboCodeLecon.BGColor = System.Drawing.Color.White;
            this.cboCodeLecon.BorderColor = System.Drawing.Color.Black;
            this.cboCodeLecon.BordeSize = 1;
            this.cboCodeLecon.DataSource = null;
            this.cboCodeLecon.DisplayMember = "";
            this.cboCodeLecon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboCodeLecon.ForeColor = System.Drawing.Color.DimGray;
            this.cboCodeLecon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.cboCodeLecon.ListBGColor = System.Drawing.Color.WhiteSmoke;
            this.cboCodeLecon.ListFGColor = System.Drawing.Color.Black;
            this.cboCodeLecon.Location = new System.Drawing.Point(107, 71);
            this.cboCodeLecon.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboCodeLecon.Name = "cboCodeLecon";
            this.cboCodeLecon.Padding = new System.Windows.Forms.Padding(1);
            this.cboCodeLecon.SelectedIndex = -1;
            this.cboCodeLecon.SelectedItem = null;
            this.cboCodeLecon.SelectedValue = null;
            this.cboCodeLecon.Size = new System.Drawing.Size(200, 30);
            this.cboCodeLecon.TabIndex = 20;
            this.cboCodeLecon.ValueMember = "";
            this.cboCodeLecon.SelectionChangeCommitted += new System.EventHandler(this.cboCodeLecon_SelectionChangeCommitted_1);
            // 
            // cboCodeExo
            // 
            this.cboCodeExo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cboCodeExo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cboCodeExo.BackColor = System.Drawing.Color.Black;
            this.cboCodeExo.BGColor = System.Drawing.Color.White;
            this.cboCodeExo.BorderColor = System.Drawing.Color.Black;
            this.cboCodeExo.BordeSize = 1;
            this.cboCodeExo.DataSource = null;
            this.cboCodeExo.DisplayMember = "";
            this.cboCodeExo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboCodeExo.ForeColor = System.Drawing.Color.DimGray;
            this.cboCodeExo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.cboCodeExo.ListBGColor = System.Drawing.Color.WhiteSmoke;
            this.cboCodeExo.ListFGColor = System.Drawing.Color.Red;
            this.cboCodeExo.Location = new System.Drawing.Point(107, 121);
            this.cboCodeExo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboCodeExo.Name = "cboCodeExo";
            this.cboCodeExo.Padding = new System.Windows.Forms.Padding(1);
            this.cboCodeExo.SelectedIndex = -1;
            this.cboCodeExo.SelectedItem = null;
            this.cboCodeExo.SelectedValue = null;
            this.cboCodeExo.Size = new System.Drawing.Size(200, 30);
            this.cboCodeExo.TabIndex = 21;
            this.cboCodeExo.ValueMember = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exercice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Leçon";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cours";
            // 
            // rdbAvance
            // 
            this.rdbAvance.AutoSize = true;
            this.rdbAvance.BackColor = System.Drawing.Color.Transparent;
            this.rdbAvance.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAvance.Location = new System.Drawing.Point(1283, 436);
            this.rdbAvance.Name = "rdbAvance";
            this.rdbAvance.Size = new System.Drawing.Size(144, 27);
            this.rdbAvance.TabIndex = 19;
            this.rdbAvance.Text = "Mode Avancé";
            this.rdbAvance.UseVisualStyleBackColor = false;
            this.rdbAvance.CheckStateChanged += new System.EventHandler(this.rdbAvance_CheckStateChanged);
            // 
            // AdministrationAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.rdbAvance);
            this.Controls.Add(this.pnlAvance);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.userInfo1);
            this.Controls.Add(this.txtboEmail);
            this.Controls.Add(this.txtboPrenom);
            this.Controls.Add(this.txtboNom);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnValider);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdministrationAjouter";
            this.Text = "AdministrationAjouter";
            this.Load += new System.EventHandler(this.AdministrationAjouter_Load);
            this.Click += new System.EventHandler(this.AdministrationAjouter_Click);
            this.Controls.SetChildIndex(this.btnValider, 0);
            this.Controls.SetChildIndex(this.btnMenu, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.lblNom, 0);
            this.Controls.SetChildIndex(this.lblPrenom, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.txtboNom, 0);
            this.Controls.SetChildIndex(this.txtboPrenom, 0);
            this.Controls.SetChildIndex(this.txtboEmail, 0);
            this.Controls.SetChildIndex(this.userInfo1, 0);
            this.Controls.SetChildIndex(this.btnRetour, 0);
            this.Controls.SetChildIndex(this.pnlAvance, 0);
            this.Controls.SetChildIndex(this.rdbAvance, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlAvance.ResumeLayout(false);
            this.pnlAvance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControls.ButtonCustom btnValider;
        private UserControls.ButtonCustom btnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtboNom;
        private System.Windows.Forms.TextBox txtboPrenom;
        private System.Windows.Forms.TextBox txtboEmail;
        private UserControls.UserInfo userInfo1;
        private UserControls.ButtonCustom btnRetour;
        private System.Windows.Forms.Panel pnlAvance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UserControls.ComboBoxCustom cboCodeCours;
        private UserControls.ComboBoxCustom cboCodeLecon;
        private UserControls.ComboBoxCustom cboCodeExo;
        private System.Windows.Forms.CheckBox rdbAvance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}