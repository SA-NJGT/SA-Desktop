using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios;
using System.IO;

namespace Restaurante.Cadastro_P_Panel
{
    
    public partial class telaClientes : UserControl
    {
        billy_jackEntities bd = new billy_jackEntities();
        string FileName;
        List<tabela_imagem> list;
        public telaClientes()
        {
            InitializeComponent();
            montarComboBox();
            pictureBox1.Click+= carregarImagem;
        }



        private void montarComboBox()
        {
            string[] selecao = {"Cliente","Entregador","Garçom"};

            List<string> listaCombo = new List<string>(selecao);
            comboBox1.DataSource = selecao;
            comboBox1.DisplayMember = selecao.ToString();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCEP.Text))
            {
                MessageBox.Show("Digite um CEP");
            }
            else
            {
                CorreiosApi correiosApi = new CorreiosApi();
                var retorno = correiosApi.consultaCEP(txtCEP.Text);
                if (retorno is null)
                {
                    MessageBox.Show("CEP não encontrado");
                }

                txtUF.Text = retorno.uf;
                txt_Cidade.Text = retorno.cidade;
                txt_Bairro.Text = retorno.bairro;
                txt_rua.Text = retorno.end;
            }
        }
        private void carregarImagem(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Selecione uma imagem...";
            openFileDialog1.Filter = "png|*.png| jpg|*.jpg| jpeg|*.jpeg";
            openFileDialog1.Title = "Open image file";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void Btn_SalvarDadosPessoais_Click(object sender, EventArgs e)
        {


                //verificar e registrar entregador
                if (comboBox1.SelectedItem.ToString() == "Entregador")
                {

                    if (txtBox_Complemento.Text == null)
                    {
                        tabela_dados_pessoais nova_pessoa = new tabela_dados_pessoais
                        {
                            id_tipo_pessoa = 2,
                            nome = txtBox_Nome.Text,
                            cpf = txtBox_CPF.Text,
                            telefone = txtBox_Telefone.Text,
                            
                            
                            uf = txtUF.Text,
                            cidade = txt_Cidade.Text,
                            bairro = txt_Bairro.Text,
                            rua = txt_rua.Text,
                            numero = txt_Numero.Text,
                            cep = txtCEP.Text
                            
                        };
                        bd.tabela_dados_pessoais.Add(nova_pessoa);
                        bd.SaveChanges();
                    using (billy_jackEntities bd = new billy_jackEntities())
                    {
                        tabela_imagem pic = new tabela_imagem() { FileName = FileName, Data = ConvertImageToBinary(pictureBox1.Image) };
                        bd.tabela_imagem.Add(pic);
                        bd.SaveChanges();
                        
                    }
                    MessageBox.Show("Salvo com sucesso!");
                    }
                    else
                    {
                        tabela_dados_pessoais nova_pessoa = new tabela_dados_pessoais
                        {
                            id_tipo_pessoa = 2,
                            nome = txtBox_Nome.Text,
                            cpf = txtBox_CPF.Text,
                            telefone = txtBox_Telefone.Text,

                            uf = txtUF.Text,
                            cidade = txt_Cidade.Text,
                            bairro = txt_Bairro.Text,
                            rua = txt_rua.Text,
                            numero = txt_Numero.Text,
                            complemento = txtBox_Complemento.Text,
                            cep = txtCEP.Text
                        };
                        bd.tabela_dados_pessoais.Add(nova_pessoa);
                        bd.SaveChanges();
                        MessageBox.Show("Salvo com sucesso!");
                    }
                    //verificar e registrar cliente
                    if (comboBox1.SelectedItem.ToString() == "Cliente")
                    {

                        if (txtBox_Complemento.Text == null)
                        {
                            tabela_dados_pessoais nova_pessoa = new tabela_dados_pessoais
                            {
                                id_tipo_pessoa = 1,
                                nome = txtBox_Nome.Text,
                                cpf = txtBox_CPF.Text,
                                telefone = txtBox_Telefone.Text,

                                uf = txtUF.Text,
                                cidade = txt_Cidade.Text,
                                bairro = txt_Bairro.Text,
                                rua = txt_rua.Text,
                                numero = txt_Numero.Text,
                                cep = txtCEP.Text
                            };
                            bd.tabela_dados_pessoais.Add(nova_pessoa);
                            bd.SaveChanges();
                            MessageBox.Show("Salvo com sucesso!");
                        }
                        else
                        {
                            tabela_dados_pessoais nova_pessoa = new tabela_dados_pessoais
                            {
                                id_tipo_pessoa = 1,
                                nome = txtBox_Nome.Text,
                                cpf = txtBox_CPF.Text,
                                telefone = txtBox_Telefone.Text,

                                uf = txtUF.Text,
                                cidade = txt_Cidade.Text,
                                bairro = txt_Bairro.Text,
                                rua = txt_rua.Text,
                                numero = txt_Numero.Text,
                                complemento = txtBox_Complemento.Text,
                                cep = txtCEP.Text
                            };
                            bd.tabela_dados_pessoais.Add(nova_pessoa);
                            bd.SaveChanges();
                            MessageBox.Show("Salvo com sucesso!");
                        }
                        //verificar e registrar garçom
                        if (comboBox1.SelectedItem.ToString() == "Garçom")
                        {

                            if (txtBox_Complemento.Text == null)
                            {
                                tabela_dados_pessoais nova_pessoa = new tabela_dados_pessoais
                                {
                                    id_tipo_pessoa = 3,
                                    nome = txtBox_Nome.Text,
                                    cpf = txtBox_CPF.Text,
                                    telefone = txtBox_Telefone.Text,

                                    uf = txtUF.Text,
                                    cidade = txt_Cidade.Text,
                                    bairro = txt_Bairro.Text,
                                    rua = txt_rua.Text,
                                    numero = txt_Numero.Text,
                                    cep = txtCEP.Text
                                };
                                bd.tabela_dados_pessoais.Add(nova_pessoa);
                                bd.SaveChanges();
                                MessageBox.Show("Salvo com sucesso!");
                            }
                            else
                            {
                                tabela_dados_pessoais nova_pessoa = new tabela_dados_pessoais
                                {
                                    id_tipo_pessoa = 3,
                                    nome = txtBox_Nome.Text,
                                    cpf = txtBox_CPF.Text,
                                    telefone = txtBox_Telefone.Text,

                                    uf = txtUF.Text,
                                    cidade = txt_Cidade.Text,
                                    bairro = txt_Bairro.Text,
                                    rua = txt_rua.Text,
                                    numero = txt_Numero.Text,
                                    complemento = txtBox_Complemento.Text,
                                    cep = txtCEP.Text
                                };
                                bd.tabela_dados_pessoais.Add(nova_pessoa);
                                bd.SaveChanges();
                                MessageBox.Show("Salvo com sucesso!");
                            }
                        }
                    }
                }
        }
    }
}
