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
    internal partial class FormGuerrero : Form
    {
        Jugador player;
        public FormGuerrero(Jugador player)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(930, 240);
            this.player = player;
            this.player = player;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormTrabajar formTrabajar = new FormTrabajar(player);
            formTrabajar.TopMost = true;
            this.Close();
            formTrabajar.Show();
        }

        private void btnGuardia_Click(object sender, EventArgs e)
        {
            if (player.TrabajO < 2)
            {
                if (player.Hambre >= 5 && player.VidaJugador >= 26)
                {
                    if (player.Experiencia >= 700)
                    {
                        FormJuegoClick formJuegoClick = new FormJuegoClick(player, 10, 100, 4, 25);
                        Close();
                        formJuegoClick.TopMost = true;
                        formJuegoClick.Show();
                    }
                    else MessageBox.Show("No tienes la experiencia suficiente");
                }
                else if (player.VidaJugador <= 26) MessageBox.Show("No tienes la vida suficiente, si alguien te ataca moriras...");
                else if (player.Hambre <= 5) MessageBox.Show("Si vas así moriras de hambre...");
            }
            else MessageBox.Show("Ya trabajaste mucho por hoy...");
            
        }

        private void FormGuerrero_Load(object sender, EventArgs e)
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

        private void btnBatalla_Click(object sender, EventArgs e)
        {
            if (player.TrabajO < 2)
            {
                if (player.Hambre >= 11 && player.VidaJugador >= 51)
                {
                    if (player.Experiencia >= 250 && player.TieneEspada == true && player.TieneArmadura == true)
                    {
                        FormJuegoClick formJuegoClick = new FormJuegoClick(player, 6, 50, 10, 50);
                        Close();
                        formJuegoClick.TopMost = true;
                        formJuegoClick.Show();
                    }
                    else if (player.TieneEspada == false) MessageBox.Show("No tienes una espada");
                    else if (player.TieneArmadura == false) MessageBox.Show("No tienes una armadura");
                    else MessageBox.Show("No tienes la experiencia suficiente");
                }
                else if (player.VidaJugador <= 51) MessageBox.Show("No tienes la vida suficiente, si vas a la batalla moriras...");
                else if (player.Hambre <= 11) MessageBox.Show("Si vas así moriras de hambre...");
            }
            else MessageBox.Show("Ya trabajaste mucho por hoy...");
            
        }
    }
}
