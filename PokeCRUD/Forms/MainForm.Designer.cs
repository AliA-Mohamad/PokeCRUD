namespace PokeCRUD
{
    partial class MainForm
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
            Gerar = new Button();
            adicionar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 32);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(108, 9);
            label2.Name = "label2";
            label2.Size = new Size(56, 32);
            label2.TabIndex = 1;
            label2.Text = "N/A";
            // 
            // Gerar
            // 
            Gerar.Location = new Point(27, 109);
            Gerar.Name = "Gerar";
            Gerar.Size = new Size(75, 23);
            Gerar.TabIndex = 2;
            Gerar.Text = "Gerar";
            Gerar.UseVisualStyleBackColor = true;
            Gerar.Click += Gerar_Click;
            // 
            // adicionar
            // 
            adicionar.Location = new Point(157, 109);
            adicionar.Name = "adicionar";
            adicionar.Size = new Size(75, 23);
            adicionar.TabIndex = 3;
            adicionar.Text = "Adicionar";
            adicionar.UseVisualStyleBackColor = true;
            adicionar.Click += adicionar_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 166);
            Controls.Add(adicionar);
            Controls.Add(Gerar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "PokeCRUD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button Gerar;
        private Button adicionar;
    }
}