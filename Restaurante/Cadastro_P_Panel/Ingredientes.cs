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
    public partial class Ingredientes : UserControl
    {
        billy_jackEntities bd = new billy_jackEntities();
        public Ingredientes()
        {
            InitializeComponent();
            btnSalvar.Click += Salvar;
            montaTabela();
        }

        private void montaTabela()
        {
            dataGridView1.DataSource = bd.tabela_ingredientes.ToList();

        }

        private void Salvar(object sender, EventArgs e)
        {
            tabela_ingredientes novo = new tabela_ingredientes
            {
                nome_ingrediente = txtIngretiente.Text,
                preco_venda = numericUpDown_preco.Value,
                quantidade = Convert.ToInt32(numericUpDown_quantidade.Value)
            };
            bd.tabela_ingredientes.Add(novo);
            bd.SaveChanges();
            montaTabela();
        }

        private void Ingredientes_Load(object sender, EventArgs e)
        {
            numericUpDown_preco.Minimum = 0;
            numericUpDown_preco.DecimalPlaces = 2;
            numericUpDown_preco.Increment = 0.01m;
        }
    }
}
