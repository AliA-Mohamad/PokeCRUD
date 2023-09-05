namespace PokeCRUD.Forms
{
    partial class RegistroForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textEmail = new TextBox();
            textNome = new TextBox();
            textSenha = new TextBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(12, 33);
            textEmail.Name = "textEmail";
            textEmail.PlaceholderText = "Exemplo@exemplo.com";
            textEmail.Size = new Size(221, 23);
            textEmail.TabIndex = 3;
            // 
            // textNome
            // 
            textNome.Location = new Point(12, 98);
            textNome.Name = "textNome";
            textNome.PlaceholderText = "Digite um nome...";
            textNome.Size = new Size(221, 23);
            textNome.TabIndex = 4;
            // 
            // textSenha
            // 
            textSenha.Location = new Point(12, 163);
            textSenha.Name = "textSenha";
            textSenha.PlaceholderText = "*****";
            textSenha.Size = new Size(221, 23);
            textSenha.TabIndex = 5;
            textSenha.UseSystemPasswordChar = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(82, 209);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Enviar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // RegistroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 244);
            Controls.Add(btnRegistrar);
            Controls.Add(textSenha);
            Controls.Add(textNome);
            Controls.Add(textEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroForm";
            Text = "RegistroForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textEmail;
        private TextBox textNome;
        private TextBox textSenha;
        private Button btnRegistrar;
    }
}