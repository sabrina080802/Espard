namespace SAE_A21_D21.UserControls
{
    partial class ExerciceVoc
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpVoc = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpVoc
            // 
            this.flpVoc.AutoScroll = true;
            this.flpVoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(227)))));
            this.flpVoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpVoc.Location = new System.Drawing.Point(0, 0);
            this.flpVoc.Name = "flpVoc";
            this.flpVoc.Size = new System.Drawing.Size(991, 618);
            this.flpVoc.TabIndex = 0;
            this.flpVoc.Paint += new System.Windows.Forms.PaintEventHandler(this.flpVoc_Paint);
            // 
            // ExerciceVoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.flpVoc);
            this.Name = "ExerciceVoc";
            this.Size = new System.Drawing.Size(991, 618);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpVoc;
    }
}
