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
    public partial class FrmAdicionarClientes : Form
    {
        public FrmAdicionarClientes()
        {
            InitializeComponent();
        }

        private void lblProduto_Click(object sender, EventArgs e)
        {

        }

        private void gbxAdicionarClientes_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdicionarSalvar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            SqlConnection conn = conexao.Conectar();

            try
            {
                string sql = "INSERT INTO Clientes (NomeCliente, Email, Telefone, CNPJ) " +
                             "VALUES (@Nome, @Email, @Telefone, @CNPJ)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nome", txtNomeCliente.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmailCliente.Text);
                cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@CNPJ", string.IsNullOrEmpty(txtCNPJ.Text) ? (object)DBNull.Value : txtCNPJ.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");
                this.Close(); // Fecha o formulário de cadastro
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }
    }
    }

