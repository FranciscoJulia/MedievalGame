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
    internal partial class FormTrabajar : Form
    {
        Jugador player;
        public FormTrabajar(Jugador player)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(930, 240);
            this.player = player;
        }

        private void FormTrabajar_Load(object sender, EventArgs e)
        {
            //Muestra vida
            pbVida.Value = player.VidaJugador;
            lblMuestraVida.Text = $"{player.VidaJugador}/100";

            //Muestra hambre
            lblMuestraHambre.Text = $"{player.Hambre}/20";

            //Muestra Monedas y xp
            lblCantMonedas.Text = $"{player.Monedas} coins";
            lblCantExperiencia.Text = $"{player.Experiencia} exp.";

            //Muestra el día...
            lblcantDias.Text = $"Día {player.Dia}";
        }

        private void btnGuerrero_Click(object sender, EventArgs e)
        {
            FormGuerrero formGuerrero = new FormGuerrero(player);
            this.Close();
            formGuerrero.TopMost = true;
            formGuerrero.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal(player);
            formPrincipal.TopMost = true;
            Close();

            formPrincipal.Show();
        }

        private void btnLeñador_Click(object sender, EventArgs e)
        {
            if (player.TrabajO < 2)
            {
                if (player.Hambre >= 3)
                {
                    FormJuegoClick formJuegoClick = new FormJuegoClick(player, 1, 15, 2, 0);
                    Close();
                    formJuegoClick.TopMost = true;
                    formJuegoClick.Show();
                }
                else MessageBox.Show("No puedes ir a trabajar, moriras de hambre...");
            }
            else MessageBox.Show("ya trabajaste mucho por hoy...");
            
        }

        private void btnGuerrero_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRobar_Click(object sender, EventArgs e)
        {
            FormRobar formTrabajar = new FormRobar(player);
            Close();
            formTrabajar.TopMost = true;
            formTrabajar.Show();
        }
    }
}
