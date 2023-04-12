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
            this.tbpModificar = new System.Windows.Forms.TabPage();
            this.tbpRegistros = new System.Windows.Forms.TabPage();
            this.tbControl.SuspendLayout();
            this.tbpRegistrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Firebrick;
            this.btnRegresar.Font = new System.Drawing.Font("Algerian", 12F);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(6, 386);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(119, 38);
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
            this.tbControl.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.tbControl.Location = new System.Drawing.Point(12, 12);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(856, 456);
            this.tbControl.TabIndex = 1;
            // 
            // tbpRegistrar
            // 
            this.tbpRegistrar.Controls.Add(this.btnRegresar);
            this.tbpRegistrar.Location = new System.Drawing.Point(4, 24);
            this.tbpRegistrar.Name = "tbpRegistrar";
            this.tbpRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistrar.Size = new System.Drawing.Size(848, 428);
            this.tbpRegistrar.TabIndex = 0;
            this.tbpRegistrar.Text = "Registrar";
            this.tbpRegistrar.UseVisualStyleBackColor = true;
            // 
            // tbpModificar
            // 
            this.tbpModificar.Location = new System.Drawing.Point(4, 22);
            this.tbpModificar.Name = "tbpModificar";
            this.tbpModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpModificar.Size = new System.Drawing.Size(848, 430);
            this.tbpModificar.TabIndex = 1;
            this.tbpModificar.Text = "Modificar";
            this.tbpModificar.UseVisualStyleBackColor = true;
            // 
            // tbpRegistros
            // 
            this.tbpRegistros.Location = new System.Drawing.Point(4, 24);
            this.tbpRegistros.Name = "tbpRegistros";
            this.tbpRegistros.Size = new System.Drawing.Size(848, 428);
            this.tbpRegistros.TabIndex = 2;
            this.tbpRegistros.Text = "Registros";
            this.tbpRegistros.UseVisualStyleBackColor = true;
            // 
            // FrmPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 480);
            this.Controls.Add(this.tbControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Peliculas";
            this.tbControl.ResumeLayout(false);
            this.tbpRegistrar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tbpRegistrar;
        private System.Windows.Forms.TabPage tbpModificar;
        private System.Windows.Forms.TabPage tbpRegistros;
    }
}