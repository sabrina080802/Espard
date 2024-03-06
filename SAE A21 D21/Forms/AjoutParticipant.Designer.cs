namespace SAE_A21_D21.Forms
{
    partial class AjoutParticipant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutParticipant));
            this.btnValider = new SAE_A21_D21.UserControls.ButtonCustom();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.btnValider.BtnText = "OK";
            this.btnValider.FgColor = System.Drawing.Color.White;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.btnValider.Location = new System.Drawing.Point(306, 333);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4);
            this.btnValider.Name = "btnValider";
            this.btnValider.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btnValider.Size = new System.Drawing.Size(159, 37);
            this.btnValider.TabIndex = 0;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            this.btnValider.Load += new System.EventHandler(this.btnValider_Load);
            this.btnValider.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.btnValider_ChangeUICues);
            // 
            // AjoutParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BtnVisible = false;
            this.ClientSize = new System.Drawing.Size(751, 430);
            this.Controls.Add(this.btnValider);
            this.Name = "AjoutParticipant";
            this.Text = "AjoutParticipant";
            this.Controls.SetChildIndex(this.btnValider, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ButtonCustom btnValider;
    }
}