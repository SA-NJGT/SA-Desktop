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
    public partial class Form1 : Form
    {
        billy_jackEntities bd = new billy_jackEntities();
        public static tabela_usuario usuario_logado = new tabela_usuario();
        public Form1()
        {
            InitializeComponent();
            BtnEntrar.Click += logar;
            btn_fechar.Click += fechar;
            btn_minimizar.Click += minimize;
        }

        private void minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        public void fechar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logar(object sender, EventArgs e)
        {
            // equivalente a SELECT * FROM usuario
            usuario_logado = bd.tabela_usuario.Where(u => u.login.Equals(txtLogin.Text)
            && u.senha.Equals(txtSenha.Text) && u.tipo_usuario == 1).FirstOrDefault();
            if (usuario_logado != null)
            {
                if (usuario_logado.tipo_usuario != 1)
                {
                    MessageBox.Show("Não é possivel logar");
                }
                if (usuario_logado.tipo_usuario == 1)
                {
                    DashBoard dashBoard = new DashBoard();
                    dashBoard.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Credenciais incorretas");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }



        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {

        }
    }
}
