namespace pryValinottiTP240524
{
    partial class frmRegistro
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
            cmdRegistrarse = new Button();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            cbPerfil = new ComboBox();
            SuspendLayout();
            // 
            // cmdRegistrarse
            // 
            cmdRegistrarse.Location = new Point(124, 237);
            cmdRegistrarse.Name = "cmdRegistrarse";
            cmdRegistrarse.Size = new Size(96, 42);
            cmdRegistrarse.TabIndex = 10;
            cmdRegistrarse.Text = "Registrarse";
            cmdRegistrarse.UseVisualStyleBackColor = true;
            cmdRegistrarse.Click += cmdRegistrarse_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 190);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(321, 23);
            txtPassword.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 166);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 8;
            label3.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 74);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(321, 23);
            txtUsuario.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 6;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 11;
            label2.Text = "Registrarse";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 109);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 12;
            label4.Text = "Perfil";
            // 
            // cbPerfil
            // 
            cbPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPerfil.FormattingEnabled = true;
            cbPerfil.Items.AddRange(new object[] { "Ventas", "Compras", "Secretaría" });
            cbPerfil.Location = new Point(12, 133);
            cbPerfil.Name = "cbPerfil";
            cbPerfil.Size = new Size(321, 23);
            cbPerfil.TabIndex = 13;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 289);
            Controls.Add(cbPerfil);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(cmdRegistrarse);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Name = "frmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrarse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdRegistrarse;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsuario;
        private Label label1;
        private Label label2;
        private Label label4;
        private ComboBox cbPerfil;
    }
}