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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(233, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(806, 493);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(35, 434);
            button1.Name = "button1";
            button1.Size = new Size(168, 33);
            button1.TabIndex = 2;
            button1.Text = "Buscar Cita";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
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
            // Listado_Citas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1051, 517);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Name = "Listado_Citas";
            Text = "Listado_Citas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
    }
}