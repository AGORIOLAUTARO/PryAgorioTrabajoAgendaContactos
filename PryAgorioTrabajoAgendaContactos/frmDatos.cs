using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryAgorioTrabajoAgendaContactos
{
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        public string[] vecContacto = new string[5];
        int indice = 0;
        private void frmDatos_Load(object sender, EventArgs e)
        {
            vecContacto[0] = "Depietri";
            vecContacto[1] = "Catalan";
            vecContacto[2] = "Guiñazu";
            vecContacto[3] = "Gandolfi";
            vecContacto[4] = "Willington";

            lblDatos.Text = vecContacto[indice];
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            indice++;
            lblDatos.Text = vecContacto[indice];

            if (vecContacto.Length == (indice + 1))
            {
                btnSiguiente.Enabled = false;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            indice--;
            lblDatos.Text = vecContacto[indice];

            if (indice == 0)
            {
                btnAnterior.Enabled = false;
            }

            if(indice < 5)
            {
                btnSiguiente.Enabled =true;

            }
        }
    }
}
