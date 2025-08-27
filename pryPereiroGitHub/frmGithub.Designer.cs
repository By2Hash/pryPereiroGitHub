namespace pryPereiroGitHub
{
    partial class frmGithub
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
            this.btnNube = new System.Windows.Forms.Button();
            this.lblPruba = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNube
            // 
            this.btnNube.Location = new System.Drawing.Point(155, 131);
            this.btnNube.Name = "btnNube";
            this.btnNube.Size = new System.Drawing.Size(75, 23);
            this.btnNube.TabIndex = 0;
            this.btnNube.Text = "Nube";
            this.btnNube.UseVisualStyleBackColor = true;
            this.btnNube.Click += new System.EventHandler(this.btnNube_Click);
            // 
            // lblPruba
            // 
            this.lblPruba.AutoSize = true;
            this.lblPruba.Location = new System.Drawing.Point(165, 66);
            this.lblPruba.Name = "lblPruba";
            this.lblPruba.Size = new System.Drawing.Size(65, 13);
            this.lblPruba.TabIndex = 1;
            this.lblPruba.Text = "Hola Mundo";
            // 
            // frmGithub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 329);
            this.Controls.Add(this.lblPruba);
            this.Controls.Add(this.btnNube);
            this.Name = "frmGithub";
            this.Text = "Prueba Git";
            this.Load += new System.EventHandler(this.pryGithub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNube;
        private System.Windows.Forms.Label lblPruba;
    }
}

