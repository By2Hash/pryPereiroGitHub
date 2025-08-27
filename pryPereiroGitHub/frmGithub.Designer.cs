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
            this.SuspendLayout();
            // 
            // btnNube
            // 
            this.btnNube.Location = new System.Drawing.Point(92, 98);
            this.btnNube.Name = "btnNube";
            this.btnNube.Size = new System.Drawing.Size(75, 23);
            this.btnNube.TabIndex = 0;
            this.btnNube.Text = "Nube";
            this.btnNube.UseVisualStyleBackColor = true;
            // 
            // frmGithub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNube);
            this.Name = "frmGithub";
            this.Text = "Prueba Git";
            this.Load += new System.EventHandler(this.pryGithub_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNube;
    }
}

