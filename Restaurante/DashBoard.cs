using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurante.Cadastro_P_Panel;

namespace Restaurante
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMesas_Click(object sender, EventArgs e)
        {
            Mesas mesas = new Mesas();
            mesas.Show();
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            telaRegistro tela_registro = new telaRegistro();
            if (Painel.Contains(tela_registro) == false)
            {
                Painel.Controls.Add(tela_registro);
                tela_registro.Dock = DockStyle.Fill;
                tela_registro.BringToFront();
            }
            else
            {
                tela_registro.BringToFront();
            }
        }

        

        private void Button5_Click(object sender, EventArgs e)
        {
            Entrega ent = new Entrega();
            if (Painel.Contains(ent) == false)
            {
                Painel.Controls.Add(ent);
                ent.Dock = DockStyle.Fill;
                ent.BringToFront();
            }
            else
            {
                ent.BringToFront();
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Delivery del = new Delivery();
            if (Painel.Contains(del) == false)
            {
                Painel.Controls.Add(del);
                del.Dock = DockStyle.Fill;
                del.BringToFront();
            }
            else
            {
                del.BringToFront();
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Delivery del = new Delivery();
            if (Painel.Contains(del) == false)
            {
                Painel.Controls.Add(del);
                del.Dock = DockStyle.Fill;
                del.BringToFront();
            }
            else
            {
                del.BringToFront();
            }
        }
    }
}
