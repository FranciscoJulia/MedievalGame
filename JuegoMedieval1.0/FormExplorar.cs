using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoMedieval1._0
{
    internal partial class FormExplorar : Form
    {
        Jugador player;
        public FormExplorar(Jugador player)
        {
            InitializeComponent();
            this.player = player;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal(player);
            formPrincipal.TopMost = true;
            Close();

            formPrincipal.Show();
        }

        private void FormExplorar_Load(object sender, EventArgs e)
        {
            rtbPrincipal.Font = new Font("Perpetua", 16);
            rtbPrincipal.Text = "!!Haz salido a explorar¡¡";
            rtbFondo.Text = "         \n             a";

            rtbDescripcion.Visible = false;

            Actualizar();

            if(player.Caballo == false) btnCaballo.Enabled = false;

            btnDormir.Enabled = true;
            btnCaminar.Enabled = true;
            btnUsar.BringToFront();
        }

        private void Actualizar()
        {
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
                ActComida();
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
            }
            if ((string)lbObjetos.SelectedItem == "Espada Acero")
            {
                rtbDescripcion.Text = player.DescAcero();
                pbObjetos.BackgroundImage = Properties.Resources.espadaAcero;
                pbObjetos.Visible = true;
            }
            if ((string)lbObjetos.SelectedItem == "Arm. Cuero")
            {
                rtbDescripcion.Text = player.DescArmCuero();
                pbObjetos.BackgroundImage = Properties.Resources.armaduraCuero;
                pbObjetos.Visible = true;
            }
            if ((string)lbObjetos.SelectedItem == "Arm. Malla")
            {
                rtbDescripcion.Text = player.DescArmMalla();
                pbObjetos.BackgroundImage = Properties.Resources.armaduraMalla;
                pbObjetos.Visible = true;
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
        public void ActComida()
        {
            if (player.TienePan == true) lbComida.Items.Add($"Pan: {player.CantPan}");
            if (player.TieneFruta == true) lbComida.Items.Add($"Fruta: {player.CantFruta}");
            if (player.TieneCarne == true) lbComida.Items.Add($"Carne: {player.CantCarne}");
        }
        private void lbComida_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnComer.Location = new Point(25, 454);
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
            pbComidas.Visible = false;
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

        private void rtbPrincipal_EnabledChanged(object sender, EventArgs e)
        {

        }


        //Posibilidad ladron (1)
        public void ExpLadron()
        {
            btnDarArmadura.BringToFront();
            btnPelearArmadura.BringToFront();
            if (player.TieneArmadura == true)
            {
                rtbPrincipal.Text = "Estás caminando pero hasta el momento no has encontrado nada interesante...\nSe acercaron 2 personas a ti pidiendote que les des tu armadura. \n¿Dar armadura o pelear?";
                btnPelearArmadura.Visible = true;
                btnDarArmadura.Visible = true;
            }
            else
            {
                btnCaminar.Enabled = true;
                rtbPrincipal.Text = "Estás caminando pero hasta el momento no has encontrado nada interesante...\nSe acercaron 2 personas a robarte, pero tuvieron piedad por si, esta vez te salvaste...";
            }
        }
        public string PerderArmadura1()
        {
            return "Estás caminando pero hasta el momento no has encontrado nada interesante...\nSe acercaron 2 personas y te pidieron que les des tu armadura. \n¿Dar armadura o pelear?\nTe han robado la armadura :c";
        }
        public string NoPerderArmadura()
        {
            return "Estás caminando pero hasta el momento no has encontrado nada interesante...\nSe acercaron 2 personas y te pidieron que les des tu armadura. \n¿Dar armadura o pelear?\nHas peleado y haz conseguido que no te roben :D!!";
        }
        private void btnDarArmadura_Click(object sender, EventArgs e)
        {
            if (player.TieneArmadura == true)
            {
                player.TieneArmadura = false;
                player.ArmaduraCuero = false;
                player.ArmaduraMalla = false;
            }

            rtbPrincipal.Text = PerderArmadura1();
            btnCaminar.Enabled = true;
            btnDarArmadura.Visible = false;
            btnPelearArmadura.Visible = false;
            Actualizar();
        }
        private void btnPelearArmadura_Click(object sender, EventArgs e)
        {
            int peleaRandom = numRandom.Next(1, 5);
            if (player.EspadaHierro == true)
            {
                if (peleaRandom == 1)
                {
                    rtbPrincipal.Text = NoPerderArmadura();
                    player.VidaJugador -= 40;
                }
                else
                {
                    player.TieneArmadura = false;
                    player.ArmaduraCuero = false;
                    player.ArmaduraMalla = false;
                    rtbPrincipal.Text = "Estás caminando pero hasta el momento no has encontrado nada interesante...\nSe acercaron 2 personas y te pidieron que les des tu armadura. \n¿Dar armadura o pelear?\nTe han robado la armadura :c";
                    player.VidaJugador -= 60;
                } 
            }else if (player.EspadaAcero == true)
            {
                if (peleaRandom >= 1 && peleaRandom <= 3)
                {
                    rtbPrincipal.Text = NoPerderArmadura();
                    player.VidaJugador -= 30;
                }
                else
                {
                    PerderArmadura1();
                    player.VidaJugador -= 60;
                }
            }
            else
            {
                player.TieneArmadura = false;
                player.ArmaduraCuero = false;
                player.ArmaduraMalla = false;
                rtbPrincipal.Text = "Estás caminando pero hasta el momento no has encontrado nada interesante...\nSe acercaron 2 personas y te pidieron que les des tu armadura. \n¿Dar armadura o pelear?\nTe han robado la armadura :c";
                player.VidaJugador -= 90;
            }
            btnCaminar.Enabled = true;
            btnDarArmadura.Visible = false;
            btnPelearArmadura.Visible = false;
            player.Experiencia += 100;
            Actualizar();
        }

        //Exp Dragon
        private int vidaDragon;
        public void ExpDragon2(int vida)
        {
            vidaDragon = vida;
            btnNo.BringToFront();
            btnPelear.BringToFront();
            btnNo.Visible = true;
            btnPelear.Visible = true;
            rtbPrincipal.Text = $"Te diriges hacia las montañas\nA lo lejos visualizas un dragón, no parece muy poderoso, dependera de tu equipamento.\nVida dragón: {vidaDragon}\n¿Quieres pelear?";
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            rtbPrincipal.Text = $"Te diriges hacia las montañas\nA lo lejos visualizas un dragón, no parece muy poderoso y tienes buen equipamento.\nVida dragón: {vidaDragon}\n¿Quieres pelear?\nHas huído";
            btnCaminar.Enabled = true;
            btnPelear.Visible = false;
            btnNo.Visible = false;
        }

        private void btnPelear_Click(object sender, EventArgs e)
        {
            if(player.EspadaAcero == true && player.ArmaduraMalla == true)
            {
                player.VidaJugador -= 30;
                if(player.VidaJugador > 0)
                    rtbPrincipal.Text = $"Te diriges hacia las montañas\nA lo lejos visualizas un dragón, no parece muy poderoso y tienes buen equipamento.\nVida dragón: {vidaDragon}\n¿Quieres pelear?\nHas conseguido acabar con el dragón y obtuviste: +1 Cabeza de dragón";
                player.Experiencia += 200;
            }
            else if(player.TieneArmadura == false || player.TieneEspada == false)
            {
                player.VidaJugador -= 101;
                rtbPrincipal.Text = $"Te diriges hacia las montañas\nA lo lejos visualizas un dragón, no parece muy poderoso y tienes buen equipamento.\nVida dragón: {vidaDragon}\n¿Quieres pelear?\nHas muerto, deberías haberte equipado mejor...";
            }else
            {
                player.VidaJugador -= 50;
                if (player.VidaJugador > 0)
                {
                    rtbPrincipal.Text = $"Te diriges hacia las montañas\nA lo lejos visualizas un dragón, no parece muy poderoso y tienes buen equipamento.\nVida dragón: {vidaDragon}\n¿Quieres pelear?\nHas conseguido matar al dragón por los pelos";
                    player.Experiencia += 100;
                }
            }

            btnPelear.Visible = false;
            btnNo.Visible = false;
            btnCaminar.Enabled = true;

            Actualizar();
        }

        public void ExpComerciante()
        {
            //Falta agregar más items
        }

        Random numRandom = new Random();
        private void btnCaminar_Click(object sender, EventArgs e)
        {
            EnableBtn();
            if (player.CaminO < 2)
            {
                VisibilidadBotones();
                
                int pos = numRandom.Next(1, 12);

                if (pos == 1)
                {
                    ExpLadron();
                    player.Hambre -= 3;
                    Actualizar();
                }
                else if (pos == 2)
                {
                    ExpDragon2(300);
                    player.Hambre -= 5;
                    Actualizar();
                }
                else if (pos == 3)
                {
                    pos = numRandom.Next(3, 8);
                    rtbPrincipal.Text = $"Te metiste al bosque y viste una planta con frutas\nObtuviste +{pos} frutas!!";
                    player.TieneComida = true;
                    player.TieneFruta = true;
                    player.CantFruta += (short)pos;
                    Actualizar();

                }
                else if(pos == 4)
                {
                    rtbPrincipal.Text = "Parece que te has perdido...\nPasaste la noche afuera..\n - 20 vida";
                    player.VidaJugador -= 20;
                    player.Dia += 1;
                    player.CaminO = 0;
                    Actualizar();

                }
                else if (pos == 5)
                {
                    rtbPrincipal.Text = "Estabas explorando y empezó una gran tormenta...\nBuscaste refugio y encontraste una cueva..\nTienes frío\n - 10 vida\nLa tormenta acabó, regresaste a casa.";
                    player.VidaJugador -= 10;
                    Actualizar();

                }
                else if(pos == 6)
                {
                    EnableBtn();
                    btnAyudar.Visible = true;
                    btnAyudar.BringToFront();
                    btnRobar.Visible = true;
                    btnRobar.BringToFront();
                    rtbPrincipal.Text = "Te metes al bosque y en un camino te encuentras una persona en el suelo pidiendo ayuda.\n¿La ayudaras?";
                    Actualizar();
                }
                else if(pos == 7)
                {
                    if(player.Monedas >= 1)
                    {
                        EnableBtn();
                        btnLanzar.Visible = true;
                        btnLanzar.BringToFront();
                        btnNo2.Visible = true;
                        btnNo2.BringToFront();
                        rtbPrincipal.Text = "Apenas sales te encuentras un pozo de los deseos!!\n¿Lanzar una moneda?";
                    }
                    else rtbPrincipal.Text = "Apenas sales te encuentras un pozo de los deseos!!\nPero no tienes monedas :c";
                    Actualizar();

                }
                else if(pos == 8)
                {
                    rtbPrincipal.Text = "Se te ocurrio ir hacia las montañas, explorando te encuentras un buen señor que te quiere regalar una poción de vida.\n+1 Poción vida";
                    player.TienePocVida = true;
                    player.CantPocVida++;
                    Actualizar();
                }
                else if(pos == 9)
                {
                    rtbPrincipal.Text = "Diste una gran vuelta por las montañas y por el bosque, no encontraste nada interesante.";
                    player.Hambre -= 3;
                    Actualizar();
                }
                else if(pos == 10)
                {
                    rtbPrincipal.Text = "A la salida del pueblo te encontraste un pan tirado, lo comiste pero al poco tiempo empezaste a sentir dolores, parece que estaba evenenado.\n-10 vida";
                    player.VidaJugador -= 10;
                    Actualizar();
                }
                else if(pos == 11)
                {
                    EnableBtn();
                    btnDerecha.BringToFront();
                    btnIzquierda.BringToFront();
                    btnDerecha.Visible = true;
                    btnIzquierda.Visible = true;
                    rtbPrincipal.Text = "Estuviste caminando por un camino en el bosque y se divide en dos.\n¿Hacia donde quieres ir?";
                }
                else if(pos == 12)
                {

                }

                
            }
            else MessageBox.Show("Necesitas descansar... Ve a dormir");
            player.CaminO++;
            if(player.Caballo == true) btnCaballo.Enabled = true;
            btnCaminar.Enabled = true;
            btnDormir.Enabled = true;
        }
        public void EnableBtn()
        {
            btnCaballo.Enabled = false;
            btnCaminar.Enabled = false;
            btnDormir.Enabled = false;
        }

        //POS 11
        private void btnDerecha_Click(object sender, EventArgs e)
        {
            rtbPrincipal.Text = "Estuviste caminando por un camino en el bosque y se divide en dos.\n¿Hacia donde quieres ir?\nNo encontraste nada...";
            Actualizar();
            VisibilidadBotones();
        }
        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            int numR = numRandom.Next(1, 10);
            rtbPrincipal.Text = $"Estuviste caminando por un camino en el bosque y se divide en dos.\n¿Hacia donde quieres ir?\nEncontraste unas monedas tiradas!!!\n+{numR} monedas";
            player.Monedas += numR;
            Actualizar();
            VisibilidadBotones();
        }

        //POS 7
        private void btnLanzar_Click(object sender, EventArgs e)
        {
            rtbPrincipal.Text = "Apenas sales te encuentras un pozo de los deseos!!\n¿Lanzar una moneda?\nLanzaste la moneda, tal vez se cumplan tus deseos.";
            player.Monedas -= 1;
            Actualizar();
            VisibilidadBotones();
        }
        private void btnNo2_Click(object sender, EventArgs e)
        {
            rtbPrincipal.Text = "Apenas sales te encuentras un pozo de los deseos!!\n¿Lanzar una moneda?\nTe ahorraste una moneda...";
            VisibilidadBotones();
        }

        //POS 6
        private void btnAyudar_Click(object sender, EventArgs e)
        {
            int random = numRandom.Next(5, 70);
            rtbPrincipal.Text = $"Te metes al bosque y en un camino te encuentras una persona en el suelo pidiendo ayuda.\n¿La ayudaras?\nAyudaste a la persona a regresar al pueblo.\nComo recompensa te dió {random} monedas.";
            player.Monedas += random;
            Actualizar();
            VisibilidadBotones();
        }
        private void btnRobar_Click(object sender, EventArgs e)
        {
            int random = numRandom.Next(1, 20);
            rtbPrincipal.Text = $"Te metes al bosque y en un camino te encuentras una persona en el suelo pidiendo ayuda.\n¿La ayudaras?\nLe robaste {random} monedas...\n-20 experiencia";
            player.Monedas += random;
            if (player.Experiencia >= 20) player.Experiencia -= 20;
            else player.Experiencia = 0;
            Actualizar();
            VisibilidadBotones();
        }

        public void VisibilidadBotones()
        {
            btnDarArmadura.Visible = false;
            btnPelearArmadura.Visible = false;
            btnNo.Visible = false;
            btnPelear.Visible = false;
            btnAyudar.Visible = false;
            btnRobar.Visible = false;
            btnLanzar.Visible = false;
            btnNo2.Visible = false;
            btnIzquierda.Visible = false;
            btnDerecha.Visible = false;
        }

        private void btnCaballo_Click(object sender, EventArgs e)
        {
            //Pueblo
            //Casa abandonada
            //
        }

        private void btnDormir_Click(object sender, EventArgs e)
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

        private void btnUsar_Click(object sender, EventArgs e)
        {
            if (player.cantPocVida > 0) player.UsarPocVida();
            else MessageBox.Show("No tienes pociones de vida...");
            Actualizar();
        }
    }  
}
