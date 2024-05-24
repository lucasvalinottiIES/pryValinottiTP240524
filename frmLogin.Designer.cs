namespace pryValinottiTP240524
{
    partial class frmLogin
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
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            cmdIniciar = new Button();
            cmdRegistrarse = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(135, 30);
            label2.TabIndex = 1;
            label2.Text = "Iniciar Sesion";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 77);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(321, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 148);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(321, 23);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // cmdIniciar
            // 
            cmdIniciar.Location = new Point(65, 195);
            cmdIniciar.Name = "cmdIniciar";
            cmdIniciar.Size = new Size(96, 42);
            cmdIniciar.TabIndex = 5;
            cmdIniciar.Text = "Iniciar Sesion";
            cmdIniciar.UseVisualStyleBackColor = true;
            cmdIniciar.Click += cmdIniciar_Click;
            // 
            // cmdRegistrarse
            // 
            cmdRegistrarse.Location = new Point(184, 195);
            cmdRegistrarse.Name = "cmdRegistrarse";
            cmdRegistrarse.Size = new Size(96, 42);
            cmdRegistrarse.TabIndex = 6;
            cmdRegistrarse.Text = "Registrarse";
            cmdRegistrarse.UseVisualStyleBackColor = true;
            cmdRegistrarse.Click += cmdRegistrarse_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 255);
            Controls.Add(cmdRegistrarse);
            Controls.Add(cmdIniciar);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Label label3;
        private Button cmdIniciar;
        private Button cmdRegistrarse;
    }
}
