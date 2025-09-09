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
        DateTime vFecha = DateTime.Now;
        string[] vecContacto = new string[5];
        string[] vecNumero = new string[5];
        int indice = 0;
        int vContador = 0;

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
            vecContacto[indice] = mtbCantContacto.Text;
            vecNumero[indice] = mtbFecha.Text;

            lstResumen.Items.Add("Contacto: " + vContacto + " - Telefono: " + vNumero);

            vContador = vContador + 1;
            mtbCantContacto.Text = Convert.ToString(vContador);
            mtbFecha.Text = Convert.ToString(vFecha);

            txtContacto.Text = "";
            mtbNumero.Text = "";

            indice++;
            txtContacto.Focus();
        }

        private void frmAgendaContactos_Load(object sender, EventArgs e)
        {

        }
    }
}
    


