namespace ProjetoLoja
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pEDIDOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pEDIDOSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadCli = new System.Windows.Forms.Button();
            this.btnCadProd = new System.Windows.Forms.Button();
            this.btnConsCli = new System.Windows.Forms.Button();
            this.btnConsProd = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROToolStripMenuItem,
            this.cLIENTESToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cADASTROToolStripMenuItem
            // 
            this.cADASTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem,
            this.pEDIDOSToolStripMenuItem});
            this.cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            this.cADASTROToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.cADASTROToolStripMenuItem.Text = "CADASTRO";
            this.cADASTROToolStripMenuItem.Click += new System.EventHandler(this.cADASTROToolStripMenuItem_Click);
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            this.cLIENTESToolStripMenuItem.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem_Click);
            // 
            // pEDIDOSToolStripMenuItem
            // 
            this.pEDIDOSToolStripMenuItem.Name = "pEDIDOSToolStripMenuItem";
            this.pEDIDOSToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pEDIDOSToolStripMenuItem.Text = "PEDIDOS";
            this.pEDIDOSToolStripMenuItem.Click += new System.EventHandler(this.pEDIDOSToolStripMenuItem_Click);
            // 
            // cLIENTESToolStripMenuItem1
            // 
            this.cLIENTESToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem2,
            this.pEDIDOSToolStripMenuItem1});
            this.cLIENTESToolStripMenuItem1.Name = "cLIENTESToolStripMenuItem1";
            this.cLIENTESToolStripMenuItem1.Size = new System.Drawing.Size(95, 24);
            this.cLIENTESToolStripMenuItem1.Text = "CONSULTA";
            this.cLIENTESToolStripMenuItem1.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem1_Click);
            // 
            // cLIENTESToolStripMenuItem2
            // 
            this.cLIENTESToolStripMenuItem2.Name = "cLIENTESToolStripMenuItem2";
            this.cLIENTESToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.cLIENTESToolStripMenuItem2.Text = "CLIENTES";
            this.cLIENTESToolStripMenuItem2.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem2_Click);
            // 
            // pEDIDOSToolStripMenuItem1
            // 
            this.pEDIDOSToolStripMenuItem1.Name = "pEDIDOSToolStripMenuItem1";
            this.pEDIDOSToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.pEDIDOSToolStripMenuItem1.Text = "PEDIDOS";
            this.pEDIDOSToolStripMenuItem1.Click += new System.EventHandler(this.pEDIDOSToolStripMenuItem1_Click);
            // 
            // btnCadCli
            // 
            this.btnCadCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnCadCli.Font = new System.Drawing.Font("Hack Nerd Font Mono", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(4)))), ((int)(((byte)(41)))));
            this.btnCadCli.Location = new System.Drawing.Point(188, 128);
            this.btnCadCli.Name = "btnCadCli";
            this.btnCadCli.Size = new System.Drawing.Size(188, 65);
            this.btnCadCli.TabIndex = 1;
            this.btnCadCli.Text = "Cadastro de Clientes";
            this.btnCadCli.UseVisualStyleBackColor = false;
            this.btnCadCli.Click += new System.EventHandler(this.btnCadCli_Click);
            // 
            // btnCadProd
            // 
            this.btnCadProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnCadProd.Font = new System.Drawing.Font("Hack Nerd Font Mono", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(4)))), ((int)(((byte)(41)))));
            this.btnCadProd.Location = new System.Drawing.Point(409, 128);
            this.btnCadProd.Name = "btnCadProd";
            this.btnCadProd.Size = new System.Drawing.Size(188, 65);
            this.btnCadProd.TabIndex = 2;
            this.btnCadProd.Text = "Cadastro de Produtos";
            this.btnCadProd.UseVisualStyleBackColor = false;
            this.btnCadProd.Click += new System.EventHandler(this.btnCadProd_Click);
            // 
            // btnConsCli
            // 
            this.btnConsCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnConsCli.Font = new System.Drawing.Font("Hack Nerd Font Mono", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsCli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(4)))), ((int)(((byte)(41)))));
            this.btnConsCli.Location = new System.Drawing.Point(188, 224);
            this.btnConsCli.Name = "btnConsCli";
            this.btnConsCli.Size = new System.Drawing.Size(188, 65);
            this.btnConsCli.TabIndex = 3;
            this.btnConsCli.Text = "Consulta de Clientes";
            this.btnConsCli.UseVisualStyleBackColor = false;
            this.btnConsCli.Click += new System.EventHandler(this.btnConsCli_Click);
            // 
            // btnConsProd
            // 
            this.btnConsProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnConsProd.Font = new System.Drawing.Font("Hack Nerd Font Mono", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(4)))), ((int)(((byte)(41)))));
            this.btnConsProd.Location = new System.Drawing.Point(409, 224);
            this.btnConsProd.Name = "btnConsProd";
            this.btnConsProd.Size = new System.Drawing.Size(188, 65);
            this.btnConsProd.TabIndex = 4;
            this.btnConsProd.Text = "Consulta de Produtos";
            this.btnConsProd.UseVisualStyleBackColor = false;
            this.btnConsProd.Click += new System.EventHandler(this.btnConsProd_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.btnConsProd);
            this.Controls.Add(this.btnConsCli);
            this.Controls.Add(this.btnCadProd);
            this.Controls.Add(this.btnCadCli);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Hack Nerd Font Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pEDIDOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pEDIDOSToolStripMenuItem1;
        private System.Windows.Forms.Button btnCadCli;
        private System.Windows.Forms.Button btnCadProd;
        private System.Windows.Forms.Button btnConsCli;
        private System.Windows.Forms.Button btnConsProd;
    }
}