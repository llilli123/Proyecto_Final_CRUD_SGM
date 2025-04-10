namespace CAPA_PRESENTACION.Properties
{
    partial class Entrada_Datos_Pacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada_Datos_Pacientes));
            btn_Buscar = new Button();
            btn_Agregar = new Button();
            btn_Paciente_Guardar = new Button();
            btn_Paciente_Modificar = new Button();
            btn_Paciente_Cancelar = new Button();
            btn_Paciente_Eliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_Paciente_Nombre = new TextBox();
            txt_Paciente_Correo = new TextBox();
            txt_Paciente_Telefono = new TextBox();
            txt_Paciente_Documento = new TextBox();
            txt_Paciente_Apellido = new TextBox();
            label8 = new Label();
            label10 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            dtp_Paciente_FDN = new DateTimePicker();
            panel1 = new Panel();
            cmb_Paciente_Genero = new ComboBox();
            cmb_Paciente_Nacionalidad = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Buscar
            // 
            btn_Buscar.Image = (Image)resources.GetObject("btn_Buscar.Image");
            btn_Buscar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Buscar.Location = new Point(27, 111);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(157, 52);
            btn_Buscar.TabIndex = 0;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Image = (Image)resources.GetObject("btn_Agregar.Image");
            btn_Agregar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Agregar.Location = new Point(216, 111);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(163, 52);
            btn_Agregar.TabIndex = 1;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Paciente_Guardar
            // 
            btn_Paciente_Guardar.BackColor = SystemColors.Highlight;
            btn_Paciente_Guardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Paciente_Guardar.ForeColor = SystemColors.ButtonHighlight;
            btn_Paciente_Guardar.Location = new Point(140, 16);
            btn_Paciente_Guardar.Name = "btn_Paciente_Guardar";
            btn_Paciente_Guardar.Size = new Size(170, 56);
            btn_Paciente_Guardar.TabIndex = 2;
            btn_Paciente_Guardar.Text = "Guardar Paciente";
            btn_Paciente_Guardar.UseVisualStyleBackColor = false;
            btn_Paciente_Guardar.Click += btn_Paciente_Guardar_Click;
            // 
            // btn_Paciente_Modificar
            // 
            btn_Paciente_Modificar.Image = (Image)resources.GetObject("btn_Paciente_Modificar.Image");
            btn_Paciente_Modificar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Paciente_Modificar.Location = new Point(491, 111);
            btn_Paciente_Modificar.Name = "btn_Paciente_Modificar";
            btn_Paciente_Modificar.Size = new Size(155, 52);
            btn_Paciente_Modificar.TabIndex = 3;
            btn_Paciente_Modificar.Text = "Modificar";
            btn_Paciente_Modificar.UseVisualStyleBackColor = true;
            btn_Paciente_Modificar.Click += btn_Paciente_Modificar_Click;
            // 
            // btn_Paciente_Cancelar
            // 
            btn_Paciente_Cancelar.Location = new Point(12, 19);
            btn_Paciente_Cancelar.Name = "btn_Paciente_Cancelar";
            btn_Paciente_Cancelar.Size = new Size(122, 53);
            btn_Paciente_Cancelar.TabIndex = 4;
            btn_Paciente_Cancelar.Text = "Cancelar";
            btn_Paciente_Cancelar.UseVisualStyleBackColor = true;
            btn_Paciente_Cancelar.Click += btn_Paciente_Cancelar_Click;
            // 
            // btn_Paciente_Eliminar
            // 
            btn_Paciente_Eliminar.Image = (Image)resources.GetObject("btn_Paciente_Eliminar.Image");
            btn_Paciente_Eliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Paciente_Eliminar.Location = new Point(678, 111);
            btn_Paciente_Eliminar.Name = "btn_Paciente_Eliminar";
            btn_Paciente_Eliminar.Size = new Size(163, 52);
            btn_Paciente_Eliminar.TabIndex = 5;
            btn_Paciente_Eliminar.Text = "Eliminar";
            btn_Paciente_Eliminar.UseVisualStyleBackColor = true;
            btn_Paciente_Eliminar.Click += btn_Paciente_Eliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(27, 195);
            label1.Name = "label1";
            label1.Size = new Size(81, 23);
            label1.TabIndex = 6;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(491, 198);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 7;
            label2.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(491, 398);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 9;
            label4.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(491, 298);
            label5.Name = "label5";
            label5.Size = new Size(157, 23);
            label5.TabIndex = 10;
            label5.Text = "Fecha Nacimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(491, 503);
            label6.Name = "label6";
            label6.Size = new Size(120, 23);
            label6.TabIndex = 11;
            label6.Text = "Nacionalidad:";
            // 
            // txt_Paciente_Nombre
            // 
            txt_Paciente_Nombre.Location = new Point(27, 230);
            txt_Paciente_Nombre.Name = "txt_Paciente_Nombre";
            txt_Paciente_Nombre.Size = new Size(352, 27);
            txt_Paciente_Nombre.TabIndex = 13;
            // 
            // txt_Paciente_Correo
            // 
            txt_Paciente_Correo.Location = new Point(27, 537);
            txt_Paciente_Correo.Name = "txt_Paciente_Correo";
            txt_Paciente_Correo.Size = new Size(352, 27);
            txt_Paciente_Correo.TabIndex = 14;
            // 
            // txt_Paciente_Telefono
            // 
            txt_Paciente_Telefono.Location = new Point(491, 434);
            txt_Paciente_Telefono.Name = "txt_Paciente_Telefono";
            txt_Paciente_Telefono.Size = new Size(350, 27);
            txt_Paciente_Telefono.TabIndex = 15;
            // 
            // txt_Paciente_Documento
            // 
            txt_Paciente_Documento.Location = new Point(27, 330);
            txt_Paciente_Documento.Name = "txt_Paciente_Documento";
            txt_Paciente_Documento.Size = new Size(352, 27);
            txt_Paciente_Documento.TabIndex = 16;
            // 
            // txt_Paciente_Apellido
            // 
            txt_Paciente_Apellido.Location = new Point(491, 230);
            txt_Paciente_Apellido.Name = "txt_Paciente_Apellido";
            txt_Paciente_Apellido.Size = new Size(350, 27);
            txt_Paciente_Apellido.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label8.Location = new Point(27, 22);
            label8.Name = "label8";
            label8.Size = new Size(366, 35);
            label8.TabIndex = 20;
            label8.Text = "Sistema de Citas Hospitalarias";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(27, 61);
            label10.Name = "label10";
            label10.Size = new Size(555, 23);
            label10.TabIndex = 22;
            label10.Text = "Ingrese los datos personales del paciente para su registro en el sistema.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label9.Location = new Point(27, 295);
            label9.Name = "label9";
            label9.Size = new Size(103, 23);
            label9.TabIndex = 23;
            label9.Text = "Documento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label11.Location = new Point(27, 395);
            label11.Name = "label11";
            label11.Size = new Size(67, 23);
            label11.TabIndex = 24;
            label11.Text = "Genero";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label12.Location = new Point(27, 500);
            label12.Name = "label12";
            label12.Size = new Size(157, 23);
            label12.TabIndex = 25;
            label12.Text = "Correo Electrónico";
            // 
            // dtp_Paciente_FDN
            // 
            dtp_Paciente_FDN.Location = new Point(491, 330);
            dtp_Paciente_FDN.Name = "dtp_Paciente_FDN";
            dtp_Paciente_FDN.Size = new Size(350, 27);
            dtp_Paciente_FDN.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Paciente_Guardar);
            panel1.Controls.Add(btn_Paciente_Cancelar);
            panel1.Location = new Point(609, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 93);
            panel1.TabIndex = 28;
            // 
            // cmb_Paciente_Genero
            // 
            cmb_Paciente_Genero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Paciente_Genero.FormattingEnabled = true;
            cmb_Paciente_Genero.Location = new Point(29, 435);
            cmb_Paciente_Genero.Name = "cmb_Paciente_Genero";
            cmb_Paciente_Genero.Size = new Size(350, 28);
            cmb_Paciente_Genero.TabIndex = 29;
            // 
            // cmb_Paciente_Nacionalidad
            // 
            cmb_Paciente_Nacionalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Paciente_Nacionalidad.FormattingEnabled = true;
            cmb_Paciente_Nacionalidad.Location = new Point(491, 536);
            cmb_Paciente_Nacionalidad.Name = "cmb_Paciente_Nacionalidad";
            cmb_Paciente_Nacionalidad.Size = new Size(350, 28);
            cmb_Paciente_Nacionalidad.TabIndex = 30;
            // 
            // Entrada_Datos_Pacientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 596);
            Controls.Add(cmb_Paciente_Nacionalidad);
            Controls.Add(cmb_Paciente_Genero);
            Controls.Add(panel1);
            Controls.Add(dtp_Paciente_FDN);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(txt_Paciente_Apellido);
            Controls.Add(txt_Paciente_Documento);
            Controls.Add(txt_Paciente_Telefono);
            Controls.Add(txt_Paciente_Correo);
            Controls.Add(txt_Paciente_Nombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Paciente_Eliminar);
            Controls.Add(btn_Paciente_Modificar);
            Controls.Add(btn_Agregar);
            Controls.Add(btn_Buscar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Entrada_Datos_Pacientes";
            Text = "SET";
            Load += Entrada_Datos_Pacientes_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Buscar;
        private Button btn_Agregar;
        private Button btn_Paciente_Guardar;
        private Button btn_Paciente_Modificar;
        private Button btn_Paciente_Cancelar;
        private Button btn_Paciente_Eliminar;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_Paciente_Nombre;
        private TextBox txt_Paciente_Correo;
        private TextBox txt_Paciente_Telefono;
        private TextBox txt_Paciente_Documento;
        private TextBox txt_Paciente_Apellido;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label11;
        private Label label12;
        private DateTimePicker dtp_Paciente_FDN;
        private Panel panel1;
        private ComboBox cmb_Paciente_Genero;
        private ComboBox cmb_Paciente_Nacionalidad;
    }
}