using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            
           int nivel = Logar.getDados();

            
            if (nivel == 1)
            {
                pastoralToolStripMenuItem.Enabled = true;
                pessoaToolStripMenuItem.Enabled = true;
                gestãoToolStripMenuItem.Enabled = true;
                tesourariaToolStripMenuItem.Enabled = true;
                patrimônioToolStripMenuItem.Enabled = true;
                sobreToolStripMenuItem.Enabled = true;
                sairToolStripMenuItem.Enabled = true;
                logarToolStripMenuItem.Visible = false;
                fecharToolStripMenuItem.Visible = false;
            }
            else if (nivel == 2)
            {
                pastoralToolStripMenuItem.Enabled = false;
                pessoaToolStripMenuItem.Enabled = true;
                gestãoToolStripMenuItem.Enabled = false;
                tesourariaToolStripMenuItem.Enabled = false;
                patrimônioToolStripMenuItem.Enabled = false;
                sobreToolStripMenuItem.Enabled = true;
                sairToolStripMenuItem.Enabled = true;
                logarToolStripMenuItem.Visible = false;
                fecharToolStripMenuItem.Visible = false;

            }
            else if (nivel == 3)
            {
                pastoralToolStripMenuItem.Enabled = false;
                pessoaToolStripMenuItem.Enabled = true;
                gestãoToolStripMenuItem.Enabled = true;
                tesourariaToolStripMenuItem.Enabled = true;
                patrimônioToolStripMenuItem.Enabled = true;
                sobreToolStripMenuItem.Enabled = true;
                sairToolStripMenuItem.Enabled = true;
                logarToolStripMenuItem.Visible = false;
                fecharToolStripMenuItem.Visible = false;

            }
            else if (nivel == 4)
            {
                pastoralToolStripMenuItem.Enabled = false;
                pessoaToolStripMenuItem.Enabled = false;
                gestãoToolStripMenuItem.Enabled = false;
                tesourariaToolStripMenuItem.Enabled = true;
                patrimônioToolStripMenuItem.Enabled = false;
                sobreToolStripMenuItem.Enabled = true;
                sairToolStripMenuItem.Enabled = true;
                logarToolStripMenuItem.Visible = false;
                fecharToolStripMenuItem.Visible = false;

            }
            else if (nivel == 5)
            {
                pastoralToolStripMenuItem.Enabled = false;
                pessoaToolStripMenuItem.Enabled = false;
                gestãoToolStripMenuItem.Enabled = false;
                tesourariaToolStripMenuItem.Enabled = false;
                patrimônioToolStripMenuItem.Enabled = true;
                sobreToolStripMenuItem.Enabled = true;
                sairToolStripMenuItem.Enabled = true;
                logarToolStripMenuItem.Visible = false;
                fecharToolStripMenuItem.Visible = false;

            }
            else 
            {
                pastoralToolStripMenuItem.Visible = false;
                pessoaToolStripMenuItem.Visible = false;
                gestãoToolStripMenuItem.Visible = false;
                tesourariaToolStripMenuItem.Visible = false;
                patrimônioToolStripMenuItem.Visible = false;
                sobreToolStripMenuItem.Visible = false;
                sairToolStripMenuItem.Visible = false;
                logarToolStripMenuItem.Enabled = true;
                fecharToolStripMenuItem.Enabled = true;
            }


        }

        
        private void menuPessoaCadastro_Click(object sender, EventArgs e)
        {
            frmPessoaSelecao frmCadastar = new frmPessoaSelecao();
            frmCadastar.MdiParent = this;
            frmCadastar.Show();
        }

        private void menuPessoaIntegrar_Click(object sender, EventArgs e)
        {
            frmPessoaSelecaoInativo frmInativo = new frmPessoaSelecaoInativo();
            frmInativo.MdiParent = this;
            frmInativo.Show();
        }

        private void menuTodosMembros_Click(object sender, EventArgs e)
        {
            frmRelatTodosMembros frmRTM = new frmRelatTodosMembros();
            frmRTM.ShowDialog();
            frmRTM.Dispose();
        }

        private void todosOsCongregadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCongregados frmCong = new frmCongregados();
            frmCong.ShowDialog();
            frmCong.Dispose();
        }

        private void ausentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatAusentes frmAusentes = new frmRelatAusentes();
            frmAusentes.ShowDialog();
            frmAusentes.Dispose();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmSob = new frmSobre();
            frmSob.MdiParent = this;
            frmSob.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMensagem frmMem = new frmMensagem();
            frmMem.MdiParent = this;
            frmMem.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logar.sair();
            this.Close();
            
        }

        private void consultarPorDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMensagemCunsultaData frmConsData = new frmMensagemCunsultaData();
            frmConsData.MdiParent = this;
            frmConsData.Show();
        }

        private void consultarPorTítuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMensagemConsultaTitulo frmConsTitulo = new frmMensagemConsultaTitulo();
            frmConsTitulo.MdiParent = this;
            frmConsTitulo.Show();
        }

        private void logarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogar frmlogar = new frmLogar();
            frmlogar.MdiParent = this;
            frmlogar.Show();
            
        }

        public void reiniciar()
        {
            this.Refresh();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        
        
       
       
    }
}
