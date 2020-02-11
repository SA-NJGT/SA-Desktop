using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurante.Properties;
using Restaurante;

namespace Restaurante
{
    public partial class Mesas : Form
    {
        billy_jackEntities bd = new billy_jackEntities();
        public Mesas()
        {
            InitializeComponent();
            montaMesas();
        }

        private void montaMesas()
        {
            bd.tabela_mesas.ToList().ForEach(m =>
            {
                Panel p = new Panel();
                p.Width = 160;
                p.Height = 160;
                p.BackColor = System.Drawing.Color.OrangeRed;
                p.Name = m.id.ToString();
                p.Click += selecionaMesa;

                Label nomeMesa = new Label();
                nomeMesa.Text = $"mesa {m.id}";
                p.Controls.Add(nomeMesa);

                PictureBox foto = new PictureBox();
                foto.Image = Resource.iconfinder_architecture_interior_27_809104__1_;
                p.Controls.Add(foto);

                flowLayoutPanel2.Controls.Add(p);
            });
        }

        private void selecionaMesa(object sender, EventArgs e)
        {
            Panel mesaSelecionada = (Panel)sender;
            tabela_mesas selecionada = bd.tabela_mesas.Find(Convert.ToInt32(mesaSelecionada.Name));
            new PedidosFRM(selecionada).Show();
            this.Hide();
        }

        private void InitializeComponent()
        {
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(960, 522);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutPanel2_Paint);
            // 
            // Mesas
            // 
            this.BackgroundImage = global::Restaurante.Properties.Resources.Billy_fade;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.flowLayoutPanel2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Mesas";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        private void FlowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
