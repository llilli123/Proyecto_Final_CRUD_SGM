namespace CAPA_PRESENTACION
{
    partial class Selector_Turnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selector_Turnos));
            dgv_Turnos = new DataGridView();
            btn_Turnos_Seleccionar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Turnos).BeginInit();
            SuspendLayout();
            // 
            // dgv_Turnos
            // 
            dgv_Turnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Turnos.Location = new Point(12, 59);
            dgv_Turnos.Name = "dgv_Turnos";
            dgv_Turnos.ReadOnly = true;
            dgv_Turnos.RowHeadersWidth = 51;
            dgv_Turnos.Size = new Size(302, 379);
            dgv_Turnos.TabIndex = 0;
            dgv_Turnos.CellContentClick += dgvTurnos_CellDoubleClick;
            // 
            // btn_Turnos_Seleccionar
            // 
            btn_Turnos_Seleccionar.Image = (Image)resources.GetObject("btn_Turnos_Seleccionar.Image");
            btn_Turnos_Seleccionar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Turnos_Seleccionar.Location = new Point(35, 12);
            btn_Turnos_Seleccionar.Name = "btn_Turnos_Seleccionar";
            btn_Turnos_Seleccionar.Size = new Size(162, 41);
            btn_Turnos_Seleccionar.TabIndex = 1;
            btn_Turnos_Seleccionar.Text = "Seleccionar";
            btn_Turnos_Seleccionar.UseVisualStyleBackColor = true;
            btn_Turnos_Seleccionar.Click += btn_Turnos_Seleccionar_Click;
            // 
            // Selector_Turnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 450);
            Controls.Add(btn_Turnos_Seleccionar);
            Controls.Add(dgv_Turnos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Selector_Turnos";
            Text = "SET";
            Load += Selector_Turnos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Turnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Turnos;
        private Button btn_Turnos_Seleccionar;
    }
}