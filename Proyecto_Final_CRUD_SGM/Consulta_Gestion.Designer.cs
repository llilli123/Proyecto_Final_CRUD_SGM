namespace CAPA_PRESENTACION
{
    partial class Consulta_Gestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Gestion));
            dgv_Paciente_Espera = new DataGridView();
            dtp_Consulta_Gestion_Fecha = new DateTimePicker();
            btn_Consulta_Gestion_Agregar = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView2 = new DataGridView();
            cmb_Consulta_Gestion_Doctor = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Paciente_Espera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dgv_Paciente_Espera
            // 
            dgv_Paciente_Espera.BackgroundColor = SystemColors.ControlLight;
            dgv_Paciente_Espera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Paciente_Espera.Location = new Point(231, 37);
            dgv_Paciente_Espera.Margin = new Padding(3, 2, 3, 2);
            dgv_Paciente_Espera.Name = "dgv_Paciente_Espera";
            dgv_Paciente_Espera.RowHeadersWidth = 51;
            dgv_Paciente_Espera.Size = new Size(635, 185);
            dgv_Paciente_Espera.TabIndex = 0;
            dgv_Paciente_Espera.CellContentClick += dgv_Paciente_Espera_CellContentClick;
            // 
            // dtp_Consulta_Gestion_Fecha
            // 
            dtp_Consulta_Gestion_Fecha.Format = DateTimePickerFormat.Short;
            dtp_Consulta_Gestion_Fecha.Location = new Point(8, 376);
            dtp_Consulta_Gestion_Fecha.Margin = new Padding(3, 2, 3, 2);
            dtp_Consulta_Gestion_Fecha.Name = "dtp_Consulta_Gestion_Fecha";
            dtp_Consulta_Gestion_Fecha.Size = new Size(206, 23);
            dtp_Consulta_Gestion_Fecha.TabIndex = 1;
            dtp_Consulta_Gestion_Fecha.ValueChanged += dtp_Consulta_Gestion_Fecha_Valor_Cambio;
            // 
            // btn_Consulta_Gestion_Agregar
            // 
            btn_Consulta_Gestion_Agregar.Image = (Image)resources.GetObject("btn_Consulta_Gestion_Agregar.Image");
            btn_Consulta_Gestion_Agregar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Consulta_Gestion_Agregar.Location = new Point(7, 37);
            btn_Consulta_Gestion_Agregar.Margin = new Padding(3, 2, 3, 2);
            btn_Consulta_Gestion_Agregar.Name = "btn_Consulta_Gestion_Agregar";
            btn_Consulta_Gestion_Agregar.Size = new Size(206, 43);
            btn_Consulta_Gestion_Agregar.TabIndex = 2;
            btn_Consulta_Gestion_Agregar.Text = "Agregar";
            btn_Consulta_Gestion_Agregar.UseVisualStyleBackColor = true;
            btn_Consulta_Gestion_Agregar.Click += btn_Consulta_Gestion_Agregar_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(7, 99);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(206, 43);
            button2.TabIndex = 3;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(7, 164);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(206, 43);
            button3.TabIndex = 4;
            button3.Text = "Atendido";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ControlLight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(231, 256);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(635, 165);
            dataGridView2.TabIndex = 7;
            // 
            // cmb_Consulta_Gestion_Doctor
            // 
            cmb_Consulta_Gestion_Doctor.FormattingEnabled = true;
            cmb_Consulta_Gestion_Doctor.Location = new Point(8, 326);
            cmb_Consulta_Gestion_Doctor.Margin = new Padding(3, 2, 3, 2);
            cmb_Consulta_Gestion_Doctor.Name = "cmb_Consulta_Gestion_Doctor";
            cmb_Consulta_Gestion_Doctor.Size = new Size(206, 23);
            cmb_Consulta_Gestion_Doctor.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 309);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 9;
            label1.Text = "Doctor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(231, 224);
            label2.Name = "label2";
            label2.Size = new Size(248, 32);
            label2.TabIndex = 10;
            label2.Text = "Pacientes Atendidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(231, 4);
            label3.Name = "label3";
            label3.Size = new Size(242, 32);
            label3.TabIndex = 11;
            label3.Text = "Pacientes En Espera";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 358);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 12;
            label4.Text = "Fecha";
            // 
            // Consulta_Gestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(877, 430);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmb_Consulta_Gestion_Doctor);
            Controls.Add(dataGridView2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_Consulta_Gestion_Agregar);
            Controls.Add(dtp_Consulta_Gestion_Fecha);
            Controls.Add(dgv_Paciente_Espera);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Consulta_Gestion";
            Text = "Consulta_Gestion";
            Load += Consulta_Gestion_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Paciente_Espera).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Paciente_Espera;
        private DateTimePicker dtp_Consulta_Gestion_Fecha;
        private Button btn_Consulta_Gestion_Agregar;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView2;
        private ComboBox cmb_Consulta_Gestion_Doctor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}