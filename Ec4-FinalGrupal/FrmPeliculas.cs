using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace Ec4_FinalGrupal
{
    public partial class FrmPeliculas : Form
    {
        public FrmPeliculas()
        {
            InitializeComponent();
        }

        OracleConnection Con = new OracleConnection(@"DATA SOURCE = localhost:1521/XE; USER ID = EC1; PASSWORD = 12345");

        objCine.clsPeliculas Pe = new objCine.clsPeliculas();

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            Pe.ListarPelicula(Con, dgvPeliculas);
            tbControlPeli.SelectedIndex = 2;
        }

        private void FrmPeliculas_Load(object sender, EventArgs e)
        {
            Pe.ListarPelicula(Con, dgvPeliculas);
        }
    }
}
