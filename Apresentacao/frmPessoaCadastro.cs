using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;



namespace ibrn
{
    public partial class frmPessoaCadastro : Form
    {
        AcaoNaTela acaoNaTelaSelecionada;



        public frmPessoaCadastro(AcaoNaTela acaoNaTela, Pessoa pessoa)
        {
            InitializeComponent();

            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Pessoa";
            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Pessoa";
                textBoxId.Text = pessoa.IDPessoa.ToString();
                textBoxStatus.Text = pessoa.Stat;
                textBoxNome.Text = pessoa.Nome;
                textBoxEndereco.Text = pessoa.Endereco;
                textBoxCEP.Text = pessoa.CEP;
                textBoxBairro.Text = pessoa.Bairro;
                textBoxCidade.Text = pessoa.Cidade;
                textBoxEstado.Text = pessoa.Estado;
                textBoxTelefone.Text = pessoa.Telefone;
                textBoxCelular.Text = pessoa.Celular;
                textBoxEmail.Text = pessoa.Email;
                dateNascimento.Value = pessoa.Nascimento;
                lblIdade.Visible = false;
                lblIdad.Visible = false;
                lblAnos.Visible = false;
                pictureBoxFoto.ImageLocation = @"C:\IDIG\Fotos\" + pessoa.Nome.ToString() + ".jpg";

            } 

            else if (acaoNaTela == AcaoNaTela.Consultar)
            {

                this.Text = "Consultar Pessoa";

                // Preencher a tela
                textBoxId.Text = pessoa.IDPessoa.ToString();
                textBoxStatus.Text = pessoa.Stat;
                textBoxNome.Text = pessoa.Nome;
                textBoxEndereco.Text = pessoa.Endereco;
                textBoxCEP.Text = pessoa.CEP;
                textBoxBairro.Text = pessoa.Bairro;
                textBoxCidade.Text = pessoa.Cidade;
                textBoxEstado.Text = pessoa.Estado;
                textBoxTelefone.Text = pessoa.Telefone;
                textBoxCelular.Text = pessoa.Celular;
                textBoxEmail.Text = pessoa.Email;
                dateNascimento.Value = pessoa.Nascimento;
                lblIdade.Visible = true;
                lblIdad.Visible = true;
                lblAnos.Visible = true;
                btnSalvar.Visible = false;
                pictureBoxFoto.ImageLocation = @"C:\IDIG\Fotos\" + pessoa.Nome.ToString() + ".jpg";

                //Cálculo da Idade                
                DateTime nasc = pessoa.Nascimento;
                //TimeSpan com a data atual menos data do niversário
                TimeSpan ts = DateTime.Today - nasc;
                //Converter TimeSpan para DateTime
                //Como o new DateTime() retorna 01/01/0001 00:00:00
                //vou ter que remover um ano .AddYears(- 1) e um dia .AddDays(-1) para ter a data exata.
                DateTime idade = (new DateTime() + ts).AddYears(-1).AddDays(-1);
                //Idade em anos
                lblIdade.Text = Convert.ToString(idade.Year);

                //Desabilitar campos
                dateCadastro.Enabled = false;
                dateCadastro.TabStop = false;
                textBoxNome.ReadOnly = true;
                textBoxNome.TabStop = false;
                textBoxEmail.ReadOnly = true;
                textBoxEmail.TabStop = false;
                dateNascimento.Enabled = false;
                dateNascimento.TabStop = false;
                textBoxTelefone.ReadOnly = true;
                textBoxTelefone.TabStop = false;
                textBoxCelular.ReadOnly = true;
                textBoxCelular.TabStop = false;
                textBoxEndereco.Enabled = false;
                textBoxEndereco.TabStop = false;
                textBoxCEP.Enabled = false;
                textBoxCEP.TabStop = false;
                textBoxBairro.Enabled = false;
                textBoxBairro.TabStop = false;
                textBoxCidade.Enabled = false;
                textBoxCidade.TabStop = false;
                textBoxEstado.ReadOnly = true;
                textBoxEstado.TabStop = false;
                textBoxStatus.Enabled = false;
                textBoxStatus.TabStop = false;
                btnFechar.Focus();


            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Verificar se é Inserção ou Alteração
            Pessoa pessoa = new Pessoa();

            if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
               // pessoa.IDPessoa = Convert.ToInt32(textBoxId.Text);
                if (textBoxStatus.Text == "Ausente")
                    pessoa.StatID = 0;
                else if (textBoxStatus.Text == "Membro")
                    pessoa.StatID = 1;
                else if (textBoxStatus.Text == "Congregado")
                    pessoa.StatID = 2;
                else if (textBoxStatus.Text == "Excluído")
                    pessoa.StatID = 3;
                else if (textBoxStatus.Text == "Falecido")
                    pessoa.StatID = 4;
                else if(textBoxStatus.Text == "Transferido")
                    pessoa.StatID = 5;

                pessoa.Nome = textBoxNome.Text;
                pessoa.Endereco = textBoxEndereco.Text;
                pessoa.CEP = Convert.ToString(textBoxCEP.Text);
                pessoa.Bairro = textBoxBairro.Text;
                pessoa.Cidade = textBoxCidade.Text;
                pessoa.Estado = textBoxEstado.Text;
                pessoa.Telefone = textBoxTelefone.Text;
                pessoa.Celular = textBoxCelular.Text;
                pessoa.Email = textBoxEmail.Text;
                pessoa.Nascimento = dateNascimento.Value;



                PessoaNegocios pessoaNegocios = new PessoaNegocios();
                string retorno = pessoaNegocios.Inserir(pessoa);


                try
                {
                    int id = Convert.ToInt32(retorno);
                    MessageBox.Show("Pessoa inserida com sucesso: " + id.ToString());
                    this.DialogResult = DialogResult.Yes;

                }
                catch
                {
                    MessageBox.Show(
                   "Não foi possível Inserir. Detalhes: " + retorno,
                   "Erro",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }


            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {

                pessoa.IDPessoa = Convert.ToInt32(textBoxId.Text);
                if (textBoxStatus.Text == "Ausente")
                    pessoa.StatID = 0;
                else if (textBoxStatus.Text == "Membro")
                    pessoa.StatID = 1;
                else if (textBoxStatus.Text == "Congregado")
                    pessoa.StatID = 2;
                else if (textBoxStatus.Text == "Excluído")
                    pessoa.StatID = 3;
                else if (textBoxStatus.Text == "Falecido")
                    pessoa.StatID = 4;
                else if (textBoxStatus.Text == "Transferido")
                    pessoa.StatID = 5;

                pessoa.Nome = textBoxNome.Text;
                pessoa.Endereco = textBoxEndereco.Text;
                pessoa.CEP = Convert.ToString(textBoxCEP.Text);
                pessoa.Bairro = textBoxBairro.Text;
                pessoa.Cidade = textBoxCidade.Text;
                pessoa.Estado = textBoxEstado.Text;
                pessoa.Telefone = textBoxTelefone.Text;
                pessoa.Celular = textBoxCelular.Text;
                pessoa.Email = textBoxEmail.Text;
                pessoa.Nascimento = dateNascimento.Value;

                PessoaNegocios pessoaNegocios = new PessoaNegocios();
                string retorno = pessoaNegocios.Alterar(pessoa);

                try
                {
                    int id = Convert.ToInt32(retorno);
                    MessageBox.Show("Pessoa alterada com sucesso: " + id.ToString());
                    this.DialogResult = DialogResult.Yes;
                    
                }
                catch
                {
                    MessageBox.Show(
                   "Não foi possível alterar. Detalhes: " + retorno,
                   "Erro",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Reinscrever)
            {


                PessoaNegocios pessoaNegocios = new PessoaNegocios();
                string retorno = pessoaNegocios.Reintegrar(pessoa);

                try
                {
                    int id = Convert.ToInt32(retorno);
                    MessageBox.Show("Pessoa Reinscrita com sucesso: " + id.ToString());
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show(
                   "Não foi possível reinscrever. Detalhes: " + retorno,
                   "Erro",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
        }
    }






}

