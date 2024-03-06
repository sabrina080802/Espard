using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_A21_D21.UserControls
{
    [DefaultEvent("OnSelectedIndexChanged")]
    internal class ComboBoxAccueil : UserControl
    {
        private Color bgColor = Color.White;
        private Color iconColor = Color.Blue;
        private Color listBGColor = Color.WhiteSmoke;
        private Color listFGColor = Color.Red;
        private Color borderColor = Color.Black;
        private int borderSize = 1;

        private ComboBox list;
        private Label text;
        private Button icon;

        public event EventHandler SelectedValueChanged;

        public ComboBoxAccueil()
        {
            list = new ComboBox();
            text = new Label();
            icon = new Button();
            this.SuspendLayout();

            list.BackColor = bgColor;
            list.Font = new Font(this.Font.Name, 10F);
            list.ForeColor = listFGColor;
            list.TextChanged += new EventHandler(ComboBox_TextChanged);
            list.SelectedValueChanged += new EventHandler(ComboBox_SelectedValueChanged);

            icon.Dock = DockStyle.Right;
            icon.FlatStyle = FlatStyle.Flat;
            icon.FlatAppearance.BorderSize = 0;
            icon.BackColor = bgColor;
            icon.Size = new Size(30, 30);
            icon.Cursor = Cursors.Hand;
            icon.Click += new EventHandler(Icon_Click);
            icon.Paint += new PaintEventHandler(Icon_Paint);

            text.Dock = DockStyle.Fill;
            text.AutoSize = false;
            text.BackColor = bgColor;
            text.TextAlign = ContentAlignment.MiddleLeft;
            text.Padding = new Padding(8, 0, 0, 0);
            text.Font = new Font(this.Font.Name, 10F);
            text.Click += new EventHandler(Surface_Click);

            this.Controls.Add(text);
            this.Controls.Add(icon);
            this.Controls.Add(list);
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);
            base.BackColor = bgColor;
            this.ResumeLayout();
            AdjustComboBoxSize();
        }

        public new Color BGColor
        {
            get => bgColor;
            set
            {
                bgColor = value;
                text.BackColor = bgColor;
                icon.BackColor = bgColor;
            }
        }

        public Color IconColor
        {
            get => iconColor;
            set
            {
                iconColor = value;
                icon.Invalidate();
            }
        }

        public Color ListBGColor
        {
            get => listBGColor;
            set
            {
                listBGColor = value;
                list.BackColor = listBGColor;
            }
        }

        public Color ListFGColor
        {
            get => listFGColor;
            set
            {
                listFGColor = value;
                list.ForeColor = listFGColor;
            }
        }

        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                base.BackColor = borderColor;
            }
        }

        public int BordeSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);
                AdjustComboBoxSize();
            }
        }

        public override Color ForeColor 
        {
            get => base.ForeColor;
            set {
                base.ForeColor = value;
                text.ForeColor = value;
                    }
        }

        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                text.Font = value;
                list.Font = value;
            }
        }

        public string Texts
        {
            get => text.Text;
            set
            {
                text.Text = value;
            }
        }

        public ComboBoxStyle DropDownStyle
        {
            get => list.DropDownStyle;
            set
            {
                if (list.DropDownStyle != ComboBoxStyle.Simple)
                    list.DropDownStyle = value;
            }
        }

        public ComboBox.ObjectCollection Items
        {
            get => list.Items;
        }

        public object DataSource
        {
            get => list.DataSource;
            set
            {
                list.DataSource = value;
            }
        }

        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get => list.AutoCompleteCustomSource;
            set
            {
                list.AutoCompleteCustomSource = value;
            }
        }

        public AutoCompleteSource AutoCompleteSource
        {
            get => list.AutoCompleteSource;
            set
            {
                list.AutoCompleteSource = value;
            }
        }

        public AutoCompleteMode AutoCompleteMode
        {
            get => list.AutoCompleteMode;
            set
            {
                list.AutoCompleteMode = value;
            }
        }

        public object SelectedItem
        {
            get => list.SelectedItem;
            set
            {
                list.SelectedItem = value;
            }
        }

        public int SelectedIndex
        {
            get => list.SelectedIndex;
            set
            {
                list.SelectedIndex = value;
            }
        }

        public string DisplayMember
        {
            get => list.DisplayMember;
            set
            {
                list.DisplayMember = value;
            }
        }

        public string ValueMember
        {
            get => list.ValueMember;
            set
            {
                list.ValueMember = value;
            }
        }

        public object SelectedValue
        {
            get => list.SelectedValue;
            set
            {
                list.SelectedValue = value;
            }
        }

        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxSize();
        }

        private void AdjustComboBoxSize()
        {
            list.Width = text.Width;
            list.Location = new Point()
            {
                X = this.Width - this.Padding.Right - list.Width,
                Y = text.Bottom - list.Height
            };
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            list.Select();
            if(list.DropDownStyle == ComboBoxStyle.DropDownList)
            {
                list.DroppedDown = true;
            }
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            int iconWidth = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((icon.Width - iconWidth) / 2, (icon.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graph = e.Graphics;

            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            list.Select();
            list.DroppedDown = true;
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            text.Text = list.Text;
        }

        private void ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(SelectedValueChanged != null)
            {
                SelectedValueChanged.Invoke(sender, e);
            }
            text.Text = list.Text;
        }
    }
}
