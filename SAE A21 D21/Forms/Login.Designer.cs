
using SAE_A21_D21.UserControls;

namespace SAE_A21_D21
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCustom1 = new SAE_A21_D21.UserControls.ButtonCustom();
            this.cboUtilisateurs = new SAE_A21_D21.UserControls.ComboBoxCustom();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::SAE_A21_D21.Properties.Resources.person_outline_1;
            this.pictureBox1.Location = new System.Drawing.Point(415, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonCustom1
            // 
            this.buttonCustom1.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.buttonCustom1.BtnText = "Connexion";
            this.buttonCustom1.FgColor = System.Drawing.Color.White;
            this.buttonCustom1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustom1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.buttonCustom1.Location = new System.Drawing.Point(382, 382);
            this.buttonCustom1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCustom1.Name = "buttonCustom1";
            this.buttonCustom1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.buttonCustom1.Size = new System.Drawing.Size(170, 47);
            this.buttonCustom1.TabIndex = 6;
            this.buttonCustom1.Click += new System.EventHandler(this.buttonCustom1_Click);
            // 
            // cboUtilisateurs
            // 
            this.cboUtilisateurs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cboUtilisateurs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cboUtilisateurs.BackColor = System.Drawing.Color.Black;
            this.cboUtilisateurs.BGColor = System.Drawing.Color.White;
            this.cboUtilisateurs.BorderColor = System.Drawing.Color.Black;
            this.cboUtilisateurs.BordeSize = 0;
            this.cboUtilisateurs.DataSource = null;
            this.cboUtilisateurs.DisplayMember = "";
            this.cboUtilisateurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUtilisateurs.ForeColor = System.Drawing.Color.DimGray;
            this.cboUtilisateurs.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.cboUtilisateurs.ListBGColor = System.Drawing.Color.WhiteSmoke;
            this.cboUtilisateurs.ListFGColor = System.Drawing.Color.Black;
            this.cboUtilisateurs.Location = new System.Drawing.Point(368, 306);
            this.cboUtilisateurs.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboUtilisateurs.Name = "cboUtilisateurs";
            this.cboUtilisateurs.SelectedIndex = -1;
            this.cboUtilisateurs.SelectedItem = null;
            this.cboUtilisateurs.SelectedValue = null;
            this.cboUtilisateurs.Size = new System.Drawing.Size(200, 30);
            this.cboUtilisateurs.TabIndex = 5;
            this.cboUtilisateurs.ValueMember = "";
            this.cboUtilisateurs.SelectedValueChanged += new System.EventHandler(this.cboUtilisateurs_SelectedValueChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAE_A21_D21.Properties.Resources.Connexion;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.buttonCustom1);
            this.Controls.Add(this.cboUtilisateurs);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.cboUtilisateurs, 0);
            this.Controls.SetChildIndex(this.buttonCustom1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComboBoxCustom cboUtilisateurs;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ButtonCustom buttonCustom1;
    }
}