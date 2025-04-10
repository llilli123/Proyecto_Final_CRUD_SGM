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
            txt_BuscarNombreyApellido = new TextBox();
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
            // txt_BuscarNombreyApellido
            // 
            txt_BuscarNombreyApellido.Location = new Point(3, 24);
            txt_BuscarNombreyApellido.Name = "txt_BuscarNombreyApellido";
            txt_BuscarNombreyApellido.Size = new Size(628, 27);
            txt_BuscarNombreyApellido.TabIndex = 9;
            txt_BuscarNombreyApellido.TextChanged += txt_BuscarNombreyApellido_TextChanged;
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
            panel1.Controls.Add(lbl_NOMBRE_Y_APELLIDO);
            panel1.Controls.Add(txt_BuscarNombreyApellido);
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
        private TextBox txt_BuscarNombreyApellido;
        private Button btn_Salir;
        private Button btn_Seleccionar;
        private Panel panel1;
        private Label lbl_Busqueda_de_Paciente;
        private DataGridView dgv_Busqueda_Pax;
    }
}