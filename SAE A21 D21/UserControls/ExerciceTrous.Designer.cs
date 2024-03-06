namespace SAE_A21_D21.UserControls
{
    partial class ExerciceTrous
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
            this.flpExo = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpExo
            // 
            this.flpExo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpExo.Location = new System.Drawing.Point(0, 0);
            this.flpExo.Name = "flpExo";
            this.flpExo.Size = new System.Drawing.Size(866, 532);
            this.flpExo.TabIndex = 0;
            // 
            // ExerciceTrous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.flpExo);
            this.Name = "ExerciceTrous";
            this.Size = new System.Drawing.Size(866, 532);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpExo;
    }
}
