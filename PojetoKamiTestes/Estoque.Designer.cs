namespace PojetoKamiTestes
{
    partial class Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.txt_qtde = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_remover = new System.Windows.Forms.Button();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 737);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel2.Controls.Add(this.btn_buscar, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_buscar, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(595, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(576, 75);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(437, 26);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(120, 26);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Pesquisar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Pesquisar";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_buscar.Location = new System.Drawing.Point(93, 26);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(338, 20);
            this.txt_buscar.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.txt_preco, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.txt_qtde, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.txt_codigo, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btn_adicionar, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.btn_editar, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.txt_nome, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 115);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 10;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(576, 609);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // txt_preco
            // 
            this.txt_preco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_preco.Location = new System.Drawing.Point(3, 193);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(570, 20);
            this.txt_preco.TabIndex = 9;
            // 
            // txt_qtde
            // 
            this.txt_qtde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_qtde.Location = new System.Drawing.Point(3, 137);
            this.txt_qtde.Name = "txt_qtde";
            this.txt_qtde.Size = new System.Drawing.Size(570, 20);
            this.txt_qtde.TabIndex = 8;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_codigo.Location = new System.Drawing.Point(3, 81);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(570, 20);
            this.txt_codigo.TabIndex = 7;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(3, 227);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(120, 26);
            this.btn_adicionar.TabIndex = 0;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(3, 269);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(120, 26);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Preço";
            // 
            // txt_nome
            // 
            this.txt_nome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_nome.Location = new System.Drawing.Point(3, 25);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(570, 20);
            this.txt_nome.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btn_remover, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.dgv_produtos, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(595, 115);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(576, 609);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // btn_remover
            // 
            this.btn_remover.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_remover.Location = new System.Drawing.Point(453, 571);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(120, 26);
            this.btn_remover.TabIndex = 2;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_produtos.Location = new System.Drawing.Point(3, 3);
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.Size = new System.Drawing.Size(570, 553);
            this.dgv_produtos.TabIndex = 0;
            this.dgv_produtos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_produtos_CellClick);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.TextBox txt_qtde;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nome;
    }
}