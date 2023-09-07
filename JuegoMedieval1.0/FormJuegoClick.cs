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
    internal partial class FormJuegoClick : Form
    {
        Jugador player;
        private byte valorJuego;
        private short valorExperiencia;
        private byte juegoHambre;
        private byte juegoDaño;

        public FormJuegoClick(Jugador player, byte valorJuego, short Experiencia, byte juegoHambre, byte juegoDaño)
        {
            this.juegoHambre = juegoHambre;
            valorExperiencia = Experiencia;
            this.player = player;
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 2500; // 2.5 segundos
            timer.Tick += Timer_Tick;
            this.valorJuego = valorJuego;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(950, 220);
            this.juegoDaño = juegoDaño;
        }

        private Timer timer;
        private bool isTimerActive;
        private int seActivo = 0;
        int cantGanadas = 0;

        private void btnClick_Click(object sender, EventArgs e)
        {

            if (isTimerActive == false)
            {
                if (seActivo == 0)
                {
                    btnVolver.Enabled = false;
                    btnClick.Text = "Click";
                    cantGanadas += valorJuego;
                    player.Monedas += valorJuego;
                    lblCantMonedas.Text = $"{player.Monedas.ToString()}";

                    seActivo++;
                    timer.Start();
                    isTimerActive = true;
                }

            }
            else
            {
                cantGanadas += valorJuego;
                player.Monedas += valorJuego;
                lblCantMonedas.Text = $"{player.Monedas.ToString()}";
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            timer.Stop();
            player.Experiencia += valorExperiencia;
            btnClick.Text = $"¡¡haz ganado {cantGanadas} monedas Y {valorExperiencia} de experiencia!! Ya puedes regresar";
            isTimerActive = false;
            btnVolver.Enabled = true;
            player.Hambre -= juegoHambre;
            if (juegoDaño>0) player.VidaJugador -= juegoDaño;
            player.TrabajO += 1;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal(player);
            formPrincipal.TopMost = true;
            Close();

            formPrincipal.Show();
        }

        private void FormJugarClick_Load(object sender, EventArgs e)
        {

        }
    }
}
