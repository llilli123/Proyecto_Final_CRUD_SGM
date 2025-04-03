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
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView2 = new DataGridView();
            comboBox1 = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(264, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(686, 230);
            dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(8, 443);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(235, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(8, 49);
            button1.Name = "button1";
            button1.Size = new Size(235, 57);
            button1.TabIndex = 2;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
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
            dataGridView2.Location = new Point(264, 273);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(686, 220);
            dataGridView2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(8, 324);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(235, 28);
            comboBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 301);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 9;
            label1.Text = "Doctor";
            // 
            // Consulta_Gestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(962, 505);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Name = "Consulta_Gestion";
            Text = "Consulta_Gestion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView2;
        private ComboBox comboBox1;
        private Label label1;
    }
}