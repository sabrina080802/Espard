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
    public partial class ButtonCustom : UserControl
    {
        private Color bgColor = Color.FromArgb(196, 59, 70);
        private Color fgColor = Color.White;
        private Color hoverColor = Color.FromArgb(181, 89, 96);
        private Color pressedColor = Color.FromArgb(143, 11, 21);

        public ButtonCustom()
        {
            InitializeComponent();
            btn.BackColor = bgColor;
            btn.ForeColor = fgColor;
        }

        public Color BgColor
        {
            get => bgColor;
            set
            {
                bgColor = value;
            }
        }

        public Color FgColor
        {
            get => fgColor;
            set
            {
                fgColor = value;
            }
        }

        public Color HoverColor
        {
            get => hoverColor;
            set
            {
                hoverColor = value;
            }
        }

        public Color PressedColor
        {
            get => pressedColor;
            set
            {
                pressedColor = value;
            }
        }

        public string BtnText
        {
            get => btn.Text;
            set
            {
                btn.Text = value;
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btn.BackColor = hoverColor;
            btn.ForeColor = BackColor;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            btn.BackColor = bgColor;
            btn.ForeColor = fgColor;
        }

        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                btn.Click += value;
            }
            remove
            {
                base.Click -= value;
                btn.Click -= value;
            }
        }

        public new event MouseEventHandler MouseDown
        {
            add
            {
                base.MouseDown += value;
                btn.MouseDown += value;
            }
            remove
            {
                base.MouseDown -= value;
                btn.MouseDown -= value;
            }
        }

        public new event MouseEventHandler MouseUp
        {
            add
            {
                base.MouseUp += value;
                btn.MouseUp += value;
            }
            remove
            {
                base.MouseUp -= value;
                btn.MouseUp -= value;
            }
        }

        public new event MouseEventHandler MouseMove
        {
            add
            {
                base.MouseMove += value;
                btn.MouseMove += value;
            }
            remove
            {
                base.MouseMove -= value;
                btn.MouseMove -= value;
            }
        }
    }
}
