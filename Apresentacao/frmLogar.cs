using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;

namespace Apresentacao
{
    public partial class frmLogar : Form
    {
        public frmLogar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            
            string NLog = txtLogin.Text;
            string Sen = txtSenha.Text;
                       
            //Instanciar a regra de negócios
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
            Usuario usuario = usuarioNegocios.Logar(NLog, Sen);

            string nomeLog = usuario.NomeLogin;
            int nivelLog = usuario.Nivel;

                Logar.autenticar(nomeLog, nivelLog);
            
            

                if (nomeLog != null)
                {
                    Logar.getTodos();
                    
                    frmPrincipal frmPr = new frmPrincipal();
                    frmPr.Show();
                   
                    Close();
                }
                else
                {
                    MessageBox.Show("Usuário não confere!!");
                    txtLogin.Text = "";
                    txtSenha.Text = "";
                }
           
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

    }
}
