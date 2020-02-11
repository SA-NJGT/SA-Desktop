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
    public partial class telaIndentificacao : UserControl
    {
        billy_jackEntities bd = new billy_jackEntities();
        public telaIndentificacao()
        {
            InitializeComponent();
            btnSalvar.Click += Salvar;
            montarCombobox();
        }

        private void montarCombobox()
        {
            using (billy_jackEntities bd = new billy_jackEntities())
            {
                comboBox1.DataSource = bd.tabela_categoria.ToList();
                comboBox1.ValueMember = "id";
                comboBox1.DisplayMember = "nome_categoria";
            }
        }

        private void Salvar(object sender, EventArgs e)
        {
            tabela_identificacao_produto id = new tabela_identificacao_produto()
            {
                id = Convert.ToInt32(txtCod.Text),
                id_categoria = comboBox1.SelectedIndex,
                codbarras = txtBarra.Text,
                descricao = richtxtDes.Text,
                referencia = txtRef.Text,
            };
            bd.tabela_identificacao_produto.Add(id);
            bd.SaveChanges();
            MessageBox.Show("Salvo com sucesso");
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
