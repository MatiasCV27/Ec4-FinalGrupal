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
            try {
                Con.Open();
                OracleCommand cmd = new OracleCommand("sp_RegistrarPeliculas", Con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("TituloPeli", OracleDbType.Varchar2).Value = txtTituloP.Text;
                cmd.Parameters.Add("AniOEsPeli", OracleDbType.Date).Value = Convert.ToDateTime(dtpFeEstreno.Value);
                cmd.Parameters.Add("DuracPeli", OracleDbType.Int32).Value = txtDuraP.Text;
                cmd.Parameters.Add("IdiomaPeli", OracleDbType.Varchar2).Value = txtIdiomaP.Text;
                cmd.Parameters.Add("SinopPeli", OracleDbType.Varchar2).Value = txtSinopP.Text;
                cmd.Parameters.Add("PresuPeli", OracleDbType.Int32).Value = txtPresuP.Text;
                cmd.Parameters.Add("PresuPeli", OracleDbType.Int32).Value = txtPresuP.Text;
                cmd.Parameters.Add("IngresoPeli", OracleDbType.Varchar2).Value = txtIngresoP.Text;
                cmd.Parameters.Add("CodEstud", OracleDbType.Varchar2).Value = txtCodE.Text;
                cmd.Parameters.Add("CodDirec", OracleDbType.Varchar2).Value = txtCodD.Text;
                cmd.Parameters.Add("CodGenero", OracleDbType.Varchar2).Value = txtCodG.Text;
                cmd.Parameters.Add("CodClasi", OracleDbType.Varchar2).Value = txtCodC.Text;
                cmd.Parameters.Add("CooPeli", OracleDbType.Char, 4).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pelicula insertada correcatamente");
            } catch (Exception ex) {
                MessageBox.Show("Hubo un error: " + ex.Message);
            }
            Con.Close();



            /*
            Pe.Titulo = txtTituloP.Text;
            Pe.FechaEstreno = dtpFeEstreno.Value;
            Pe.Duracion = Convert.ToInt32(txtDuraP.Text);
            Pe.Idioma = txtIdiomaP.Text;
            Pe.Sinopsis = txtSinopP.Text;
            Pe.Presupuesto = Convert.ToInt32(txtPresuP.Text);
            Pe.Ingreso = Convert.ToInt32(txtIngresoP.Text);
            Pe.CodEstud = txtCodE.Text;
            Pe.CodDirec = txtCodD.Text;
            Pe.CodGenero = txtCodG.Text;
            Pe.CodClasi = txtCodC.Text;

            Pe.RegistrarPelicula(Con);
            txtCodP.Text = Pe.CodPeli;
            Pe.ListarPelicula(Con, dgvPeliculas);
            
            /*
            Pe.ListarPelicula(Con, dgvPeliculas);
            tbControlPeli.SelectedIndex = 2; */
        }

        private void FrmPeliculas_Load(object sender, EventArgs e)
        {
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Pe.ListarPelicula(Con, dgvPeliculas);
        }
    }
}
