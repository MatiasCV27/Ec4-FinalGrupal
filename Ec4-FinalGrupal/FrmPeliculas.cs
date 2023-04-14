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
using System.Data.OracleClient;


namespace Ec4_FinalGrupal
{
    public partial class FrmPeliculas : Form
    {
        public FrmPeliculas()
        {
            InitializeComponent();
        }

        OracleConnection Con = new OracleConnection("Data Source=xe;User ID=EC1;Password=12345;");

        objCine.clsPeliculas Pe = new objCine.clsPeliculas();

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            dgvPeliculas.DataSource = Pe.ListarPelicula(Con);
        }
    }
}
