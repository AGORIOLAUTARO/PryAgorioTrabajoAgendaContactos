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
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Location = new Point(40, 25);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(56, 15);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(45, 78);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Número";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(45, 125);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(92, 36);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Enabled = false;
            btnAceptar.Location = new Point(143, 125);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 36);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Agendar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lstResumen
            // 
            lstResumen.FormattingEnabled = true;
            lstResumen.ItemHeight = 15;
            lstResumen.Location = new Point(55, 187);
            lstResumen.Margin = new Padding(3, 2, 3, 2);
            lstResumen.Name = "lstResumen";
            lstResumen.Size = new Size(189, 49);
            lstResumen.TabIndex = 4;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(129, 17);
            txtContacto.Margin = new Padding(3, 2, 3, 2);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(110, 23);
            txtContacto.TabIndex = 5;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // mtbNumero
            // 
            mtbNumero.Enabled = false;
            mtbNumero.Location = new Point(129, 70);
            mtbNumero.Margin = new Padding(3, 2, 3, 2);
            mtbNumero.Mask = "(999)000-0000";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(110, 23);
            mtbNumero.TabIndex = 6;
            mtbNumero.MaskInputRejected += mtbNumero_MaskInputRejected;
            // 
            // lblCantContactos
            // 
            lblCantContactos.AutoSize = true;
            lblCantContactos.Location = new Point(22, 255);
            lblCantContactos.Name = "lblCantContactos";
            lblCantContactos.Size = new Size(81, 15);
            lblCantContactos.TabIndex = 7;
            lblCantContactos.Text = "CantContacto";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(22, 308);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(74, 15);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha y hora";
            // 
            // mtbCantContacto
            // 
            mtbCantContacto.Location = new Point(139, 252);
            mtbCantContacto.Name = "mtbCantContacto";
            mtbCantContacto.Size = new Size(100, 23);
            mtbCantContacto.TabIndex = 9;
            // 
            // mtbFecha
            // 
            mtbFecha.Location = new Point(139, 300);
            mtbFecha.Mask = "00/00/0000 00:00";
            mtbFecha.Name = "mtbFecha";
            mtbFecha.Size = new Size(100, 23);
            mtbFecha.TabIndex = 10;
            mtbFecha.ValidatingType = typeof(DateTime);
            // 
            // frmAgendaContactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 362);
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
            Margin = new Padding(3, 2, 3, 2);
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
    }
}
