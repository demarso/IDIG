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


namespace Apresentacao
{
    public partial class frmMensagem : Form
    {
        public frmMensagem()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Mensagem mensagem = new Mensagem();

            mensagem.DataMensagem = dataMensagem.Value;
            mensagem.TituloMensagem = txtMensagemTítulo.Text;
            mensagem.ResumoMensagem = txtMensagemResumo.Text;

            MensagemNegocios mensagemNegocios = new MensagemNegocios();
            string retorno = mensagemNegocios.Inserir(mensagem);


            try
            {
                int id = Convert.ToInt32(retorno);
                MessageBox.Show("Mensagem inserida com sucesso: " + id.ToString());
                this.DialogResult = DialogResult.Yes;

            }
            catch
            {
                MessageBox.Show(
               "Não foi possível Inserir a Mensagem. Detalhes: " + retorno,
               "Erro",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
            }
        }
    }
}