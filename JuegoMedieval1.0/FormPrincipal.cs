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
    internal partial class FormPrincipal : Form
    {
        Jugador player;
        public FormPrincipal(Jugador player)
        {
            InitializeComponent();
            this.player = player;

        }



        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lblNombre.Text = player.Nombre;
            rtbDescripcion.Visible = false;

            //Muestra vida
            pbVida.Value = player.VidaJugador;
            lblMuestraVida.Text = $"{player.VidaJugador}/100";

            //Muestra hambre
            pbhambre.Value = player.Hambre;
            lblMuestraHambre.Text = $"{player.Hambre}/20";

            //Muestra Monedas y xp
            lblCantMonedas.Text = $"{player.Monedas} monedas";
            lblCantExperiencia.Text = $"{player.Experiencia} experiencia";

            //Muestra el día
            lblcantDias.Text = $"Día {player.Dia}";

            //Agrega items a las listas comida y objetos
            lbObjetos.Items.Clear();

            if (player.TieneEspada == true)
            {
                if (player.EspadaHierro == true) lbObjetos.Items.Add(player.addEspadaHierro());
                if (player.EspadaAcero == true) lbObjetos.Items.Add(player.addEspadaAcero());
            }
            if (player.TieneArmadura == true)
            {
                if (player.ArmaduraCuero == true) lbObjetos.Items.Add(player.addArmaduraCuero());
                if (player.ArmaduraMalla == true) lbObjetos.Items.Add(player.addArmaduraMalla());
            }
            if(player.Caballo == true)
            {
                lbObjetos.Items.Add(player.addCaballo());
            }
            if(player.TienePocVida == true)
            {
                lbObjetos.Items.Add($"Poción vida: {player.CantPocVida}");
            }

            lbComida.Items.Clear();

            if (player.TieneComida == true)
            {
                if (player.TienePan == true) lbComida.Items.Add($"Pan: {player.CantPan}");
                if (player.TieneFruta == true) lbComida.Items.Add($"Fruta: {player.CantFruta}");
                if (player.TieneCarne == true) lbComida.Items.Add($"Carne: {player.CantCarne}");
            }

        }


        public void DescripcionObjetos(Jugador player)
        {
            rtbDescripcion.Text = lbObjetos.SelectedItem.ToString();
        }

        private void lbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)lbObjetos.SelectedItem == "Espada Hierro") 
            {
                rtbDescripcion.Text = player.DescHierro();
                pbObjetos.BackgroundImage = Properties.Resources.espadaHierro;
                pbObjetos.Visible = true;
                btnUsar.Visible = false;
            }
            if ((string)lbObjetos.SelectedItem == "Espada Acero") 
            { 
                rtbDescripcion.Text = player.DescAcero();
                pbObjetos.BackgroundImage = Properties.Resources.espadaAcero;
                pbObjetos.Visible = true;
                btnUsar.Visible = false;
            }
            if ((string)lbObjetos.SelectedItem == "Arm. Cuero")
            {
                rtbDescripcion.Text = player.DescArmCuero();
                pbObjetos.BackgroundImage = Properties.Resources.armaduraCuero;
                pbObjetos.Visible = true;
                btnUsar.Visible = false;
            }
            if ((string)lbObjetos.SelectedItem == "Arm. Malla")
            {
                rtbDescripcion.Text = player.DescArmMalla();
                pbObjetos.BackgroundImage = Properties.Resources.armaduraMalla;
                pbObjetos.Visible = true;
                btnUsar.Visible = false;
            }
            if ((string)lbObjetos.SelectedItem == "Caballo")
            {
                rtbDescripcion.Text = player.DescCaballo();
                pbObjetos.BackgroundImage = Properties.Resources.caballo;
                pbObjetos.Visible = true;
                btnUsar.Visible = false;
            }
            if ((string)lbObjetos.SelectedItem == $"Poción vida: {player.CantPocVida}")
            {
                rtbDescripcion.Text = player.DescPocVida();
                pbObjetos.BackgroundImage = Properties.Resources.pocVida;
                pbObjetos.Visible = true;
                btnUsar.Visible = true;
            }
            rtbDescripcion.Visible = true;
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

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            FormTrabajar formTrabajar = new FormTrabajar(player);
            this.Close();
            formTrabajar.ShowDialog();
        }


        public void btnActualizar_Click(object sender, EventArgs e)
        {
            //Muestra vida
            pbVida.Value = player.VidaJugador;
            lblMuestraVida.Text = player.VidaJugador.ToString();

            //Muestra hambre
            pbhambre.Value = player.Hambre;
            lblMuestraHambre.Text = player.Hambre.ToString();

            //Muestra Monedas y xp
            lblCantMonedas.Text = $"{player.Monedas} monedas";
            lblCantExperiencia.Text = $"{player.Experiencia} experiencia";

            //Muestra el día...
            lblcantDias.Text = $"Día {player.Dia}";

            if (player.TieneEspada == true)
            {
                if (player.EspadaHierro == true) lbObjetos.Items.Add(player.addEspadaHierro());
                if (player.EspadaAcero == true) lbObjetos.Items.Add(player.addEspadaAcero());
            }
            if (player.TieneArmadura == true)
            {
                if (player.ArmaduraCuero == true) lbObjetos.Items.Add(player.addArmaduraCuero());
                if (player.ArmaduraMalla == true) lbObjetos.Items.Add(player.addArmaduraMalla());
            }
            if (player.Caballo == true)
            {
                lbObjetos.Items.Add(player.addCaballo());
            }
            if (player.TienePocVida == true)
            {
                lbObjetos.Items.Add($"Poción vida: {player.CantPocVida}");
            }

            lbComida.Items.Clear();

            if (player.TieneComida == true)
            {
                if (player.TienePan == true) lbComida.Items.Add($"Pan: {player.CantPan}");
                if (player.TieneFruta == true) lbComida.Items.Add($"Fruta: {player.CantFruta}");
                if (player.TieneCarne == true) lbComida.Items.Add($"Carne: {player.CantCarne}");
            }
        }

        private void btnUsar_Click(object sender, EventArgs e)
        {
            if (player.cantPocVida > 0) player.UsarPocVida();
            else MessageBox.Show("No tienes pociones de vida...");
            if (player.TienePocVida == true)
            {
                lbObjetos.Items.Add($"Poción vida: {player.CantPocVida}");
            }
            btnUsar.Visible = false;

        }

        private void pbInfo_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();
        }

        private void lbComida_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnComer.Location = new Point(18, 497);
            if ((string)lbComida.SelectedItem == $"Pan: {player.CantPan}") 
            {
                rtbDescComida.Text = $"{player.DescPan()}";
                pbComidas.BackgroundImage = Properties.Resources.pan;
                pbComidas.Visible = true;
            }
            if ((string)lbComida.SelectedItem == $"Fruta: {player.CantFruta}") 
            {
                rtbDescComida.Text = $"{player.DescFruta()}";
                pbComidas.BackgroundImage = Properties.Resources.fruta;
                pbComidas.Visible = true;
            }
            if ((string)lbComida.SelectedItem == $"Carne: {player.CantCarne}")
            {
                rtbDescComida.Text = $"{player.DescCarne()}";
                pbComidas.BackgroundImage = Properties.Resources.Carne;
                pbComidas.Visible = true;
            }

            rtbDescComida.Visible = true;
        }

        private void btnComer_Click(object sender, EventArgs e)
        {
            if ((string)lbComida.SelectedItem == $"Pan: {player.CantPan}")
            {
                player.Comer("Pan");
                pbhambre.Value = player.Hambre;
                lblMuestraHambre.Text = player.Hambre.ToString();

                lbComida.Items.Clear();

                if (player.TieneComida == true)
                {
                    ActComida();
                }
                lbComida.SelectedIndex = 0;
            }

            else if ((string)lbComida.SelectedItem == $"Fruta: {player.CantFruta}")
            {
                player.Comer("Fruta");

                pbhambre.Value = player.Hambre;
                lblMuestraHambre.Text = player.Hambre.ToString();

                pbVida.Value = player.VidaJugador;
                lblMuestraVida.Text = $"{player.VidaJugador}/100";

                lbComida.Items.Clear();

                if (player.TieneComida == true)
                {
                    ActComida();
                }
                if (player.TienePan) lbComida.SelectedIndex = 1;
                else lbComida.SelectedIndex = 0;
         
            }

            else if ((string)lbComida.SelectedItem == $"Carne: {player.CantCarne}")
            {
                player.Comer("Carne");

                pbhambre.Value = player.Hambre;
                lblMuestraHambre.Text = player.Hambre.ToString();

                pbVida.Value = player.VidaJugador;
                lblMuestraVida.Text = $"{player.VidaJugador}/100";

                lbComida.Items.Clear();

                if (player.TieneComida == true)
                {
                    ActComida();
                }
                if (player.TienePan && player.TieneFruta) lbComida.SelectedIndex = 2;
                else if (player.TieneFruta || player.TienePan) lbComida.SelectedIndex = 1;
                else lbComida.SelectedIndex = 0;
            }
            else MessageBox.Show("No has seleccionado ninguna comida...");
        }

        public void ActComida()
        {
            if (player.TienePan == true) lbComida.Items.Add($"Pan: {player.CantPan}");
            if (player.TieneFruta == true) lbComida.Items.Add($"Fruta: {player.CantFruta}");
            if (player.TieneCarne == true) lbComida.Items.Add($"Carne: {player.CantCarne}");
        }


        private void btnComerciar_Click(object sender, EventArgs e)
        {
            FormComerciar formComerciar = new FormComerciar(player);
            Close();
            formComerciar.ShowDialog();
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            FormExplorar formExplorar = new FormExplorar(player);
            Close();
            formExplorar.ShowDialog();  
        }

        private void btnPasarDia_Click(object sender, EventArgs e)
        {
            if (player.Hambre == 0)
            {
                player.CaminO = 0;
                player.Dia += 1;
                player.VidaJugador -= 50;
                player.TrabajO = 0;
            }
            else
            {
                player.CaminO = 0;
                player.Dia += 1;
                player.Hambre -= 6;
                player.TrabajO = 0;
            }

            

            //Actualiza día 
            lblcantDias.Text = $"Día {player.Dia}";

            //Actualiza hambre
            pbhambre.Value = player.Hambre;
            lblMuestraHambre.Text = $"{player.Hambre}/20";

            //Actualiza vida
            pbVida.Value = player.VidaJugador;
            lblMuestraVida.Text = $"{player.VidaJugador}/100";
        }

        
    }
}
