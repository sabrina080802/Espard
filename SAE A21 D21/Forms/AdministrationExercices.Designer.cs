
namespace SAE_A21_D21
{
    partial class AdministrationExercices
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrationExercices));
            this.btnRetour = new SAE_A21_D21.UserControls.ButtonCustom();
            this.cboCodeCours = new SAE_A21_D21.UserControls.ComboBoxCustom();
            this.cboCodeLecon = new SAE_A21_D21.UserControls.ComboBoxCustom();
            this.buttonCustom1 = new SAE_A21_D21.UserControls.ButtonCustom();
            this.buttonCustom2 = new SAE_A21_D21.UserControls.ButtonCustom();
            this.buttonCustom3 = new SAE_A21_D21.UserControls.ButtonCustom();
            this.buttonCustom4 = new SAE_A21_D21.UserControls.ButtonCustom();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpExercice = new System.Windows.Forms.GroupBox();
            this.lblMiniTitre = new System.Windows.Forms.Label();
            this.lblTemps = new System.Windows.Forms.Label();
            this.lblVerbeTrad = new System.Windows.Forms.Label();
            this.lblVerbe = new System.Windows.Forms.Label();
            this.lblListeMots = new System.Windows.Forms.Label();
            this.lblCompleteON = new System.Windows.Forms.Label();
            this.lblPhraseTrad = new System.Windows.Forms.Label();
            this.lblPhrase = new System.Windows.Forms.Label();
            this.lblRegle = new System.Windows.Forms.Label();
            this.lblEnonce = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumExo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userInfo1 = new SAE_A21_D21.UserControls.UserInfo();
            this.btnMenu = new SAE_A21_D21.UserControls.ButtonCustom();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.grpExercice.SuspendLayout();
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
            this.btnRetour.Location = new System.Drawing.Point(1492, 943);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnRetour.Size = new System.Drawing.Size(357, 57);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
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
            this.cboCodeCours.IconColor = System.Drawing.Color.Brown;
            this.cboCodeCours.ListBGColor = System.Drawing.Color.WhiteSmoke;
            this.cboCodeCours.ListFGColor = System.Drawing.Color.Black;
            this.cboCodeCours.Location = new System.Drawing.Point(910, 210);
            this.cboCodeCours.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboCodeCours.Name = "cboCodeCours";
            this.cboCodeCours.Padding = new System.Windows.Forms.Padding(1);
            this.cboCodeCours.SelectedIndex = -1;
            this.cboCodeCours.SelectedItem = null;
            this.cboCodeCours.SelectedValue = null;
            this.cboCodeCours.Size = new System.Drawing.Size(200, 30);
            this.cboCodeCours.TabIndex = 4;
            this.cboCodeCours.ValueMember = "";
            this.cboCodeCours.SelectedValueChanged += new System.EventHandler(this.cboCodeCours_SelectedValueChanged_1);
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
            this.cboCodeLecon.Location = new System.Drawing.Point(1492, 210);
            this.cboCodeLecon.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboCodeLecon.Name = "cboCodeLecon";
            this.cboCodeLecon.Padding = new System.Windows.Forms.Padding(1);
            this.cboCodeLecon.SelectedIndex = -1;
            this.cboCodeLecon.SelectedItem = null;
            this.cboCodeLecon.SelectedValue = null;
            this.cboCodeLecon.Size = new System.Drawing.Size(200, 30);
            this.cboCodeLecon.TabIndex = 5;
            this.cboCodeLecon.ValueMember = "";
            this.cboCodeLecon.SelectedValueChanged += new System.EventHandler(this.cboCodeLecon_SelectedValueChanged_1);
            // 
            // buttonCustom1
            // 
            this.buttonCustom1.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.buttonCustom1.BtnText = "<<";
            this.buttonCustom1.FgColor = System.Drawing.Color.White;
            this.buttonCustom1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustom1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.buttonCustom1.Location = new System.Drawing.Point(857, 288);
            this.buttonCustom1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonCustom1.Name = "buttonCustom1";
            this.buttonCustom1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.buttonCustom1.Size = new System.Drawing.Size(44, 44);
            this.buttonCustom1.TabIndex = 6;
            this.buttonCustom1.Click += new System.EventHandler(this.buttonCustom1_Click);
            // 
            // buttonCustom2
            // 
            this.buttonCustom2.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.buttonCustom2.BtnText = "<";
            this.buttonCustom2.FgColor = System.Drawing.Color.White;
            this.buttonCustom2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustom2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.buttonCustom2.Location = new System.Drawing.Point(938, 288);
            this.buttonCustom2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonCustom2.Name = "buttonCustom2";
            this.buttonCustom2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.buttonCustom2.Size = new System.Drawing.Size(44, 44);
            this.buttonCustom2.TabIndex = 7;
            this.buttonCustom2.Click += new System.EventHandler(this.buttonCustom2_Click);
            // 
            // buttonCustom3
            // 
            this.buttonCustom3.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.buttonCustom3.BtnText = ">";
            this.buttonCustom3.FgColor = System.Drawing.Color.White;
            this.buttonCustom3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustom3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.buttonCustom3.Location = new System.Drawing.Point(1678, 288);
            this.buttonCustom3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonCustom3.Name = "buttonCustom3";
            this.buttonCustom3.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.buttonCustom3.Size = new System.Drawing.Size(44, 44);
            this.buttonCustom3.TabIndex = 8;
            this.buttonCustom3.Click += new System.EventHandler(this.buttonCustom3_Click);
            // 
            // buttonCustom4
            // 
            this.buttonCustom4.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.buttonCustom4.BtnText = ">>";
            this.buttonCustom4.FgColor = System.Drawing.Color.White;
            this.buttonCustom4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustom4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.buttonCustom4.Location = new System.Drawing.Point(1755, 288);
            this.buttonCustom4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonCustom4.Name = "buttonCustom4";
            this.buttonCustom4.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.buttonCustom4.Size = new System.Drawing.Size(44, 44);
            this.buttonCustom4.TabIndex = 9;
            this.buttonCustom4.Click += new System.EventHandler(this.buttonCustom4_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // grpExercice
            // 
            this.grpExercice.Controls.Add(this.lblMiniTitre);
            this.grpExercice.Controls.Add(this.lblTemps);
            this.grpExercice.Controls.Add(this.lblVerbeTrad);
            this.grpExercice.Controls.Add(this.lblVerbe);
            this.grpExercice.Controls.Add(this.lblListeMots);
            this.grpExercice.Controls.Add(this.lblCompleteON);
            this.grpExercice.Controls.Add(this.lblPhraseTrad);
            this.grpExercice.Controls.Add(this.lblPhrase);
            this.grpExercice.Controls.Add(this.lblRegle);
            this.grpExercice.Controls.Add(this.lblEnonce);
            this.grpExercice.Controls.Add(this.label3);
            this.grpExercice.Controls.Add(this.lblNumExo);
            this.grpExercice.Location = new System.Drawing.Point(857, 369);
            this.grpExercice.Name = "grpExercice";
            this.grpExercice.Size = new System.Drawing.Size(942, 440);
            this.grpExercice.TabIndex = 10;
            this.grpExercice.TabStop = false;
            // 
            // lblMiniTitre
            // 
            this.lblMiniTitre.AutoSize = true;
            this.lblMiniTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblMiniTitre.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiniTitre.Location = new System.Drawing.Point(35, 105);
            this.lblMiniTitre.Name = "lblMiniTitre";
            this.lblMiniTitre.Size = new System.Drawing.Size(187, 21);
            this.lblMiniTitre.TabIndex = 19;
            this.lblMiniTitre.Text = "Phrase dans le désordre : ";
            // 
            // lblTemps
            // 
            this.lblTemps.AutoSize = true;
            this.lblTemps.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemps.Location = new System.Drawing.Point(424, 296);
            this.lblTemps.Name = "lblTemps";
            this.lblTemps.Size = new System.Drawing.Size(65, 23);
            this.lblTemps.TabIndex = 17;
            this.lblTemps.Text = "Temps";
            // 
            // lblVerbeTrad
            // 
            this.lblVerbeTrad.AutoSize = true;
            this.lblVerbeTrad.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerbeTrad.Location = new System.Drawing.Point(424, 214);
            this.lblVerbeTrad.Name = "lblVerbeTrad";
            this.lblVerbeTrad.Size = new System.Drawing.Size(153, 23);
            this.lblVerbeTrad.TabIndex = 15;
            this.lblVerbeTrad.Text = "Traduction verbe";
            // 
            // lblVerbe
            // 
            this.lblVerbe.AutoSize = true;
            this.lblVerbe.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerbe.Location = new System.Drawing.Point(424, 137);
            this.lblVerbe.Name = "lblVerbe";
            this.lblVerbe.Size = new System.Drawing.Size(60, 23);
            this.lblVerbe.TabIndex = 14;
            this.lblVerbe.Text = "Verbe";
            // 
            // lblListeMots
            // 
            this.lblListeMots.BackColor = System.Drawing.Color.Transparent;
            this.lblListeMots.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeMots.Location = new System.Drawing.Point(61, 137);
            this.lblListeMots.Name = "lblListeMots";
            this.lblListeMots.Size = new System.Drawing.Size(120, 23);
            this.lblListeMots.TabIndex = 13;
            this.lblListeMots.Text = "Liste mots";
            // 
            // lblCompleteON
            // 
            this.lblCompleteON.AutoSize = true;
            this.lblCompleteON.BackColor = System.Drawing.Color.Transparent;
            this.lblCompleteON.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleteON.Location = new System.Drawing.Point(62, 135);
            this.lblCompleteON.Name = "lblCompleteON";
            this.lblCompleteON.Size = new System.Drawing.Size(119, 23);
            this.lblCompleteON.TabIndex = 12;
            this.lblCompleteON.Text = "CompleteON";
            // 
            // lblPhraseTrad
            // 
            this.lblPhraseTrad.AutoSize = true;
            this.lblPhraseTrad.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhraseTrad.Location = new System.Drawing.Point(62, 296);
            this.lblPhraseTrad.Name = "lblPhraseTrad";
            this.lblPhraseTrad.Size = new System.Drawing.Size(163, 23);
            this.lblPhraseTrad.TabIndex = 11;
            this.lblPhraseTrad.Text = "Traduction phrase";
            // 
            // lblPhrase
            // 
            this.lblPhrase.AutoSize = true;
            this.lblPhrase.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhrase.Location = new System.Drawing.Point(62, 214);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.Size = new System.Drawing.Size(67, 23);
            this.lblPhrase.TabIndex = 10;
            this.lblPhrase.Text = "Phrase";
            // 
            // lblRegle
            // 
            this.lblRegle.AutoSize = true;
            this.lblRegle.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegle.Location = new System.Drawing.Point(62, 376);
            this.lblRegle.Name = "lblRegle";
            this.lblRegle.Size = new System.Drawing.Size(57, 23);
            this.lblRegle.TabIndex = 9;
            this.lblRegle.Text = "Règle";
            // 
            // lblEnonce
            // 
            this.lblEnonce.AutoSize = true;
            this.lblEnonce.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnonce.Location = new System.Drawing.Point(137, 61);
            this.lblEnonce.Name = "lblEnonce";
            this.lblEnonce.Size = new System.Drawing.Size(72, 23);
            this.lblEnonce.TabIndex = 2;
            this.lblEnonce.Text = "Enonce";
            this.lblEnonce.Click += new System.EventHandler(this.lblEnonce_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enoncé : ";
            // 
            // lblNumExo
            // 
            this.lblNumExo.AutoSize = true;
            this.lblNumExo.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumExo.Location = new System.Drawing.Point(385, 17);
            this.lblNumExo.Name = "lblNumExo";
            this.lblNumExo.Size = new System.Drawing.Size(178, 27);
            this.lblNumExo.TabIndex = 0;
            this.lblNumExo.Text = "Numéro exercice";
            this.lblNumExo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1074, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 54);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
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
            // btnMenu
            // 
            this.btnMenu.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnMenu.BtnText = "Menu";
            this.btnMenu.FgColor = System.Drawing.Color.White;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnMenu.Location = new System.Drawing.Point(137, 943);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnMenu.Size = new System.Drawing.Size(357, 57);
            this.btnMenu.TabIndex = 13;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // AdministrationExercices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.userInfo1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpExercice);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.buttonCustom4);
            this.Controls.Add(this.buttonCustom3);
            this.Controls.Add(this.buttonCustom2);
            this.Controls.Add(this.buttonCustom1);
            this.Controls.Add(this.cboCodeLecon);
            this.Controls.Add(this.cboCodeCours);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdministrationExercices";
            this.Text = "AdministrationExercices";
            this.Load += new System.EventHandler(this.AdministrationExercices_Load);
            this.Controls.SetChildIndex(this.cboCodeCours, 0);
            this.Controls.SetChildIndex(this.cboCodeLecon, 0);
            this.Controls.SetChildIndex(this.buttonCustom1, 0);
            this.Controls.SetChildIndex(this.buttonCustom2, 0);
            this.Controls.SetChildIndex(this.buttonCustom3, 0);
            this.Controls.SetChildIndex(this.buttonCustom4, 0);
            this.Controls.SetChildIndex(this.btnRetour, 0);
            this.Controls.SetChildIndex(this.grpExercice, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.userInfo1, 0);
            this.Controls.SetChildIndex(this.btnMenu, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.grpExercice.ResumeLayout(false);
            this.grpExercice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ButtonCustom btnRetour;
        private UserControls.ComboBoxCustom cboCodeCours;
        private UserControls.ComboBoxCustom cboCodeLecon;
        private UserControls.ButtonCustom buttonCustom1;
        private UserControls.ButtonCustom buttonCustom2;
        private UserControls.ButtonCustom buttonCustom3;
        private UserControls.ButtonCustom buttonCustom4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpExercice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumExo;
        private System.Windows.Forms.Label lblEnonce;
        private System.Windows.Forms.Label lblRegle;
        private System.Windows.Forms.Label lblTemps;
        private System.Windows.Forms.Label lblVerbeTrad;
        private System.Windows.Forms.Label lblVerbe;
        private System.Windows.Forms.Label lblListeMots;
        private System.Windows.Forms.Label lblCompleteON;
        private System.Windows.Forms.Label lblPhraseTrad;
        private System.Windows.Forms.Label lblPhrase;
        private System.Windows.Forms.Label lblMiniTitre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.UserInfo userInfo1;
        private UserControls.ButtonCustom btnMenu;
    }
}
    