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
            btnAnterior.BackColor = Color.Blue;
            btnAnterior.ForeColor = Color.White;
            btnAnterior.Location = new Point(80, 149);
            btnAnterior.Margin = new Padding(3, 2, 3, 2);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(96, 52);
            btnAnterior.TabIndex = 0;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.Blue;
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(238, 149);
            btnSiguiente.Margin = new Padding(3, 2, 3, 2);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(94, 52);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // lblDatos
            // 
            lblDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDatos.AutoSize = true;
            lblDatos.BackColor = Color.Blue;
            lblDatos.BorderStyle = BorderStyle.Fixed3D;
            lblDatos.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDatos.ForeColor = Color.White;
            lblDatos.Location = new Point(164, 44);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(2, 34);
            lblDatos.TabIndex = 2;
            // 
            // frmDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(415, 364);
            Controls.Add(lblDatos);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Margin = new Padding(3, 2, 3, 2);
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