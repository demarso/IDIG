namespace Apresentacao
{
    partial class frmPessoaSelecaoInativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPessoaSelecaoInativo));
            this.dataGridViewPrincipal = new System.Windows.Forms.DataGridView();
            this.Ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.btnSelecao = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnReintegrar = new System.Windows.Forms.Button();
            this.tnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPrincipal
            // 
            this.dataGridViewPrincipal.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ordem,
            this.IDPessoa,
            this.Nome,
            this.Telefome,
            this.Celular,
            this.Email,
            this.Status});
            this.dataGridViewPrincipal.Location = new System.Drawing.Point(11, 108);
            this.dataGridViewPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPrincipal.Name = "dataGridViewPrincipal";
            this.dataGridViewPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPrincipal.Size = new System.Drawing.Size(1132, 466);
            this.dataGridViewPrincipal.TabIndex = 0;
            // 
            // Ordem
            // 
            this.Ordem.DataPropertyName = "num";
            this.Ordem.HeaderText = "Ordem";
            this.Ordem.Name = "Ordem";
            this.Ordem.Width = 50;
            // 
            // IDPessoa
            // 
            this.IDPessoa.DataPropertyName = "IDPessoa";
            this.IDPessoa.HeaderText = "ID";
            this.IDPessoa.Name = "IDPessoa";
            this.IDPessoa.Width = 50;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 300;
            // 
            // Telefome
            // 
            this.Telefome.DataPropertyName = "Telefone";
            this.Telefome.HeaderText = "Telefome";
            this.Telefome.Name = "Telefome";
            this.Telefome.Width = 150;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.Width = 150;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 250;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "stat";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisa.Location = new System.Drawing.Point(88, 43);
            this.textBoxPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(720, 34);
            this.textBoxPesquisa.TabIndex = 2;
            // 
            // btnSelecao
            // 
            this.btnSelecao.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSelecao.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecao.Location = new System.Drawing.Point(853, 31);
            this.btnSelecao.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecao.Name = "btnSelecao";
            this.btnSelecao.Size = new System.Drawing.Size(156, 44);
            this.btnSelecao.TabIndex = 3;
            this.btnSelecao.Text = "Buscar";
            this.btnSelecao.UseVisualStyleBackColor = false;
            this.btnSelecao.Click += new System.EventHandler(this.btnSelecao_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFechar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(987, 606);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(156, 44);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnReintegrar
            // 
            this.btnReintegrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReintegrar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReintegrar.Location = new System.Drawing.Point(88, 606);
            this.btnReintegrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReintegrar.Name = "btnReintegrar";
            this.btnReintegrar.Size = new System.Drawing.Size(156, 44);
            this.btnReintegrar.TabIndex = 9;
            this.btnReintegrar.Text = "Reintegrar";
            this.btnReintegrar.UseVisualStyleBackColor = false;
            this.btnReintegrar.Click += new System.EventHandler(this.btnReintegrar_Click);
            // 
            // tnConsultar
            // 
            this.tnConsultar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tnConsultar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnConsultar.Location = new System.Drawing.Point(301, 606);
            this.tnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.tnConsultar.Name = "tnConsultar";
            this.tnConsultar.Size = new System.Drawing.Size(156, 44);
            this.tnConsultar.TabIndex = 10;
            this.tnConsultar.Text = "Consultar";
            this.tnConsultar.UseVisualStyleBackColor = false;
            this.tnConsultar.Click += new System.EventHandler(this.tnConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(797, 596);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total de Inativos:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(851, 625);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(0, 23);
            this.lblNum.TabIndex = 12;
            // 
            // frmPessoaSelecaoInativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 663);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.tnConsultar);
            this.Controls.Add(this.btnReintegrar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSelecao);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPrincipal);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPessoaSelecaoInativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecao de Pessoa Inativa";
            this.Load += new System.EventHandler(this.frmPessoaSelecaoInativo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Button btnSelecao;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnReintegrar;
        private System.Windows.Forms.Button tnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNum;
    }
}