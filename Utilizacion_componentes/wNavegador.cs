using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilizacion_componentes
{
    public partial class fmrNavegador : Form
    {
        /// <summary>
        /// Constructor de la clase fmrNavegador.
        /// </summary>
        public fmrNavegador()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento click del botón "Ir". Navega al URL indicado en el TextBox "txtUrl".
        /// </summary>
        private void btnIr_Click(object sender, EventArgs e)
        {
            wb1.Navigate(txtUrl.Text);
        }

        /// <summary>
        /// Evento click del botón "Atrás". Regresa a la página anterior en el historial del navegador.
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            wb1.GoBack();
        }

        /// <summary>
        /// Evento click del botón "Siguiente". Avanza a la página siguiente en el historial del navegador.
        /// </summary>
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            wb1.GoForward();
        }

        /// <summary>
        /// Evento click del botón "Recargar". Recarga la página actual.
        /// </summary>
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            wb1.Refresh();
        }

        /// <summary>
        /// Evento click del botón "Detener". Detiene la carga de la página actual.
        /// </summary>
        private void btnStop_Click(object sender, EventArgs e)
        {
            wb1.Stop();
        }

        /// <summary>
        /// Evento click del botón "Inicio". Navega a la página de inicio del navegador.
        /// </summary>
        private void btnHome_Click(object sender, EventArgs e)
        {
            wb1.GoHome();
        }
    }
}
