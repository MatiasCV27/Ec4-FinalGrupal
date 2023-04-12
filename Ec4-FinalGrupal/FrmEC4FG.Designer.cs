namespace Ec4_FinalGrupal
{
    partial class FrmEC4FG
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
            this.mmuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mmuPrincipal
            // 
            this.mmuPrincipal.BackColor = System.Drawing.Color.Ivory;
            this.mmuPrincipal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem});
            this.mmuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mmuPrincipal.Name = "mmuPrincipal";
            this.mmuPrincipal.Size = new System.Drawing.Size(884, 27);
            this.mmuPrincipal.TabIndex = 1;
            this.mmuPrincipal.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peliculasToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(128, 23);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // peliculasToolStripMenuItem
            // 
            this.peliculasToolStripMenuItem.Name = "peliculasToolStripMenuItem";
            this.peliculasToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.peliculasToolStripMenuItem.Text = "Peliculas";
            this.peliculasToolStripMenuItem.Click += new System.EventHandler(this.peliculasToolStripMenuItem_Click);
            // 
            // FrmEC4FG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.mmuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FrmEC4FG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluacion Continua 4 - Grupal";
            this.mmuPrincipal.ResumeLayout(false);
            this.mmuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mmuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peliculasToolStripMenuItem;
    }
}

