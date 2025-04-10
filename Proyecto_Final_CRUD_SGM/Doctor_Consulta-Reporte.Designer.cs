namespace CAPA_PRESENTACION
{
    partial class Doctor_Consulta_Reporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor_Consulta_Reporte));
            dgv_Pacientes_Atender_Doctor = new DataGridView();
            btn_start_asistencia = new Button();
            btn_Terminar_Ass = new Button();
            cmb_Doctor_Seleccion = new ComboBox();
            lbl_Doctor_consulta = new Label();
            dtp_Fecha_Seleccion_Doctor = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgv_Pacientes_Atender_Doctor).BeginInit();
            SuspendLayout();
            // 
            // dgv_Pacientes_Atender_Doctor
            // 
            dgv_Pacientes_Atender_Doctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Pacientes_Atender_Doctor.Location = new Point(292, 18);
            dgv_Pacientes_Atender_Doctor.Name = "dgv_Pacientes_Atender_Doctor";
            dgv_Pacientes_Atender_Doctor.ReadOnly = true;
            dgv_Pacientes_Atender_Doctor.RowHeadersWidth = 51;
            dgv_Pacientes_Atender_Doctor.Size = new Size(620, 420);
            dgv_Pacientes_Atender_Doctor.TabIndex = 0;
            dgv_Pacientes_Atender_Doctor.CellFormatting += dgv_Pacientes_Atender_Doctor_CellFormatting;
            // 
            // btn_start_asistencia
            // 
            btn_start_asistencia.Location = new Point(40, 18);
            btn_start_asistencia.Name = "btn_start_asistencia";
            btn_start_asistencia.Size = new Size(196, 60);
            btn_start_asistencia.TabIndex = 1;
            btn_start_asistencia.Text = "Empezar Asistencia";
            btn_start_asistencia.UseVisualStyleBackColor = true;
            btn_start_asistencia.Click += btn_start_asistencia_Click;
            // 
            // btn_Terminar_Ass
            // 
            btn_Terminar_Ass.Location = new Point(40, 123);
            btn_Terminar_Ass.Name = "btn_Terminar_Ass";
            btn_Terminar_Ass.Size = new Size(196, 63);
            btn_Terminar_Ass.TabIndex = 2;
            btn_Terminar_Ass.Text = "Terminar Asistencia";
            btn_Terminar_Ass.UseVisualStyleBackColor = true;
            btn_Terminar_Ass.Click += btn_Terminar_Ass_Click;
            // 
            // cmb_Doctor_Seleccion
            // 
            cmb_Doctor_Seleccion.FormattingEnabled = true;
            cmb_Doctor_Seleccion.Location = new Point(41, 351);
            cmb_Doctor_Seleccion.Name = "cmb_Doctor_Seleccion";
            cmb_Doctor_Seleccion.Size = new Size(195, 28);
            cmb_Doctor_Seleccion.TabIndex = 4;
            cmb_Doctor_Seleccion.SelectedIndexChanged += cmb_Doctor_Seleccion_SelectedIndexChanged;
            // 
            // lbl_Doctor_consulta
            // 
            lbl_Doctor_consulta.AutoSize = true;
            lbl_Doctor_consulta.Location = new Point(45, 327);
            lbl_Doctor_consulta.Name = "lbl_Doctor_consulta";
            lbl_Doctor_consulta.Size = new Size(55, 20);
            lbl_Doctor_consulta.TabIndex = 5;
            lbl_Doctor_consulta.Text = "Doctor";
            // 
            // dtp_Fecha_Seleccion_Doctor
            // 
            dtp_Fecha_Seleccion_Doctor.Location = new Point(41, 402);
            dtp_Fecha_Seleccion_Doctor.Name = "dtp_Fecha_Seleccion_Doctor";
            dtp_Fecha_Seleccion_Doctor.Size = new Size(195, 27);
            dtp_Fecha_Seleccion_Doctor.TabIndex = 6;
            dtp_Fecha_Seleccion_Doctor.ValueChanged += dtp_Fecha_Seleccion_Doctor_ValueChanged;
            // 
            // Doctor_Consulta_Reporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 450);
            Controls.Add(dtp_Fecha_Seleccion_Doctor);
            Controls.Add(lbl_Doctor_consulta);
            Controls.Add(cmb_Doctor_Seleccion);
            Controls.Add(btn_Terminar_Ass);
            Controls.Add(btn_start_asistencia);
            Controls.Add(dgv_Pacientes_Atender_Doctor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Doctor_Consulta_Reporte";
            Text = "SET";
            Load += Doctor_Consulta_Reporte_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Pacientes_Atender_Doctor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Pacientes_Atender_Doctor;
        private Button btn_start_asistencia;
        private Button btn_Terminar_Ass;
        private ComboBox cmb_Doctor_Seleccion;
        private Label lbl_Doctor_consulta;
        private DateTimePicker dtp_Fecha_Seleccion_Doctor;
    }
}