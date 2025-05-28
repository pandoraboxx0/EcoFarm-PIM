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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            SqlConnection conn = conexao.Conectar();

            try
            {
                string sql = "SELECT * FROM Login WHERE NomeFuncionario = @NomeFuncionario AND Senha = @Senha";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NomeFuncionario", txtLoginNome.Text);
                cmd.Parameters.AddWithValue("@Senha", txtLoginSenha.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Login realizado com sucesso!");

                    this.Hide();
                    FrmMenuEstoque menu = new FrmMenuEstoque();
                    menu.Show();
                    


                }
                else
                {
                    MessageBox.Show("Nome ou senha incorretos.");
                }
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


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadastro frmCadastro = new FrmCadastro();
            frmCadastro.Show();
          

        }

        private void linkEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmEsqueciSenha frmEsqueciSenha = new FrmEsqueciSenha();
            frmEsqueciSenha.Show();
        }
    }
}
