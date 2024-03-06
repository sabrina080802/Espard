
namespace SAE_A21_D21
{
    partial class ConfirmerQuitter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmerQuitter));
            this.btnOui = new SAE_A21_D21.UserControls.ButtonCustom();
            this.btnNon = new SAE_A21_D21.UserControls.ButtonCustom();
            this.SuspendLayout();
            // 
            // btnOui
            // 
            this.btnOui.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnOui.BtnText = "Oui";
            this.btnOui.FgColor = System.Drawing.Color.White;
            this.btnOui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOui.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnOui.Location = new System.Drawing.Point(494, 390);
            this.btnOui.Name = "btnOui";
            this.btnOui.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnOui.Size = new System.Drawing.Size(159, 38);
            this.btnOui.TabIndex = 6;
            this.btnOui.Click += new System.EventHandler(this.btnOui_Click);
            // 
            // btnNon
            // 
            this.btnNon.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnNon.BtnText = "Non";
            this.btnNon.FgColor = System.Drawing.Color.White;
            this.btnNon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNon.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnNon.Location = new System.Drawing.Point(279, 390);
            this.btnNon.Name = "btnNon";
            this.btnNon.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnNon.Size = new System.Drawing.Size(159, 38);
            this.btnNon.TabIndex = 7;
            this.btnNon.Click += new System.EventHandler(this.btnNon_Click);
            // 
            // ConfirmerQuitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(892, 526);
            this.Controls.Add(this.btnNon);
            this.Controls.Add(this.btnOui);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConfirmerQuitter";
            this.Text = "ConfirmerQuitter";
            this.Load += new System.EventHandler(this.ConfirmerQuitter_Load);
            this.Controls.SetChildIndex(this.btnOui, 0);
            this.Controls.SetChildIndex(this.btnNon, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ButtonCustom btnOui;
        private UserControls.ButtonCustom btnNon;
    }
}