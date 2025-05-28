namespace EcoFarm
{
    partial class FrmAdicionarClientes
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
            this.gbxAdicionarClientes = new System.Windows.Forms.GroupBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.btnAdicionarSalvar = new System.Windows.Forms.Button();
            this.gbxAdicionarClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAdicionarClientes
            // 
            this.gbxAdicionarClientes.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gbxAdicionarClientes.Controls.Add(this.lblCNPJ);
            this.gbxAdicionarClientes.Controls.Add(this.txtCNPJ);
            this.gbxAdicionarClientes.Controls.Add(this.lblTelefone);
            this.gbxAdicionarClientes.Controls.Add(this.txtTelefone);
            this.gbxAdicionarClientes.Controls.Add(this.lblEmailCliente);
            this.gbxAdicionarClientes.Controls.Add(this.txtEmailCliente);
            this.gbxAdicionarClientes.Controls.Add(this.lblNomeCliente);
            this.gbxAdicionarClientes.Controls.Add(this.txtNomeCliente);
            this.gbxAdicionarClientes.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAdicionarClientes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gbxAdicionarClientes.Location = new System.Drawing.Point(368, 123);
            this.gbxAdicionarClientes.Name = "gbxAdicionarClientes";
            this.gbxAdicionarClientes.Size = new System.Drawing.Size(532, 280);
            this.gbxAdicionarClientes.TabIndex = 5;
            this.gbxAdicionarClientes.TabStop = false;
            this.gbxAdicionarClientes.Text = "Adicionar Clientes";
            this.gbxAdicionarClientes.Enter += new System.EventHandler(this.gbxAdicionarClientes_Enter);
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.lblCNPJ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(125, 196);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(49, 21);
            this.lblCNPJ.TabIndex = 16;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.BackColor = System.Drawing.Color.White;
            this.txtCNPJ.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJ.Location = new System.Drawing.Point(190, 194);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(215, 27);
            this.txtCNPJ.TabIndex = 15;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(108, 152);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(76, 21);
            this.lblTelefone.TabIndex = 14;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.White;
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(190, 146);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(173, 27);
            this.txtTelefone.TabIndex = 13;
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCliente.Location = new System.Drawing.Point(125, 104);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(59, 21);
            this.lblEmailCliente.TabIndex = 12;
            this.lblEmailCliente.Text = "E-mail";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.BackColor = System.Drawing.Color.White;
            this.txtEmailCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.Location = new System.Drawing.Point(190, 98);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(227, 27);
            this.txtEmailCliente.TabIndex = 11;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(69, 56);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(115, 21);
            this.lblNomeCliente.TabIndex = 10;
            this.lblNomeCliente.Text = "Nome Cliente";
            this.lblNomeCliente.Click += new System.EventHandler(this.lblProduto_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.Color.White;
            this.txtNomeCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(190, 50);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(227, 27);
            this.txtNomeCliente.TabIndex = 9;
            // 
            // btnAdicionarSalvar
            // 
            this.btnAdicionarSalvar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAdicionarSalvar.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarSalvar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarSalvar.Location = new System.Drawing.Point(596, 427);
            this.btnAdicionarSalvar.Name = "btnAdicionarSalvar";
            this.btnAdicionarSalvar.Size = new System.Drawing.Size(152, 52);
            this.btnAdicionarSalvar.TabIndex = 10;
            this.btnAdicionarSalvar.Text = "Adicionar";
            this.btnAdicionarSalvar.UseVisualStyleBackColor = false;
            this.btnAdicionarSalvar.Click += new System.EventHandler(this.btnAdicionarSalvar_Click);
            // 
            // FrmAdicionarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EcoFarm.Properties.Resources.fundinho;
            this.ClientSize = new System.Drawing.Size(1249, 627);
            this.Controls.Add(this.btnAdicionarSalvar);
            this.Controls.Add(this.gbxAdicionarClientes);
            this.Name = "FrmAdicionarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdicionarClientes";
            this.gbxAdicionarClientes.ResumeLayout(false);
            this.gbxAdicionarClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAdicionarClientes;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Button btnAdicionarSalvar;
    }
}