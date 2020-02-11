using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class PedidosFRM : Form
    {
        tabela_mesas selecionada;
        billy_jackEntities bd = new billy_jackEntities();
        double totalMesa = 0;
        public PedidosFRM()
        {
            InitializeComponent();
        }

        public PedidosFRM(tabela_mesas mesaSelecionada)
        {
            selecionada = mesaSelecionada;
            InitializeComponent();
            label1.Text = $"Mesa {selecionada.id}";
            button1.Click += voltar;
            carregaCategorias();
            carregaProdutos();
            button3.Click += selecionarItem;
        }

        private void selecionarItem(object sender, EventArgs e)
        {
            int idProduto = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            tabela_produto p = bd.tabela_produto.Find(idProduto);
            int qtd = Convert.ToInt32(numericUpDown1.Value);
            tabela_pedidos pd = new tabela_pedidos()
            {
                data = DateTime.Now,
                id_mesa = selecionada.id
            };

            bd.tabela_pedidos.Add(pd);
            bd.SaveChanges();

            tabela_itens_produtos ip = new tabela_itens_produtos()
            {
                id_pedido = pd.id,
                id_produto = p.id,
                quantidade = qtd
            };

            bd.tabela_itens_produtos.Add(ip);
            bd.SaveChanges();
            MessageBox.Show("Item inserido com sucesso");

        }

        private void carregaProdutos()
        {
            dataGridView1.DataSource = bd.tabela_produto.Select(p => new {
                p.id,
                p.nome,
                p.preco
            }).ToList();
        }

        private void carregaCategorias()
        {
            comboBox1.DataSource = bd.tabela_categoria.Select(c => c.nome_categoria).ToList();

        }

        private void voltar(object sender, EventArgs e)
        {
            new Mesas().Show();
            this.Hide();
        }
    }
}
