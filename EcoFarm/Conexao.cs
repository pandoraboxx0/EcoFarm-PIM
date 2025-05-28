using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EcoFarm
{
    public class Conexao
    {

        private SqlConnection conexao;

        private string  stringConexao = @"Data Source=localhost;Initial Catalog=ecofarm;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;Encrypt=False;TrustServerCertificate=True;";

        public SqlConnection Conectar()
        {
            try
            {
                conexao = new SqlConnection(stringConexao);
                conexao.Open();
                return conexao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar com o banco de dados: " + ex.Message);
            }


        }

        public void Desconectar()
        {
            try
            {
                if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao desconectar do banco de dados: " + ex.Message);
            }
        }

    }
}
