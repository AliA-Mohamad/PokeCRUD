namespace PokeCRUD.Forms
{
    partial class MenuForm
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
            labelNome = new Label();
            pictureBoxPokemon = new PictureBox();
            labelNomePokemon = new Label();
            btnProcurar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPokemon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(79, 9);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(16, 21);
            labelNome.TabIndex = 1;
            labelNome.Text = "-";
            // 
            // pictureBoxPokemon
            // 
            pictureBoxPokemon.Location = new Point(140, 122);
            pictureBoxPokemon.Name = "pictureBoxPokemon";
            pictureBoxPokemon.Size = new Size(100, 100);
            pictureBoxPokemon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPokemon.TabIndex = 2;
            pictureBoxPokemon.TabStop = false;
            // 
            // labelNomePokemon
            // 
            labelNomePokemon.AutoSize = true;
            labelNomePokemon.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelNomePokemon.Location = new Point(165, 225);
            labelNomePokemon.Name = "labelNomePokemon";
            labelNomePokemon.Size = new Size(53, 25);
            labelNomePokemon.TabIndex = 3;
            labelNomePokemon.Text = "Ditto";
            // 
            // btnProcurar
            // 
            btnProcurar.Location = new Point(152, 292);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(75, 23);
            btnProcurar.TabIndex = 4;
            btnProcurar.Text = "Procurar";
            btnProcurar.UseVisualStyleBackColor = true;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 348);
            Controls.Add(btnProcurar);
            Controls.Add(labelNomePokemon);
            Controls.Add(pictureBoxPokemon);
            Controls.Add(labelNome);
            Controls.Add(label1);
            Name = "MenuForm";
            Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPokemon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelNome;
        private PictureBox pictureBoxPokemon;
        private Label labelNomePokemon;
        private Button btnProcurar;
    }
}