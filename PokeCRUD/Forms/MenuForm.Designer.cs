﻿namespace PokeCRUD.Forms
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
            pictureBoxPokemon = new PictureBox();
            labelNomePokemon = new Label();
            btnProcurar = new Button();
            labelNome = new Label();
            Adicionar = new Button();
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
            // pictureBoxPokemon
            // 
            pictureBoxPokemon.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPokemon.Location = new Point(175, 125);
            pictureBoxPokemon.Name = "pictureBoxPokemon";
            pictureBoxPokemon.Size = new Size(100, 100);
            pictureBoxPokemon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPokemon.TabIndex = 2;
            pictureBoxPokemon.TabStop = false;
            // 
            // labelNomePokemon
            // 
            labelNomePokemon.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelNomePokemon.Location = new Point(175, 238);
            labelNomePokemon.Name = "labelNomePokemon";
            labelNomePokemon.Size = new Size(100, 25);
            labelNomePokemon.TabIndex = 3;
            labelNomePokemon.Text = "N/A";
            labelNomePokemon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnProcurar
            // 
            btnProcurar.Location = new Point(188, 276);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(75, 23);
            btnProcurar.TabIndex = 4;
            btnProcurar.Text = "Procurar";
            btnProcurar.UseVisualStyleBackColor = true;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(79, 14);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(12, 15);
            labelNome.TabIndex = 5;
            labelNome.Text = "-";
            // 
            // Adicionar
            // 
            Adicionar.Location = new Point(288, 136);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(75, 23);
            Adicionar.TabIndex = 6;
            Adicionar.Text = "Capturar";
            Adicionar.UseVisualStyleBackColor = true;
            Adicionar.Click += Adicionar_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 361);
            Controls.Add(Adicionar);
            Controls.Add(labelNome);
            Controls.Add(btnProcurar);
            Controls.Add(labelNomePokemon);
            Controls.Add(pictureBoxPokemon);
            Controls.Add(label1);
            Name = "MenuForm";
            Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPokemon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBoxPokemon;
        private Label labelNomePokemon;
        private Button btnProcurar;
        private Label labelNome;
        private Button Adicionar;
    }
}