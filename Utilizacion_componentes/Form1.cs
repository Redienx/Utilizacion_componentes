using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Utilizacion_componentes
{
    /// <summary>
    /// Representa la ventana principal de la aplicación que permite acceder a diferentes funcionalidades a través de botones.
    /// </summary>
    public partial class frmMenu : Form
    {
        /// <summary>
        /// Crea una nueva instancia de la ventana principal.
        /// </summary>
        public frmMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Muestra la ventana del reproductor multimedia al hacer clic en el botón correspondiente.
        /// </summary>
        /// <param name="sender">El objeto que desencadena el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnMediaPlayer_Click(object sender, EventArgs e)
        {
            fmrMediaPlayer MediaPlayer = new fmrMediaPlayer();
            MediaPlayer.Show();
        }

        /// <summary>
        /// Muestra la ventana del lector de PDF al hacer clic en el botón correspondiente.
        /// </summary>
        /// <param name="sender">El objeto que desencadena el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnPDF_Click(object sender, EventArgs e)
        {
            fmrLectorPDF LectorPDF = new fmrLectorPDF();
            LectorPDF.Show();
        }

        /// <summary>
        /// Muestra la ventana del navegador web al hacer clic en el botón correspondiente.
        /// </summary>
        /// <param name="sender">El objeto que desencadena el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnNavegador_Click(object sender, EventArgs e)
        {
            fmrNavegador Navegador = new fmrNavegador();
            Navegador.Show();
        }
    }
}
 // Codigo Hecho por Sneider Velasquez Iglesias
 // Hecho: 20 de abril de 2023
 // Ultima Modificación: 4 de mayo de 2023
 // Sneider el ciego.