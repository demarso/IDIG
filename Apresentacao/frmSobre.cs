using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Apresentacao
{
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();
        }

       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.idbras.com.br");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("mailto:contato@idbras.com.br");
            
        }

        private void frmSobre_Load(object sender, EventArgs e)
        {
            label1.Text = "Versão: 1.0 " + Convert.ToChar(174);
            label8.Text = "CopyRight " + Convert.ToChar(169) + " 2014-" + DateTime.Now.Year;
        }

        
    }
}
