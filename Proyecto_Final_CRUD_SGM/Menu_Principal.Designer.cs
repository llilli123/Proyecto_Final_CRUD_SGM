namespace CAPA_PRESENTACION
{
    partial class Menu_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            menuStrip1 = new MenuStrip();
            cITASToolStripMenuItem = new ToolStripMenuItem();
            gESTIONARToolStripMenuItem = new ToolStripMenuItem();
            listadoToolStripMenuItem = new ToolStripMenuItem();
            pacientesToolStripMenuItem = new ToolStripMenuItem();
            gestionarToolStripMenuItem1 = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            gestionToolStripMenuItem = new ToolStripMenuItem();
            doctorToolStripMenuItem = new ToolStripMenuItem();
            citasToolStripMenuItem1 = new ToolStripMenuItem();
            listadoDeDoctoresToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            btn_Menu_Principal_Cita = new Button();
            btn_Menu_Principal_Pacientes = new Button();
            btn_Menu_Principal_Consulta = new Button();
            btn_Menu_Principal_Reportes = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLightLight;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cITASToolStripMenuItem, pacientesToolStripMenuItem, consultaToolStripMenuItem, doctorToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(850, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // cITASToolStripMenuItem
            // 
            cITASToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gESTIONARToolStripMenuItem, listadoToolStripMenuItem });
            cITASToolStripMenuItem.Name = "cITASToolStripMenuItem";
            cITASToolStripMenuItem.Size = new Size(55, 24);
            cITASToolStripMenuItem.Text = "Citas";
            // 
            // gESTIONARToolStripMenuItem
            // 
            gESTIONARToolStripMenuItem.Name = "gESTIONARToolStripMenuItem";
            gESTIONARToolStripMenuItem.Size = new Size(155, 26);
            gESTIONARToolStripMenuItem.Text = "Gestionar";
            gESTIONARToolStripMenuItem.Click += gESTIONARToolStripMenuItem_Click;
            // 
            // listadoToolStripMenuItem
            // 
            listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            listadoToolStripMenuItem.Size = new Size(155, 26);
            listadoToolStripMenuItem.Text = "Listado";
            listadoToolStripMenuItem.Click += listadoToolStripMenuItem_Click;
            // 
            // pacientesToolStripMenuItem
            // 
            pacientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionarToolStripMenuItem1 });
            pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            pacientesToolStripMenuItem.Size = new Size(84, 24);
            pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // gestionarToolStripMenuItem1
            // 
            gestionarToolStripMenuItem1.Name = "gestionarToolStripMenuItem1";
            gestionarToolStripMenuItem1.Size = new Size(155, 26);
            gestionarToolStripMenuItem1.Text = "Gestionar";
            gestionarToolStripMenuItem1.Click += gestionarToolStripMenuItem1_Click;
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionToolStripMenuItem });
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(80, 24);
            consultaToolStripMenuItem.Text = "Consulta";
            // 
            // gestionToolStripMenuItem
            // 
            gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            gestionToolStripMenuItem.Size = new Size(224, 26);
            gestionToolStripMenuItem.Text = "Gestion";
            gestionToolStripMenuItem.Click += gestionToolStripMenuItem_Click;
            // 
            // doctorToolStripMenuItem
            // 
            doctorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { citasToolStripMenuItem1, listadoDeDoctoresToolStripMenuItem });
            doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            doctorToolStripMenuItem.Size = new Size(69, 24);
            doctorToolStripMenuItem.Text = "Doctor";
            // 
            // citasToolStripMenuItem1
            // 
            citasToolStripMenuItem1.Name = "citasToolStripMenuItem1";
            citasToolStripMenuItem1.Size = new Size(225, 26);
            citasToolStripMenuItem1.Text = "Reportes";
            citasToolStripMenuItem1.Click += citasToolStripMenuItem1_Click;
            // 
            // listadoDeDoctoresToolStripMenuItem
            // 
            listadoDeDoctoresToolStripMenuItem.Name = "listadoDeDoctoresToolStripMenuItem";
            listadoDeDoctoresToolStripMenuItem.Size = new Size(225, 26);
            listadoDeDoctoresToolStripMenuItem.Text = "Listado de Doctores";
            listadoDeDoctoresToolStripMenuItem.Click += listadoDeDoctoresToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(89, 24);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(106, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(744, 421);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btn_Menu_Principal_Cita
            // 
            btn_Menu_Principal_Cita.Image = (Image)resources.GetObject("btn_Menu_Principal_Cita.Image");
            btn_Menu_Principal_Cita.ImageAlign = ContentAlignment.TopCenter;
            btn_Menu_Principal_Cita.Location = new Point(12, 61);
            btn_Menu_Principal_Cita.Name = "btn_Menu_Principal_Cita";
            btn_Menu_Principal_Cita.Size = new Size(88, 83);
            btn_Menu_Principal_Cita.TabIndex = 7;
            btn_Menu_Principal_Cita.Text = "Citas";
            btn_Menu_Principal_Cita.TextAlign = ContentAlignment.BottomCenter;
            btn_Menu_Principal_Cita.UseVisualStyleBackColor = true;
            btn_Menu_Principal_Cita.Click += btn_Menu_Principal_Cita_Click;
            // 
            // btn_Menu_Principal_Pacientes
            // 
            btn_Menu_Principal_Pacientes.Image = (Image)resources.GetObject("btn_Menu_Principal_Pacientes.Image");
            btn_Menu_Principal_Pacientes.ImageAlign = ContentAlignment.TopCenter;
            btn_Menu_Principal_Pacientes.Location = new Point(12, 162);
            btn_Menu_Principal_Pacientes.Name = "btn_Menu_Principal_Pacientes";
            btn_Menu_Principal_Pacientes.Size = new Size(88, 83);
            btn_Menu_Principal_Pacientes.TabIndex = 8;
            btn_Menu_Principal_Pacientes.Text = "Pacientes";
            btn_Menu_Principal_Pacientes.TextAlign = ContentAlignment.BottomCenter;
            btn_Menu_Principal_Pacientes.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_Menu_Principal_Pacientes.UseVisualStyleBackColor = true;
            btn_Menu_Principal_Pacientes.Click += btn_Menu_Principal_Pacientes_Click;
            // 
            // btn_Menu_Principal_Consulta
            // 
            btn_Menu_Principal_Consulta.Image = (Image)resources.GetObject("btn_Menu_Principal_Consulta.Image");
            btn_Menu_Principal_Consulta.ImageAlign = ContentAlignment.TopCenter;
            btn_Menu_Principal_Consulta.Location = new Point(12, 263);
            btn_Menu_Principal_Consulta.Name = "btn_Menu_Principal_Consulta";
            btn_Menu_Principal_Consulta.Size = new Size(88, 80);
            btn_Menu_Principal_Consulta.TabIndex = 9;
            btn_Menu_Principal_Consulta.Text = "Consulta";
            btn_Menu_Principal_Consulta.TextAlign = ContentAlignment.BottomCenter;
            btn_Menu_Principal_Consulta.UseVisualStyleBackColor = true;
            btn_Menu_Principal_Consulta.Click += btn_Menu_Principal_Consulta_Click;
            // 
            // btn_Menu_Principal_Reportes
            // 
            btn_Menu_Principal_Reportes.Image = (Image)resources.GetObject("btn_Menu_Principal_Reportes.Image");
            btn_Menu_Principal_Reportes.ImageAlign = ContentAlignment.TopCenter;
            btn_Menu_Principal_Reportes.Location = new Point(12, 364);
            btn_Menu_Principal_Reportes.Name = "btn_Menu_Principal_Reportes";
            btn_Menu_Principal_Reportes.Size = new Size(88, 80);
            btn_Menu_Principal_Reportes.TabIndex = 10;
            btn_Menu_Principal_Reportes.Text = "Reportes";
            btn_Menu_Principal_Reportes.TextAlign = ContentAlignment.BottomCenter;
            btn_Menu_Principal_Reportes.UseVisualStyleBackColor = true;
            btn_Menu_Principal_Reportes.Click += btn_Menu_Principal_Reportes_Click;
            // 
            // Menu_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(850, 473);
            Controls.Add(btn_Menu_Principal_Reportes);
            Controls.Add(btn_Menu_Principal_Consulta);
            Controls.Add(btn_Menu_Principal_Pacientes);
            Controls.Add(btn_Menu_Principal_Cita);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu_Principal";
            Text = "SET";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cITASToolStripMenuItem;
        private ToolStripMenuItem gESTIONARToolStripMenuItem;
        private ToolStripMenuItem listadoToolStripMenuItem;
        private ToolStripMenuItem pacientesToolStripMenuItem;
        private ToolStripMenuItem gestionarToolStripMenuItem1;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem gestionToolStripMenuItem;
        private ToolStripMenuItem doctorToolStripMenuItem;
        private ToolStripMenuItem citasToolStripMenuItem1;
        private ToolStripMenuItem listadoDeDoctoresToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button btn_Menu_Principal_Cita;
        private Button btn_Menu_Principal_Pacientes;
        private Button btn_Menu_Principal_Consulta;
        private Button btn_Menu_Principal_Reportes;
    }
}