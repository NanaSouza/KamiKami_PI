namespace PojetoKamiTestes
{
    partial class UserControlPedidos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.labelNroPedido = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.dataGridViewItensPedido = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItensPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor R$";
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinalizar.ForeColor = System.Drawing.Color.Black;
            this.buttonFinalizar.Location = new System.Drawing.Point(20, 203);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(213, 23);
            this.buttonFinalizar.TabIndex = 3;
            this.buttonFinalizar.Text = "FINALIZAR PEDIDO";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            // 
            // labelNroPedido
            // 
            this.labelNroPedido.AutoSize = true;
            this.labelNroPedido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroPedido.ForeColor = System.Drawing.Color.Black;
            this.labelNroPedido.Location = new System.Drawing.Point(59, 15);
            this.labelNroPedido.Name = "labelNroPedido";
            this.labelNroPedido.Size = new System.Drawing.Size(39, 12);
            this.labelNroPedido.TabIndex = 4;
            this.labelNroPedido.Text = "label3";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.ForeColor = System.Drawing.Color.Black;
            this.labelValor.Location = new System.Drawing.Point(59, 31);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(39, 12);
            this.labelValor.TabIndex = 5;
            this.labelValor.Text = "label4";
            // 
            // dataGridViewItensPedido
            // 
            this.dataGridViewItensPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItensPedido.Location = new System.Drawing.Point(3, 47);
            this.dataGridViewItensPedido.Name = "dataGridViewItensPedido";
            this.dataGridViewItensPedido.Size = new System.Drawing.Size(247, 150);
            this.dataGridViewItensPedido.TabIndex = 6;
            // 
            // UserControlPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewItensPedido);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelNroPedido);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlPedidos";
            this.Size = new System.Drawing.Size(253, 239);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItensPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.Label labelNroPedido;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.DataGridView dataGridViewItensPedido;
    }
}
