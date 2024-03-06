using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_A21_D21.UserControls
{
    public partial class PointedProgressBar : UserControl
    {
        private BindingList<PointedProgressBarState> states = new BindingList<PointedProgressBarState>();

        private Color barNoneColor = Color.White;
        private Color barFailColor = Color.Red;
        private Color barSuccessColor = Color.Green;
        private Color barCurrentColor = Color.Gray;

        public PointedProgressBar()
        {
            InitializeComponent();
            states.ListChanged += States_ListChanged;
        }

        private void States_ListChanged(object sender, ListChangedEventArgs e)
        {
            Invalidate();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BindingList<PointedProgressBarState> BarStates
        {
            get => states;
            set
            {
                states.Clear();
                if (value != null)
                {
                    foreach (PointedProgressBarState state in value)
                    {
                        states.Add(state);
                    }
                }

                Invalidate();
            }
        }

        public Color BarNoneColor
        {
            get => barNoneColor;
            set
            {
                barNoneColor = value;
                Invalidate();
            }
        }

        public Color BarFailColor
        {
            get => barFailColor;
            set
            {
                barFailColor = value;
                Invalidate();
            }
        }

        public Color BarSuccessColor
        {
            get => barSuccessColor;
            set
            {
                barSuccessColor = value;
                Invalidate();
            }
        }

        public Color BarCurrentColor
        {
            get => barCurrentColor;
            set
            {
                barCurrentColor = value;
                Invalidate();
            }
        }


        private void ProgessBarCustom_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Brush brushNone = new SolidBrush(barNoneColor))
            using (Brush brushFail = new SolidBrush(barFailColor))
            using (Brush brushSuccess = new SolidBrush(barSuccessColor))
            using (Brush brushCurrent = new SolidBrush(barCurrentColor))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                int offset = (this.Width / 2) - (((this.Height * states.Count) + ((states.Count - 1) * (this.Height / 3))) / 2);

                int ndot = 0;
                foreach(PointedProgressBarState state in states)
                {
                    Rectangle dot = new Rectangle(offset + ((this.Height * ndot) + (ndot * ((ndot != 0) ? this.Height / 3 : 0))), 0, this.Height, this.Height);

                    g.FillEllipse(state == PointedProgressBarState.CURRENT ? brushCurrent : state == PointedProgressBarState.FAIL ? brushFail : state == PointedProgressBarState.SUCCESS ? brushSuccess : brushNone, dot);
                    ndot++;
                }
            }
        }
    }

    [Serializable]
    public enum PointedProgressBarState
    {
        NONE,
        FAIL,
        SUCCESS,
        CURRENT
    }
}
