namespace Ec4_FinalGrupal
{
    partial class FrmPeliculas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegresar = new System.Windows.Forms.Button();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbpRegistrar = new System.Windows.Forms.TabPage();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbpModificar = new System.Windows.Forms.TabPage();
            this.tbpRegistros = new System.Windows.Forms.TabPage();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.colCodPeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAEstreno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSinop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPresu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIngre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodDirec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbControl.SuspendLayout();
            this.tbpRegistrar.SuspendLayout();
            this.tbpRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Firebrick;
            this.btnRegresar.Font = new System.Drawing.Font("Cambria", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(749, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(119, 35);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tbpRegistrar);
            this.tbControl.Controls.Add(this.tbpModificar);
            this.tbControl.Controls.Add(this.tbpRegistros);
            this.tbControl.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.tbControl.Location = new System.Drawing.Point(12, 23);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(856, 445);
            this.tbControl.TabIndex = 1;
            // 
            // tbpRegistrar
            // 
            this.tbpRegistrar.Controls.Add(this.btnRegistrar);
            this.tbpRegistrar.Location = new System.Drawing.Point(4, 28);
            this.tbpRegistrar.Name = "tbpRegistrar";
            this.tbpRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistrar.Size = new System.Drawing.Size(848, 413);
            this.tbpRegistrar.TabIndex = 0;
            this.tbpRegistrar.Text = "Registrar";
            this.tbpRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Firebrick;
            this.btnRegistrar.Font = new System.Drawing.Font("Cambria", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(706, 357);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(119, 35);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tbpModificar
            // 
            this.tbpModificar.Location = new System.Drawing.Point(4, 28);
            this.tbpModificar.Name = "tbpModificar";
            this.tbpModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpModificar.Size = new System.Drawing.Size(848, 413);
            this.tbpModificar.TabIndex = 1;
            this.tbpModificar.Text = "Modificar";
            this.tbpModificar.UseVisualStyleBackColor = true;
            // 
            // tbpRegistros
            // 
            this.tbpRegistros.Controls.Add(this.dgvPeliculas);
            this.tbpRegistros.Location = new System.Drawing.Point(4, 28);
            this.tbpRegistros.Name = "tbpRegistros";
            this.tbpRegistros.Size = new System.Drawing.Size(848, 413);
            this.tbpRegistros.TabIndex = 2;
            this.tbpRegistros.Text = "Registros";
            this.tbpRegistros.UseVisualStyleBackColor = true;
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AllowUserToAddRows = false;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodPeli,
            this.colTitulo,
            this.colAEstreno,
            this.colDura,
            this.colIdioma,
            this.ColSinop,
            this.colPresu,
            this.colIngre,
            this.colCodE,
            this.colCodDirec,
            this.colGenero,
            this.colClasi});
            this.dgvPeliculas.Location = new System.Drawing.Point(3, 3);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.Size = new System.Drawing.Size(842, 407);
            this.dgvPeliculas.TabIndex = 0;
            // 
            // colCodPeli
            // 
            this.colCodPeli.DataPropertyName = "CooPeli";
            this.colCodPeli.HeaderText = "Codigo Pelicula";
            this.colCodPeli.Name = "colCodPeli";
            // 
            // colTitulo
            // 
            this.colTitulo.DataPropertyName = "TituloPeli";
            this.colTitulo.HeaderText = "Titulo";
            this.colTitulo.Name = "colTitulo";
            // 
            // colAEstreno
            // 
            this.colAEstreno.DataPropertyName = "AniOEsPeli";
            this.colAEstreno.HeaderText = "Año de Estreno";
            this.colAEstreno.Name = "colAEstreno";
            // 
            // colDura
            // 
            this.colDura.DataPropertyName = "DuracPeli";
            this.colDura.HeaderText = "Duracion";
            this.colDura.Name = "colDura";
            // 
            // colIdioma
            // 
            this.colIdioma.DataPropertyName = "IdiomaPeli";
            this.colIdioma.HeaderText = "Idioma";
            this.colIdioma.Name = "colIdioma";
            // 
            // ColSinop
            // 
            this.ColSinop.DataPropertyName = "SinopPeli";
            this.ColSinop.HeaderText = "Sinopsis";
            this.ColSinop.Name = "ColSinop";
            // 
            // colPresu
            // 
            this.colPresu.DataPropertyName = "PresuPeli";
            this.colPresu.HeaderText = "Presupuesto (MD)";
            this.colPresu.Name = "colPresu";
            // 
            // colIngre
            // 
            this.colIngre.DataPropertyName = "IngresoPeli";
            this.colIngre.HeaderText = "Ingresos (MD)";
            this.colIngre.Name = "colIngre";
            // 
            // colCodE
            // 
            this.colCodE.DataPropertyName = "CodEstud";
            this.colCodE.HeaderText = "Estudio";
            this.colCodE.Name = "colCodE";
            // 
            // colCodDirec
            // 
            this.colCodDirec.DataPropertyName = "CodDirec";
            this.colCodDirec.HeaderText = "Director";
            this.colCodDirec.Name = "colCodDirec";
            // 
            // colGenero
            // 
            this.colGenero.DataPropertyName = "CodGenero";
            this.colGenero.HeaderText = "Genero";
            this.colGenero.Name = "colGenero";
            // 
            // colClasi
            // 
            this.colClasi.DataPropertyName = "CodClasi";
            this.colClasi.HeaderText = "Clasificacion";
            this.colClasi.Name = "colClasi";
            // 
            // FrmPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 480);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.tbControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Peliculas";
            this.tbControl.ResumeLayout(false);
            this.tbpRegistrar.ResumeLayout(false);
            this.tbpRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tbpRegistrar;
        private System.Windows.Forms.TabPage tbpModificar;
        private System.Windows.Forms.TabPage tbpRegistros;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodPeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAEstreno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSinop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPresu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodDirec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClasi;
        private System.Windows.Forms.Button btnRegistrar;
    }
}