namespace CAPA_PRESENTACION
{
    partial class FormReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporte));
            ptb_Logo_Reporte = new PictureBox();
            lbl_NombreCentro_Centro = new Label();
            gb_DatosPaciente_Reporte = new GroupBox();
            txt_DoctorMostrar_Reporte = new TextBox();
            txt_Genero_Reporte = new TextBox();
            txt_Fecha_Reporte = new TextBox();
            txt_Documento_Reporte = new TextBox();
            txt_FDN_Reporte = new TextBox();
            txt_Apellido_Reporte = new TextBox();
            txt_Nombre_Reporte = new TextBox();
            lbl_Doctor_Reporte = new Label();
            lbl_Genero_Reporte = new Label();
            lbl_Documento_Reporte = new Label();
            lbl_Fecha_Reporte = new Label();
            lbl_FDN_Reporte = new Label();
            lbl_Apellido_Reporte = new Label();
            lbl_Nombre_Reporte = new Label();
            gb_DatosReporte_Reporte = new GroupBox();
            rtb_Observaciones = new RichTextBox();
            lbl_Observaciones = new Label();
            rtb_Tratamiento = new RichTextBox();
            lbl_Tratamiento = new Label();
            rtb_Diagnostico = new RichTextBox();
            lbl_Diagnostico = new Label();
            rtb_MotivoConsulta = new RichTextBox();
            lbl_MotivoConsulta = new Label();
            btn_Guardar_Reporte = new Button();
            btn_Cancelar_Reporte = new Button();
            gb_Botones_Reportes = new GroupBox();
            gb_Reporte = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)ptb_Logo_Reporte).BeginInit();
            gb_DatosPaciente_Reporte.SuspendLayout();
            gb_DatosReporte_Reporte.SuspendLayout();
            gb_Botones_Reportes.SuspendLayout();
            gb_Reporte.SuspendLayout();
            SuspendLayout();
            // 
            // ptb_Logo_Reporte
            // 
            ptb_Logo_Reporte.Image = (Image)resources.GetObject("ptb_Logo_Reporte.Image");
            ptb_Logo_Reporte.Location = new Point(14, 54);
            ptb_Logo_Reporte.Name = "ptb_Logo_Reporte";
            ptb_Logo_Reporte.Size = new Size(170, 170);
            ptb_Logo_Reporte.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Logo_Reporte.TabIndex = 0;
            ptb_Logo_Reporte.TabStop = false;
            // 
            // lbl_NombreCentro_Centro
            // 
            lbl_NombreCentro_Centro.AutoSize = true;
            lbl_NombreCentro_Centro.Font = new Font("Franklin Gothic Book", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_NombreCentro_Centro.Location = new Point(247, 0);
            lbl_NombreCentro_Centro.Name = "lbl_NombreCentro_Centro";
            lbl_NombreCentro_Centro.Size = new Size(398, 51);
            lbl_NombreCentro_Centro.TabIndex = 1;
            lbl_NombreCentro_Centro.Text = "Centro Medico UCE";
            // 
            // gb_DatosPaciente_Reporte
            // 
            gb_DatosPaciente_Reporte.Controls.Add(txt_DoctorMostrar_Reporte);
            gb_DatosPaciente_Reporte.Controls.Add(txt_Genero_Reporte);
            gb_DatosPaciente_Reporte.Controls.Add(txt_Fecha_Reporte);
            gb_DatosPaciente_Reporte.Controls.Add(txt_Documento_Reporte);
            gb_DatosPaciente_Reporte.Controls.Add(txt_FDN_Reporte);
            gb_DatosPaciente_Reporte.Controls.Add(txt_Apellido_Reporte);
            gb_DatosPaciente_Reporte.Controls.Add(txt_Nombre_Reporte);
            gb_DatosPaciente_Reporte.Controls.Add(lbl_Doctor_Reporte);
            gb_DatosPaciente_Reporte.Controls.Add(lbl_Genero_Reporte);
            gb_DatosPaciente_Reporte.Controls.Add(lbl_Documento_Reporte);
            gb_DatosPaciente_Reporte.Controls.Add(lbl_Fecha_Reporte);
            gb_DatosPaciente_Reporte.Controls.Add(lbl_FDN_Reporte);
            gb_DatosPaciente_Reporte.Controls.Add(lbl_Apellido_Reporte);
            gb_DatosPaciente_Reporte.Controls.Add(lbl_Nombre_Reporte);
            gb_DatosPaciente_Reporte.Location = new Point(198, 52);
            gb_DatosPaciente_Reporte.Name = "gb_DatosPaciente_Reporte";
            gb_DatosPaciente_Reporte.Size = new Size(602, 172);
            gb_DatosPaciente_Reporte.TabIndex = 2;
            gb_DatosPaciente_Reporte.TabStop = false;
            // 
            // txt_DoctorMostrar_Reporte
            // 
            txt_DoctorMostrar_Reporte.BorderStyle = BorderStyle.None;
            txt_DoctorMostrar_Reporte.Location = new Point(390, 96);
            txt_DoctorMostrar_Reporte.Name = "txt_DoctorMostrar_Reporte";
            txt_DoctorMostrar_Reporte.ReadOnly = true;
            txt_DoctorMostrar_Reporte.Size = new Size(164, 20);
            txt_DoctorMostrar_Reporte.TabIndex = 13;
            // 
            // txt_Genero_Reporte
            // 
            txt_Genero_Reporte.BorderStyle = BorderStyle.None;
            txt_Genero_Reporte.Location = new Point(390, 62);
            txt_Genero_Reporte.Name = "txt_Genero_Reporte";
            txt_Genero_Reporte.ReadOnly = true;
            txt_Genero_Reporte.Size = new Size(164, 20);
            txt_Genero_Reporte.TabIndex = 12;
            // 
            // txt_Fecha_Reporte
            // 
            txt_Fecha_Reporte.BorderStyle = BorderStyle.None;
            txt_Fecha_Reporte.Location = new Point(384, 23);
            txt_Fecha_Reporte.Name = "txt_Fecha_Reporte";
            txt_Fecha_Reporte.ReadOnly = true;
            txt_Fecha_Reporte.Size = new Size(170, 20);
            txt_Fecha_Reporte.TabIndex = 11;
            // 
            // txt_Documento_Reporte
            // 
            txt_Documento_Reporte.BorderStyle = BorderStyle.None;
            txt_Documento_Reporte.Location = new Point(102, 128);
            txt_Documento_Reporte.Name = "txt_Documento_Reporte";
            txt_Documento_Reporte.ReadOnly = true;
            txt_Documento_Reporte.Size = new Size(220, 20);
            txt_Documento_Reporte.TabIndex = 10;
            // 
            // txt_FDN_Reporte
            // 
            txt_FDN_Reporte.BorderStyle = BorderStyle.None;
            txt_FDN_Reporte.Location = new Point(49, 93);
            txt_FDN_Reporte.Name = "txt_FDN_Reporte";
            txt_FDN_Reporte.ReadOnly = true;
            txt_FDN_Reporte.Size = new Size(273, 20);
            txt_FDN_Reporte.TabIndex = 9;
            // 
            // txt_Apellido_Reporte
            // 
            txt_Apellido_Reporte.BorderStyle = BorderStyle.None;
            txt_Apellido_Reporte.Location = new Point(79, 55);
            txt_Apellido_Reporte.Name = "txt_Apellido_Reporte";
            txt_Apellido_Reporte.ReadOnly = true;
            txt_Apellido_Reporte.Size = new Size(243, 20);
            txt_Apellido_Reporte.TabIndex = 8;
            // 
            // txt_Nombre_Reporte
            // 
            txt_Nombre_Reporte.BorderStyle = BorderStyle.None;
            txt_Nombre_Reporte.Location = new Point(79, 18);
            txt_Nombre_Reporte.Name = "txt_Nombre_Reporte";
            txt_Nombre_Reporte.ReadOnly = true;
            txt_Nombre_Reporte.Size = new Size(243, 20);
            txt_Nombre_Reporte.TabIndex = 7;
            // 
            // lbl_Doctor_Reporte
            // 
            lbl_Doctor_Reporte.AutoSize = true;
            lbl_Doctor_Reporte.Location = new Point(328, 96);
            lbl_Doctor_Reporte.Name = "lbl_Doctor_Reporte";
            lbl_Doctor_Reporte.Size = new Size(58, 20);
            lbl_Doctor_Reporte.TabIndex = 6;
            lbl_Doctor_Reporte.Text = "Doctor:";
            // 
            // lbl_Genero_Reporte
            // 
            lbl_Genero_Reporte.AutoSize = true;
            lbl_Genero_Reporte.Location = new Point(328, 62);
            lbl_Genero_Reporte.Name = "lbl_Genero_Reporte";
            lbl_Genero_Reporte.Size = new Size(60, 20);
            lbl_Genero_Reporte.TabIndex = 5;
            lbl_Genero_Reporte.Text = "Genero:";
            // 
            // lbl_Documento_Reporte
            // 
            lbl_Documento_Reporte.AutoSize = true;
            lbl_Documento_Reporte.Location = new Point(6, 128);
            lbl_Documento_Reporte.Name = "lbl_Documento_Reporte";
            lbl_Documento_Reporte.Size = new Size(90, 20);
            lbl_Documento_Reporte.TabIndex = 4;
            lbl_Documento_Reporte.Text = "Documento:";
            // 
            // lbl_Fecha_Reporte
            // 
            lbl_Fecha_Reporte.AutoSize = true;
            lbl_Fecha_Reporte.Location = new Point(328, 23);
            lbl_Fecha_Reporte.Name = "lbl_Fecha_Reporte";
            lbl_Fecha_Reporte.Size = new Size(50, 20);
            lbl_Fecha_Reporte.TabIndex = 3;
            lbl_Fecha_Reporte.Text = "Fecha:";
            // 
            // lbl_FDN_Reporte
            // 
            lbl_FDN_Reporte.AutoSize = true;
            lbl_FDN_Reporte.Location = new Point(6, 96);
            lbl_FDN_Reporte.Name = "lbl_FDN_Reporte";
            lbl_FDN_Reporte.Size = new Size(41, 20);
            lbl_FDN_Reporte.TabIndex = 2;
            lbl_FDN_Reporte.Text = "FDN:";
            // 
            // lbl_Apellido_Reporte
            // 
            lbl_Apellido_Reporte.AutoSize = true;
            lbl_Apellido_Reporte.Location = new Point(6, 58);
            lbl_Apellido_Reporte.Name = "lbl_Apellido_Reporte";
            lbl_Apellido_Reporte.Size = new Size(69, 20);
            lbl_Apellido_Reporte.TabIndex = 1;
            lbl_Apellido_Reporte.Text = "Apellido:";
            // 
            // lbl_Nombre_Reporte
            // 
            lbl_Nombre_Reporte.AutoSize = true;
            lbl_Nombre_Reporte.Location = new Point(6, 21);
            lbl_Nombre_Reporte.Name = "lbl_Nombre_Reporte";
            lbl_Nombre_Reporte.Size = new Size(67, 20);
            lbl_Nombre_Reporte.TabIndex = 0;
            lbl_Nombre_Reporte.Text = "Nombre:";
            // 
            // gb_DatosReporte_Reporte
            // 
            gb_DatosReporte_Reporte.BackgroundImageLayout = ImageLayout.None;
            gb_DatosReporte_Reporte.Controls.Add(rtb_Observaciones);
            gb_DatosReporte_Reporte.Controls.Add(lbl_Observaciones);
            gb_DatosReporte_Reporte.Controls.Add(rtb_Tratamiento);
            gb_DatosReporte_Reporte.Controls.Add(lbl_Tratamiento);
            gb_DatosReporte_Reporte.Controls.Add(rtb_Diagnostico);
            gb_DatosReporte_Reporte.Controls.Add(lbl_Diagnostico);
            gb_DatosReporte_Reporte.Controls.Add(rtb_MotivoConsulta);
            gb_DatosReporte_Reporte.Controls.Add(lbl_MotivoConsulta);
            gb_DatosReporte_Reporte.FlatStyle = FlatStyle.Flat;
            gb_DatosReporte_Reporte.Location = new Point(14, 232);
            gb_DatosReporte_Reporte.Name = "gb_DatosReporte_Reporte";
            gb_DatosReporte_Reporte.Size = new Size(786, 660);
            gb_DatosReporte_Reporte.TabIndex = 3;
            gb_DatosReporte_Reporte.TabStop = false;
            // 
            // rtb_Observaciones
            // 
            rtb_Observaciones.BorderStyle = BorderStyle.FixedSingle;
            rtb_Observaciones.Location = new Point(6, 486);
            rtb_Observaciones.MaxLength = 512;
            rtb_Observaciones.Name = "rtb_Observaciones";
            rtb_Observaciones.Size = new Size(762, 151);
            rtb_Observaciones.TabIndex = 7;
            rtb_Observaciones.Text = "";
            // 
            // lbl_Observaciones
            // 
            lbl_Observaciones.AutoSize = true;
            lbl_Observaciones.Location = new Point(6, 463);
            lbl_Observaciones.Name = "lbl_Observaciones";
            lbl_Observaciones.Size = new Size(105, 20);
            lbl_Observaciones.TabIndex = 6;
            lbl_Observaciones.Text = "Observaciones";
            // 
            // rtb_Tratamiento
            // 
            rtb_Tratamiento.BorderStyle = BorderStyle.FixedSingle;
            rtb_Tratamiento.Location = new Point(6, 343);
            rtb_Tratamiento.MaxLength = 512;
            rtb_Tratamiento.Name = "rtb_Tratamiento";
            rtb_Tratamiento.Size = new Size(762, 117);
            rtb_Tratamiento.TabIndex = 5;
            rtb_Tratamiento.Text = "";
            // 
            // lbl_Tratamiento
            // 
            lbl_Tratamiento.AutoSize = true;
            lbl_Tratamiento.Location = new Point(6, 320);
            lbl_Tratamiento.Name = "lbl_Tratamiento";
            lbl_Tratamiento.Size = new Size(89, 20);
            lbl_Tratamiento.TabIndex = 4;
            lbl_Tratamiento.Text = "Tratamiento";
            // 
            // rtb_Diagnostico
            // 
            rtb_Diagnostico.BorderStyle = BorderStyle.FixedSingle;
            rtb_Diagnostico.Location = new Point(6, 228);
            rtb_Diagnostico.MaxLength = 512;
            rtb_Diagnostico.Name = "rtb_Diagnostico";
            rtb_Diagnostico.Size = new Size(762, 89);
            rtb_Diagnostico.TabIndex = 3;
            rtb_Diagnostico.Text = "";
            // 
            // lbl_Diagnostico
            // 
            lbl_Diagnostico.AutoSize = true;
            lbl_Diagnostico.Location = new Point(6, 205);
            lbl_Diagnostico.Name = "lbl_Diagnostico";
            lbl_Diagnostico.Size = new Size(89, 20);
            lbl_Diagnostico.TabIndex = 2;
            lbl_Diagnostico.Text = "Diagnostico";
            // 
            // rtb_MotivoConsulta
            // 
            rtb_MotivoConsulta.BorderStyle = BorderStyle.FixedSingle;
            rtb_MotivoConsulta.Location = new Point(6, 64);
            rtb_MotivoConsulta.MaxLength = 256;
            rtb_MotivoConsulta.Name = "rtb_MotivoConsulta";
            rtb_MotivoConsulta.Size = new Size(762, 138);
            rtb_MotivoConsulta.TabIndex = 1;
            rtb_MotivoConsulta.Text = "";
            // 
            // lbl_MotivoConsulta
            // 
            lbl_MotivoConsulta.AutoSize = true;
            lbl_MotivoConsulta.Location = new Point(6, 41);
            lbl_MotivoConsulta.Name = "lbl_MotivoConsulta";
            lbl_MotivoConsulta.Size = new Size(140, 20);
            lbl_MotivoConsulta.TabIndex = 0;
            lbl_MotivoConsulta.Text = "Motivo De Consulta";
            // 
            // btn_Guardar_Reporte
            // 
            btn_Guardar_Reporte.Location = new Point(26, 26);
            btn_Guardar_Reporte.Name = "btn_Guardar_Reporte";
            btn_Guardar_Reporte.Size = new Size(258, 67);
            btn_Guardar_Reporte.TabIndex = 8;
            btn_Guardar_Reporte.Text = "Guardar";
            btn_Guardar_Reporte.UseVisualStyleBackColor = true;
            btn_Guardar_Reporte.Click += btn_Guardar_Reporte_Click;
            // 
            // btn_Cancelar_Reporte
            // 
            btn_Cancelar_Reporte.Location = new Point(341, 26);
            btn_Cancelar_Reporte.Name = "btn_Cancelar_Reporte";
            btn_Cancelar_Reporte.Size = new Size(258, 67);
            btn_Cancelar_Reporte.TabIndex = 9;
            btn_Cancelar_Reporte.Text = "Cancelar";
            btn_Cancelar_Reporte.UseVisualStyleBackColor = true;
            // 
            // gb_Botones_Reportes
            // 
            gb_Botones_Reportes.Controls.Add(btn_Cancelar_Reporte);
            gb_Botones_Reportes.Controls.Add(btn_Guardar_Reporte);
            gb_Botones_Reportes.Location = new Point(76, 939);
            gb_Botones_Reportes.Name = "gb_Botones_Reportes";
            gb_Botones_Reportes.Size = new Size(640, 113);
            gb_Botones_Reportes.TabIndex = 10;
            gb_Botones_Reportes.TabStop = false;
            // 
            // gb_Reporte
            // 
            gb_Reporte.Controls.Add(gb_DatosReporte_Reporte);
            gb_Reporte.Controls.Add(ptb_Logo_Reporte);
            gb_Reporte.Controls.Add(gb_DatosPaciente_Reporte);
            gb_Reporte.Controls.Add(lbl_NombreCentro_Centro);
            gb_Reporte.Location = new Point(6, 12);
            gb_Reporte.Name = "gb_Reporte";
            gb_Reporte.Size = new Size(814, 921);
            gb_Reporte.TabIndex = 11;
            gb_Reporte.TabStop = false;
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(832, 1055);
            Controls.Add(gb_Botones_Reportes);
            Controls.Add(gb_Reporte);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormReporte";
            Text = "FormReporte";
            Load += FormReporte_Load;
            ((System.ComponentModel.ISupportInitialize)ptb_Logo_Reporte).EndInit();
            gb_DatosPaciente_Reporte.ResumeLayout(false);
            gb_DatosPaciente_Reporte.PerformLayout();
            gb_DatosReporte_Reporte.ResumeLayout(false);
            gb_DatosReporte_Reporte.PerformLayout();
            gb_Botones_Reportes.ResumeLayout(false);
            gb_Reporte.ResumeLayout(false);
            gb_Reporte.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptb_Logo_Reporte;
        private Label lbl_NombreCentro_Centro;
        private GroupBox gb_DatosPaciente_Reporte;
        private GroupBox gb_DatosReporte_Reporte;
        private RichTextBox rtb_MotivoConsulta;
        private Label lbl_MotivoConsulta;
        private RichTextBox rtb_Diagnostico;
        private Label lbl_Diagnostico;
        private RichTextBox rtb_Observaciones;
        private Label lbl_Observaciones;
        private RichTextBox rtb_Tratamiento;
        private Label lbl_Tratamiento;
        private Label lbl_FDN_Reporte;
        private Label lbl_Apellido_Reporte;
        private Label lbl_Nombre_Reporte;
        private Label lbl_Documento_Reporte;
        private Label lbl_Fecha_Reporte;
        private TextBox txt_Documento_Reporte;
        private TextBox txt_FDN_Reporte;
        private TextBox txt_Apellido_Reporte;
        private TextBox txt_Nombre_Reporte;
        private Label lbl_Doctor_Reporte;
        private Label lbl_Genero_Reporte;
        private TextBox txt_DoctorMostrar_Reporte;
        private TextBox txt_Genero_Reporte;
        private TextBox txt_Fecha_Reporte;
        private Button btn_Guardar_Reporte;
        private Button btn_Cancelar_Reporte;
        private GroupBox gb_Botones_Reportes;
        private GroupBox gb_Reporte;
    }
}