using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace LivrariaControleEmprestimo.WEB.Models
{
    public class DAL
    {
        public static readonly String Server = "HOME";
        public static readonly String Database = "Session"; // Outro Banco
        public static readonly String User = "sa";
        public static readonly String Password = "Paradoxo22";

        public static readonly String StrSql = $"Server = {Server}; Database = {Database}; Uid = {User}; Pwd = {Password}";

        public SqlConnection Conexao()
        {
            return new SqlConnection(StrSql);
        }

        public void FecharConexao()
        {
            SqlConnection conn = Conexao();
            conn.Close();
        }

        private SqlParameterCollection Colecao = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            Colecao.Clear();
        }

        public void AddParametros(String nome, Object valor)
        {
            Colecao.Add(new SqlParameter(nome, valor));
        }

        public DataTable ExecutarConsulta(CommandType commandType, String Sp_Ou_Texto)
        {
            try
            {
                SqlConnection conn = Conexao();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = commandType;
                cmd.CommandText = Sp_Ou_Texto;
                cmd.CommandTimeout = 3600;

                foreach(SqlParameter param in Colecao)
                {
                    cmd.Parameters.Add(new SqlParameter(param.ParameterName, param.Value));
                }
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }                
        }

        public Object ExecutarManipulacao(CommandType commandType, String Sp_Ou_Texto)
        {
            try
            {
                SqlConnection conn = Conexao();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = commandType;
                cmd.CommandText = Sp_Ou_Texto;
                cmd.CommandTimeout = 3600;

                foreach (SqlParameter param in Colecao)
                {
                    cmd.Parameters.Add(new SqlParameter(param.ParameterName, param.Value));
                }
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable RetDatatable(String sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, Conexao());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        // Polimorfismo para evitar ataque de injeção de sql
        public DataTable RetDatatable(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            cmd.Connection = Conexao();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}