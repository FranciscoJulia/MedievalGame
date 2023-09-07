using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoMedieval1._0
{
    internal partial class FormComerciar : Form
    {
        Jugador player;
        public FormComerciar(Jugador player)
        {
            InitializeComponent();
            this.player = player;
        }

        private void FormComerciar_Load(object sender, EventArgs e)
        {
            //Muestra vida
            pbVida.Value = player.VidaJugador;
            lblMuestraVida.Text = $"{player.VidaJugador}/100";

            //Muestra Monedas y xp
            lblCantMonedas.Text = $"{player.Monedas} monedas";
            lblCantExperiencia.Text = $"{player.Experiencia} experiencia";

            //Muestra el día...
            lblcantDias.Text = $"Día {player.Dia}";

            //Agrega items a tienda lista objetos
            lbComprarObjetos.Items.Clear();
            lbComprarObjetos.Items.Add(player.AddTiendaEspadaHierro());
            lbComprarObjetos.Items.Add(player.AddTiendaEspadaAcero());
            lbComprarObjetos.Items.Add(player.AddTiendaArmCuero());
            lbComprarObjetos.Items.Add(player.AddTiendaArmMalla());
            lbComprarObjetos.Items.Add(player.AddTiendaCaballo());
            lbComprarObjetos.Items.Add(player.AddTiendaPocVida());

            //Agrega items a tienda lista comidas
            lbComprarComida.Items.Clear();
            lbComprarComida.Items.Add(player.AddTiendaPan());
            lbComprarComida.Items.Add(player.AddTiendaFruta());
            lbComprarComida.Items.Add(player.AddTiendaCarne());


            //Agrega tus items a la lista vender
            lbVender.Items.Clear();

            if (player.TieneEspada == true)
            {
                if (player.EspadaHierro == true) lbVender.Items.Add(player.addEspadaHierro());
                if (player.EspadaAcero == true) lbVender.Items.Add(player.addEspadaAcero());
            }
            if (player.TieneArmadura == true)
            {
                if (player.ArmaduraCuero == true) lbVender.Items.Add(player.addArmaduraCuero());
                if (player.ArmaduraMalla == true) lbVender.Items.Add(player.addArmaduraMalla());
            }
            if (player.Caballo == true)
            {
                lbVender.Items.Add(player.AddTiendaCaballo());
            }


            //Agrega items a la lista Tu comida
            lbTuComida.Items.Clear();

            if (player.TieneComida == true)
            {
                if (player.TienePan == true) lbTuComida.Items.Add($"Pan: {player.CantPan}");
                if (player.TieneFruta == true) lbTuComida.Items.Add($"Fruta: {player.CantFruta}");
                if (player.TieneCarne == true) lbTuComida.Items.Add($"Carne: {player.CantCarne}");
                if (player.TienePocVida == true) lbTuComida.Items.Add($"Poción vida: {player.CantPocVida}");
            }


        }

        private void lbComprarComida_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if ((string)lbComprarComida.SelectedItem == "Pan")
            {
                lbComprarObjetos.SelectedItem = null;
                lblMuestraPrecio.Text = "Precio: 5 monedas";
                pbObjetos.BackgroundImage = Properties.Resources.pan;
                pbObjetos.Visible = true;
                lblMuestraPrecio.Visible = true;
                lblInfo1.Text = "+2 alimento";
                lblInfo1.Visible = true;
                lblInfo2.Visible = false;
                btnComprar.Enabled = true;
            }
            if ((string)lbComprarComida.SelectedItem == "Fruta")
            {
                lbComprarObjetos.SelectedItem = null;
                lblMuestraPrecio.Text = "Precio: 10 monedas";
                pbObjetos.BackgroundImage = Properties.Resources.fruta;
                pbObjetos.Visible = true;
                lblMuestraPrecio.Visible = true;
                lblInfo1.Text = "+1 alimento";
                lblInfo2.Text = "+3 vida";
                lblInfo1.Visible = true;
                lblInfo2.Visible = true;
                btnComprar.Enabled = true;
            }
            if ((string)lbComprarComida.SelectedItem == "Carne")
            {
                lbComprarObjetos.SelectedItem = null;
                lblMuestraPrecio.Text = "Precio: 20 monedas";
                pbObjetos.BackgroundImage = Properties.Resources.Carne;
                pbObjetos.Visible = true;
                lblMuestraPrecio.Visible = true;
                lblInfo1.Text = "+5 alimento";
                lblInfo2.Text = "+6 vida";
                lblInfo1.Visible = true;
                lblInfo2.Visible = true;
                btnComprar.Enabled = true;
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            //Compra comida
            if ((string)lbComprarComida.SelectedItem == "Pan")
            {
                if (player.Monedas >= 5)
                {
                    player.Monedas -= 5;
                    player.CantPan += 1;
                    player.TienePan = true;
                    player.TieneComida = true;
                }
                else if (player.Monedas < 5) MessageBox.Show("No tienes suficientes monedas.");
            }
            else if ((string)lbComprarComida.SelectedItem == "Fruta")
            {
                if (player.Monedas >= 10)
                {
                    player.Monedas -= 10;
                    player.CantFruta += 1;
                    player.TieneFruta = true;
                    player.TieneComida = true;
                }
                else if (player.Monedas < 10) MessageBox.Show("No tienes suficientes monedas.");
            }
            else if ((string)lbComprarComida.SelectedItem == "Carne")
            {
                if (player.Monedas >= 20)
                {
                    player.Monedas -= 20;
                    player.CantCarne += 1;
                    player.TieneCarne = true;
                    player.TieneComida = true;
                }
                else if (player.Monedas < 20) MessageBox.Show("No tienes suficientes monedas.");
            }

            //Compra objetos
            if ((string)lbComprarObjetos.SelectedItem == "Espada Hierro")
            {
                if (player.Monedas >= 40 && player.EspadaAcero == false)
                {
                    if (player.EspadaHierro) MessageBox.Show("ya tienes una espada de Hierro");
                    else if (player.EspadaHierro == false)
                    {
                        player.EspadaHierro = true;
                        player.TieneEspada = true;
                        player.Monedas -= 40;

                        lbVender.Items.Clear();
                        lbVender.Items.Add(player.AddTiendaEspadaHierro());

                        MessageBox.Show("Haz comprado una espada de Hierro!!");
                    }
                }
                else if (player.EspadaAcero == true) MessageBox.Show("Ya tienes una espada, si quieres cambiarla deberas venderla...");
                else if (player.Monedas < 40) MessageBox.Show("No tienes suficientes monedas.");
                
            }
            else if ((string)lbComprarObjetos.SelectedItem == "Espada Acero")
            {
                if (player.Monedas >= 70 && player.EspadaHierro == false)
                {
                    if (player.EspadaAcero) MessageBox.Show("ya tienes una espada de Acero");
                    else if (player.EspadaAcero == false)
                    {
                        player.EspadaAcero = true;
                        player.TieneEspada = true;
                        player.Monedas -= 70;

                        lbVender.Items.Clear();
                        lbVender.Items.Add(player.AddTiendaEspadaAcero());

                        MessageBox.Show("Haz comprado una espada de Acero!!");
                    }
                }
                else if (player.EspadaHierro == true) MessageBox.Show("Ya tienes una espada, si quieres cambiarla deberas venderla...");
                else if (player.Monedas < 70) MessageBox.Show("No tienes suficientes monedas.");
            }
            else if ((string)lbComprarObjetos.SelectedItem == "Arm. Cuero")
            {
                if (player.Monedas >= 120 && player.ArmaduraMalla == false)
                {
                    if (player.ArmaduraCuero) MessageBox.Show("Ya tienes una armadura de cuero.");
                    else if (player.ArmaduraCuero == false)
                    {
                        player.ArmaduraCuero = true;
                        player.TieneArmadura = true;
                        player.Monedas -= 120;

                        lbVender.Items.Clear();
                        lbVender.Items.Add(player.AddTiendaArmCuero());

                        MessageBox.Show("Haz comprado una armadura de cuero!!");
                    }
                }
                else if (player.ArmaduraMalla == true) MessageBox.Show("Ya tienes una armadura, si quieres cambiarla deberas venderla...");
                else if (player.Monedas < 120) MessageBox.Show("No tienes suficientes monedas.");
            }
            else if ((string)lbComprarObjetos.SelectedItem == "Arm. Malla")
            {
                if (player.Monedas >= 500 && player.ArmaduraCuero == false)
                {
                    if (player.ArmaduraMalla) MessageBox.Show("Ya tienes una armadura de cota de malla.");
                    else if (player.ArmaduraMalla == false)
                    {
                        player.ArmaduraMalla = true;
                        player.TieneArmadura = true;
                        player.Monedas -= 500;

                        lbVender.Items.Clear();
                        lbVender.Items.Add(player.AddTiendaArmMalla());

                        MessageBox.Show("Haz comprado una armadura de cota de malla!!");
                    }
                }
                else if (player.ArmaduraCuero == true) MessageBox.Show("Ya tienes una armadura, si quieres cambiarla deberas venderla...");
                else if (player.Monedas < 500) MessageBox.Show("No tienes suficientes monedas.");
            }
            else if ((string)lbComprarObjetos.SelectedItem == "Caballo")
            {
                if (player.Monedas >= 700 && player.Caballo == false)
                {
                    if (player.Caballo) MessageBox.Show("Ya tienes un caballo.");
                    else if (player.Caballo == false)
                    {
                        player.Caballo = true;
                        player.Monedas -= 700;

                        lbVender.Items.Clear();
                        lbVender.Items.Add(player.AddTiendaCaballo());

                        MessageBox.Show("Haz comprado un caballo!!");
                    }
                }
                else if (player.Monedas < 700) MessageBox.Show("No tienes suficientes monedas.");
            }
            else if ((string)lbComprarObjetos.SelectedItem == "Poción vida")
            {
                if (player.Monedas >= 120)
                {
                    player.Monedas -= 120;
                    player.CantPocVida += 1;
                    player.TienePocVida = true;
                }
                else if (player.Monedas < 120) MessageBox.Show("No tienes suficientes monedas.");
            }

            lbVender.Items.Clear();
            if (player.EspadaHierro == true) lbVender.Items.Add(player.AddTiendaEspadaHierro());
            if (player.EspadaAcero == true) lbVender.Items.Add(player.AddTiendaEspadaAcero());
            if (player.ArmaduraCuero == true) lbVender.Items.Add(player.AddTiendaArmCuero());
            if (player.ArmaduraMalla == true) lbVender.Items.Add(player.AddTiendaArmMalla());
            if (player.Caballo == true) lbVender.Items.Add(player.addCaballo());


            lbTuComida.Items.Clear();
            if (player.TienePan == true) lbTuComida.Items.Add($"Pan: {player.CantPan}");
            if (player.TieneFruta == true) lbTuComida.Items.Add($"Fruta: {player.CantFruta}");
            if (player.TieneCarne == true) lbTuComida.Items.Add($"Carne: {player.CantCarne}");
            if (player.TienePocVida == true) lbTuComida.Items.Add($"Poción vida: {player.CantPocVida}");

            //Actualiza monedas
            lblCantMonedas.Text = $"{player.Monedas} monedas";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal(player);
            formPrincipal.TopMost = true;
            Close();

            formPrincipal.Show();
        }

        private void lbComprarObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if ((string)lbComprarObjetos.SelectedItem == "Espada Hierro")
            {
                lbComprarComida.SelectedItem = null;
                lblMuestraPrecio.Text = "Precio: 40 monedas";
                pbObjetos.BackgroundImage = Properties.Resources.espadaHierro;
                pbObjetos.Visible = true;
                lblMuestraPrecio.Visible = true;
                lblInfo1.Text = "10 de daño";
                lblInfo1.Visible = true;
                lblInfo2.Visible = false;
                btnComprar.Enabled = true;
            }
            if ((string)lbComprarObjetos.SelectedItem == "Espada Acero")
            {
                lbComprarComida.SelectedItem = null;
                lblMuestraPrecio.Text = "Precio: 70 monedas";
                pbObjetos.BackgroundImage = Properties.Resources.espadaAcero;
                pbObjetos.Visible = true;
                lblMuestraPrecio.Visible = true;
                lblInfo1.Text = "20 de daño";
                lblInfo1.Visible = true;
                lblInfo2.Visible = false;
                btnComprar.Enabled = true;
            }
            if ((string)lbComprarObjetos.SelectedItem == "Arm. Malla")
            {
                lbComprarComida.SelectedItem = null;
                lblMuestraPrecio.Text = "Precio: 500 monedas";
                pbObjetos.BackgroundImage = Properties.Resources.armaduraMalla;
                pbObjetos.Visible = true;
                lblMuestraPrecio.Visible = true;
                lblInfo1.Text = "+100 de vida";
                lblInfo1.Visible = true;
                lblInfo2.Visible = false;
                btnComprar.Enabled = true;
            }
            if ((string)lbComprarObjetos.SelectedItem == "Arm. Cuero")
            {
                lbComprarComida.SelectedItem = null;
                lblMuestraPrecio.Text = "Precio: 120 monedas";
                pbObjetos.BackgroundImage = Properties.Resources.armaduraCuero;
                pbObjetos.Visible = true;
                lblMuestraPrecio.Visible = true;
                lblInfo1.Text = "+30 de vida";
                lblInfo1.Visible = true;
                lblInfo2.Visible = false;
                btnComprar.Enabled = true;
            }
            if ((string)lbComprarObjetos.SelectedItem == "Caballo")
            {
                lbComprarComida.SelectedItem = null;
                lblMuestraPrecio.Text = "Precio: 700 monedas";
                pbObjetos.BackgroundImage = Properties.Resources.caballo;
                pbObjetos.Visible = true;
                lblMuestraPrecio.Visible = true;
                lblInfo1.Text = "+Explorar";
                lblInfo1.Visible = true;
                btnComprar.Enabled = true;
            }
            if ((string)lbComprarObjetos.SelectedItem == "Poción vida")
            {
                lbComprarComida.SelectedItem = null;
                lblMuestraPrecio.Text = "Precio: 120 monedas";
                pbObjetos.BackgroundImage = Properties.Resources.pocVida;
                pbObjetos.Visible = true;
                lblMuestraPrecio.Visible = true;
                lblInfo1.Text = "+40 vida";
                lblInfo1.Visible = true;
                btnComprar.Enabled = true;
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            //Vender objetos
            if ((string)lbVender.SelectedItem == "Espada Hierro")
            {
                player.EspadaHierro = false;
                if(player.EspadaAcero == true) player.TieneEspada = true;
                else player.TieneEspada = false;

                player.Monedas += 20;

                MessageBox.Show("Haz ventido tu espada de Hierro!!");
            }
            else if ((string)lbVender.SelectedItem == "Espada Acero")
            {
                player.EspadaAcero = false;
                if (player.EspadaHierro == true) player.TieneEspada = true;
                else player.TieneEspada = false;

                player.Monedas += 35;

                MessageBox.Show("Haz ventido tu espada de Acero!!");
            }
            else if ((string)lbVender.SelectedItem == "Arm. Cuero")
            {
                player.ArmaduraCuero = false;
                if (player.ArmaduraCuero == true) player.TieneArmadura = true;
                else player.TieneArmadura = false;

                player.Monedas += 60;

                MessageBox.Show("Haz ventido tu armadura de Cuero!!");
            }
            else if ((string)lbVender.SelectedItem == "Arm. Malla")
            {
                player.ArmaduraMalla = false;
                if (player.ArmaduraMalla == true) player.TieneArmadura = true;
                else player.TieneArmadura = false;

                player.Monedas += 200;

                MessageBox.Show("Haz ventido tu armadura de cota de malla!!");
            }
            else if ((string)lbVender.SelectedItem == "Caballo")
            {
                player.Caballo = false;

                player.Monedas += 250;

                MessageBox.Show("Haz ventido tu caballo!!");
            }

            //ACtualiza items
            lbVender.Items.Clear();
            if (player.EspadaHierro == true) lbVender.Items.Add(player.AddTiendaEspadaHierro());
            if (player.EspadaAcero == true) lbVender.Items.Add(player.AddTiendaEspadaAcero());
            if (player.ArmaduraCuero == true) lbVender.Items.Add(player.AddTiendaArmCuero());
            if (player.ArmaduraMalla == true) lbVender.Items.Add(player.AddTiendaArmMalla());
            if (player.Caballo == true) lbVender.Items.Add(player.AddTiendaCaballo());

            pbVender.Visible = false;
            lblPrecioVenta.Visible = false;
            btnVender.Enabled = false;

            //Actualiza monedas
            lblCantMonedas.Text = $"{player.Monedas} monedas";

        }

        private void lbVender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)lbVender.SelectedItem == "Espada Hierro")
            {
                lblPrecioVenta.Text = "+20 monedas";
                pbVender.BackgroundImage = Properties.Resources.espadaHierro;
                pbVender.Visible = true;
                lblPrecioVenta.Visible = true;
                btnVender.Enabled = true;
            }
            if ((string)lbVender.SelectedItem == "Espada Acero")
            {
                lblPrecioVenta.Text = "+35 monedas";
                pbVender.BackgroundImage = Properties.Resources.espadaAcero;
                pbVender.Visible = true;
                lblPrecioVenta.Visible = true;
                btnVender.Enabled = true;
            }
            if ((string)lbVender.SelectedItem == "Arm. Cuero")
            {
                lblPrecioVenta.Text = "+60 monedas";
                pbVender.BackgroundImage = Properties.Resources.armaduraCuero;
                pbVender.Visible = true;
                lblPrecioVenta.Visible = true;
                btnVender.Enabled = true;
            }
            if ((string)lbVender.SelectedItem == "Arm. Malla")
            {
                lblPrecioVenta.Text = "+200 monedas";
                pbVender.BackgroundImage = Properties.Resources.armaduraMalla;
                pbVender.Visible = true;
                lblPrecioVenta.Visible = true;
                btnVender.Enabled = true;
            }
            if ((string)lbVender.SelectedItem == "Caballo")
            {
                lblPrecioVenta.Text = "+250 monedas";
                pbVender.BackgroundImage = Properties.Resources.caballo;
                pbVender.Visible = true;
                lblPrecioVenta.Visible = true;
                btnVender.Enabled = true;
            }
        }

        private void lbTuComida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
