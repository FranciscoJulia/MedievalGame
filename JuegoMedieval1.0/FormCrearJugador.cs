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
     partial class FormCrearJugador : Form
    {
        public FormCrearJugador()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lblFacil.Font = new Font("Perpetua", 20);

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text.ToString() == "")
            {
                MessageBox.Show("No ha ingresado un nombre");
            }
            else if (tbNombre.Text.Length > 18) MessageBox.Show("Nombre muy largo. Máximo 18 caracteres...");
            else
            {
                Jugador player = new Jugador(tbNombre.Text.ToString(), (byte)tbDificultad.Value);
                FormPrincipal formPrincipal = new FormPrincipal(player);

                this.Close();
                formPrincipal.Show();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormInicio form1 = new FormInicio();
            this.Close();
            form1.Show();
        }

        private void tbDificultad_ValueChanged(object sender, EventArgs e)
        {
            Font nuevoFont = new Font("Perpetua", 20);
            Font normalFont = new Font("Perpetua", 18);
            if (tbDificultad.Value == 1)
            {
                lblFacil.Font = nuevoFont;
                lblMedio.Font = normalFont;
                lblDificil.Font = normalFont;

            }
            else if (tbDificultad.Value == 2)
            {
                lblFacil.Font = normalFont;
                lblMedio.Font = nuevoFont;
                lblDificil.Font = normalFont;

            }
            else
            {
                lblFacil.Font = normalFont;
                lblMedio.Font = normalFont;
                lblDificil.Font = nuevoFont;
            }

        }

        private void FormCrearJugador_Load(object sender, EventArgs e)
        {
            lblFacil.Font = new Font("Perpetua", 20);
        }

        private void FormCrearJugador_Load_1(object sender, EventArgs e)
        {

        }

        private void tbDificultad_Scroll(object sender, EventArgs e)
        {

        }
    }
}
