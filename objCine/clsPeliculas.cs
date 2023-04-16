using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace objCine
{
    public class clsPeliculas
    {
        // Atributos
        private String _CodPeli;
        private String _Titulo;
        private DateTime _AnioEstreno;
        private int _Duracion;
        private String _Idioma;
        private String _Sinopsis;
        private int _Presupuesto;
        private int _Ingresos;
        private String _CodEstud;
        private String _CodDirec;
        private String _CodGenero;
        private String _CodClasi;
        private DataSet dst = new DataSet();

        // Propiedades
        public String CodPeli { 
            get {
                return _CodPeli;
            } set {
                _CodPeli = value;
            }
        }
        public String  Titulo { 
            get {
                return _Titulo;
            } set {
                _Titulo = value;
            }
        }
        public DateTime  FechaEstreno { 
            get {
                return _AnioEstreno;
            } set {
                _AnioEstreno = value;
            }
        }
        public int Duracion { 
            get {
                return _Duracion;
            } set {
                _Duracion = value;
            }
        }
        public String Idioma { 
            get {
                return _Idioma;
            } set {
                _Idioma = value;
            }
        }
        public String Sinopsis { 
            get {
                return _Sinopsis;
            } set {
                _Sinopsis = value;
            }
        }
        public int Presupuesto { 
            get {
                return _Presupuesto;
            } set {
                _Presupuesto = value;
            }
        }
        public int Ingreso { 
            get {
                return _Ingresos;
            } set {
                _Ingresos = value;
            }
        }
        public String CodEstud { 
            get {
                return _CodEstud;
            } set {
                _CodEstud = value;
            }
        }
        public String CodDirec { 
            get {
                return _CodDirec;
            } set {
                _CodDirec = value;
            }
        }
        public String CodGenero { 
            get {
                return _CodGenero;
            } set {
                _CodGenero = value;
            }
        }
        public String CodClasi { 
            get {
                return _CodClasi;
            } set {
                _CodClasi = value;
            }
        }

        // Metodos o funcionesç
        public void ListarPelicula(OracleConnection ConOracle, DataGridView dgv)
        {
            ConOracle.Open();

            OracleCommand cmd = new OracleCommand("sp_ListarPeliculas", ConOracle);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("listapelicula", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adt = new OracleDataAdapter();
            adt.SelectCommand = cmd;
            DataTable tb = new DataTable();
            adt.Fill(tb);

            dgv.DataSource = tb;

            ConOracle.Close();
        }
    }
}
