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
    internal partial class FormRobar : Form
    {
        Jugador player;
        public FormRobar(Jugador player)
        {
            InitializeComponent();
            this.player = player;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(780, 240);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormTrabajar formTrabajar = new FormTrabajar(player);
            formTrabajar.TopMost = true;
            this.Close();
            formTrabajar.Show();
        }

        private void FormRobar_Load(object sender, EventArgs e)
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

        public void ObtenerObjeto()
        {
            if (player.ArmaduraCuero == false)
            {
                player.TieneArmadura = true;
                player.ArmaduraCuero = true;
            }
            else if (player.EspadaHierro == false)
            {
                player.TieneEspada = true;
                player.EspadaHierro = true;
            }
            else if (player.EspadaAcero == false)
            {
                player.TieneEspada = true;
                player.EspadaAcero = true;
            }
            else if (player.ArmaduraMalla == false)
            {
                player.TieneArmadura = true;
                player.ArmaduraMalla = true;
            }
        }

        private void btnCasa_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int numrandom = num.Next(1, 5);
            if(player.Experiencia >= 150)
            {
                if(numrandom == 1)
                {
                    MessageBox.Show("Te han atrapado, Te quitaron todos tus items y estarás encerrado por 30 días.");
                    player.PerderTodo();
                    player.Dia += 30;
                    if (player.Experiencia >= 300) player.Experiencia -= 300;
                    else player.Experiencia = 0;
                    if (player.VidaJugador > 50) player.VidaJugador -= 50;
                    if (player.Hambre > 10) player.Hambre -= 8;
                    FormPrincipal formPrincipal = new FormPrincipal(player);
                    this.Close();
                    formPrincipal.Show();
                }
                else
                {
                    player.Monedas += 100;
                    if (player.Experiencia >= 300) player.Experiencia -= 300;
                    else player.Experiencia = 0;
                    ObtenerObjeto();
                }
            }else if(player.Experiencia < 150)
            {
                MessageBox.Show("Te han atrapado, Te quitaron todos tus items y estarás encerrado por 30 días.");
                player.PerderTodo();
                player.Dia += 30;
                player.Experiencia = 0;
                if (player.VidaJugador > 50) player.VidaJugador -= 50;
                if (player.Hambre > 10) player.Hambre -= 8;
                FormPrincipal formPrincipal = new FormPrincipal(player);
                this.Close();
                formPrincipal.Show();
            }
            
        }

        private void btnCalle_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int numrandom = num.Next(1, 6);
            if (player.Experiencia >= 40)
            {
                if(numrandom == 1) 
                {
                    MessageBox.Show("Te han atrapado, Te quitaron todos tus items y estarás encerrado por 10 días.");
                    player.PerderTodo();
                    player.Dia += 10;
                    if (player.Experiencia >= 80) player.Experiencia -= 80;
                    else player.Experiencia = 0;
                    if (player.VidaJugador > 30) player.VidaJugador -= 20;
                    if (player.Hambre > 8) player.Hambre -= 6;
                    FormPrincipal formPrincipal = new FormPrincipal(player);
                    this.Close();
                    formPrincipal.Show();
                }
                else
                {
                    if (player.Experiencia >= 80) player.Experiencia -= 80;
                    else player.Experiencia = 0;
                    player.Monedas += 10;
                    ObtenerObjeto();
                }
            }
            else if(player.Experiencia < 40)
            {
                MessageBox.Show("Te han atrapado, Te quitaron todos tus items y estarás encerrado por 10 días.");
                player.PerderTodo();
                player.Dia += 10;
                player.Experiencia = 0;
                if (player.VidaJugador > 30) player.VidaJugador -= 20;
                if (player.Hambre > 8) player.Hambre -= 6;
                FormPrincipal formPrincipal = new FormPrincipal(player);
                this.Close();
                formPrincipal.Show();
                
            }
        }

        private void btnCaballo_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int numrandom = num.Next(1, 5);
            if (player.Experiencia >= 100 && player.Caballo == false)
            {
                if (numrandom == 1)
                {
                    MessageBox.Show("Te han atrapado, Te quitaron todos tus items y estarás encerrado por 10 días.");
                    player.PerderTodo();
                    player.Dia += 10;
                    if (player.Experiencia >= 200) player.Experiencia -= 200;
                    else player.Experiencia = 0;
                    if (player.VidaJugador > 30) player.VidaJugador -= 20;
                    if (player.Hambre > 8) player.Hambre -= 6;
                    FormPrincipal formPrincipal = new FormPrincipal(player);
                    this.Close();
                    formPrincipal.Show();
                }
                else
                {
                    if (player.Experiencia >= 200) player.Experiencia -= 200;
                    else player.Experiencia = 0;
                    player.Caballo = true;
                }
            }
            else if (player.Caballo == true) MessageBox.Show("ya tienes un caballo...");
            else if (player.Experiencia < 100)
            {
                MessageBox.Show("Te han atrapado, Te quitaron todos tus items y estarás encerrado por 10 días.");
                player.PerderTodo();
                player.Dia += 10;
                player.Experiencia = 0;
                if (player.VidaJugador > 30) player.VidaJugador -= 20;
                if (player.Hambre > 8) player.Hambre -= 6;
                FormPrincipal formPrincipal = new FormPrincipal(player);
                this.Close();
                formPrincipal.Show();
            }
        }
    }
}
