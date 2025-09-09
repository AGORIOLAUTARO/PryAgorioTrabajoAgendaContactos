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
            lblContacto = new Label();
            lblNumero = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            lstResumen = new ListBox();
            txtContacto = new TextBox();
            mtbNumero = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Location = new Point(161, 59);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(69, 20);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(161, 141);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(63, 20);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Número";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(202, 259);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Enabled = false;
            btnAceptar.Location = new Point(376, 259);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Agendar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lstResumen
            // 
            lstResumen.FormattingEnabled = true;
            lstResumen.Location = new Point(195, 334);
            lstResumen.Name = "lstResumen";
            lstResumen.Size = new Size(312, 104);
            lstResumen.TabIndex = 4;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(328, 60);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(125, 27);
            txtContacto.TabIndex = 5;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // mtbNumero
            // 
            mtbNumero.Enabled = false;
            mtbNumero.Location = new Point(328, 141);
            mtbNumero.Mask = "(999)000-0000";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(125, 27);
            mtbNumero.TabIndex = 6;
            mtbNumero.MaskInputRejected += mtbNumero_MaskInputRejected;
            // 
            // frmAgendaContactos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mtbNumero);
            Controls.Add(txtContacto);
            Controls.Add(lstResumen);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lblNumero);
            Controls.Add(lblContacto);
            Name = "frmAgendaContactos";
            Text = "Form1";
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
    }
}
