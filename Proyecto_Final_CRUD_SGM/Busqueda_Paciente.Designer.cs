namespace CAPA_PRESENTACION
{
    partial class Busqueda_Paciente
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
            lbl_NOMBRE_Y_APELLIDO = new Label();
            lbl_DOCUMENTO = new Label();
            lbl_ID_PACIENTE = new Label();
            lbl_CORREO = new Label();
            lbl_FECHA_VENCIMIENTIO = new Label();
            lbl_TELEFONO = new Label();
            txt_BuscarNombreyApellido = new TextBox();
            txt_IDPACIENTE = new TextBox();
            txt_CORREO = new TextBox();
            txt_DOCUMENTO = new TextBox();
            txt_FECHA_DE_NACIMIENTO = new TextBox();
            txt_TELEFONO = new TextBox();
            btn_Salir = new Button();
            btn_Seleccionar = new Button();
            panel1 = new Panel();
            lbl_Busqueda_de_Paciente = new Label();
            dgv_Busqueda_Pax = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Busqueda_Pax).BeginInit();
            SuspendLayout();
            // 
            // lbl_NOMBRE_Y_APELLIDO
            // 
            lbl_NOMBRE_Y_APELLIDO.AutoSize = true;
            lbl_NOMBRE_Y_APELLIDO.BackColor = Color.Transparent;
            lbl_NOMBRE_Y_APELLIDO.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_NOMBRE_Y_APELLIDO.ForeColor = Color.Black;
            lbl_NOMBRE_Y_APELLIDO.Location = new Point(3, 67);
            lbl_NOMBRE_Y_APELLIDO.Name = "lbl_NOMBRE_Y_APELLIDO";
            lbl_NOMBRE_Y_APELLIDO.Size = new Size(162, 21);
            lbl_NOMBRE_Y_APELLIDO.TabIndex = 0;
            lbl_NOMBRE_Y_APELLIDO.Text = "NOMBRE Y APELLIDO";
            // 
            // lbl_DOCUMENTO
            // 
            lbl_DOCUMENTO.AutoSize = true;
            lbl_DOCUMENTO.BackColor = Color.Transparent;
            lbl_DOCUMENTO.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_DOCUMENTO.ForeColor = SystemColors.ActiveCaptionText;
            lbl_DOCUMENTO.Location = new Point(328, 68);
            lbl_DOCUMENTO.Name = "lbl_DOCUMENTO";
            lbl_DOCUMENTO.Size = new Size(107, 21);
            lbl_DOCUMENTO.TabIndex = 1;
            lbl_DOCUMENTO.Text = "DOCUMENTO";
            // 
            // lbl_ID_PACIENTE
            // 
            lbl_ID_PACIENTE.AutoSize = true;
            lbl_ID_PACIENTE.BackColor = Color.Transparent;
            lbl_ID_PACIENTE.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ID_PACIENTE.ForeColor = SystemColors.ActiveCaptionText;
            lbl_ID_PACIENTE.Location = new Point(501, 67);
            lbl_ID_PACIENTE.Name = "lbl_ID_PACIENTE";
            lbl_ID_PACIENTE.Size = new Size(97, 21);
            lbl_ID_PACIENTE.TabIndex = 2;
            lbl_ID_PACIENTE.Text = "ID PACIENTE";
            // 
            // lbl_CORREO
            // 
            lbl_CORREO.AutoSize = true;
            lbl_CORREO.BackColor = Color.Transparent;
            lbl_CORREO.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CORREO.ForeColor = SystemColors.ActiveCaptionText;
            lbl_CORREO.Location = new Point(863, 67);
            lbl_CORREO.Name = "lbl_CORREO";
            lbl_CORREO.Size = new Size(71, 21);
            lbl_CORREO.TabIndex = 3;
            lbl_CORREO.Text = "CORREO";
            // 
            // lbl_FECHA_VENCIMIENTIO
            // 
            lbl_FECHA_VENCIMIENTIO.AutoSize = true;
            lbl_FECHA_VENCIMIENTIO.BackColor = Color.Transparent;
            lbl_FECHA_VENCIMIENTIO.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_FECHA_VENCIMIENTIO.ForeColor = SystemColors.ActiveCaptionText;
            lbl_FECHA_VENCIMIENTIO.Location = new Point(645, 67);
            lbl_FECHA_VENCIMIENTIO.Name = "lbl_FECHA_VENCIMIENTIO";
            lbl_FECHA_VENCIMIENTIO.Size = new Size(181, 21);
            lbl_FECHA_VENCIMIENTIO.TabIndex = 4;
            lbl_FECHA_VENCIMIENTIO.Text = "FECHA  DE NACIMIENTO";
            // 
            // lbl_TELEFONO
            // 
            lbl_TELEFONO.AutoSize = true;
            lbl_TELEFONO.BackColor = Color.Transparent;
            lbl_TELEFONO.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_TELEFONO.ForeColor = SystemColors.ActiveCaptionText;
            lbl_TELEFONO.Location = new Point(1108, 67);
            lbl_TELEFONO.Name = "lbl_TELEFONO";
            lbl_TELEFONO.Size = new Size(84, 21);
            lbl_TELEFONO.TabIndex = 7;
            lbl_TELEFONO.Text = "TELEFONO";
            // 
            // txt_BuscarNombreyApellido
            // 
            txt_BuscarNombreyApellido.Location = new Point(3, 24);
            txt_BuscarNombreyApellido.Name = "txt_BuscarNombreyApellido";
            txt_BuscarNombreyApellido.Size = new Size(306, 27);
            txt_BuscarNombreyApellido.TabIndex = 9;
            txt_BuscarNombreyApellido.TextChanged += txt_BuscarNombreyApellido_TextChanged;
            // 
            // txt_IDPACIENTE
            // 
            txt_IDPACIENTE.Location = new Point(501, 24);
            txt_IDPACIENTE.Name = "txt_IDPACIENTE";
            txt_IDPACIENTE.Size = new Size(125, 27);
            txt_IDPACIENTE.TabIndex = 10;
            // 
            // txt_CORREO
            // 
            txt_CORREO.Location = new Point(863, 24);
            txt_CORREO.Name = "txt_CORREO";
            txt_CORREO.Size = new Size(230, 27);
            txt_CORREO.TabIndex = 11;
            // 
            // txt_DOCUMENTO
            // 
            txt_DOCUMENTO.Location = new Point(328, 24);
            txt_DOCUMENTO.Name = "txt_DOCUMENTO";
            txt_DOCUMENTO.Size = new Size(153, 27);
            txt_DOCUMENTO.TabIndex = 12;
            // 
            // txt_FECHA_DE_NACIMIENTO
            // 
            txt_FECHA_DE_NACIMIENTO.Location = new Point(645, 24);
            txt_FECHA_DE_NACIMIENTO.Name = "txt_FECHA_DE_NACIMIENTO";
            txt_FECHA_DE_NACIMIENTO.Size = new Size(198, 27);
            txt_FECHA_DE_NACIMIENTO.TabIndex = 13;
            // 
            // txt_TELEFONO
            // 
            txt_TELEFONO.Location = new Point(1108, 24);
            txt_TELEFONO.Name = "txt_TELEFONO";
            txt_TELEFONO.Size = new Size(223, 27);
            txt_TELEFONO.TabIndex = 16;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.OldLace;
            btn_Salir.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Salir.Location = new Point(12, 68);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(112, 33);
            btn_Salir.TabIndex = 17;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // btn_Seleccionar
            // 
            btn_Seleccionar.BackColor = Color.OldLace;
            btn_Seleccionar.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Seleccionar.Location = new Point(162, 68);
            btn_Seleccionar.Name = "btn_Seleccionar";
            btn_Seleccionar.Size = new Size(100, 33);
            btn_Seleccionar.TabIndex = 18;
            btn_Seleccionar.Text = "Seleccionar";
            btn_Seleccionar.UseVisualStyleBackColor = false;
            btn_Seleccionar.Click += btn_Seleccionar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(lbl_CORREO);
            panel1.Controls.Add(lbl_NOMBRE_Y_APELLIDO);
            panel1.Controls.Add(txt_DOCUMENTO);
            panel1.Controls.Add(lbl_TELEFONO);
            panel1.Controls.Add(txt_TELEFONO);
            panel1.Controls.Add(txt_BuscarNombreyApellido);
            panel1.Controls.Add(lbl_DOCUMENTO);
            panel1.Controls.Add(txt_IDPACIENTE);
            panel1.Controls.Add(txt_FECHA_DE_NACIMIENTO);
            panel1.Controls.Add(lbl_ID_PACIENTE);
            panel1.Controls.Add(txt_CORREO);
            panel1.Controls.Add(lbl_FECHA_VENCIMIENTIO);
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(4, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(1344, 99);
            panel1.TabIndex = 20;
            // 
            // lbl_Busqueda_de_Paciente
            // 
            lbl_Busqueda_de_Paciente.AutoSize = true;
            lbl_Busqueda_de_Paciente.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Busqueda_de_Paciente.Location = new Point(15, 19);
            lbl_Busqueda_de_Paciente.Name = "lbl_Busqueda_de_Paciente";
            lbl_Busqueda_de_Paciente.Size = new Size(195, 24);
            lbl_Busqueda_de_Paciente.TabIndex = 21;
            lbl_Busqueda_de_Paciente.Text = "Busqueda de Paciente";
            // 
            // dgv_Busqueda_Pax
            // 
            dgv_Busqueda_Pax.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Busqueda_Pax.Location = new Point(4, 224);
            dgv_Busqueda_Pax.Name = "dgv_Busqueda_Pax";
            dgv_Busqueda_Pax.ReadOnly = true;
            dgv_Busqueda_Pax.RowHeadersWidth = 51;
            dgv_Busqueda_Pax.Size = new Size(1344, 291);
            dgv_Busqueda_Pax.TabIndex = 22;
            // 
            // Busqueda_Paciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1350, 527);
            Controls.Add(dgv_Busqueda_Pax);
            Controls.Add(lbl_Busqueda_de_Paciente);
            Controls.Add(panel1);
            Controls.Add(btn_Seleccionar);
            Controls.Add(btn_Salir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Busqueda_Paciente";
            Text = "SET";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Busqueda_Pax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_NOMBRE_Y_APELLIDO;
        private Label lbl_DOCUMENTO;
        private Label lbl_ID_PACIENTE;
        private Label lbl_CORREO;
        private Label lbl_FECHA_VENCIMIENTIO;
        private Label lbl_TELEFONO;
        private TextBox txt_BuscarNombreyApellido;
        private TextBox txt_IDPACIENTE;
        private TextBox txt_CORREO;
        private TextBox txt_DOCUMENTO;
        private TextBox txt_FECHA_DE_NACIMIENTO;
        private TextBox txt_TELEFONO;
        private Button btn_Salir;
        private Button btn_Seleccionar;
        private Panel panel1;
        private Label lbl_Busqueda_de_Paciente;
        private DataGridView dgv_Busqueda_Pax;
    }
}