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
    
    public partial class frmPessoaSelecao : Form
    {
        public frmPessoaSelecao()
        {
            InitializeComponent();
            dataGridViewPrincipal.AutoGenerateColumns = false;
        }

        private void btnSelecao_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
        int mem = 0; int cong = 0;      
        private void AtualizarGrid()
        {
            PessoaNegocios pessoaNegocios = new PessoaNegocios();

            PessoaColecao pessoaColecao = pessoaNegocios.ConsultarPorNome(textBoxPesquisa.Text);
            int mem = 0; int cong = 0;
            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = pessoaColecao;
            dataGridViewPrincipal.Update();
            dataGridViewPrincipal.Refresh();
            foreach (Pessoa item in pessoaColecao)
            {
                if (item.Stat == "Membro")
                    mem = mem + 1;
                if (item.Stat == "Congregado")
                    cong = cong + 1;
            }
            lblMem.Text = Convert.ToString(mem);
            lblCong.Text = Convert.ToString(cong);

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            frmPessoaCadastro frmPCad = new frmPessoaCadastro(AcaoNaTela.Inserir, null);

            DialogResult dialogResult = frmPCad.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
            //vericar se tem registro selecionado
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nemhum nome selecionado");
                return;
            }
            
            //Pegar a Pessoa selecionada no grid
            Pessoa pessoaSelecionada = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Pessoa);

            frmPessoaCadastro frmPessoaCadastrar = new frmPessoaCadastro(AcaoNaTela.Alterar, pessoaSelecionada);

            DialogResult dialogResult = frmPessoaCadastrar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //vericar se tem registro selecionado
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nemhum nome selecionado");
                return;
            }
            // Perguntar se realmente quer excluir
            DialogResult resultado = MessageBox.Show("Tem certeza da exclusão?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            //Pegar a Pessoa selecionada no grid
            Pessoa pessoaSelecionada = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Pessoa);
            //Instanciar a regra de negócios
            PessoaNegocios pessoaNegocios = new PessoaNegocios();
            //chamar o método p excluir
            string retorno = pessoaNegocios.Excluir(pessoaSelecionada);

            //Verificar sexcluiu com sucesso
            //Se o retorno um numero é pq deu certo, senão é uma mesagem de erro
            try
            {
                int IDPessoa = Convert.ToInt32(retorno);
                MessageBox.Show(
                    "Pessoa excluída com sucesso",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                AtualizarGrid();
            }
            catch
            {
                MessageBox.Show(
                    "Não foi possível excluir. Detalhes: " + retorno,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dataGridViewPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        
    }
}