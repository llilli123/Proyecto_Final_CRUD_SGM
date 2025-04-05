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
            dgv_Paciente_Espera.Location = new Point(264, 49);
            dgv_Paciente_Espera.Name = "dgv_Paciente_Espera";
            dgv_Paciente_Espera.RowHeadersWidth = 51;
            dgv_Paciente_Espera.Size = new Size(726, 247);
            dgv_Paciente_Espera.TabIndex = 0;
            // 
            // dtp_Consulta_Gestion_Fecha
            // 
            dtp_Consulta_Gestion_Fecha.Format = DateTimePickerFormat.Short;
            dtp_Consulta_Gestion_Fecha.Location = new Point(9, 501);
            dtp_Consulta_Gestion_Fecha.Name = "dtp_Consulta_Gestion_Fecha";
            dtp_Consulta_Gestion_Fecha.Size = new Size(235, 27);
            dtp_Consulta_Gestion_Fecha.TabIndex = 1;
            dtp_Consulta_Gestion_Fecha.ValueChanged += dtp_Consulta_Gestion_Fecha_Valor_Cambio;
            // 
            // btn_Consulta_Gestion_Agregar
            // 
            btn_Consulta_Gestion_Agregar.Image = (Image)resources.GetObject("btn_Consulta_Gestion_Agregar.Image");
            btn_Consulta_Gestion_Agregar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Consulta_Gestion_Agregar.Location = new Point(8, 49);
            btn_Consulta_Gestion_Agregar.Name = "btn_Consulta_Gestion_Agregar";
            btn_Consulta_Gestion_Agregar.Size = new Size(235, 57);
            btn_Consulta_Gestion_Agregar.TabIndex = 2;
            btn_Consulta_Gestion_Agregar.Text = "Agregar";
            btn_Consulta_Gestion_Agregar.UseVisualStyleBackColor = true;
            btn_Consulta_Gestion_Agregar.Click += btn_Consulta_Gestion_Agregar_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(8, 132);
            button2.Name = "button2";
            button2.Size = new Size(235, 57);
            button2.TabIndex = 3;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(8, 218);
            button3.Name = "button3";
            button3.Size = new Size(235, 57);
            button3.TabIndex = 4;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ControlLight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(264, 342);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(726, 220);
            dataGridView2.TabIndex = 7;
            // 
            // cmb_Consulta_Gestion_Doctor
            // 
            cmb_Consulta_Gestion_Doctor.FormattingEnabled = true;
            cmb_Consulta_Gestion_Doctor.Location = new Point(9, 435);
            cmb_Consulta_Gestion_Doctor.Name = "cmb_Consulta_Gestion_Doctor";
            cmb_Consulta_Gestion_Doctor.Size = new Size(235, 28);
            cmb_Consulta_Gestion_Doctor.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 412);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 9;
            label1.Text = "Doctor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(264, 299);
            label2.Name = "label2";
            label2.Size = new Size(305, 40);
            label2.TabIndex = 10;
            label2.Text = "Pacientes Atendidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(264, 6);
            label3.Name = "label3";
            label3.Size = new Size(296, 40);
            label3.TabIndex = 11;
            label3.Text = "Pacientes En Espera";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 478);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 12;
            label4.Text = "Fecha";
            // 
            // Consulta_Gestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1002, 574);
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