namespace Apresentacao
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pastoralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPorDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPorTítuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPessoaCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPessoaIntegrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImpressão = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTodosMembros = new System.Windows.Forms.ToolStripMenuItem();
            this.todosOsCongregadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluídosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.falecidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pGsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tesourariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.compromissosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patrimônioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pastoralToolStripMenuItem,
            this.pessoaToolStripMenuItem,
            this.gestãoToolStripMenuItem,
            this.tesourariaToolStripMenuItem,
            this.patrimônioToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.logarToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(876, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pastoralToolStripMenuItem
            // 
            this.pastoralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mensagensToolStripMenuItem});
            this.pastoralToolStripMenuItem.Name = "pastoralToolStripMenuItem";
            this.pastoralToolStripMenuItem.Size = new System.Drawing.Size(95, 30);
            this.pastoralToolStripMenuItem.Text = "Pastoral";
            // 
            // mensagensToolStripMenuItem
            // 
            this.mensagensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultarPorDataToolStripMenuItem,
            this.consultarPorTítuloToolStripMenuItem});
            this.mensagensToolStripMenuItem.Name = "mensagensToolStripMenuItem";
            this.mensagensToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.mensagensToolStripMenuItem.Text = "Mensagens";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // consultarPorDataToolStripMenuItem
            // 
            this.consultarPorDataToolStripMenuItem.Name = "consultarPorDataToolStripMenuItem";
            this.consultarPorDataToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.consultarPorDataToolStripMenuItem.Text = "Consultar por Data";
            this.consultarPorDataToolStripMenuItem.Click += new System.EventHandler(this.consultarPorDataToolStripMenuItem_Click);
            // 
            // consultarPorTítuloToolStripMenuItem
            // 
            this.consultarPorTítuloToolStripMenuItem.Name = "consultarPorTítuloToolStripMenuItem";
            this.consultarPorTítuloToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.consultarPorTítuloToolStripMenuItem.Text = "Consultar por Título";
            this.consultarPorTítuloToolStripMenuItem.Click += new System.EventHandler(this.consultarPorTítuloToolStripMenuItem_Click);
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPessoaCadastro,
            this.menuPessoaIntegrar,
            this.menuImpressão});
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(117, 30);
            this.pessoaToolStripMenuItem.Text = "Secretaria";
            // 
            // menuPessoaCadastro
            // 
            this.menuPessoaCadastro.Name = "menuPessoaCadastro";
            this.menuPessoaCadastro.Size = new System.Drawing.Size(176, 30);
            this.menuPessoaCadastro.Text = "Cadastro";
            this.menuPessoaCadastro.Click += new System.EventHandler(this.menuPessoaCadastro_Click);
            // 
            // menuPessoaIntegrar
            // 
            this.menuPessoaIntegrar.Name = "menuPessoaIntegrar";
            this.menuPessoaIntegrar.Size = new System.Drawing.Size(176, 30);
            this.menuPessoaIntegrar.Text = "Reintegrar";
            this.menuPessoaIntegrar.Click += new System.EventHandler(this.menuPessoaIntegrar_Click);
            // 
            // menuImpressão
            // 
            this.menuImpressão.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTodosMembros,
            this.todosOsCongregadosToolStripMenuItem,
            this.ausentesToolStripMenuItem,
            this.excluídosToolStripMenuItem,
            this.falecidosToolStripMenuItem});
            this.menuImpressão.Name = "menuImpressão";
            this.menuImpressão.Size = new System.Drawing.Size(176, 30);
            this.menuImpressão.Text = "Impressão";
            // 
            // menuTodosMembros
            // 
            this.menuTodosMembros.Name = "menuTodosMembros";
            this.menuTodosMembros.Size = new System.Drawing.Size(194, 30);
            this.menuTodosMembros.Text = "Membros";
            this.menuTodosMembros.Click += new System.EventHandler(this.menuTodosMembros_Click);
            // 
            // todosOsCongregadosToolStripMenuItem
            // 
            this.todosOsCongregadosToolStripMenuItem.Name = "todosOsCongregadosToolStripMenuItem";
            this.todosOsCongregadosToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.todosOsCongregadosToolStripMenuItem.Text = "Congregados";
            this.todosOsCongregadosToolStripMenuItem.Click += new System.EventHandler(this.todosOsCongregadosToolStripMenuItem_Click);
            // 
            // ausentesToolStripMenuItem
            // 
            this.ausentesToolStripMenuItem.Name = "ausentesToolStripMenuItem";
            this.ausentesToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.ausentesToolStripMenuItem.Text = "Ausentes";
            this.ausentesToolStripMenuItem.Click += new System.EventHandler(this.ausentesToolStripMenuItem_Click);
            // 
            // excluídosToolStripMenuItem
            // 
            this.excluídosToolStripMenuItem.Name = "excluídosToolStripMenuItem";
            this.excluídosToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.excluídosToolStripMenuItem.Text = "Excluídos";
            // 
            // falecidosToolStripMenuItem
            // 
            this.falecidosToolStripMenuItem.Name = "falecidosToolStripMenuItem";
            this.falecidosToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.falecidosToolStripMenuItem.Text = "Falecidos";
            // 
            // gestãoToolStripMenuItem
            // 
            this.gestãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pGsToolStripMenuItem,
            this.financeiroToolStripMenuItem});
            this.gestãoToolStripMenuItem.Name = "gestãoToolStripMenuItem";
            this.gestãoToolStripMenuItem.Size = new System.Drawing.Size(84, 30);
            this.gestãoToolStripMenuItem.Text = "Gestão";
            // 
            // pGsToolStripMenuItem
            // 
            this.pGsToolStripMenuItem.Enabled = false;
            this.pGsToolStripMenuItem.Name = "pGsToolStripMenuItem";
            this.pGsToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.pGsToolStripMenuItem.Text = "PGs";
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.Enabled = false;
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // tesourariaToolStripMenuItem
            // 
            this.tesourariaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.financeiroToolStripMenuItem1,
            this.compromissosToolStripMenuItem});
            this.tesourariaToolStripMenuItem.Name = "tesourariaToolStripMenuItem";
            this.tesourariaToolStripMenuItem.Size = new System.Drawing.Size(118, 30);
            this.tesourariaToolStripMenuItem.Text = "Tesouraria";
            // 
            // financeiroToolStripMenuItem1
            // 
            this.financeiroToolStripMenuItem1.Enabled = false;
            this.financeiroToolStripMenuItem1.Name = "financeiroToolStripMenuItem1";
            this.financeiroToolStripMenuItem1.Size = new System.Drawing.Size(205, 30);
            this.financeiroToolStripMenuItem1.Text = "Financeiro";
            // 
            // compromissosToolStripMenuItem
            // 
            this.compromissosToolStripMenuItem.Enabled = false;
            this.compromissosToolStripMenuItem.Name = "compromissosToolStripMenuItem";
            this.compromissosToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.compromissosToolStripMenuItem.Text = "Compromissos";
            // 
            // patrimônioToolStripMenuItem
            // 
            this.patrimônioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.obrasToolStripMenuItem});
            this.patrimônioToolStripMenuItem.Name = "patrimônioToolStripMenuItem";
            this.patrimônioToolStripMenuItem.Size = new System.Drawing.Size(114, 30);
            this.patrimônioToolStripMenuItem.Text = "Patrimônio";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Enabled = false;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // obrasToolStripMenuItem
            // 
            this.obrasToolStripMenuItem.Enabled = false;
            this.obrasToolStripMenuItem.Name = "obrasToolStripMenuItem";
            this.obrasToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.obrasToolStripMenuItem.Text = "Obras";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(77, 30);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(60, 30);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // logarToolStripMenuItem
            // 
            this.logarToolStripMenuItem.Name = "logarToolStripMenuItem";
            this.logarToolStripMenuItem.Size = new System.Drawing.Size(73, 30);
            this.logarToolStripMenuItem.Text = "Logar";
            this.logarToolStripMenuItem.Click += new System.EventHandler(this.logarToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(85, 30);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 465);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Gestão de Igreja  - IDIG - IBRN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPessoaCadastro;
        private System.Windows.Forms.ToolStripMenuItem pastoralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensagensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pGsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tesourariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem compromissosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patrimônioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPessoaIntegrar;
        private System.Windows.Forms.ToolStripMenuItem menuImpressão;
        private System.Windows.Forms.ToolStripMenuItem menuTodosMembros;
        private System.Windows.Forms.ToolStripMenuItem todosOsCongregadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluídosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem falecidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPorDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPorTítuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
    }
}