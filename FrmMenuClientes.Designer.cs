namespace EcoFarm
{
    partial class FrmMenuClientes
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
            this.btnSairClientes = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnClientesDeletar = new System.Windows.Forms.Button();
            this.btnClientesAdicionar = new System.Windows.Forms.Button();
            this.btnClientesAtualizar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAttVisualizacao = new System.Windows.Forms.Button();
            this.btnExportarCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSairClientes
            // 
            this.btnSairClientes.BackColor = System.Drawing.Color.Green;
            this.btnSairClientes.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairClientes.ForeColor = System.Drawing.Color.White;
            this.btnSairClientes.Location = new System.Drawing.Point(957, 525);
            this.btnSairClientes.Name = "btnSairClientes";
            this.btnSairClientes.Size = new System.Drawing.Size(100, 39);
            this.btnSairClientes.TabIndex = 4;
            this.btnSairClientes.Text = "Sair";
            this.btnSairClientes.UseVisualStyleBackColor = false;
            this.btnSairClientes.Click += new System.EventHandler(this.btnSairClientes_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(30, 103);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(618, 429);
            this.dgvClientes.TabIndex = 5;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // btnClientesDeletar
            // 
            this.btnClientesDeletar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnClientesDeletar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientesDeletar.ForeColor = System.Drawing.Color.White;
            this.btnClientesDeletar.Location = new System.Drawing.Point(717, 349);
            this.btnClientesDeletar.Name = "btnClientesDeletar";
            this.btnClientesDeletar.Size = new System.Drawing.Size(307, 42);
            this.btnClientesDeletar.TabIndex = 6;
            this.btnClientesDeletar.Text = "Deletar";
            this.btnClientesDeletar.UseVisualStyleBackColor = false;
            this.btnClientesDeletar.Click += new System.EventHandler(this.btnClientesDeletar_Click);
            // 
            // btnClientesAdicionar
            // 
            this.btnClientesAdicionar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnClientesAdicionar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientesAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnClientesAdicionar.Location = new System.Drawing.Point(717, 282);
            this.btnClientesAdicionar.Name = "btnClientesAdicionar";
            this.btnClientesAdicionar.Size = new System.Drawing.Size(307, 42);
            this.btnClientesAdicionar.TabIndex = 7;
            this.btnClientesAdicionar.Text = "Adicionar";
            this.btnClientesAdicionar.UseVisualStyleBackColor = false;
            this.btnClientesAdicionar.Click += new System.EventHandler(this.btnClientesAdicionar_Click);
            // 
            // btnClientesAtualizar
            // 
            this.btnClientesAtualizar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnClientesAtualizar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientesAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnClientesAtualizar.Location = new System.Drawing.Point(717, 207);
            this.btnClientesAtualizar.Name = "btnClientesAtualizar";
            this.btnClientesAtualizar.Size = new System.Drawing.Size(307, 42);
            this.btnClientesAtualizar.TabIndex = 8;
            this.btnClientesAtualizar.Text = "Editar cadastro";
            this.btnClientesAtualizar.UseVisualStyleBackColor = false;
            this.btnClientesAtualizar.Click += new System.EventHandler(this.btnClientesAtualizar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Beige;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(72, 38);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(618, 33);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Beige;
            this.pictureBox1.BackgroundImage = global::EcoFarm.Properties.Resources.lupa;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(30, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnAttVisualizacao
            // 
            this.btnAttVisualizacao.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAttVisualizacao.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttVisualizacao.ForeColor = System.Drawing.Color.White;
            this.btnAttVisualizacao.Location = new System.Drawing.Point(717, 411);
            this.btnAttVisualizacao.Name = "btnAttVisualizacao";
            this.btnAttVisualizacao.Size = new System.Drawing.Size(307, 44);
            this.btnAttVisualizacao.TabIndex = 11;
            this.btnAttVisualizacao.Text = "Atualizar visualização";
            this.btnAttVisualizacao.UseVisualStyleBackColor = false;
            this.btnAttVisualizacao.Click += new System.EventHandler(this.btnAttVisualizacao_Click);
            // 
            // btnExportarCSV
            // 
            this.btnExportarCSV.BackColor = System.Drawing.Color.Green;
            this.btnExportarCSV.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarCSV.ForeColor = System.Drawing.Color.White;
            this.btnExportarCSV.Location = new System.Drawing.Point(762, 525);
            this.btnExportarCSV.Name = "btnExportarCSV";
            this.btnExportarCSV.Size = new System.Drawing.Size(179, 39);
            this.btnExportarCSV.TabIndex = 12;
            this.btnExportarCSV.Text = "Extrair Relatório";
            this.btnExportarCSV.UseVisualStyleBackColor = false;
            this.btnExportarCSV.Click += new System.EventHandler(this.btnExportarCSV_Click);
            // 
            // FrmMenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EcoFarm.Properties.Resources.Slide2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 595);
            this.Controls.Add(this.btnExportarCSV);
            this.Controls.Add(this.btnAttVisualizacao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnClientesAtualizar);
            this.Controls.Add(this.btnClientesAdicionar);
            this.Controls.Add(this.btnClientesDeletar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnSairClientes);
            this.Name = "FrmMenuClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuClientes";
            this.Load += new System.EventHandler(this.FrmMenuClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSairClientes;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnClientesDeletar;
        private System.Windows.Forms.Button btnClientesAdicionar;
        private System.Windows.Forms.Button btnClientesAtualizar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAttVisualizacao;
        private System.Windows.Forms.Button btnExportarCSV;
    }
}