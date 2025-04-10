namespace CAPA_PRESENTACION
{
    partial class Menu_Recepcionista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Recepcionista));
            menuStrip_MenuRecepcionista = new MenuStrip();
            cITASToolStripMenuItem = new ToolStripMenuItem();
            gESTIONARToolStripMenuItem = new ToolStripMenuItem();
            listadoToolStripMenuItem = new ToolStripMenuItem();
            pacientesToolStripMenuItem = new ToolStripMenuItem();
            gestionarToolStripMenuItem1 = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            gestionToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            btn_Menu_Recepcion_Cita = new Button();
            btn_Menu_Recepcion_Pacientes = new Button();
            btn_Menu_Recepcion_Consulta = new Button();
            ptb_ImagenLOGO_Recpcion = new PictureBox();
            menuStrip_MenuRecepcionista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_ImagenLOGO_Recpcion).BeginInit();
            SuspendLayout();
            // 
            // menuStrip_MenuRecepcionista
            // 
            menuStrip_MenuRecepcionista.BackColor = SystemColors.ControlLightLight;
            menuStrip_MenuRecepcionista.ImageScalingSize = new Size(20, 20);
            menuStrip_MenuRecepcionista.Items.AddRange(new ToolStripItem[] { cITASToolStripMenuItem, pacientesToolStripMenuItem, consultaToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip_MenuRecepcionista.Location = new Point(0, 0);
            menuStrip_MenuRecepcionista.Name = "menuStrip_MenuRecepcionista";
            menuStrip_MenuRecepcionista.Size = new Size(850, 28);
            menuStrip_MenuRecepcionista.TabIndex = 6;
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
            gestionToolStripMenuItem.Size = new Size(142, 26);
            gestionToolStripMenuItem.Text = "Gestion";
            gestionToolStripMenuItem.Click += gestionToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(89, 24);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // btn_Menu_Recepcion_Cita
            // 
            btn_Menu_Recepcion_Cita.Image = (Image)resources.GetObject("btn_Menu_Recepcion_Cita.Image");
            btn_Menu_Recepcion_Cita.ImageAlign = ContentAlignment.TopCenter;
            btn_Menu_Recepcion_Cita.Location = new Point(12, 46);
            btn_Menu_Recepcion_Cita.Name = "btn_Menu_Recepcion_Cita";
            btn_Menu_Recepcion_Cita.Size = new Size(88, 83);
            btn_Menu_Recepcion_Cita.TabIndex = 8;
            btn_Menu_Recepcion_Cita.Text = "Citas";
            btn_Menu_Recepcion_Cita.TextAlign = ContentAlignment.BottomCenter;
            btn_Menu_Recepcion_Cita.UseVisualStyleBackColor = true;
            btn_Menu_Recepcion_Cita.Click += btn_Menu_Recepcion_Cita_Click;
            // 
            // btn_Menu_Recepcion_Pacientes
            // 
            btn_Menu_Recepcion_Pacientes.Image = (Image)resources.GetObject("btn_Menu_Recepcion_Pacientes.Image");
            btn_Menu_Recepcion_Pacientes.ImageAlign = ContentAlignment.TopCenter;
            btn_Menu_Recepcion_Pacientes.Location = new Point(12, 150);
            btn_Menu_Recepcion_Pacientes.Name = "btn_Menu_Recepcion_Pacientes";
            btn_Menu_Recepcion_Pacientes.Size = new Size(88, 83);
            btn_Menu_Recepcion_Pacientes.TabIndex = 9;
            btn_Menu_Recepcion_Pacientes.Text = "Pacientes";
            btn_Menu_Recepcion_Pacientes.TextAlign = ContentAlignment.BottomCenter;
            btn_Menu_Recepcion_Pacientes.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_Menu_Recepcion_Pacientes.UseVisualStyleBackColor = true;
            btn_Menu_Recepcion_Pacientes.Click += btn_Menu_Recepcion_Pacientes_Click;
            // 
            // btn_Menu_Recepcion_Consulta
            // 
            btn_Menu_Recepcion_Consulta.Image = (Image)resources.GetObject("btn_Menu_Recepcion_Consulta.Image");
            btn_Menu_Recepcion_Consulta.ImageAlign = ContentAlignment.TopCenter;
            btn_Menu_Recepcion_Consulta.Location = new Point(12, 254);
            btn_Menu_Recepcion_Consulta.Name = "btn_Menu_Recepcion_Consulta";
            btn_Menu_Recepcion_Consulta.Size = new Size(88, 80);
            btn_Menu_Recepcion_Consulta.TabIndex = 10;
            btn_Menu_Recepcion_Consulta.Text = "Consulta";
            btn_Menu_Recepcion_Consulta.TextAlign = ContentAlignment.BottomCenter;
            btn_Menu_Recepcion_Consulta.UseVisualStyleBackColor = true;
            btn_Menu_Recepcion_Consulta.Click += btn_Menu_Recepcion_Consulta_Click;
            // 
            // ptb_ImagenLOGO_Recpcion
            // 
            ptb_ImagenLOGO_Recpcion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ptb_ImagenLOGO_Recpcion.Image = (Image)resources.GetObject("ptb_ImagenLOGO_Recpcion.Image");
            ptb_ImagenLOGO_Recpcion.Location = new Point(0, 31);
            ptb_ImagenLOGO_Recpcion.Name = "ptb_ImagenLOGO_Recpcion";
            ptb_ImagenLOGO_Recpcion.Size = new Size(850, 445);
            ptb_ImagenLOGO_Recpcion.SizeMode = PictureBoxSizeMode.CenterImage;
            ptb_ImagenLOGO_Recpcion.TabIndex = 11;
            ptb_ImagenLOGO_Recpcion.TabStop = false;
            // 
            // Menu_Recepcionista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(850, 473);
            Controls.Add(btn_Menu_Recepcion_Consulta);
            Controls.Add(btn_Menu_Recepcion_Pacientes);
            Controls.Add(btn_Menu_Recepcion_Cita);
            Controls.Add(menuStrip_MenuRecepcionista);
            Controls.Add(ptb_ImagenLOGO_Recpcion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu_Recepcionista";
            Text = "SET";
            menuStrip_MenuRecepcionista.ResumeLayout(false);
            menuStrip_MenuRecepcionista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_ImagenLOGO_Recpcion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_MenuRecepcionista;
        private ToolStripMenuItem cITASToolStripMenuItem;
        private ToolStripMenuItem gESTIONARToolStripMenuItem;
        private ToolStripMenuItem listadoToolStripMenuItem;
        private ToolStripMenuItem pacientesToolStripMenuItem;
        private ToolStripMenuItem gestionarToolStripMenuItem1;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem gestionToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private Button btn_Menu_Recepcion_Cita;
        private Button btn_Menu_Recepcion_Pacientes;
        private Button btn_Menu_Recepcion_Consulta;
        private PictureBox ptb_ImagenLOGO_Recpcion;
    }
}