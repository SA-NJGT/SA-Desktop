using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante.Cadastro_P_Panel
{
    public partial class RegistroCategoria : UserControl
    {
        billy_jackEntities bd = new billy_jackEntities();
        public RegistroCategoria()
        {
            InitializeComponent();
            btn_salvarCategoria.Click += Salvar;
            montarTabela();
        }

        private void montarTabela()
        {
            dataGridView1.DataSource = bd.tabela_categoria.ToList();
        }

        private void Salvar(object sender, EventArgs e)
        {
            tabela_categoria nova_categoria = new tabela_categoria
            {
                nome_categoria = textBox1.Text,
                
            };
            bd.tabela_categoria.Add(nova_categoria);
            bd.SaveChanges();
            montarTabela();
        }
    }
}
