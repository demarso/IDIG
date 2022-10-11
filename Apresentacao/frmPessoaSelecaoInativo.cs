using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ibrn;
using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    
    public partial class frmPessoaSelecaoInativo : Form
    {
        public frmPessoaSelecaoInativo()
        {
            InitializeComponent();
            dataGridViewPrincipal.AutoGenerateColumns = false;
        }

        private void btnSelecao_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
               
        private void AtualizarGrid()
        {
            PessoaNegocios pessoaNegocios = new PessoaNegocios();

            PessoaColecao pessoaColecao = pessoaNegocios.ConsultarPessoaInativo(textBoxPesquisa.Text);

            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = pessoaColecao;
            dataGridViewPrincipal.Update();
            dataGridViewPrincipal.Refresh();
            lblNum.Text = Convert.ToString(dataGridViewPrincipal.RowCount);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReintegrar_Click(object sender, EventArgs e)
        {
            //vericar se tem registro selecionado
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nemhum nome selecionado");
                return;
            }
            // Perguntar se realmente quer excluir
            DialogResult resultado = MessageBox.Show("Tem certeza da reintegração?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            //Pegar a Pessoa selecionada no grid
            Pessoa pessoaSelecionada = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Pessoa);
            //Instanciar a regra de negócios
            PessoaNegocios pessoaNegocios = new PessoaNegocios();
            //chamar o método p excluir
            string retorno = pessoaNegocios.Reintegrar(pessoaSelecionada);

            //Verificar sexcluiu com sucesso
            //Se o retorno um numero é pq deu certo, senão é uma mesagem de erro
            try
            {
                int IDPessoa = Convert.ToInt32(retorno);
                MessageBox.Show(
                    "Pessoa Reintegrada com sucesso",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                AtualizarGrid();
            }
            catch
            {
                MessageBox.Show(
                    "Não foi possível Reintegrada. Detalhes: " + retorno,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void tnConsultar_Click(object sender, EventArgs e)
        {
            //vericar se tem registro selecionado
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nemhum nome selecionado");
                return;
            }

            //Pegar a Pessoa selecionada no grid
            Pessoa pessoaSelecionada = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Pessoa);

            frmPessoaCadastro frmPessoalCadastrar = new frmPessoaCadastro(AcaoNaTela.Consultar, pessoaSelecionada);


            frmPessoalCadastrar.ShowDialog();
        }

        private void frmPessoaSelecaoInativo_Load(object sender, EventArgs e)
        {

        }

        
        
    }
}