using SAE_A21_D21.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_A21_D21.UserControls
{
    public partial class ProgressionEleve : UserControl
    {
        private Main main;
        string id;
        public ProgressionEleve(Main main)
        {
            this.main = main;
            InitializeComponent();
        }

        public string Username
        {
            get => username.Text;
            set
            {
                username.Text = value;
            }
        }

        public string Id
        {
            get => id;
            set
            {
                id = value;
            }
        }

        private void InitializeComponent()
        {
            this.btnProfile = new SAE_A21_D21.UserControls.ButtonCustom();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfile.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnProfile.BtnText = "Voir profil";
            this.btnProfile.FgColor = System.Drawing.Color.White;
            this.btnProfile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnProfile.Location = new System.Drawing.Point(8, 30);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnProfile.Size = new System.Drawing.Size(148, 50);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SAE_A21_D21.Properties.Resources.person_outline_2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 112);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // username
            // 
            this.username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.username.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.ControlText;
            this.username.Location = new System.Drawing.Point(112, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(316, 112);
            this.username.TabIndex = 2;
            this.username.Text = "label1";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(428, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 112);
            this.panel1.TabIndex = 3;
            // 
            // ProgressionEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.username);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ProgressionEleve";
            this.Size = new System.Drawing.Size(584, 112);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new Eleve(main, id).ShowDialog();
        }
    }
}
