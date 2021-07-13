
namespace FormsMutantes
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.ADN = new System.Windows.Forms.Button();
            this.MostrarLetras = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ADN
            // 
            this.ADN.AutoSize = true;
            this.ADN.BackColor = System.Drawing.Color.RoyalBlue;
            this.ADN.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADN.Location = new System.Drawing.Point(257, 209);
            this.ADN.Name = "ADN";
            this.ADN.Size = new System.Drawing.Size(179, 51);
            this.ADN.TabIndex = 0;
            this.ADN.Text = "Ver Adn";
            this.ADN.UseVisualStyleBackColor = false;
            this.ADN.Click += new System.EventHandler(this.VerAdn_Click);
            // 
            // MostrarLetras
            // 
            this.MostrarLetras.Location = new System.Drawing.Point(164, 278);
            this.MostrarLetras.Multiline = true;
            this.MostrarLetras.Name = "MostrarLetras";
            this.MostrarLetras.Size = new System.Drawing.Size(363, 31);
            this.MostrarLetras.TabIndex = 1;
            this.MostrarLetras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
           
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(681, 365);
            this.Controls.Add(this.MostrarLetras);
            this.Controls.Add(this.ADN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificación ADN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADN;
        private System.Windows.Forms.TextBox MostrarLetras;
    }
}

