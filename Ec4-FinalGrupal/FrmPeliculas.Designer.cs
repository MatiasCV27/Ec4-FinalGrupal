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
            this.tbControlPeli = new System.Windows.Forms.TabControl();
            this.tbpRegistrar = new System.Windows.Forms.TabPage();
            this.txtCodC = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.txtCodD = new System.Windows.Forms.TextBox();
            this.txtCodE = new System.Windows.Forms.TextBox();
            this.txtIngresoP = new System.Windows.Forms.TextBox();
            this.txtSinopP = new System.Windows.Forms.TextBox();
            this.txtIdiomaP = new System.Windows.Forms.TextBox();
            this.txtPresuP = new System.Windows.Forms.TextBox();
            this.txtDuraP = new System.Windows.Forms.TextBox();
            this.txtTituloP = new System.Windows.Forms.TextBox();
            this.txtCodP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodG = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.colCodEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodDirec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodClasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFeEstreno = new System.Windows.Forms.DateTimePicker();
            this.tbControlPeli.SuspendLayout();
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
            // tbControlPeli
            // 
            this.tbControlPeli.Controls.Add(this.tbpRegistrar);
            this.tbControlPeli.Controls.Add(this.tbpModificar);
            this.tbControlPeli.Controls.Add(this.tbpRegistros);
            this.tbControlPeli.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.tbControlPeli.Location = new System.Drawing.Point(12, 23);
            this.tbControlPeli.Name = "tbControlPeli";
            this.tbControlPeli.SelectedIndex = 0;
            this.tbControlPeli.Size = new System.Drawing.Size(856, 445);
            this.tbControlPeli.TabIndex = 1;
            // 
            // tbpRegistrar
            // 
            this.tbpRegistrar.Controls.Add(this.dtpFeEstreno);
            this.tbpRegistrar.Controls.Add(this.txtCodC);
            this.tbpRegistrar.Controls.Add(this.textBox11);
            this.tbpRegistrar.Controls.Add(this.txtCodD);
            this.tbpRegistrar.Controls.Add(this.txtCodE);
            this.tbpRegistrar.Controls.Add(this.txtIngresoP);
            this.tbpRegistrar.Controls.Add(this.txtSinopP);
            this.tbpRegistrar.Controls.Add(this.txtIdiomaP);
            this.tbpRegistrar.Controls.Add(this.txtPresuP);
            this.tbpRegistrar.Controls.Add(this.txtDuraP);
            this.tbpRegistrar.Controls.Add(this.txtTituloP);
            this.tbpRegistrar.Controls.Add(this.txtCodP);
            this.tbpRegistrar.Controls.Add(this.label12);
            this.tbpRegistrar.Controls.Add(this.label11);
            this.tbpRegistrar.Controls.Add(this.txtCodG);
            this.tbpRegistrar.Controls.Add(this.label9);
            this.tbpRegistrar.Controls.Add(this.label8);
            this.tbpRegistrar.Controls.Add(this.label7);
            this.tbpRegistrar.Controls.Add(this.label6);
            this.tbpRegistrar.Controls.Add(this.label5);
            this.tbpRegistrar.Controls.Add(this.label4);
            this.tbpRegistrar.Controls.Add(this.label3);
            this.tbpRegistrar.Controls.Add(this.label2);
            this.tbpRegistrar.Controls.Add(this.label1);
            this.tbpRegistrar.Controls.Add(this.btnRegistrar);
            this.tbpRegistrar.Location = new System.Drawing.Point(4, 28);
            this.tbpRegistrar.Name = "tbpRegistrar";
            this.tbpRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistrar.Size = new System.Drawing.Size(848, 413);
            this.tbpRegistrar.TabIndex = 0;
            this.tbpRegistrar.Text = "Registrar";
            this.tbpRegistrar.UseVisualStyleBackColor = true;
            // 
            // txtCodC
            // 
            this.txtCodC.Location = new System.Drawing.Point(498, 164);
            this.txtCodC.Name = "txtCodC";
            this.txtCodC.Size = new System.Drawing.Size(127, 26);
            this.txtCodC.TabIndex = 24;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(498, 132);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(127, 26);
            this.textBox11.TabIndex = 23;
            // 
            // txtCodD
            // 
            this.txtCodD.Location = new System.Drawing.Point(498, 100);
            this.txtCodD.Name = "txtCodD";
            this.txtCodD.Size = new System.Drawing.Size(127, 26);
            this.txtCodD.TabIndex = 22;
            // 
            // txtCodE
            // 
            this.txtCodE.Location = new System.Drawing.Point(498, 68);
            this.txtCodE.Name = "txtCodE";
            this.txtCodE.Size = new System.Drawing.Size(127, 26);
            this.txtCodE.TabIndex = 21;
            // 
            // txtIngresoP
            // 
            this.txtIngresoP.Location = new System.Drawing.Point(192, 293);
            this.txtIngresoP.Name = "txtIngresoP";
            this.txtIngresoP.Size = new System.Drawing.Size(127, 26);
            this.txtIngresoP.TabIndex = 20;
            // 
            // txtSinopP
            // 
            this.txtSinopP.Location = new System.Drawing.Point(192, 229);
            this.txtSinopP.Name = "txtSinopP";
            this.txtSinopP.Size = new System.Drawing.Size(127, 26);
            this.txtSinopP.TabIndex = 19;
            // 
            // txtIdiomaP
            // 
            this.txtIdiomaP.Location = new System.Drawing.Point(192, 197);
            this.txtIdiomaP.Name = "txtIdiomaP";
            this.txtIdiomaP.Size = new System.Drawing.Size(127, 26);
            this.txtIdiomaP.TabIndex = 18;
            // 
            // txtPresuP
            // 
            this.txtPresuP.Location = new System.Drawing.Point(192, 261);
            this.txtPresuP.Name = "txtPresuP";
            this.txtPresuP.Size = new System.Drawing.Size(127, 26);
            this.txtPresuP.TabIndex = 18;
            // 
            // txtDuraP
            // 
            this.txtDuraP.Location = new System.Drawing.Point(192, 165);
            this.txtDuraP.Name = "txtDuraP";
            this.txtDuraP.Size = new System.Drawing.Size(127, 26);
            this.txtDuraP.TabIndex = 17;
            // 
            // txtTituloP
            // 
            this.txtTituloP.Location = new System.Drawing.Point(192, 96);
            this.txtTituloP.Name = "txtTituloP";
            this.txtTituloP.Size = new System.Drawing.Size(127, 26);
            this.txtTituloP.TabIndex = 15;
            // 
            // txtCodP
            // 
            this.txtCodP.Location = new System.Drawing.Point(192, 64);
            this.txtCodP.Name = "txtCodP";
            this.txtCodP.Size = new System.Drawing.Size(127, 26);
            this.txtCodP.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(120, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = "Idioma:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(385, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 19);
            this.label11.TabIndex = 12;
            this.label11.Text = "Clasificacion:";
            // 
            // txtCodG
            // 
            this.txtCodG.AutoSize = true;
            this.txtCodG.Location = new System.Drawing.Point(427, 140);
            this.txtCodG.Name = "txtCodG";
            this.txtCodG.Size = new System.Drawing.Size(65, 19);
            this.txtCodG.TabIndex = 11;
            this.txtCodG.Text = "Genero:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(418, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Director:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Estudio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ingreso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Presupuesto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sinopsis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Duracion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Año de estreno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titulo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo:";
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
            this.colCodEst,
            this.colCodDirec,
            this.colCodGen,
            this.colCodClasi});
            this.dgvPeliculas.Location = new System.Drawing.Point(3, 6);
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
            // colCodEst
            // 
            this.colCodEst.DataPropertyName = "CodEstud";
            this.colCodEst.HeaderText = "Estudio";
            this.colCodEst.Name = "colCodEst";
            // 
            // colCodDirec
            // 
            this.colCodDirec.DataPropertyName = "CodDirec";
            this.colCodDirec.HeaderText = "Director";
            this.colCodDirec.Name = "colCodDirec";
            // 
            // colCodGen
            // 
            this.colCodGen.DataPropertyName = "CodGenero";
            this.colCodGen.HeaderText = "Genero";
            this.colCodGen.Name = "colCodGen";
            // 
            // colCodClasi
            // 
            this.colCodClasi.DataPropertyName = "CodClasi";
            this.colCodClasi.HeaderText = "Clasificacion";
            this.colCodClasi.Name = "colCodClasi";
            // 
            // dtpFeEstreno
            // 
            this.dtpFeEstreno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFeEstreno.Location = new System.Drawing.Point(192, 132);
            this.dtpFeEstreno.Name = "dtpFeEstreno";
            this.dtpFeEstreno.Size = new System.Drawing.Size(127, 26);
            this.dtpFeEstreno.TabIndex = 25;
            // 
            // FrmPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 480);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.tbControlPeli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Peliculas";
            this.Load += new System.EventHandler(this.FrmPeliculas_Load);
            this.tbControlPeli.ResumeLayout(false);
            this.tbpRegistrar.ResumeLayout(false);
            this.tbpRegistrar.PerformLayout();
            this.tbpRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TabControl tbControlPeli;
        private System.Windows.Forms.TabPage tbpRegistrar;
        private System.Windows.Forms.TabPage tbpModificar;
        private System.Windows.Forms.TabPage tbpRegistros;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodPeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAEstreno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSinop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPresu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodDirec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodClasi;
        private System.Windows.Forms.TextBox txtCodC;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox txtCodD;
        private System.Windows.Forms.TextBox txtCodE;
        private System.Windows.Forms.TextBox txtIngresoP;
        private System.Windows.Forms.TextBox txtSinopP;
        private System.Windows.Forms.TextBox txtIdiomaP;
        private System.Windows.Forms.TextBox txtPresuP;
        private System.Windows.Forms.TextBox txtDuraP;
        private System.Windows.Forms.TextBox txtTituloP;
        private System.Windows.Forms.TextBox txtCodP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtCodG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFeEstreno;
    }
}