namespace EcoFarm
{
    partial class FrmMenuEstoque
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
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gbxEstoque = new System.Windows.Forms.GroupBox();
            this.btnEstoqueDeletar = new System.Windows.Forms.Button();
            this.btnEstoqueEditar = new System.Windows.Forms.Button();
            this.btnEstoqueNovo = new System.Windows.Forms.Button();
            this.btnEstoqueCancelar = new System.Windows.Forms.Button();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.btnEstoqueSalvar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.gbxEstoque.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1101, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.estoqueToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estoqueToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Location = new System.Drawing.Point(25, 81);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.Size = new System.Drawing.Size(618, 429);
            this.dgvEstoque.TabIndex = 2;
            this.dgvEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSair.Location = new System.Drawing.Point(582, 532);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(73, 39);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // gbxEstoque
            // 
            this.gbxEstoque.BackColor = System.Drawing.Color.Beige;
            this.gbxEstoque.Controls.Add(this.label5);
            this.gbxEstoque.Controls.Add(this.txtObservacoes);
            this.gbxEstoque.Controls.Add(this.lblUnidade);
            this.gbxEstoque.Controls.Add(this.txtUnidade);
            this.gbxEstoque.Controls.Add(this.lblPreco);
            this.gbxEstoque.Controls.Add(this.txtPreco);
            this.gbxEstoque.Controls.Add(this.lblQuantidade);
            this.gbxEstoque.Controls.Add(this.txtQuantidade);
            this.gbxEstoque.Controls.Add(this.lblCategoria);
            this.gbxEstoque.Controls.Add(this.txtCategoria);
            this.gbxEstoque.Controls.Add(this.lblProduto);
            this.gbxEstoque.Controls.Add(this.txtProduto);
            this.gbxEstoque.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEstoque.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gbxEstoque.Location = new System.Drawing.Point(667, 145);
            this.gbxEstoque.Name = "gbxEstoque";
            this.gbxEstoque.Size = new System.Drawing.Size(393, 438);
            this.gbxEstoque.TabIndex = 4;
            this.gbxEstoque.TabStop = false;
            this.gbxEstoque.Text = "Informações";
            this.gbxEstoque.Visible = false;
            this.gbxEstoque.Enter += new System.EventHandler(this.gbxEstoque_Enter);
            // 
            // btnEstoqueDeletar
            // 
            this.btnEstoqueDeletar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEstoqueDeletar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueDeletar.ForeColor = System.Drawing.Color.White;
            this.btnEstoqueDeletar.Location = new System.Drawing.Point(237, 532);
            this.btnEstoqueDeletar.Name = "btnEstoqueDeletar";
            this.btnEstoqueDeletar.Size = new System.Drawing.Size(100, 39);
            this.btnEstoqueDeletar.TabIndex = 5;
            this.btnEstoqueDeletar.Text = "Deletar";
            this.btnEstoqueDeletar.UseVisualStyleBackColor = false;
            this.btnEstoqueDeletar.Click += new System.EventHandler(this.btnEstoqueDeletar_Click);
            // 
            // btnEstoqueEditar
            // 
            this.btnEstoqueEditar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEstoqueEditar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueEditar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEstoqueEditar.Location = new System.Drawing.Point(131, 532);
            this.btnEstoqueEditar.Name = "btnEstoqueEditar";
            this.btnEstoqueEditar.Size = new System.Drawing.Size(100, 39);
            this.btnEstoqueEditar.TabIndex = 6;
            this.btnEstoqueEditar.Text = "Editar";
            this.btnEstoqueEditar.UseVisualStyleBackColor = false;
            this.btnEstoqueEditar.Click += new System.EventHandler(this.btnEstoqueEditar_Click);
            // 
            // btnEstoqueNovo
            // 
            this.btnEstoqueNovo.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEstoqueNovo.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueNovo.ForeColor = System.Drawing.Color.White;
            this.btnEstoqueNovo.Location = new System.Drawing.Point(25, 532);
            this.btnEstoqueNovo.Name = "btnEstoqueNovo";
            this.btnEstoqueNovo.Size = new System.Drawing.Size(100, 39);
            this.btnEstoqueNovo.TabIndex = 7;
            this.btnEstoqueNovo.Text = "Novo";
            this.btnEstoqueNovo.UseVisualStyleBackColor = false;
            this.btnEstoqueNovo.Click += new System.EventHandler(this.btnEstoqueNovo_Click);
            // 
            // btnEstoqueCancelar
            // 
            this.btnEstoqueCancelar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEstoqueCancelar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueCancelar.ForeColor = System.Drawing.Color.White;
            this.btnEstoqueCancelar.Location = new System.Drawing.Point(449, 532);
            this.btnEstoqueCancelar.Name = "btnEstoqueCancelar";
            this.btnEstoqueCancelar.Size = new System.Drawing.Size(100, 39);
            this.btnEstoqueCancelar.TabIndex = 8;
            this.btnEstoqueCancelar.Text = "Cancelar";
            this.btnEstoqueCancelar.UseVisualStyleBackColor = false;
            this.btnEstoqueCancelar.Click += new System.EventHandler(this.btnEstoqueCancelar_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(40, 50);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(72, 21);
            this.lblProduto.TabIndex = 10;
            this.lblProduto.Text = "Produto";
            this.lblProduto.Click += new System.EventHandler(this.lblProduto_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.Color.White;
            this.txtProduto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(118, 48);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(227, 27);
            this.txtProduto.TabIndex = 9;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(28, 98);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(84, 21);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.Click += new System.EventHandler(this.lblCategoria_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.White;
            this.txtCategoria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(118, 96);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(227, 27);
            this.txtCategoria.TabIndex = 11;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(12, 146);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(100, 21);
            this.lblQuantidade.TabIndex = 14;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.White;
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(118, 144);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(46, 27);
            this.txtQuantidade.TabIndex = 13;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(59, 194);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(53, 21);
            this.lblPreco.TabIndex = 16;
            this.lblPreco.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.White;
            this.txtPreco.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(118, 192);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(78, 27);
            this.txtPreco.TabIndex = 15;
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.BackColor = System.Drawing.Color.Transparent;
            this.lblUnidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.Location = new System.Drawing.Point(37, 242);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(75, 21);
            this.lblUnidade.TabIndex = 18;
            this.lblUnidade.Text = "Unidade";
            // 
            // txtUnidade
            // 
            this.txtUnidade.BackColor = System.Drawing.Color.White;
            this.txtUnidade.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidade.Location = new System.Drawing.Point(118, 240);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(98, 27);
            this.txtUnidade.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Observações";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.BackColor = System.Drawing.Color.White;
            this.txtObservacoes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.Location = new System.Drawing.Point(118, 288);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(246, 123);
            this.txtObservacoes.TabIndex = 19;
            // 
            // btnEstoqueSalvar
            // 
            this.btnEstoqueSalvar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEstoqueSalvar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueSalvar.ForeColor = System.Drawing.Color.White;
            this.btnEstoqueSalvar.Location = new System.Drawing.Point(343, 532);
            this.btnEstoqueSalvar.Name = "btnEstoqueSalvar";
            this.btnEstoqueSalvar.Size = new System.Drawing.Size(100, 39);
            this.btnEstoqueSalvar.TabIndex = 9;
            this.btnEstoqueSalvar.Text = "Salvar";
            this.btnEstoqueSalvar.UseVisualStyleBackColor = false;
            this.btnEstoqueSalvar.Click += new System.EventHandler(this.btnEstoqueSalvar_Click);
            // 
            // FrmMenuEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EcoFarm.Properties.Resources.Slide2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 595);
            this.Controls.Add(this.btnEstoqueSalvar);
            this.Controls.Add(this.btnEstoqueCancelar);
            this.Controls.Add(this.btnEstoqueNovo);
            this.Controls.Add(this.btnEstoqueEditar);
            this.Controls.Add(this.btnEstoqueDeletar);
            this.Controls.Add(this.gbxEstoque);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvEstoque);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal";
            this.Load += new System.EventHandler(this.FrmMenuEstoque_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.gbxEstoque.ResumeLayout(false);
            this.gbxEstoque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox gbxEstoque;
        private System.Windows.Forms.Button btnEstoqueDeletar;
        private System.Windows.Forms.Button btnEstoqueEditar;
        private System.Windows.Forms.Button btnEstoqueNovo;
        private System.Windows.Forms.Button btnEstoqueCancelar;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnEstoqueSalvar;
    }
}