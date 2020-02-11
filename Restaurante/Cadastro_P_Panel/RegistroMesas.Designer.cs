namespace Restaurante
{
    partial class RegistroMesas
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_salvarMesa = new System.Windows.Forms.Button();
            this.numericUpDown_capacidade = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_capacidade)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(138, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Disponível";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // btn_salvarMesa
            // 
            this.btn_salvarMesa.Location = new System.Drawing.Point(3, 277);
            this.btn_salvarMesa.Name = "btn_salvarMesa";
            this.btn_salvarMesa.Size = new System.Drawing.Size(75, 23);
            this.btn_salvarMesa.TabIndex = 1;
            this.btn_salvarMesa.Text = "Salvar";
            this.btn_salvarMesa.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_capacidade
            // 
            this.numericUpDown_capacidade.Location = new System.Drawing.Point(3, 120);
            this.numericUpDown_capacidade.Name = "numericUpDown_capacidade";
            this.numericUpDown_capacidade.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_capacidade.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 175);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(338, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Capacidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Observação:";
            // 
            // RegistroMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.numericUpDown_capacidade);
            this.Controls.Add(this.btn_salvarMesa);
            this.Controls.Add(this.checkBox1);
            this.Name = "RegistroMesas";
            this.Size = new System.Drawing.Size(876, 475);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_capacidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_salvarMesa;
        private System.Windows.Forms.NumericUpDown numericUpDown_capacidade;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
