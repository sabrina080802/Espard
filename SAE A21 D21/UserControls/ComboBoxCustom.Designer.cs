namespace SAE_A21_D21.UserControls
{
    partial class ComboBoxCustom
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
            this.list = new System.Windows.Forms.ComboBox();
            this.text = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(58, 3);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(121, 21);
            this.list.TabIndex = 0;
            this.list.TextChanged += new System.EventHandler(this.list_TextChanged);
            // 
            // text
            // 
            this.text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text.Location = new System.Drawing.Point(0, 0);
            this.text.Name = "text";
            this.text.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.text.Size = new System.Drawing.Size(200, 30);
            this.text.TabIndex = 1;
            this.text.Text = "label1";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.text.Click += new System.EventHandler(this.text_Click);
            this.text.MouseEnter += new System.EventHandler(this.text_MouseEnter);
            this.text.MouseLeave += new System.EventHandler(this.text_MouseLeave);
            // 
            // icon
            // 
            this.icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon.Dock = System.Windows.Forms.DockStyle.Right;
            this.icon.FlatAppearance.BorderSize = 0;
            this.icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icon.Location = new System.Drawing.Point(170, 0);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(30, 30);
            this.icon.TabIndex = 2;
            this.icon.UseVisualStyleBackColor = true;
            this.icon.Click += new System.EventHandler(this.icon_Click);
            this.icon.Paint += new System.Windows.Forms.PaintEventHandler(this.icon_Paint);
            // 
            // ComboBoxCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.icon);
            this.Controls.Add(this.text);
            this.Controls.Add(this.list);
            this.MinimumSize = new System.Drawing.Size(200, 30);
            this.Name = "ComboBoxCustom";
            this.Size = new System.Drawing.Size(200, 30);
            this.Resize += new System.EventHandler(this.ComboBoxCustom_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox list;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button icon;
    }
}
