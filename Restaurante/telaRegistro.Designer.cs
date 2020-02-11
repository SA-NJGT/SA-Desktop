namespace Restaurante
{
    partial class telaRegistro
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_abrirProdutos = new System.Windows.Forms.Button();
            this.btn_abrirCliente = new System.Windows.Forms.Button();
            this.btn_abrirIngredientes = new System.Windows.Forms.Button();
            this.btn_abrirMesa = new System.Windows.Forms.Button();
            this.btn_abrirCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(132, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 544);
            this.panel1.TabIndex = 2;
            // 
            // btn_abrirProdutos
            // 
            this.btn_abrirProdutos.Location = new System.Drawing.Point(6, 75);
            this.btn_abrirProdutos.Name = "btn_abrirProdutos";
            this.btn_abrirProdutos.Size = new System.Drawing.Size(91, 23);
            this.btn_abrirProdutos.TabIndex = 3;
            this.btn_abrirProdutos.Text = "Produtos";
            this.btn_abrirProdutos.UseVisualStyleBackColor = true;
            this.btn_abrirProdutos.Click += new System.EventHandler(this.Btn_abrirProdutos_Click);
            // 
            // btn_abrirCliente
            // 
            this.btn_abrirCliente.Location = new System.Drawing.Point(6, 104);
            this.btn_abrirCliente.Name = "btn_abrirCliente";
            this.btn_abrirCliente.Size = new System.Drawing.Size(91, 23);
            this.btn_abrirCliente.TabIndex = 4;
            this.btn_abrirCliente.Text = "Dados Pessoais";
            this.btn_abrirCliente.UseVisualStyleBackColor = true;
            this.btn_abrirCliente.Click += new System.EventHandler(this.Btn_abrirCliente_Click);
            // 
            // btn_abrirIngredientes
            // 
            this.btn_abrirIngredientes.Location = new System.Drawing.Point(6, 134);
            this.btn_abrirIngredientes.Name = "btn_abrirIngredientes";
            this.btn_abrirIngredientes.Size = new System.Drawing.Size(91, 23);
            this.btn_abrirIngredientes.TabIndex = 5;
            this.btn_abrirIngredientes.Text = "Ingredientes";
            this.btn_abrirIngredientes.UseVisualStyleBackColor = true;
            this.btn_abrirIngredientes.Click += new System.EventHandler(this.Btn_abrirIngredientes_Click);
            // 
            // btn_abrirMesa
            // 
            this.btn_abrirMesa.Location = new System.Drawing.Point(6, 163);
            this.btn_abrirMesa.Name = "btn_abrirMesa";
            this.btn_abrirMesa.Size = new System.Drawing.Size(91, 23);
            this.btn_abrirMesa.TabIndex = 6;
            this.btn_abrirMesa.Text = "Mesa";
            this.btn_abrirMesa.UseVisualStyleBackColor = true;
            this.btn_abrirMesa.Click += new System.EventHandler(this.Btn_abrirMesa_Click);
            // 
            // btn_abrirCategoria
            // 
            this.btn_abrirCategoria.Location = new System.Drawing.Point(6, 192);
            this.btn_abrirCategoria.Name = "btn_abrirCategoria";
            this.btn_abrirCategoria.Size = new System.Drawing.Size(91, 23);
            this.btn_abrirCategoria.TabIndex = 7;
            this.btn_abrirCategoria.Text = "Categoria";
            this.btn_abrirCategoria.UseVisualStyleBackColor = true;
            this.btn_abrirCategoria.Click += new System.EventHandler(this.Btn_abrirCategoria_Click);
            // 
            // telaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_abrirCategoria);
            this.Controls.Add(this.btn_abrirMesa);
            this.Controls.Add(this.btn_abrirIngredientes);
            this.Controls.Add(this.btn_abrirCliente);
            this.Controls.Add(this.btn_abrirProdutos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "telaRegistro";
            this.Size = new System.Drawing.Size(900, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_abrirProdutos;
        private System.Windows.Forms.Button btn_abrirCliente;
        private System.Windows.Forms.Button btn_abrirIngredientes;
        private System.Windows.Forms.Button btn_abrirMesa;
        private System.Windows.Forms.Button btn_abrirCategoria;
    }
}
