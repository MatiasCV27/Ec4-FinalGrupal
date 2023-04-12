using Oracle.ManagedDataAccess.Client;
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

namespace Ec4_FinalGrupal
{
    public partial class FrmPeliculas : Form
    {
        public FrmPeliculas()
        {
            InitializeComponent();
            prueba();
        }

        OracleConnection Con = new OracleConnection("Data Source=xe;User ID=EC1;Password=12345;");

        private void prueba()
        {
            try { 
                Con.Open();
                MessageBox.Show("La conexión se ha establecido correctamente");
            } catch (Exception e) {
                MessageBox.Show("Error al intentar conectar a la base de datos: " + e.Message);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
