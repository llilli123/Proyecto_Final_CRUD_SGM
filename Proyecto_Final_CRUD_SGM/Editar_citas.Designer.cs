namespace CAPA_PRESENTACION
{
    partial class Editar_citas
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
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            txtCorreo = new TextBox();
            txtHora = new TextBox();
            btn_Guardar = new Button();
            lbl_nuevoNombre = new Label();
            lblNuevoapellido = new Label();
            lblNuevoCorreo = new Label();
            lblNuevoTelefono = new Label();
            lblNuevaFecha = new Label();
            lbl_nueva_hora = new Label();
            lbl_Editar_Cita = new Label();
            dtp_Fecha = new DateTimePicker();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 114);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(146, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(8, 238);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 27);
            txtTelefono.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(260, 113);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(149, 27);
            txtApellido.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(514, 114);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(161, 27);
            txtCorreo.TabIndex = 4;
            // 
            // txtHora
            // 
            txtHora.Location = new Point(583, 238);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(161, 27);
            txtHora.TabIndex = 5;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Guardar.Location = new Point(289, 349);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(131, 37);
            btn_Guardar.TabIndex = 7;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // lbl_nuevoNombre
            // 
            lbl_nuevoNombre.AutoSize = true;
            lbl_nuevoNombre.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nuevoNombre.Location = new Point(12, 91);
            lbl_nuevoNombre.Name = "lbl_nuevoNombre";
            lbl_nuevoNombre.Size = new Size(114, 19);
            lbl_nuevoNombre.TabIndex = 8;
            lbl_nuevoNombre.Text = "Nuevo nombre";
            // 
            // lblNuevoapellido
            // 
            lblNuevoapellido.AutoSize = true;
            lblNuevoapellido.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNuevoapellido.Location = new Point(260, 91);
            lblNuevoapellido.Name = "lblNuevoapellido";
            lblNuevoapellido.Size = new Size(114, 19);
            lblNuevoapellido.TabIndex = 9;
            lblNuevoapellido.Text = "Nuevo apellido";
            // 
            // lblNuevoCorreo
            // 
            lblNuevoCorreo.AutoSize = true;
            lblNuevoCorreo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNuevoCorreo.Location = new Point(514, 91);
            lblNuevoCorreo.Name = "lblNuevoCorreo";
            lblNuevoCorreo.Size = new Size(107, 19);
            lblNuevoCorreo.TabIndex = 10;
            lblNuevoCorreo.Text = "Nuevo correo";
            // 
            // lblNuevoTelefono
            // 
            lblNuevoTelefono.AutoSize = true;
            lblNuevoTelefono.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNuevoTelefono.Location = new Point(8, 221);
            lblNuevoTelefono.Name = "lblNuevoTelefono";
            lblNuevoTelefono.Size = new Size(116, 19);
            lblNuevoTelefono.TabIndex = 11;
            lblNuevoTelefono.Text = "Nuevo telefono";
            // 
            // lblNuevaFecha
            // 
            lblNuevaFecha.AutoSize = true;
            lblNuevaFecha.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNuevaFecha.Location = new Point(260, 221);
            lblNuevaFecha.Name = "lblNuevaFecha";
            lblNuevaFecha.Size = new Size(100, 19);
            lblNuevaFecha.TabIndex = 12;
            lblNuevaFecha.Text = "Nueva fecha";
            // 
            // lbl_nueva_hora
            // 
            lbl_nueva_hora.AutoSize = true;
            lbl_nueva_hora.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nueva_hora.Location = new Point(583, 221);
            lbl_nueva_hora.Name = "lbl_nueva_hora";
            lbl_nueva_hora.Size = new Size(92, 19);
            lbl_nueva_hora.TabIndex = 13;
            lbl_nueva_hora.Text = "Nueva hora";
            // 
            // lbl_Editar_Cita
            // 
            lbl_Editar_Cita.AutoSize = true;
            lbl_Editar_Cita.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Editar_Cita.Location = new Point(119, 23);
            lbl_Editar_Cita.Name = "lbl_Editar_Cita";
            lbl_Editar_Cita.Size = new Size(87, 24);
            lbl_Editar_Cita.TabIndex = 15;
            lbl_Editar_Cita.Text = "Editar cita";
            // 
            // dtp_Fecha
            // 
            dtp_Fecha.Location = new Point(260, 243);
            dtp_Fecha.Name = "dtp_Fecha";
            dtp_Fecha.Size = new Size(278, 27);
            dtp_Fecha.TabIndex = 16;
            // 
            // Editar_citas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(dtp_Fecha);
            Controls.Add(lbl_Editar_Cita);
            Controls.Add(lbl_nueva_hora);
            Controls.Add(lblNuevaFecha);
            Controls.Add(lblNuevoTelefono);
            Controls.Add(lblNuevoCorreo);
            Controls.Add(lblNuevoapellido);
            Controls.Add(lbl_nuevoNombre);
            Controls.Add(btn_Guardar);
            Controls.Add(txtHora);
            Controls.Add(txtCorreo);
            Controls.Add(txtApellido);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Name = "Editar_citas";
            Text = "Editar_citas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private TextBox txtCorreo;
        private TextBox txtHora;
        private Button btn_Guardar;
        private Label lbl_nuevoNombre;
        private Label lblNuevoapellido;
        private Label lblNuevoCorreo;
        private Label lblNuevoTelefono;
        private Label lblNuevaFecha;
        private Label lbl_nueva_hora;
        private Label lbl_Editar_Cita;
        private DateTimePicker dtp_Fecha;
    }
}