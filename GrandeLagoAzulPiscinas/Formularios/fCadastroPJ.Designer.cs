namespace GrandeLagoAzulPiscinas
{
    partial class fCadastroPJ
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
            this.txtLogradouroPF = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.Label();
            this.txtNumEnderecoPJ = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLogradouroPF
            // 
            this.txtLogradouroPF.AutoSize = true;
            this.txtLogradouroPF.Location = new System.Drawing.Point(45, 67);
            this.txtLogradouroPF.Name = "txtLogradouroPF";
            this.txtLogradouroPF.Size = new System.Drawing.Size(53, 13);
            this.txtLogradouroPF.TabIndex = 0;
            this.txtLogradouroPF.Text = "Endereço";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.AutoSize = true;
            this.txtNomeEmpresa.Location = new System.Drawing.Point(45, 41);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(35, 13);
            this.txtNomeEmpresa.TabIndex = 1;
            this.txtNomeEmpresa.Text = "Nome";
            // 
            // txtNumEnderecoPJ
            // 
            this.txtNumEnderecoPJ.AutoSize = true;
            this.txtNumEnderecoPJ.Location = new System.Drawing.Point(45, 91);
            this.txtNumEnderecoPJ.Name = "txtNumEnderecoPJ";
            this.txtNumEnderecoPJ.Size = new System.Drawing.Size(44, 13);
            this.txtNumEnderecoPJ.TabIndex = 2;
            this.txtNumEnderecoPJ.Text = "Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // fCadastroPJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumEnderecoPJ);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.txtLogradouroPF);
            this.Name = "fCadastroPJ";
            this.Text = "fCadastroPJ";
            this.Load += new System.EventHandler(this.fCadastroPJ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtLogradouroPF;
        private System.Windows.Forms.Label txtNomeEmpresa;
        private System.Windows.Forms.Label txtNumEnderecoPJ;
        private System.Windows.Forms.Label label4;
    }
}