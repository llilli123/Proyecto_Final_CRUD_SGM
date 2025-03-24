namespace Proyecto_Final_CRUD_SGM
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btn_Login_Conectarse = new Button();
            btn_Login_Salir = new Button();
            txt_Login_Contrasena = new TextBox();
            txt_Login_Usuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Login_Conectarse
            // 
            btn_Login_Conectarse.Location = new Point(409, 272);
            btn_Login_Conectarse.Name = "btn_Login_Conectarse";
            btn_Login_Conectarse.Size = new Size(135, 46);
            btn_Login_Conectarse.TabIndex = 0;
            btn_Login_Conectarse.Text = "Conectarse";
            btn_Login_Conectarse.UseVisualStyleBackColor = true;
            // 
            // btn_Login_Salir
            // 
            btn_Login_Salir.Location = new Point(550, 272);
            btn_Login_Salir.Name = "btn_Login_Salir";
            btn_Login_Salir.Size = new Size(135, 46);
            btn_Login_Salir.TabIndex = 1;
            btn_Login_Salir.Text = "Salir";
            btn_Login_Salir.UseVisualStyleBackColor = true;
            btn_Login_Salir.Click += btn_Login_Salir_Click;
            // 
            // txt_Login_Contrasena
            // 
            txt_Login_Contrasena.Location = new Point(409, 210);
            txt_Login_Contrasena.Name = "txt_Login_Contrasena";
            txt_Login_Contrasena.Size = new Size(334, 27);
            txt_Login_Contrasena.TabIndex = 2;
            txt_Login_Contrasena.Text = "Contraseña";
            txt_Login_Contrasena.Enter += txt_Login_Contrasena_Enter;
            txt_Login_Contrasena.Leave += txt_Login_Contrasena_Leave;
            // 
            // txt_Login_Usuario
            // 
            txt_Login_Usuario.Location = new Point(409, 144);
            txt_Login_Usuario.Name = "txt_Login_Usuario";
            txt_Login_Usuario.Size = new Size(334, 27);
            txt_Login_Usuario.TabIndex = 3;
            txt_Login_Usuario.Text = "Usuario";
            txt_Login_Usuario.Enter += txt_Login_Usuario_Enter;
            txt_Login_Usuario.Leave += txt_Login_Usuario_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(409, 337);
            label1.Name = "label1";
            label1.Size = new Size(386, 119);
            label1.TabIndex = 4;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(409, 37);
            label2.Name = "label2";
            label2.Size = new Size(117, 38);
            label2.TabIndex = 5;
            label2.Text = "ACCESO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(325, 325);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 465);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Login_Usuario);
            Controls.Add(txt_Login_Contrasena);
            Controls.Add(btn_Login_Salir);
            Controls.Add(btn_Login_Conectarse);
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Login_Conectarse;
        private Button btn_Login_Salir;
        private TextBox txt_Login_Contrasena;
        private TextBox txt_Login_Usuario;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
