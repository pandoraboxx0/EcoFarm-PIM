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
    public partial class FrmCadastro : Form
    {

        SqlConnection conexao = new SqlConnection("Data Source=localhost;Initial Catalog=ecofarm;Integrated Security=True");
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            SqlConnection conn = conexao.Conectar();

            try
            {
                conexao.Conectar();

                string sql = "INSERT INTO Login (IdFuncionario, NomeFuncionario, Email, Senha) VALUES (@IdFuncionario, @NomeFuncionario, @Email, @Senha)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IdFuncionario", txtCadastroMatricula.Text);
                cmd.Parameters.AddWithValue("@NomeFuncionario", txtCadastroNome.Text);
                cmd.Parameters.AddWithValue("@Email", txtCadastroEmail.Text);
                cmd.Parameters.AddWithValue("@Senha", txtCadastroSenha.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso!");

                txtCadastroMatricula.Text = "";
                txtCadastroNome.Text = "";
                txtCadastroEmail.Text = "";
                txtCadastroSenha.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }
    }
}
