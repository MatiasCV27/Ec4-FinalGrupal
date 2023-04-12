using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ec4_FinalGrupal
{
    public partial class FrmEC4FG : Form
    {
        public FrmEC4FG()
        {
            InitializeComponent();
        }

        private FrmPeliculas fPeliculas; 
        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fPeliculas == null || fPeliculas.IsDisposed) {
                fPeliculas = new FrmPeliculas();
                fPeliculas.MdiParent = this;
                fPeliculas.Show();
            } else {
                fPeliculas.Focus();
            }
        }
    }
}
