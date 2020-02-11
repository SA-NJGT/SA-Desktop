using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurante.Cadastro_P_Panel;

namespace Restaurante
{
    public partial class telaRegistro : UserControl
    {
        billy_jackEntities bd = new billy_jackEntities();
        public telaRegistro()
        {
            InitializeComponent();
        }

        private void Btn_abrirProdutos_Click(object sender, EventArgs e)
        {
            Cadastro_P_Panel.telaIndentificacao painel_ingredientes = new Cadastro_P_Panel.telaIndentificacao();
            if (panel1.Contains(painel_ingredientes) == false)
            {
                panel1.Controls.Add(painel_ingredientes);
                painel_ingredientes.Dock = DockStyle.Fill;
                painel_ingredientes.BringToFront();
            }
            else
            {
                painel_ingredientes.BringToFront();

            }
        }

        private void Btn_abrirCliente_Click(object sender, EventArgs e)
        {
            telaClientes tela_clientes = new telaClientes();
            if (panel1.Contains(tela_clientes) == false)
            {
                panel1.Controls.Add(tela_clientes);
                tela_clientes.Dock = DockStyle.Fill;
                tela_clientes.BringToFront();
            }
            else
            {
                tela_clientes.BringToFront();
            }
        }

        private void Btn_abrirIngredientes_Click(object sender, EventArgs e)
        {
            Ingredientes tela_ingredientes = new Ingredientes();
            if (panel1.Contains(tela_ingredientes) == false)
            {
                panel1.Controls.Add(tela_ingredientes);
                tela_ingredientes.Dock = DockStyle.Fill;
                tela_ingredientes.BringToFront();
            }
            else
            {
                tela_ingredientes.BringToFront();
            }
        }

        private void Btn_abrirMesa_Click(object sender, EventArgs e)
        {
            RegistroMesas tela_registroMesas = new RegistroMesas();
            if (panel1.Contains(tela_registroMesas) == false)
            {
                panel1.Controls.Add(tela_registroMesas);
                tela_registroMesas.Dock = DockStyle.Fill;
                tela_registroMesas.BringToFront();
            }
            else
            {
                tela_registroMesas.BringToFront();
            }
        }

        private void Btn_abrirCategoria_Click(object sender, EventArgs e)
        {
            RegistroCategoria tela_registroCategoria = new RegistroCategoria();
            if (panel1.Contains(tela_registroCategoria) == false)
            {
                panel1.Controls.Add(tela_registroCategoria);
                tela_registroCategoria.Dock = DockStyle.Fill;
                tela_registroCategoria.BringToFront();
            }
            else
            {
                tela_registroCategoria.BringToFront();
            }
        }
    }
    
}
