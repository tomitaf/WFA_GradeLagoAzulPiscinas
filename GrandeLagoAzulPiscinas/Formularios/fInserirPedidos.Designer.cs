using GrandeLagoAzulPiscinas.Entidades;
namespace GrandeLagoAzulPiscinas.Formularios
{
    partial class fInserirPedidos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInserirPedidos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.statusBarInserirPedidos = new System.Windows.Forms.StatusStrip();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbStatusPagamento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalPedido = new System.Windows.Forms.Label();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInserirPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(426, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grande Lago Azul Piscinas";
            // 
            // dgvInserirPedidos
            // 
            this.dgvInserirPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInserirPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantidade,
            this.Preço,
            this.Total});
            this.dgvInserirPedidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dgvInserirPedidos.Location = new System.Drawing.Point(121, 396);
            this.dgvInserirPedidos.Name = "dgvInserirPedidos";
            this.dgvInserirPedidos.Size = new System.Drawing.Size(935, 429);
            this.dgvInserirPedidos.TabIndex = 1;
            this.dgvInserirPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvInserirPedidos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInserirPedidos_CellEndEdit);
            this.dgvInserirPedidos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvInserirPedidos_EditingControlShowing);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(117, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(186, 68);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(426, 20);
            this.txtCliente.TabIndex = 3;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(116, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vendedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(117, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF/CNPJ";
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(223, 111);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(389, 20);
            this.txtCpfCnpj.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(644, 114);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(196, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Buscar no banco de dados";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // statusBarInserirPedidos
            // 
            this.statusBarInserirPedidos.Location = new System.Drawing.Point(0, 980);
            this.statusBarInserirPedidos.Name = "statusBarInserirPedidos";
            this.statusBarInserirPedidos.Size = new System.Drawing.Size(1341, 22);
            this.statusBarInserirPedidos.TabIndex = 9;
            this.statusBarInserirPedidos.Text = "statusStrip1";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Items.AddRange(new object[] {
            "Jéssica",
            "Solange"});
            this.cmbVendedor.Location = new System.Drawing.Point(223, 150);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(121, 21);
            this.cmbVendedor.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(116, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Forma de pagamento";
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.FormattingEnabled = true;
            this.txtFormaPagamento.Items.AddRange(new object[] {
            "À vista (débito)",
            "À vista (dinheiro)",
            "1 x sem juros",
            "2 x sem juros",
            "3 x sem juros",
            "4 x sem juros",
            "5 x sem juros",
            "6 x sem juros",
            "7 x sem juros",
            "8 x sem juros",
            "9 x sem juros",
            "10 x sem juros",
            "11 x sem juros",
            "12 x sem juros",
            "Cheque"});
            this.txtFormaPagamento.Location = new System.Drawing.Point(315, 187);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(121, 21);
            this.txtFormaPagamento.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(640, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Status do pagamento";
            // 
            // cmbStatusPagamento
            // 
            this.cmbStatusPagamento.FormattingEnabled = true;
            this.cmbStatusPagamento.Items.AddRange(new object[] {
            "PAGO",
            "PENDENTE"});
            this.cmbStatusPagamento.Location = new System.Drawing.Point(838, 187);
            this.cmbStatusPagamento.Name = "cmbStatusPagamento";
            this.cmbStatusPagamento.Size = new System.Drawing.Size(121, 21);
            this.cmbStatusPagamento.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.Location = new System.Drawing.Point(629, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tipo";
            // 
            // cmbTipoCliente
            // 
            this.cmbTipoCliente.FormattingEnabled = true;
            this.cmbTipoCliente.Items.AddRange(new object[] {
            "Pessoa Física",
            "Pessoa Jurídica"});
            this.cmbTipoCliente.Location = new System.Drawing.Point(683, 67);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoCliente.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.Location = new System.Drawing.Point(1108, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 75);
            this.button1.TabIndex = 17;
            this.button1.Text = "Finalizar Pedido";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(116, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Observações sobre o pedido";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 255);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(934, 75);
            this.textBox1.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(877, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total:";
            // 
            // lblTotalPedido
            // 
            this.lblTotalPedido.AutoSize = true;
            this.lblTotalPedido.BackColor = System.Drawing.SystemColors.Window;
            this.lblTotalPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblTotalPedido.Location = new System.Drawing.Point(982, 367);
            this.lblTotalPedido.Name = "lblTotalPedido";
            this.lblTotalPedido.Size = new System.Drawing.Size(72, 26);
            this.lblTotalPedido.TabIndex = 21;
            this.lblTotalPedido.Text = "label10";
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.Width = 600;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 90;
            // 
            // Preço
            // 
            this.Preço.HeaderText = "Preço Unitário (R$)";
            this.Preço.Name = "Preço";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total Item (R$)";
            this.Total.Name = "Total";
            // 
            // fInserirPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1341, 1002);
            this.Controls.Add(this.lblTotalPedido);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbTipoCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbStatusPagamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFormaPagamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(this.statusBarInserirPedidos);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtCpfCnpj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInserirPedidos);
            this.Controls.Add(this.label1);
            this.Name = "fInserirPedidos";
            this.Text = "Inserir Pedido";
            this.Load += new System.EventHandler(this.fInserirPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInserirPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInserirPedidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.StatusStrip statusBarInserirPedidos;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtFormaPagamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbStatusPagamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox txtCliente;
        public System.Windows.Forms.TextBox txtCpfCnpj;
        public System.Windows.Forms.ComboBox cmbTipoCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}