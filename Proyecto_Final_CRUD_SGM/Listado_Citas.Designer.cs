namespace CAPA_PRESENTACION
{
    partial class Listado_Citas
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
            dateTimePicker1 = new DateTimePicker();
            dgvCitas = new DataGridView();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btn_Eliminar = new Button();
            btn_Editar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(35, 122);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(168, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // dgvCitas
            // 
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.AllowUserToDeleteRows = false;
            dgvCitas.BackgroundColor = SystemColors.ControlLight;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(233, 12);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.RowHeadersWidth = 51;
            dgvCitas.Size = new Size(806, 380);
            dgvCitas.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Jorge cabrera", "Ezequiel Peguero", "Yulian Estenyer", "Percha" });
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(35, 199);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(168, 28);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 88);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 4;
            label1.Text = "Fecha De Consulta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 167);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 5;
            label2.Text = "Doctor";
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(58, 427);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(128, 37);
            btn_Eliminar.TabIndex = 6;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.Location = new Point(233, 427);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(146, 37);
            btn_Editar.TabIndex = 7;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // Listado_Citas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1051, 517);
            Controls.Add(btn_Editar);
            Controls.Add(btn_Eliminar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(dgvCitas);
            Controls.Add(dateTimePicker1);
            Name = "Listado_Citas";
            Text = "Listado_Citas";
            Load += Listado_Citas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DataGridView dgvCitas;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Button btn_Eliminar;
        private Button btn_Editar;
    }
}