namespace CAPA_PRESENTACION
{
    partial class Entrada_de_datos_cita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada_de_datos_cita));
            panel1 = new Panel();
            dateTimePickerFecha = new DateTimePicker();
            cmbHora = new ComboBox();
            ptb_Logo_Citas = new PictureBox();
            label15 = new Label();
            cmbDoctor = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            lbl_Info_Correo = new Label();
            label10 = new Label();
            lbl_Info_Telefono = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCorreoElectronico = new TextBox();
            txtApellido = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtTelefono = new TextBox();
            rbtnMasculino = new RadioButton();
            rbtnFemenino = new RadioButton();
            panel4 = new Panel();
            btnContinuar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Logo_Citas).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(dateTimePickerFecha);
            panel1.Controls.Add(cmbHora);
            panel1.Controls.Add(ptb_Logo_Citas);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(cmbDoctor);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 722);
            panel1.TabIndex = 0;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Format = DateTimePickerFormat.Short;
            dateTimePickerFecha.Location = new Point(29, 57);
            dateTimePickerFecha.MinDate = new DateTime(2025, 4, 10, 9, 27, 20, 0);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(109, 27);
            dateTimePickerFecha.TabIndex = 27;
            dateTimePickerFecha.Value = new DateTime(2025, 4, 10, 9, 27, 20, 0);
            // 
            // cmbHora
            // 
            cmbHora.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHora.FormattingEnabled = true;
            cmbHora.Location = new Point(177, 56);
            cmbHora.Name = "cmbHora";
            cmbHora.Size = new Size(129, 28);
            cmbHora.TabIndex = 26;
            // 
            // ptb_Logo_Citas
            // 
            ptb_Logo_Citas.Image = (Image)resources.GetObject("ptb_Logo_Citas.Image");
            ptb_Logo_Citas.Location = new Point(18, 224);
            ptb_Logo_Citas.Name = "ptb_Logo_Citas";
            ptb_Logo_Citas.Size = new Size(288, 288);
            ptb_Logo_Citas.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Logo_Citas.TabIndex = 25;
            ptb_Logo_Citas.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ControlLightLight;
            label15.Location = new Point(215, 11);
            label15.Name = "label15";
            label15.Size = new Size(67, 31);
            label15.TabIndex = 13;
            label15.Text = "Hora";
            // 
            // cmbDoctor
            // 
            cmbDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(18, 160);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(298, 28);
            cmbDoctor.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(121, 124);
            label14.Name = "label14";
            label14.Size = new Size(88, 31);
            label14.TabIndex = 11;
            label14.Text = "Doctor";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(39, 11);
            label13.Name = "label13";
            label13.Size = new Size(75, 31);
            label13.TabIndex = 8;
            label13.Text = "Fecha";
            // 
            // panel2
            // 
            panel2.Location = new Point(363, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(lbl_Info_Correo);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(lbl_Info_Telefono);
            panel5.Location = new Point(12, 526);
            panel5.Name = "panel5";
            panel5.Size = new Size(295, 125);
            panel5.TabIndex = 7;
            // 
            // lbl_Info_Correo
            // 
            lbl_Info_Correo.AutoSize = true;
            lbl_Info_Correo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Info_Correo.ForeColor = SystemColors.ControlLightLight;
            lbl_Info_Correo.Location = new Point(6, 75);
            lbl_Info_Correo.Name = "lbl_Info_Correo";
            lbl_Info_Correo.Size = new Size(281, 28);
            lbl_Info_Correo.TabIndex = 6;
            lbl_Info_Correo.Text = "medico.centro.uce@gmail.com";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(47, 11);
            label10.Name = "label10";
            label10.Size = new Size(193, 28);
            label10.TabIndex = 4;
            label10.Text = "Pongase en contacto";
            // 
            // lbl_Info_Telefono
            // 
            lbl_Info_Telefono.AutoSize = true;
            lbl_Info_Telefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Info_Telefono.ForeColor = SystemColors.Control;
            lbl_Info_Telefono.Location = new Point(57, 39);
            lbl_Info_Telefono.Name = "lbl_Info_Telefono";
            lbl_Info_Telefono.Size = new Size(187, 28);
            lbl_Info_Telefono.TabIndex = 5;
            lbl_Info_Telefono.Text = "+1 (829) 539-0097  ";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(358, 143);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(280, 45);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(399, 38);
            label1.TabIndex = 2;
            label1.Text = "INFORMACION DE PACIENTE";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(332, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(700, 85);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(362, 109);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 4;
            label2.Text = "* Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(710, 107);
            label3.Name = "label3";
            label3.Size = new Size(116, 31);
            label3.TabIndex = 5;
            label3.Text = "* Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(362, 224);
            label4.Name = "label4";
            label4.Size = new Size(217, 31);
            label4.TabIndex = 6;
            label4.Text = "* Correo Electronico";
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreoElectronico.Location = new Point(358, 258);
            txtCorreoElectronico.Multiline = true;
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(280, 45);
            txtCorreoElectronico.TabIndex = 9;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(706, 143);
            txtApellido.Multiline = true;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(272, 45);
            txtApellido.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(710, 224);
            label7.Name = "label7";
            label7.Size = new Size(116, 31);
            label7.TabIndex = 13;
            label7.Text = "* Telefono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(706, 347);
            label8.Name = "label8";
            label8.Size = new Size(178, 31);
            label8.TabIndex = 14;
            label8.Text = "Cual es su sexo?";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(706, 258);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(272, 45);
            txtTelefono.TabIndex = 16;
            // 
            // rbtnMasculino
            // 
            rbtnMasculino.AutoSize = true;
            rbtnMasculino.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnMasculino.Location = new Point(713, 385);
            rbtnMasculino.Name = "rbtnMasculino";
            rbtnMasculino.Size = new Size(140, 35);
            rbtnMasculino.TabIndex = 19;
            rbtnMasculino.TabStop = true;
            rbtnMasculino.Text = "Masculino";
            rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            rbtnFemenino.AutoSize = true;
            rbtnFemenino.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnFemenino.Location = new Point(713, 423);
            rbtnFemenino.Name = "rbtnFemenino";
            rbtnFemenino.Size = new Size(135, 35);
            rbtnFemenino.TabIndex = 20;
            rbtnFemenino.TabStop = true;
            rbtnFemenino.Text = "Femenino";
            rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(btnContinuar);
            panel4.Location = new Point(338, 601);
            panel4.Name = "panel4";
            panel4.Size = new Size(684, 104);
            panel4.TabIndex = 24;
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = SystemColors.Highlight;
            btnContinuar.BackgroundImageLayout = ImageLayout.None;
            btnContinuar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinuar.ForeColor = SystemColors.HighlightText;
            btnContinuar.Location = new Point(506, 7);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(179, 59);
            btnContinuar.TabIndex = 0;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btncontinuar_Click;
            // 
            // Entrada_de_datos_cita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1030, 706);
            Controls.Add(panel4);
            Controls.Add(rbtnFemenino);
            Controls.Add(rbtnMasculino);
            Controls.Add(txtTelefono);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtApellido);
            Controls.Add(txtCorreoElectronico);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(txtNombre);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Entrada_de_datos_cita";
            Text = "Entrada_de_datos_cita";
            Load += Entrada_de_datos_cita_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Logo_Citas).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtNombre;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCorreoElectronico;
        private TextBox txtApellido;
        private Label label7;
        private Label label8;
        private TextBox txtTelefono;
        private RadioButton rbtnMasculino;
        private RadioButton rbtnFemenino;
        private Panel panel4;
        private Button btnContinuar;
        private Label lbl_Info_Correo;
        private Label lbl_Info_Telefono;
        private Label label10;
        private Panel panel5;
        private Label label13;
        private ComboBox cmbDoctor;
        private Label label14;
        private Label label15;
        private PictureBox ptb_Logo_Citas;
        private DateTimePicker dateTimePickerFecha;
        private ComboBox cmbHora;
    }
}