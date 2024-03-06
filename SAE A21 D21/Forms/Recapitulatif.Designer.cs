
namespace SAE_A21_D21
{
    partial class Recapitulatif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recapitulatif));
            this.btnEnregistrer = new SAE_A21_D21.UserControls.ButtonCustom();
            this.btnRetour = new SAE_A21_D21.UserControls.ButtonCustom();
            this.userInfo1 = new SAE_A21_D21.UserControls.UserInfo();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEchec = new System.Windows.Forms.Panel();
            this.pnlReussi = new System.Windows.Forms.Panel();
            this.btnSuivant = new SAE_A21_D21.UserControls.ButtonCustom();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnEnregistrer.BtnText = "Enregistrer en PDF";
            this.btnEnregistrer.FgColor = System.Drawing.Color.White;
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnEnregistrer.Location = new System.Drawing.Point(1216, 943);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnEnregistrer.Size = new System.Drawing.Size(289, 55);
            this.btnEnregistrer.TabIndex = 1;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            this.btnEnregistrer.Load += new System.EventHandler(this.btnEnregistrer_Load_1);
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
            this.btnRetour.TabIndex = 3;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            this.btnRetour.Load += new System.EventHandler(this.btnRetour_Load);
            // 
            // userInfo1
            // 
            this.userInfo1.BackColor = System.Drawing.Color.Transparent;
            this.userInfo1.Lesson = "Un cours tkt";
            this.userInfo1.Location = new System.Drawing.Point(97, 172);
            this.userInfo1.Name = "userInfo1";
            this.userInfo1.Size = new System.Drawing.Size(486, 241);
            this.userInfo1.TabIndex = 4;
            this.userInfo1.User = "";
            this.userInfo1.Click += new System.EventHandler(this.userInfo1_Click);
            this.userInfo1.Load += new System.EventHandler(this.userInfo1_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1157, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 67);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(928, 169);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.94336F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.05665F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(871, 690);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(865, 90);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::SAE_A21_D21.Properties.Resources.Vector_3;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(426, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(435, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(427, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.pnlEchec, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pnlReussi, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 99);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(865, 588);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // pnlEchec
            // 
            this.pnlEchec.AutoScroll = true;
            this.pnlEchec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEchec.Location = new System.Drawing.Point(4, 4);
            this.pnlEchec.Name = "pnlEchec";
            this.pnlEchec.Size = new System.Drawing.Size(425, 580);
            this.pnlEchec.TabIndex = 0;
            // 
            // pnlReussi
            // 
            this.pnlReussi.AutoScroll = true;
            this.pnlReussi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReussi.Location = new System.Drawing.Point(436, 4);
            this.pnlReussi.Name = "pnlReussi";
            this.pnlReussi.Size = new System.Drawing.Size(425, 580);
            this.pnlReussi.TabIndex = 1;
            // 
            // btnSuivant
            // 
            this.btnSuivant.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnSuivant.BtnText = "Suivant";
            this.btnSuivant.FgColor = System.Drawing.Color.White;
            this.btnSuivant.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnSuivant.Location = new System.Drawing.Point(1563, 945);
            this.btnSuivant.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnSuivant.Size = new System.Drawing.Size(289, 55);
            this.btnSuivant.TabIndex = 7;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // Recapitulatif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userInfo1);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnEnregistrer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Recapitulatif";
            this.Text = "Recapitulatif";
            this.Load += new System.EventHandler(this.Recapitulatif_Load);
            this.Controls.SetChildIndex(this.btnEnregistrer, 0);
            this.Controls.SetChildIndex(this.btnRetour, 0);
            this.Controls.SetChildIndex(this.userInfo1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.btnSuivant, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
//=======
        private UserControls.ButtonCustom btnEnregistrer;
        private UserControls.ButtonCustom btnRetour;
        private UserControls.UserInfo userInfo1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel pnlEchec;
        private System.Windows.Forms.Panel pnlReussi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private UserControls.ButtonCustom btnSuivant;
        //>>>>>>> master
    }
}