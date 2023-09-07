using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoMedieval1._0
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnNuevaPartida_Click(object sender, EventArgs e)
        {
            FormCrearJugador formCrearJugador = new FormCrearJugador();
            Hide();
            formCrearJugador.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Quieres continuar?", "Confirmación", MessageBoxButtons.YesNo);

            // Evaluar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // El usuario hizo clic en "Sí", realiza la acción correspondiente
                Application.Exit();
            }
            else if (resultado == DialogResult.No)
            {
                // El usuario hizo clic en "No", realiza la acción correspondiente

            }
        }
    }
}
