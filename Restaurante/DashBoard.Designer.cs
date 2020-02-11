namespace Restaurante
{
    partial class DashBoard
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
            this.Painel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PainelCadastro = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnProdutos = new System.Windows.Forms.Button();
            this.BtnMesas = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.Painel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PainelCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // Painel
            // 
            this.Painel.Controls.Add(this.pictureBox1);
            this.Painel.Location = new System.Drawing.Point(309, 31);
            this.Painel.Name = "Painel";
            this.Painel.Size = new System.Drawing.Size(887, 566);
            this.Painel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Restaurante.Properties.Resources.Billyjackw2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(887, 566);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Billy Jack";
            // 
            // PainelCadastro
            // 
            this.PainelCadastro.BackColor = System.Drawing.Color.DarkOrange;
            this.PainelCadastro.BackgroundImage = global::Restaurante.Properties.Resources.frente_pra_tras;
            this.PainelCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PainelCadastro.Controls.Add(this.button5);
            this.PainelCadastro.Controls.Add(this.button4);
            this.PainelCadastro.Controls.Add(this.BtnClientes);
            this.PainelCadastro.Controls.Add(this.BtnProdutos);
            this.PainelCadastro.Controls.Add(this.BtnMesas);
            this.PainelCadastro.Location = new System.Drawing.Point(0, -2);
            this.PainelCadastro.Name = "PainelCadastro";
            this.PainelCadastro.Size = new System.Drawing.Size(303, 610);
            this.PainelCadastro.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(153, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 60);
            this.button5.TabIndex = 10;
            this.button5.Text = "Entregador";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(153, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 60);
            this.button4.TabIndex = 9;
            this.button4.Text = "Delivery";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackColor = System.Drawing.Color.Transparent;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Location = new System.Drawing.Point(3, 129);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(147, 60);
            this.BtnClientes.TabIndex = 2;
            this.BtnClientes.Text = "Consultar";
            this.BtnClientes.UseVisualStyleBackColor = false;
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.BackColor = System.Drawing.Color.Transparent;
            this.BtnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProdutos.Location = new System.Drawing.Point(3, 66);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Size = new System.Drawing.Size(147, 60);
            this.BtnProdutos.TabIndex = 1;
            this.BtnProdutos.Text = "Registrar";
            this.BtnProdutos.UseVisualStyleBackColor = false;
            this.BtnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // BtnMesas
            // 
            this.BtnMesas.BackColor = System.Drawing.Color.Transparent;
            this.BtnMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMesas.Location = new System.Drawing.Point(3, 4);
            this.BtnMesas.Name = "BtnMesas";
            this.BtnMesas.Size = new System.Drawing.Size(147, 60);
            this.BtnMesas.TabIndex = 0;
            this.BtnMesas.Text = "Mesas";
            this.BtnMesas.UseVisualStyleBackColor = false;
            this.BtnMesas.Click += new System.EventHandler(this.BtnMesas_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnMinimizar.BackgroundImage = global::Restaurante.Properties.Resources.frente_pra_tras;
            this.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimizar.Location = new System.Drawing.Point(1141, 2);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(23, 23);
            this.BtnMinimizar.TabIndex = 5;
            this.BtnMinimizar.Text = "-";
            this.BtnMinimizar.UseVisualStyleBackColor = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnFechar.BackgroundImage = global::Restaurante.Properties.Resources.frente_pra_tras;
            this.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Location = new System.Drawing.Point(1166, 2);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(22, 23);
            this.BtnFechar.TabIndex = 4;
            this.BtnFechar.Text = "X";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PainelCadastro);
            this.Controls.Add(this.BtnMinimizar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.Painel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Painel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PainelCadastro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Panel PainelCadastro;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnProdutos;
        private System.Windows.Forms.Button BtnMesas;
        private System.Windows.Forms.Panel Painel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}