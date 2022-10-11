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
    public partial class frmCongregados : Form
    {
        public frmCongregados()
        {
            InitializeComponent();
        }

        private void frmCongregados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ibrnDataSet.tblPessoa' table. You can move, or remove it, as needed.
            this.tblPessoaTableAdapter.Fill(this.ibrnDataSet.tblPessoa);

            this.reportViewer1.RefreshReport();
        }
    }
}
