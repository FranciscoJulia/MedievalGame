using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoMedieval1._0
{
    internal class Jugador
    {
        public Jugador(string nombre, byte dificultad)
        {
            //Pruebas...
            //experiencia = 1000;
            //tieneFruta = true;
            //cantFruta = 20;
            //armaduraCuero = true;
            //tieneArmadura = true;
            //tieneCarne = true;
            //cantCarne = 2;

            //Default
            TienePan = true;
            TieneComida = true;
            dia = 1;


            hambre = 20;
            vida = 100;
            this.nombre = nombre;
            if (dificultad == 1)
            {
                monedas = 100;
                cantPan = 10;
                this.dificultad = dificultad;
            }
            else if (dificultad == 2)
            {
                monedas = 20;
                cantPan = 4;
                this.dificultad = dificultad;
            }
            else if (dificultad == 3)
            {
                cantPan = 1;
                monedas = 0;
                this.dificultad = 3;
            }
        }
        private string nombre;
        private int monedas;
        private byte vida;
        private byte hambre;

        private byte trabajO = 0;        

        public byte TrabajO
        {
            get { return trabajO; }
            set { trabajO = value; }
        }

        private byte caminO = 0;
        public byte CaminO
        {
            get { return caminO; }
            set { caminO = value; }
        }



        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public int Monedas
        {
            get { return monedas; }
            set { monedas = value; }
        }

        public byte VidaJugador
        {
            get { return vida; }
            set 
            { 
                if (vida - value <= 0)
                {
                    MessageBox.Show("Haz muerto...");
                    Application.Exit();
                }else
                    vida = value; 
            }
        }

        public byte Hambre
        {
            get { return hambre; }
            set
            {
                if (hambre - value <= 0)
                {
                    Hambre = 0;
                    MessageBox.Show("Tienes mucha hambre...");
                }
                else
                    hambre = value;
            }
        }

        public byte comeR
        {
            get { return hambre; }
            set {
                hambre = value;
            }
        }

        private bool tienePocVida;
        public bool TienePocVida
        {
            get { return tienePocVida; }
            set { tienePocVida = value; }   
        }
        public short cantPocVida;
        public short CantPocVida
        {
            get { return cantPocVida; }
            set { cantPocVida = value; }
        }
        public string addPocVida()
        {
            if (TienePocVida == true) return "Poción vida";
            else return "";
        }
        public string DescPocVida()
        {
            return "Al usarla podras curarte. +40 vida";
        }

        public void UsarPocVida()
        {
            if (TienePocVida == true)
            {
                if (vida <= 60) 
                {
                    vida += 40;
                    CantPocVida -= 1;
                } 
                    
                else if (vida == 100) MessageBox.Show("Ya estás full vida...");
                else if (vida > 60)
                {
                    vida = 100;
                    CantPocVida -= 1;
                }
            }
            else MessageBox.Show("No tienes pociónes de vida...");
            
        }


        private bool caballo;
        public bool Caballo
        {
            get { return caballo; }
            set { caballo = value; }    
        }
        public string addCaballo()
        {
            if (Caballo == true) return "Caballo";
            else return "";
        }

        public string DescCaballo()
        {
            return "Te permitira explorar más";
        }

        private bool tieneEspada;
        public bool TieneEspada
        {
            get { return tieneEspada; }
            set { tieneEspada = value; }
        }


        private bool espadaHierro;
        public bool EspadaHierro
        {
            get { return espadaHierro; }
            set { espadaHierro = value; }
        }

        private bool espadaAcero;
        public bool EspadaAcero
        {
            get { return espadaAcero; }
            set { espadaAcero = value; }
        }


        private bool tieneComida;
        public bool TieneComida
        {
            get { return tieneComida; }
            set { tieneComida = value; }
        }

        private short cantPan;
        private bool tienePan;

        public bool TienePan
        {
            get { return tienePan; }
            set { tienePan = value; }
        }
        public short CantPan
        {
            get { return cantPan; }
            set { cantPan = value; }
        }

        //ARMADURAS
        private bool tieneArmadura;

        public bool TieneArmadura
        {
            get { return tieneArmadura; }
            set { tieneArmadura = value; }
        }


        private bool armaduraCuero;
        public bool ArmaduraCuero
        {
            get { return armaduraCuero; }
            set { armaduraCuero = value; }
        }

        private bool armaduraMalla;
        public bool ArmaduraMalla
        {
            get { return armaduraMalla; }
            set { armaduraMalla = value; }
        }

        public string addArmaduraCuero()
        {
            if (armaduraCuero == true) return "Arm. Cuero";
            else return "";
        }
        public string addArmaduraMalla()
        {
            if (armaduraMalla == true) return "Arm. Malla";
            else return "";
        }

        public string DescArmCuero()
        {
            return "La armadura de cuero te dará +30 de vida";
        }
        public string DescArmMalla()
        {
            return "La armadura de Cota de Malla te dará +100 de vida";
        }



        public void PerderTodo()
        {
            TieneEspada = false;
            EspadaAcero = false;
            EspadaHierro = false;
            TieneComida = false;
            TieneFruta = false;
            cantFruta = 0;
            TienePan = false;
            cantPan = 0;
            TieneCarne = false;
            cantCarne = 0;
            tieneArmadura = false;
            ArmaduraCuero = false;
            ArmaduraMalla = false;
            TienePocVida = false;
            CantPocVida = 0;
        }


        //Sirven para agregar informacion en las listBox y las rtb
        public string addPan()
        {
            if (tienePan == true) return "Pan";
            else return "";
        }
        public string DescPan()
        {
            return "+2 de alimento.";
        }

        public string DescFruta()
        {
            return "+1 de alimento\n+3 de vida.";
        }
        public string addFruta()
        {
            if (tieneFruta == true) return "Fruta";
            else return "";
        }

        public string addCarne()
        {
            if (tieneCarne == true) return "Carne";
            else return "";
        }
        public string DescCarne()
        {
            return "+5 de alimento.\n+6 de vida";
        }

        //-----------------------------------------------

        private short cantFruta;
        private bool tieneFruta;

        public bool TieneFruta
        {
            get { return tieneFruta; }
            set { tieneFruta = value; }
        }
        public short CantFruta
        {
            get { return cantFruta; }
            set { cantFruta = value; }
        }

        private short cantCarne;
        private bool tieneCarne;

        public bool TieneCarne
        {
            get { return tieneCarne; }
            set { tieneCarne = value; }
        }
        public short CantCarne
        {
            get { return cantCarne; }
            set { cantCarne = value; }
        }



        public void Comer(string nomComida)
        {
            if (nomComida == "Pan" && CantPan > 0)
            {
                if (hambre < 18)
                {
                    cantPan -= 1;
                    comeR += 2;
                }
                else if (hambre == 18 || hambre == 19)
                {
                    cantPan -= 1;
                    comeR = 20;
                }
                else if (hambre == 20) MessageBox.Show("No tienes hambre");
            }
            else if (nomComida == "Fruta" && cantFruta > 0)
            {
                if (hambre < 19)
                {
                    cantFruta -= 1;
                    comeR += 1; ;
                    if (vida <= 97) vida += 3;
                    else if (vida > 97) vida = 100;
                }
                else if (hambre == 19)
                {
                    cantFruta -= 1;
                    hambre = 20;
                    if (vida <= 97) vida += 3;
                    else if (vida > 97) vida = 100;
                }
                else if (hambre == 20 || vida < 100)
                {
                    if (vida <= 97)
                    {
                        vida += 3;
                        cantFruta -= 1;
                    }
                    else if (vida > 97 && vida < 100) 
                    {
                        vida = 100;
                        cantFruta -= 1;
                    } 
                    else if (hambre == 20)
                    {
                        MessageBox.Show("No tienes hambre");
                    }
                }
            }
            else if(nomComida == "Carne" && cantCarne > 0)
            {
                if (hambre <= 15)
                {
                    cantCarne -= 1;
                    comeR += 5; 
                    if (vida <= 94) vida += 6;
                    else if (vida > 94) vida = 100;
                }
                else if (hambre > 15 && hambre < 20)
                {
                    cantCarne -= 1;
                    hambre = 20;
                    if (vida <= 94) vida += 6;
                    else if (vida > 94) vida = 100;
                }
                else if (hambre == 20 || vida < 100)
                {
                    if (vida <= 94)
                    {
                        vida += 6;
                        cantCarne -= 1;
                    }
                    else if (vida > 94 && vida < 100)
                    {
                        vida = 100;
                        cantCarne -= 1;
                    }
                    else if (hambre == 20)
                    {
                        MessageBox.Show("No tienes hambre");
                    }
                }
            }
            else MessageBox.Show("No tienes esa comida...");
        }

        

        private short experiencia;
        public short Experiencia
        {
            get { return experiencia; }
            set { experiencia = value; }
        }

        private short dia;
        public short Dia
        {
            get { return dia; }
            set { dia = value; }
        }   


        private byte dificultad;
        public byte Dificultad
        {
            get { return dificultad; }
            set
            {
                dificultad = value;
            }
        }

        //Sirven para agregar informacion en las listBox y las rtb

        public string addEspadaHierro()
        {
            if (espadaHierro == true) return "Espada Hierro";
            else return "";
        }
        public string addEspadaAcero()
        {
            if (espadaAcero == true) return "Espada Acero";
            else return "";
        }

        public string DescHierro()
        {
            return "La espada de hierro hace 10 de daño.";
        }
        public string DescAcero()
        {
            return "La espada de Acero hace 18 de daño.";
        }


        //Agregar items a la tienda
                   //Tienda objetos
        public string AddTiendaEspadaHierro() { return "Espada Hierro"; }
        public string AddTiendaEspadaAcero() { return "Espada Acero"; }
        public string AddTiendaArmCuero() { return "Arm. Cuero"; }
        public string AddTiendaArmMalla() { return "Arm. Malla"; }
        public string AddTiendaCaballo() { return "Caballo"; }
        public string AddTiendaPocVida() { return "Poción vida"; }

        //Tienda comidas
        public string AddTiendaFruta() { return "Fruta"; }
        public string AddTiendaPan() { return "Pan"; }
        public string AddTiendaCarne() { return "Carne"; }


    }
}
