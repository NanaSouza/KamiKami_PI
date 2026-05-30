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
            this.listViewItensPedido = new System.Windows.Forms.ListView();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.labelNroPedido = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor R$";
            // 
            // listViewItensPedido
            // 
            this.listViewItensPedido.HideSelection = false;
            this.listViewItensPedido.Location = new System.Drawing.Point(17, 79);
            this.listViewItensPedido.Name = "listViewItensPedido";
            this.listViewItensPedido.Size = new System.Drawing.Size(213, 148);
            this.listViewItensPedido.TabIndex = 2;
            this.listViewItensPedido.UseCompatibleStateImageBehavior = false;
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Location = new System.Drawing.Point(17, 252);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(213, 23);
            this.buttonFinalizar.TabIndex = 3;
            this.buttonFinalizar.Text = "Finalizar pedido";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            // 
            // labelNroPedido
            // 
            this.labelNroPedido.AutoSize = true;
            this.labelNroPedido.Location = new System.Drawing.Point(70, 15);
            this.labelNroPedido.Name = "labelNroPedido";
            this.labelNroPedido.Size = new System.Drawing.Size(35, 13);
            this.labelNroPedido.TabIndex = 4;
            this.labelNroPedido.Text = "label3";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(70, 44);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(35, 13);
            this.labelValor.TabIndex = 5;
            this.labelValor.Text = "label4";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelNroPedido);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.listViewItensPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(253, 305);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewItensPedido;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.Label labelNroPedido;
        private System.Windows.Forms.Label labelValor;
    }
}
