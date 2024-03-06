using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_A21_D21.UserControls
{
    public partial class CircleProgessBar : UserControl
    {
        private int barSize = 12;
        private float percentage = 10.5F;

        private Color barColor = Color.White;
        private Color barProgressColor = Color.Red;

        public CircleProgessBar()
        {
            InitializeComponent();
        }

        public int BarSize
        {
            get => barSize;
            set
            {
                barSize = value;
                if (barSize % 2 == 1) barSize++;
                Invalidate();
            }
        }

        public float Percentage
        {
            get => percentage;
            set
            {
                percentage = value;
                if (percentage < 0) percentage = 0;
                if (percentage > 100) percentage = 100;
                Invalidate();
                lblPercentage.Text = percentage + "%";
            }
        }

        public Color BarColor
        {
            get => barColor;
            set
            {
                barColor = value;
                Invalidate();
            }
        }

        public Color BarProgressColor
        {
            get => barProgressColor;
            set
            {
                barProgressColor = value;
                Invalidate();
            }
        }

        public bool PercentageVisible
        {
            get => lblPercentage.Visible;
            set
            {
                lblPercentage.Visible = value;
            }
        }

        public new Font Font
        {
            get => lblPercentage.Font;
            set
            {
                lblPercentage.Font = value;
            }
        }

        public new Color ForeColor
        {
            get => lblPercentage.ForeColor;
            set
            {
                lblPercentage.ForeColor = value;
            }
        }

        private void ProgessBarCustom_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
           
            using (Brush brush = new SolidBrush(BackColor))
            using (Pen pen = new Pen(barColor, barSize))
            {
                Rectangle inner = new Rectangle(barSize / 2, barSize / 2, this.Width - barSize, this.Height - barSize);
                
                g.SmoothingMode = SmoothingMode.AntiAlias;

                g.DrawEllipse(pen, inner);
                pen.Color = barProgressColor;

                g.DrawArc(pen, inner, -90, 360 * (percentage / 100));
            }
        }
    }
}
