namespace Utilizacion_componentes
{
    partial class frmMenu
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
            this.btnMediaPlayer = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnNavegador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMediaPlayer
            // 
            this.btnMediaPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMediaPlayer.Location = new System.Drawing.Point(62, 199);
            this.btnMediaPlayer.Name = "btnMediaPlayer";
            this.btnMediaPlayer.Size = new System.Drawing.Size(134, 50);
            this.btnMediaPlayer.TabIndex = 0;
            this.btnMediaPlayer.Text = "Media Player";
            this.btnMediaPlayer.UseVisualStyleBackColor = true;
            this.btnMediaPlayer.Click += new System.EventHandler(this.btnMediaPlayer_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDF.Location = new System.Drawing.Point(321, 199);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(134, 50);
            this.btnPDF.TabIndex = 1;
            this.btnPDF.Text = "Lectura de PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnNavegador
            // 
            this.btnNavegador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavegador.Location = new System.Drawing.Point(606, 199);
            this.btnNavegador.Name = "btnNavegador";
            this.btnNavegador.Size = new System.Drawing.Size(134, 50);
            this.btnNavegador.TabIndex = 2;
            this.btnNavegador.Text = "Navegador Web";
            this.btnNavegador.UseVisualStyleBackColor = true;
            this.btnNavegador.Click += new System.EventHandler(this.btnNavegador_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNavegador);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnMediaPlayer);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMediaPlayer;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnNavegador;
    }
}

