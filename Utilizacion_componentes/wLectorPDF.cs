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
    public partial class fmrLectorPDF : Form
    {
        string ruta = "";

        /// <summary>
        /// Constructor de la clase fmrLectorPDF que inicializa los componentes del formulario.
        /// </summary>
        public fmrLectorPDF()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método del botón "Abrir" que muestra un diálogo para seleccionar un archivo PDF y carga el archivo en el control AxAcroPDF.
        /// </summary>
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                axAcroPDF.src = ruta;
            }
        }

        /// <summary>
        /// Método del botón "Regresar" que cierra el formulario.
        /// </summary>
        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
