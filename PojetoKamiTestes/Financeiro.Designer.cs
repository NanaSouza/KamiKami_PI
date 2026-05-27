namespace PojetoKamiTestes
{
    partial class Financeiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Financeiro));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPagamento = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lOJAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_criarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_pedidoAndto = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_financeiro = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_estoque = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUÁRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_resetSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataPedido,
            this.NumeroPedido,
            this.Valor,
            this.colPagamento});
            this.dataGridView1.Location = new System.Drawing.Point(93, 121);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(547, 480);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DataPedido
            // 
            this.DataPedido.HeaderText = "Data do Pedido";
            this.DataPedido.MinimumWidth = 6;
            this.DataPedido.Name = "DataPedido";
            this.DataPedido.Width = 125;
            // 
            // NumeroPedido
            // 
            this.NumeroPedido.HeaderText = "Nº do pedido";
            this.NumeroPedido.MinimumWidth = 6;
            this.NumeroPedido.Name = "NumeroPedido";
            this.NumeroPedido.Width = 125;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            this.Valor.Width = 125;
            // 
            // colPagamento
            // 
            this.colPagamento.HeaderText = "Forma de pagamento";
            this.colPagamento.Items.AddRange(new object[] {
            "Pix",
            "Dinheiro",
            "Cartão Débito",
            "Cartão Crédito"});
            this.colPagamento.Name = "colPagamento";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(682, 184);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(72, 49);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(682, 254);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(72, 46);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(682, 331);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(72, 40);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(682, 397);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(72, 53);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlText;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOJAToolStripMenuItem,
            this.uSUÁRIOToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1181, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lOJAToolStripMenuItem
            // 
            this.lOJAToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.lOJAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_criarPedido,
            this.btn_pedidoAndto,
            this.btn_financeiro,
            this.btn_estoque});
            this.lOJAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOJAToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lOJAToolStripMenuItem.Name = "lOJAToolStripMenuItem";
            this.lOJAToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.lOJAToolStripMenuItem.Text = "LOJA";
            // 
            // btn_criarPedido
            // 
            this.btn_criarPedido.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_criarPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_criarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btn_criarPedido.Image")));
            this.btn_criarPedido.Name = "btn_criarPedido";
            this.btn_criarPedido.Size = new System.Drawing.Size(201, 22);
            this.btn_criarPedido.Text = "Criar Pedido";
            this.btn_criarPedido.Click += new System.EventHandler(this.btn_criarPedido_Click);
            // 
            // btn_pedidoAndto
            // 
            this.btn_pedidoAndto.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_pedidoAndto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_pedidoAndto.Image = ((System.Drawing.Image)(resources.GetObject("btn_pedidoAndto.Image")));
            this.btn_pedidoAndto.Name = "btn_pedidoAndto";
            this.btn_pedidoAndto.Size = new System.Drawing.Size(201, 22);
            this.btn_pedidoAndto.Text = "Pedido em Andamento";
            this.btn_pedidoAndto.Click += new System.EventHandler(this.btn_pedidoAndto_Click);
            // 
            // btn_financeiro
            // 
            this.btn_financeiro.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_financeiro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_financeiro.Image = ((System.Drawing.Image)(resources.GetObject("btn_financeiro.Image")));
            this.btn_financeiro.Name = "btn_financeiro";
            this.btn_financeiro.Size = new System.Drawing.Size(201, 22);
            this.btn_financeiro.Text = "Financeiro";
            this.btn_financeiro.Click += new System.EventHandler(this.btn_financeiro_Click);
            // 
            // btn_estoque
            // 
            this.btn_estoque.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_estoque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_estoque.Image = ((System.Drawing.Image)(resources.GetObject("btn_estoque.Image")));
            this.btn_estoque.Name = "btn_estoque";
            this.btn_estoque.Size = new System.Drawing.Size(201, 22);
            this.btn_estoque.Text = "Estoque";
            this.btn_estoque.Click += new System.EventHandler(this.btn_estoque_Click);
            // 
            // uSUÁRIOToolStripMenuItem
            // 
            this.uSUÁRIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.btn_resetSenha});
            this.uSUÁRIOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uSUÁRIOToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uSUÁRIOToolStripMenuItem.Name = "uSUÁRIOToolStripMenuItem";
            this.uSUÁRIOToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.uSUÁRIOToolStripMenuItem.Text = "USUÁRIO";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(250, 22);
            this.toolStripMenuItem1.Text = "Gerenciamento de Funcionários";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // btn_resetSenha
            // 
            this.btn_resetSenha.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_resetSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_resetSenha.Image = ((System.Drawing.Image)(resources.GetObject("btn_resetSenha.Image")));
            this.btn_resetSenha.Name = "btn_resetSenha";
            this.btn_resetSenha.Size = new System.Drawing.Size(250, 22);
            this.btn_resetSenha.Text = "Reset de Senha";
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sAIRToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sAIRToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // Financeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 755);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Financeiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financeiro";
            this.Load += new System.EventHandler(this.Financeiro_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lOJAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_criarPedido;
        private System.Windows.Forms.ToolStripMenuItem btn_pedidoAndto;
        private System.Windows.Forms.ToolStripMenuItem btn_financeiro;
        private System.Windows.Forms.ToolStripMenuItem btn_estoque;
        private System.Windows.Forms.ToolStripMenuItem uSUÁRIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btn_resetSenha;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewComboBoxColumn colPagamento;
    }
}