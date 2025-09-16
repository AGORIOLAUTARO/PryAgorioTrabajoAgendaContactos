namespace PryAgorioTrabajoAgendaContactos
{
    partial class frmDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAnterior = new Button();
            btnSiguiente = new Button();
            lblDatos = new Label();
            SuspendLayout();
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(197, 223);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(94, 29);
            btnAnterior.TabIndex = 0;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(478, 223);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(94, 29);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Location = new Point(351, 86);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(0, 20);
            lblDatos.TabIndex = 2;
            // 
            // frmDatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDatos);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Name = "frmDatos";
            Text = "frmDatos";
            Load += frmDatos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnterior;
        private Button btnSiguiente;
        private Label lblDatos;
    }
}