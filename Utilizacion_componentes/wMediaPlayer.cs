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
    /// La clase fmrMediaPlayer representa una ventana que permite cargar y reproducir archivos de audio o video.
    /// </summary>
    public partial class fmrMediaPlayer : Form
    {
        private string ruta = "";

        /// <summary>
        /// El constructor de la clase fmrMediaPlayer inicializa la ventana.
        /// </summary>
        public fmrMediaPlayer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// El evento btnCargar_Click se produce cuando el usuario hace clic en el botón "Cargar archivo".
        /// Permite al usuario seleccionar un archivo de audio o video y muestra la ruta en un Label.
        /// </summary>
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                lblRuta.Text = ruta;
            }
        }

        /// <summary>
        /// El evento btnReproducir_Click se produce cuando el usuario hace clic en el botón "Reproducir".
        /// Reproduce el archivo seleccionado en el reproductor multimedia.
        /// </summary>
        private void btnReproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL = ruta;
            axWindowsMediaPlayer.Ctlcontrols.play();
        }

        /// <summary>
        /// El evento btnPausar_Click se produce cuando el usuario hace clic en el botón "Pausar".
        /// Pausa la reproducción del archivo en el reproductor multimedia.
        /// </summary>
        private void btnPausar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.pause();
        }

        /// <summary>
        /// El evento btnParar_Click se produce cuando el usuario hace clic en el botón "Parar".
        /// Detiene la reproducción del archivo en el reproductor multimedia.
        /// </summary>
        private void btnParar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.stop();
        }

        /// <summary>
        /// El evento btnRegresar_Click se produce cuando el usuario hace clic en el botón "Regresar".
        /// Cierra la ventana actual.
        /// </summary>
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
