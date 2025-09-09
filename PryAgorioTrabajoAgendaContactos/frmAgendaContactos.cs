namespace PryAgorioTrabajoAgendaContactos
{
    public partial class frmAgendaContactos : Form
    {
        public frmAgendaContactos()
        {
            InitializeComponent();
        }
        string vContacto = "";
        string vNumero = "";

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
            if (txtContacto.Text == "")
            {
                mtbNumero.Enabled = false;
            }
            else
            {
                mtbNumero.Enabled = true;
            }



        }

        private void mtbNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbNumero.Text == "")
            {
                btnAceptar.Enabled = false;
            }
            else
            {
                btnAceptar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtContacto.Text = "";
            mtbNumero.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            vContacto = txtContacto.Text;
            vNumero = mtbNumero.Text;

            lstResumen.Items.Add("Contacto: " + vContacto + " - Telefono: " + vNumero);
        }
    }
}
    


