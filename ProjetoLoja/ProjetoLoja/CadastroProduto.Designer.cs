namespace ProjetoLoja
{
    partial class frmCadProd
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
            this.lblObsProd = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblNomeProd = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.txtObsProd = new System.Windows.Forms.TextBox();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadProd = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblObsProd
            // 
            this.lblObsProd.AutoSize = true;
            this.lblObsProd.Font = new System.Drawing.Font("Hack Nerd Font Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObsProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.lblObsProd.Location = new System.Drawing.Point(141, 251);
            this.lblObsProd.Name = "lblObsProd";
            this.lblObsProd.Size = new System.Drawing.Size(152, 26);
            this.lblObsProd.TabIndex = 25;
            this.lblObsProd.Text = "Observação";
            this.lblObsProd.Click += new System.EventHandler(this.lblObs_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Hack Nerd Font Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.lblValor.Location = new System.Drawing.Point(141, 211);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(82, 26);
            this.lblValor.TabIndex = 24;
            this.lblValor.Text = "Valor";
            this.lblValor.Click += new System.EventHandler(this.lblEnd_Click);
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Font = new System.Drawing.Font("Hack Nerd Font Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.lblQuant.Location = new System.Drawing.Point(141, 171);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(152, 26);
            this.lblQuant.TabIndex = 23;
            this.lblQuant.Text = "Quantidade";
            this.lblQuant.Click += new System.EventHandler(this.lblTelefone_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Hack Nerd Font Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.lblDesc.Location = new System.Drawing.Point(141, 131);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(138, 26);
            this.lblDesc.TabIndex = 22;
            this.lblDesc.Text = "Descrição";
            this.lblDesc.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblNomeProd
            // 
            this.lblNomeProd.AutoSize = true;
            this.lblNomeProd.Font = new System.Drawing.Font("Hack Nerd Font Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.lblNomeProd.Location = new System.Drawing.Point(141, 91);
            this.lblNomeProd.Name = "lblNomeProd";
            this.lblNomeProd.Size = new System.Drawing.Size(222, 26);
            this.lblNomeProd.TabIndex = 21;
            this.lblNomeProd.Text = "Nome do Produto";
            this.lblNomeProd.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Hack Nerd Font Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(369, 168);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(290, 34);
            this.txtQtd.TabIndex = 20;
            this.txtQtd.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Font = new System.Drawing.Font("Hack Nerd Font Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProd.Location = new System.Drawing.Point(369, 88);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(290, 34);
            this.txtNomeProd.TabIndex = 19;
            this.txtNomeProd.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtObsProd
            // 
            this.txtObsProd.Font = new System.Drawing.Font("Hack Nerd Font Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObsProd.Location = new System.Drawing.Point(369, 248);
            this.txtObsProd.Multiline = true;
            this.txtObsProd.Name = "txtObsProd";
            this.txtObsProd.Size = new System.Drawing.Size(290, 56);
            this.txtObsProd.TabIndex = 18;
            this.txtObsProd.TextChanged += new System.EventHandler(this.txtObs_TextChanged);
            // 
            // txtVal
            // 
            this.txtVal.Font = new System.Drawing.Font("Hack Nerd Font Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal.Location = new System.Drawing.Point(369, 208);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(290, 34);
            this.txtVal.TabIndex = 17;
            this.txtVal.TextChanged += new System.EventHandler(this.txtEnd_TextChanged);
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Hack Nerd Font Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(369, 128);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(290, 34);
            this.txtDesc.TabIndex = 16;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hack Nerd Font Mono", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(203, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cadastro de Produto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCadProd
            // 
            this.btnCadProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnCadProd.Font = new System.Drawing.Font("Hack Nerd Font Mono", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(4)))), ((int)(((byte)(41)))));
            this.btnCadProd.Location = new System.Drawing.Point(146, 336);
            this.btnCadProd.Name = "btnCadProd";
            this.btnCadProd.Size = new System.Drawing.Size(242, 68);
            this.btnCadProd.TabIndex = 14;
            this.btnCadProd.Text = "Confirmar cadastro";
            this.btnCadProd.UseVisualStyleBackColor = false;
            this.btnCadProd.Click += new System.EventHandler(this.btnCadCli_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnVoltar.Font = new System.Drawing.Font("Hack Nerd Font Mono", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(4)))), ((int)(((byte)(41)))));
            this.btnVoltar.Location = new System.Drawing.Point(417, 336);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(242, 68);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmCadProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.lblObsProd);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblQuant);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblNomeProd);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtNomeProd);
            this.Controls.Add(this.txtObsProd);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadProd);
            this.Controls.Add(this.btnVoltar);
            this.Font = new System.Drawing.Font("Hack Nerd Font Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCadProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.frmCadProd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObsProd;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblNomeProd;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.TextBox txtObsProd;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadProd;
        private System.Windows.Forms.Button btnVoltar;
    }
}