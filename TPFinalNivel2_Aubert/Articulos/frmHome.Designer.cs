namespace Articulos
{
    partial class frmHome
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArticuos = new System.Windows.Forms.DataGridView();
            this.pbArt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticuos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticuos
            // 
            this.dgvArticuos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticuos.Location = new System.Drawing.Point(25, 64);
            this.dgvArticuos.Name = "dgvArticuos";
            this.dgvArticuos.Size = new System.Drawing.Size(429, 243);
            this.dgvArticuos.TabIndex = 0;
            this.dgvArticuos.SelectionChanged += new System.EventHandler(this.dgvArticuos_SelectionChanged);
            // 
            // pbArt
            // 
            this.pbArt.Location = new System.Drawing.Point(518, 64);
            this.pbArt.Name = "pbArt";
            this.pbArt.Size = new System.Drawing.Size(256, 243);
            this.pbArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArt.TabIndex = 1;
            this.pbArt.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.pbArt);
            this.Controls.Add(this.dgvArticuos);
            this.Name = "frmHome";
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticuos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticuos;
        private System.Windows.Forms.PictureBox pbArt;
    }
}

