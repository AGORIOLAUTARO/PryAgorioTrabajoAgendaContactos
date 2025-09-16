namespace PryAgorioTrabajoAgendaContactos
{
    partial class frmAgendaContactos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendaContactos));
            lblContacto = new Label();
            lblNumero = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            lstResumen = new ListBox();
            txtContacto = new TextBox();
            mtbNumero = new MaskedTextBox();
            lblCantContactos = new Label();
            lblFecha = new Label();
            mtbCantContacto = new MaskedTextBox();
            mtbFecha = new MaskedTextBox();
            btnGestion = new Button();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.BackColor = Color.Blue;
            lblContacto.ForeColor = Color.White;
            lblContacto.Location = new Point(55, 30);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(69, 20);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = Color.Blue;
            lblNumero.ForeColor = Color.White;
            lblNumero.Location = new Point(61, 93);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(63, 20);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Número";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Blue;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(51, 150);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 48);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Blue;
            btnAceptar.Enabled = false;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(163, 150);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(110, 48);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Agendar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lstResumen
            // 
            lstResumen.FormattingEnabled = true;
            lstResumen.Location = new Point(58, 221);
            lstResumen.Name = "lstResumen";
            lstResumen.Size = new Size(215, 64);
            lstResumen.TabIndex = 4;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(147, 23);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(125, 27);
            txtContacto.TabIndex = 5;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // mtbNumero
            // 
            mtbNumero.Enabled = false;
            mtbNumero.Location = new Point(147, 93);
            mtbNumero.Mask = "(999)000-0000";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(125, 27);
            mtbNumero.TabIndex = 6;
            mtbNumero.MaskInputRejected += mtbNumero_MaskInputRejected;
            // 
            // lblCantContactos
            // 
            lblCantContactos.AutoSize = true;
            lblCantContactos.BackColor = Color.Blue;
            lblCantContactos.ForeColor = Color.White;
            lblCantContactos.Location = new Point(25, 305);
            lblCantContactos.Name = "lblCantContactos";
            lblCantContactos.Size = new Size(99, 20);
            lblCantContactos.TabIndex = 7;
            lblCantContactos.Text = "CantContacto";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Blue;
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(32, 358);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(92, 20);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha y hora";
            // 
            // mtbCantContacto
            // 
            mtbCantContacto.Location = new Point(159, 305);
            mtbCantContacto.Margin = new Padding(3, 4, 3, 4);
            mtbCantContacto.Name = "mtbCantContacto";
            mtbCantContacto.Size = new Size(114, 27);
            mtbCantContacto.TabIndex = 9;
            // 
            // mtbFecha
            // 
            mtbFecha.Location = new Point(158, 358);
            mtbFecha.Margin = new Padding(3, 4, 3, 4);
            mtbFecha.Mask = "00/00/0000 00:00";
            mtbFecha.Name = "mtbFecha";
            mtbFecha.Size = new Size(114, 27);
            mtbFecha.TabIndex = 10;
            mtbFecha.ValidatingType = typeof(DateTime);
            // 
            // btnGestion
            // 
            btnGestion.BackColor = Color.Blue;
            btnGestion.ForeColor = Color.White;
            btnGestion.Location = new Point(109, 425);
            btnGestion.Name = "btnGestion";
            btnGestion.Size = new Size(94, 29);
            btnGestion.TabIndex = 11;
            btnGestion.Text = "Gestion";
            btnGestion.UseVisualStyleBackColor = false;
            btnGestion.Click += btnGestion_Click;
            // 
            // frmAgendaContactos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(313, 483);
            Controls.Add(btnGestion);
            Controls.Add(mtbFecha);
            Controls.Add(mtbCantContacto);
            Controls.Add(lblFecha);
            Controls.Add(lblCantContactos);
            Controls.Add(mtbNumero);
            Controls.Add(txtContacto);
            Controls.Add(lstResumen);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lblNumero);
            Controls.Add(lblContacto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAgendaContactos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda Contactos";
            Load += frmAgendaContactos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContacto;
        private Label lblNumero;
        private Button btnCancelar;
        private Button btnAceptar;
        private ListBox lstResumen;
        private TextBox txtContacto;
        private MaskedTextBox mtbNumero;
        private Label lblCantContactos;
        private Label lblFecha;
        private MaskedTextBox mtbCantContacto;
        private MaskedTextBox mtbFecha;
        private Button btnGestion;
    }
}
