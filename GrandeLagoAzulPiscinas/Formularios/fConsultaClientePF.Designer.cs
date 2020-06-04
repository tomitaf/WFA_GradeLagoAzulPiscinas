namespace GrandeLagoAzulPiscinas.Formularios
{
    partial class fConsultaClientePF
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeBusca = new System.Windows.Forms.TextBox();
            this.txtCPFBusca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsultaCadastroPF = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefoneBusca = new System.Windows.Forms.TextBox();
            this.txtEmailBusca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // txtNomeBusca
            // 
            this.txtNomeBusca.Location = new System.Drawing.Point(110, 39);
            this.txtNomeBusca.Name = "txtNomeBusca";
            this.txtNomeBusca.Size = new System.Drawing.Size(100, 20);
            this.txtNomeBusca.TabIndex = 2;
            // 
            // txtCPFBusca
            // 
            this.txtCPFBusca.Location = new System.Drawing.Point(110, 65);
            this.txtCPFBusca.Name = "txtCPFBusca";
            this.txtCPFBusca.Size = new System.Drawing.Size(100, 20);
            this.txtCPFBusca.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Digite nome ou CPF para pesquisa:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnConsultaCadastroPF
            // 
            this.btnConsultaCadastroPF.Location = new System.Drawing.Point(272, 71);
            this.btnConsultaCadastroPF.Name = "btnConsultaCadastroPF";
            this.btnConsultaCadastroPF.Size = new System.Drawing.Size(75, 35);
            this.btnConsultaCadastroPF.TabIndex = 5;
            this.btnConsultaCadastroPF.Text = "Pesquisar";
            this.btnConsultaCadastroPF.UseVisualStyleBackColor = true;
            this.btnConsultaCadastroPF.Click += new System.EventHandler(this.btnConsultaCadastroPF_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone";
            // 
            // txtTelefoneBusca
            // 
            this.txtTelefoneBusca.Location = new System.Drawing.Point(110, 90);
            this.txtTelefoneBusca.Name = "txtTelefoneBusca";
            this.txtTelefoneBusca.Size = new System.Drawing.Size(100, 20);
            this.txtTelefoneBusca.TabIndex = 7;
            // 
            // txtEmailBusca
            // 
            this.txtEmailBusca.Location = new System.Drawing.Point(110, 116);
            this.txtEmailBusca.Name = "txtEmailBusca";
            this.txtEmailBusca.Size = new System.Drawing.Size(100, 20);
            this.txtEmailBusca.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // fConsultaClientePF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmailBusca);
            this.Controls.Add(this.txtTelefoneBusca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConsultaCadastroPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCPFBusca);
            this.Controls.Add(this.txtNomeBusca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fConsultaClientePF";
            this.Text = "Consulta Cliente Pessoa Física";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeBusca;
        private System.Windows.Forms.TextBox txtCPFBusca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConsultaCadastroPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefoneBusca;
        private System.Windows.Forms.TextBox txtEmailBusca;
        private System.Windows.Forms.Label label5;
    }
}