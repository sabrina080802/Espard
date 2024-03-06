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
    public partial class ControlPagination : UserControl
    {
        private List<Control> pages = new List<Control>();
        private int current = -1;

        public int Count
        {
            get => pages.Count;
        }

        public int PageNumber
        {
            get => current + 1;
        }

        public ControlPagination()
        {
            InitializeComponent();
        }

        public void addPage(Control page)
        {
            pages.Add(page);
            page.Visible = false;
            page.Location = new Point(0, 0);
            page.Width = this.Width;
            page.Height = this.Height;
            page.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
            this.Controls.Add(page);
        }

        /// <summary>
        /// Supprime une page
        /// </summary>
        /// <param name="page">La page à supprimer</param>
        public void removePage(Control page)
        {
            pages.Remove(page);
            this.Controls.Remove(page);
        }

        /// <summary>
        /// Nettoie les pages
        /// </summary>
        public void Clear()
        {
            pages.Clear();
        }

        /// <summary>
        /// Charge la page souhaité
        /// </summary>
        /// <param name="index">L'index de la page souhaité</param>
        public void switchTo(int index)
        {
            if (index >= 0 && index < pages.Count)
            {
                if (current != -1) pages[current].Visible = false;
                pages[index].Visible = true;
                current = index;
            }
        }

        /// <summary>
        /// Charge la prochaine page
        /// </summary>
        public void next()
        {
            if (current < (pages.Count - 1)) switchTo(current + 1);
        }

        /// <summary>
        /// Charge la page précédente
        /// </summary>
        public void prev()
        {
            if (current > 0) switchTo(current - 1);
        }

        /// <summary>
        /// Charge la première page
        /// </summary>
        public void first()
        {
            switchTo(0);
        }

        /// <summary>
        /// Charge la dernière page
        /// </summary>
        public void last()
        {
            switchTo(pages.Count - 1);
        }
    }
}
