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
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1250, 220);
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            rtbSobreJuego.Text = "Eres un hombre viviendo en la era medieval, tienes que hacer lo que puedas para conseguir recursos y sobrevivir, o ganar más poder. Algunos datos importantes a tener en cuenta:\n- Solo puedes trabajar una vez al día y caminar dos veces.\n- Si tu vida llega a cero moriras, y si tu hambre llega a cero no podras trabajar ni realizar ninguna actividad, si pasas de día y tienes cero de hambre perderas 50 de vida, solo puedes sobrevivir 2 días sin comida. Si no tienes ningun objeto para vender y poder comprar comida moriras.";
            rtbProgramador.Text = "Este es el primer programa \"grande\" que hago.\n- Instagram: @fran_julia29\n- Email: franciscojulia2004@gmail.com";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rtbSobreJuego_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
