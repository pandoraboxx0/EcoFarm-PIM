using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoFarm
{
    public partial class FrmMenuClientes : Form
    {
        public FrmMenuClientes()
        {
            InitializeComponent();
        }

        private void FrmMenuClientes_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnSairClientes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

              
            }

         
        }

        void CarregarDados()
        {
            Conexao conexao = new Conexao();
            SqlConnection conn = conexao.Conectar();

            string sql = "SELECT IdClientes, NomeCliente, Email, Telefone, CNPJ FROM Clientes";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvClientes.DataSource = dt;

            dgvClientes.Columns["IdClientes"].Visible = false;
            dgvClientes.Columns["NomeCliente"].HeaderText = "Nome Cliente";
            dgvClientes.Columns["Email"].HeaderText = "E-mail";
            dgvClientes.Columns["Telefone"].HeaderText = "Telefone";
            dgvClientes.Columns["CNPJ"].HeaderText = "CNPJ";

            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            conexao.Desconectar();
        }
        

        private void btnClientesAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["IdClientes"].Value);

                string nome = dgvClientes.CurrentRow.Cells["NomeCliente"].Value.ToString();
                string email = dgvClientes.CurrentRow.Cells["Email"].Value.ToString();
                string telefone = dgvClientes.CurrentRow.Cells["Telefone"].Value.ToString();
                string cnpj = dgvClientes.CurrentRow.Cells["CNPJ"].Value?.ToString();

                Conexao conexao = new Conexao();
                SqlConnection conn = conexao.Conectar();

                try
                {
                    string sql = "UPDATE Clientes SET NomeCliente=@Nome, Email=@Email, Telefone=@Telefone, CNPJ=@CNPJ WHERE IdClientes=@Id";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Telefone", telefone);
                    cmd.Parameters.AddWithValue("@CNPJ", string.IsNullOrEmpty(cnpj) ? (object)DBNull.Value : cnpj);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente atualizado com sucesso!");
                    CarregarDados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar: " + ex.Message);
                }
                finally
                {
                    conexao.Desconectar();
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para atualizar.");
            }
        }

        private void btnClientesDeletar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir este cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["IdClientes"].Value);

                    Conexao conexao = new Conexao();
                    SqlConnection conn = conexao.Conectar();

                    try
                    {
                        string sql = "DELETE FROM Clientes WHERE IdClientes = @Id";

                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@Id", id);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cliente deletado com sucesso!");
                        CarregarDados();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao deletar: " + ex.Message);
                    }
                    finally
                    {
                        conexao.Desconectar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para deletar.");
            }
        }

        private void btnClientesAdicionar_Click(object sender, EventArgs e)
        {
            FrmAdicionarClientes frmAdicionarClientes = new FrmAdicionarClientes();
            frmAdicionarClientes.Show();
        }

        private void btnAttVisualizacao_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dgvClientes.DataSource as DataTable).DefaultView.RowFilter =
        string.Format("NomeCliente LIKE '%{0}%' OR Email LIKE '%{0}%' OR Telefone LIKE '%{0}%'", txtBuscar.Text);
        }

        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count > 0)
            {
                SaveFileDialog salvar = new SaveFileDialog();
                salvar.Filter = "CSV (*.csv)|*.csv";
                salvar.FileName = "RelatorioClientes.csv";

                if (salvar.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(salvar.FileName, false, Encoding.UTF8))
                        {
                            // Cabeçalho
                            for (int i = 0; i < dgvClientes.Columns.Count; i++)
                            {
                                sw.Write(dgvClientes.Columns[i].HeaderText);
                                if (i < dgvClientes.Columns.Count - 1)
                                    sw.Write(";");
                            }
                            sw.WriteLine();

                            // Dados
                            foreach (DataGridViewRow row in dgvClientes.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    for (int i = 0; i < dgvClientes.Columns.Count; i++)
                                    {
                                        sw.Write(row.Cells[i].Value?.ToString());
                                        if (i < dgvClientes.Columns.Count - 1)
                                            sw.Write(";");
                                    }
                                    sw.WriteLine();
                                }
                            }
                        }

                        MessageBox.Show("CSV gerado com sucesso!", "Exportação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao exportar CSV: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Não há dados para exportar.");
            }
        }
    }
    }
    

