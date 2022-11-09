using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DAL
{
    class Conexao
    {
        MySqlConnection conexao;
        public void Conectar()
        {
            string conn = @"Persist Security Info = false;
                            server   = localhost;
                            database = ExemploCamadasPOO;
                            uid      = root;
                            pwd      =";
            try
            {
                conexao = new MySqlConnection(conn);
                conexao.Open();
            }
            catch (MySqlException)
            {
                throw new Exception("Problemas ao se conectar com o banco de dados.");
            }
        }

        public void ExecutarComando(string sql)
        {
            Conectar();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
               throw new Exception("Não foi possível executar o comando.\n" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable ExecutarConsulta(string sql)
        {
            Conectar();
            try
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                dados.Fill(dt);
                return dt;
            }
            catch(MySqlException ex)
            {
                throw new Exception("Não foi possível executar o comando.\n" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
