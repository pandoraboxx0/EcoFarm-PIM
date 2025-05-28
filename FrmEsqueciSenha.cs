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
    public partial class FrmEsqueciSenha : Form
    {
        SqlConnection conexao = new SqlConnection("Data Source=localhost;Initial Catalog=ecofarm;Integrated Security=True");
        public FrmEsqueciSenha()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            SqlConnection conn = conexao.Conectar();

            try
            {
                conexao.Conectar();

                string sql = "UPDATE Login SET Senha = @Senha WHERE IdFuncionario = @IdFuncionario AND Email = @Email";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Senha", txtAltNovaSenha.Text);
                cmd.Parameters.AddWithValue("@IdFuncionario", txtAltMatricula.Text);
                cmd.Parameters.AddWithValue("@Email", txtAltEmail.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Senha alterada com Sucesso!");

                txtAltMatricula.Text = "";
                txtAltEmail.Text = "";
                txtAltNovaSenha.Text = "";
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
