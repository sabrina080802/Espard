using SAE_A21_D21.Utils;
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
    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<Exercice, UserControl>))]
    public abstract partial class Exercice : UserControl
    {
        protected Main main;
        protected DataRow exoRow;
        private string help = null;
        private List<Control> defaultControls = new List<Control>();
        private string enonce = "";
        protected string type = "";
        private int numExo;

        public Exercice(Main main, DataRow exoRow)
        {
            this.main = main;
            this.exoRow = exoRow;
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.Size = new Size(890, 511);
            if (exoRow["codeRegle"] is string)
            {
                help = (string)main.dsDonnees.Tables["Regles"].Select("[codeRegle] = '" + (string)exoRow["codeRegle"] + "'")[0]["texteRegle"];
            }
            enonce = (string)exoRow["enonceExo"];
            numExo = (int)exoRow["numExo"];
        }

        public string getHelp()
        {
            return help;
        }

        public bool isHelpAvailable()
        {
            return help != null;
        }

        public string getEnonce()
        {
            return enonce;
        }

        public string getType()
        {
            return type;
        } 

        public int getNumExo()
        {
            return numExo;
        }

        protected abstract void setup();
        public abstract List<string> printCorrection();
        public abstract bool isValid();

        private static IEnumerable<Control> getAllControls(Control container)
        {
            List<Control> controlList = new List<Control>();
            foreach (Control c in container.Controls)
            {
                controlList.AddRange(getAllControls(c));
                controlList.Add(c);
            }
            return controlList;
        }

        private void Exercice_Load(object sender, EventArgs e)
        {
            defaultControls.AddRange(getAllControls(this));
            setup();
        }

        public void reload()
        {
            foreach(Control c in getAllControls(this))
            {
                if (!defaultControls.Contains(c))
                {
                    c.Parent.Controls.Remove(c);
                }
            }
            setup();
        }

        public override string ToString()
        {
            return base.ToString() + " : " + enonce;
        }
    }
}
