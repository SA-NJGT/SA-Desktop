using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{

    public partial class RegistroMesas : UserControl
    {
        billy_jackEntities bd = new billy_jackEntities();
        public static tabela_mesas nova_mesa = new tabela_mesas();
        public RegistroMesas()
        {
            InitializeComponent();
            marcarCheckBox();
            btn_salvarMesa.Click += Salvar;
        }
        private void Salvar(object sender, EventArgs e)
        {
            tabela_mesas nova = new tabela_mesas
            {
                observacao = richTextBox1.Text,
                capacidade = Convert.ToInt32(numericUpDown_capacidade.Value),
                disponivel = checkBox1.Checked,
            };
            bd.tabela_mesas.Add(nova);
            bd.SaveChanges();
           
        }
        private void marcarCheckBox()
        {
            if (!checkBox1.Checked)
            {
                nova_mesa.disponivel= false;
            }
            else
            {
                nova_mesa.disponivel = true;
            }
        }
    }
}
