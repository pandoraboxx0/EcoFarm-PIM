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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EcoFarm
{
    public partial class FrmMenuEstoque : Form
    {
        bool modoEdicao = false;
        int idSelecionado = 0;
        public FrmMenuEstoque()
        {
            InitializeComponent();
            bool modoEdicao = false;
            int idSelecionado = 0;
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenuClientes frmClientes = new FrmMenuClientes();
            frmClientes.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEstoque.Rows[e.RowIndex];

                txtProduto.Text = row.Cells["Produto"].Value.ToString();
                txtCategoria.Text = row.Cells["Categoria"].Value.ToString();
                txtQuantidade.Text = row.Cells["Quantidade"].Value.ToString();
                txtPreco.Text = row.Cells["Preco (R$)"].Value.ToString();
                txtUnidade.Text = row.Cells["Unidade"].Value.ToString();
                txtObservacoes.Text = row.Cells["Observacoes"].Value.ToString();

                gbxEstoque.Visible = true;
            }

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

        private void lblProduto_Click(object sender, EventArgs e)
        {

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbxEstoque_Enter(object sender, EventArgs e)
        {

        }

        private void btnEstoqueNovo_Click(object sender, EventArgs e)
        {
            modoEdicao = false;
            idSelecionado = 0;

            txtProduto.Text = "";
            txtCategoria.Text = "";
            txtQuantidade.Text = "";
            txtPreco.Text = "";
            txtUnidade.Text = "";
            txtObservacoes.Text = "";

            gbxEstoque.Visible = true;
        }

        private void btnEstoqueSalvar_Click(object sender, EventArgs e)
        {
            // Conexão com o banco
            Conexao conexao = new Conexao();
            SqlConnection conn = conexao.Conectar();
            

            try
            {
                SqlCommand cmd;

                if (modoEdicao) // Edição de registro
                {
                    string sql = "UPDATE Estoque SET NomeProduto=@Produto, Categoria=@Categoria, Quantidade=@Quantidade, " +
                                 "PreçoFinal=@Preco, Unidade=@Unidade, Observacoes=@Observacoes WHERE IdProduto=@Id";

                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Id", idSelecionado);
                }
                else // Inserção de novo registro
                {
                    string sql = "INSERT INTO Estoque (NomeProduto, Categoria, Quantidade, PreçoFinal, Unidade, Observacoes) " +
                                 "VALUES (@Produto, @Categoria, @Quantidade, @Preco, @Unidade, @Observacoes)";

                    cmd = new SqlCommand(sql, conn);
                }

                // Adicionando parâmetros comuns
                cmd.Parameters.AddWithValue("@Produto", txtProduto.Text);
                cmd.Parameters.AddWithValue("@Categoria", txtCategoria.Text);
                cmd.Parameters.AddWithValue("@Quantidade", Convert.ToInt32(txtQuantidade.Text));
                cmd.Parameters.AddWithValue("@Preco", Convert.ToDecimal(txtPreco.Text));
                cmd.Parameters.AddWithValue("@Unidade", txtUnidade.Text);
                cmd.Parameters.AddWithValue("@Observacoes", txtObservacoes.Text);

                // Executando o comando
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Resetando os controles
                gbxEstoque.Visible = false;
                modoEdicao = false;
                idSelecionado = 0;

                // Atualiza o DataGridView
                CarregarDados();
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique se os campos Quantidade e Preço estão preenchidos corretamente com números válidos.",
                                "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        private void btnEstoqueEditar_Click(object sender, EventArgs e)
        {
            modoEdicao = true;
            idSelecionado = Convert.ToInt32(dgvEstoque.CurrentRow.Cells["IdProduto"].Value);

            if (dgvEstoque.CurrentRow != null)
            {
                gbxEstoque.Visible = true;

                txtProduto.Text = dgvEstoque.CurrentRow.Cells["NomeProduto"].Value.ToString();
                txtCategoria.Text = dgvEstoque.CurrentRow.Cells["Categoria"].Value.ToString();
                txtQuantidade.Text = dgvEstoque.CurrentRow.Cells["Quantidade"].Value.ToString();
                txtPreco.Text = dgvEstoque.CurrentRow.Cells["PreçoFinal"].Value.ToString();
                txtUnidade.Text = dgvEstoque.CurrentRow.Cells["Unidade"].Value.ToString();
                txtObservacoes.Text = dgvEstoque.CurrentRow.Cells["Observacoes"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para editar.");
            }

        }

        private void btnEstoqueCancelar_Click(object sender, EventArgs e)
        {
            gbxEstoque.Visible = false;
            modoEdicao = false;
            idSelecionado = 0;
        }

        private void btnEstoqueDeletar_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.CurrentRow != null)
            {
                // Confirmação antes de excluir
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este produto?",
                                                         "Confirmação",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    // Pega o Id do produto selecionado
                    int id = Convert.ToInt32(dgvEstoque.CurrentRow.Cells["IdProduto"].Value);

                    // Faz a conexão com o banco
                    Conexao conexao = new Conexao();
                    SqlConnection conn = conexao.Conectar();

                    try
                    {
                        // Comando SQL de deletar
                        string sql = "DELETE FROM Estoque WHERE IdProduto = @Id";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@Id", id);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Produto deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Atualiza o DataGridView
                        CarregarDados();
                        gbxEstoque.Visible = false; // Fecha o groupbox se quiser
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao deletar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Desconectar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para deletar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}


