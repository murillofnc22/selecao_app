namespace SelecaoApp
{
    partial class frmPrincipal
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
            this.toolStripCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCadastros,
            this.tsSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripCadastros
            // 
            this.toolStripCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFornecedores,
            this.tsProdutos});
            this.toolStripCadastros.Name = "toolStripCadastros";
            this.toolStripCadastros.Size = new System.Drawing.Size(71, 20);
            this.toolStripCadastros.Text = "Cadastros";
            // 
            // tsFornecedores
            // 
            this.tsFornecedores.Name = "tsFornecedores";
            this.tsFornecedores.Size = new System.Drawing.Size(145, 22);
            this.tsFornecedores.Text = "Fornecedores";
            this.tsFornecedores.Click += new System.EventHandler(this.Fornecedores_Click);
            // 
            // tsProdutos
            // 
            this.tsProdutos.Name = "tsProdutos";
            this.tsProdutos.Size = new System.Drawing.Size(145, 22);
            this.tsProdutos.Text = "Produtos";
            this.tsProdutos.Click += new System.EventHandler(this.Produtos_Click);
            // 
            // tsSair
            // 
            this.tsSair.Name = "tsSair";
            this.tsSair.Size = new System.Drawing.Size(38, 20);
            this.tsSair.Text = "Sair";
            this.tsSair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripCadastros;
        private System.Windows.Forms.ToolStripMenuItem tsFornecedores;
        private System.Windows.Forms.ToolStripMenuItem tsProdutos;
        private System.Windows.Forms.ToolStripMenuItem tsSair;
    }
}