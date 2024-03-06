namespace SAE_A21_D21.UserControls
{
    partial class ExerciceDesordre
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
            this.flpAnswers = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpExo
            // 
            this.flpExo.AutoScroll = true;
            this.flpExo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(227)))));
            this.flpExo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpExo.Location = new System.Drawing.Point(0, 0);
            this.flpExo.Name = "flpExo";
            this.flpExo.Padding = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.flpExo.Size = new System.Drawing.Size(964, 529);
            this.flpExo.TabIndex = 0;
            this.flpExo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            // 
            // flpAnswers
            // 
            this.flpAnswers.AutoScroll = true;
            this.flpAnswers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpAnswers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(227)))));
            this.flpAnswers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpAnswers.Location = new System.Drawing.Point(0, 529);
            this.flpAnswers.Name = "flpAnswers";
            this.flpAnswers.Size = new System.Drawing.Size(964, 79);
            this.flpAnswers.TabIndex = 1;
            this.flpAnswers.WrapContents = false;
            this.flpAnswers.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            // 
            // ExerciceDesordre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.flpExo);
            this.Controls.Add(this.flpAnswers);
            this.Name = "ExerciceDesordre";
            this.Size = new System.Drawing.Size(964, 608);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpExo;
        private System.Windows.Forms.FlowLayoutPanel flpAnswers;
    }
}
