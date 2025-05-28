using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoFarm
{
    public partial class FrmMenuEstoque : Form
    {
        public FrmMenuEstoque()
        {
            InitializeComponent();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenuVendas frmVendas = new FrmMenuVendas();
            frmVendas.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenuClientes frmClientes = new FrmMenuClientes();
            frmClientes.Show(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // if (e.RowIndex >= 0)
           // {
             //   DataGridViewRow row = dgvEstoque.Rows[e.RowIndex];

            //    txtId.Text = row.Cells["Id"].Value.ToString();
// txtProduto.Text = row.Cells["Produto"].Value.ToString();
               // txtQuantidade.Text = row.Cells["Quantidade"].Value.ToString();
              //  txtUnidade.Text = row.Cells["Unidade"].Value.ToString();
              //  txtPreco.Text = row.Cells["Preco"].Value.ToString();
            }
        
        void CarregarDados()
        {
            Conexao conexao = new Conexao();
            SqlConnection conn = conexao.Conectar();

            string sql = "SELECT IdProduto, NomeProduto, Categoria, Quantidade, PreçoFinal, Unidade, Observacoes FROM Estoque";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvEstoque.DataSource = dt;

            dgvEstoque.Columns["IdProduto"].Visible = false;
            dgvEstoque.Columns["NomeProduto"].HeaderText = "Produto";
            dgvEstoque.Columns["Categoria"].HeaderText = "Categoria";
            dgvEstoque.Columns["Quantidade"].HeaderText = "Quantidade";
            dgvEstoque.Columns["PreçoFinal"].HeaderText = "Preço (R$)";
            dgvEstoque.Columns["Unidade"].HeaderText = "Unidade";
            dgvEstoque.Columns["Observacoes"].HeaderText = "Observações";

            dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            conexao.Desconectar();
        }

        private void FrmMenuEstoque_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
