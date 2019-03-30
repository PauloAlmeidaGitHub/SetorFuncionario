using System;
using System.Collections.Generic;
using System.Configuration; //capturar elementos do App.config.xml
using System.Data.SqlClient; //acesso ao SqlServer
using System.Data; //execução de procedures
using SetorFuncionario.Entities; //classes de entidade
namespace SetorFuncionario.Repositories
{
    public class FuncionarioRepository
    {
        //==================================================================
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        private string connectionString;
        private string strSQL = "";

        //==================================================================
        public FuncionarioRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["CONNECTION"].ConnectionString;
        }

        //==================================================================
        public void Insert(Funcionario Funcionario)
        {
            strSQL = "INSERT INTO Funcionario (Nome, DataAdmissao, SetorId) VALUES (@Nome, @DataAdmissao, @SetorId)";
            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                cmd = new SqlCommand(strSQL, conn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", Funcionario.Nome);
                cmd.Parameters.AddWithValue("@DataAdmissao", Funcionario.DataAdmissao);
                cmd.Parameters.AddWithValue("@SetorId", Funcionario.SetorId);
                cmd.ExecuteNonQuery();
            }
        }

        //==================================================================
        public void Update(Funcionario Funcionario)
        {
            strSQL = "UPDATE Funcionario SET Nome =  @Nome, DataAdmissao = @DataAdmissao, SetorId = @SetorId WHERE FuncionarioId = @FuncionarioId";
            using (conn = new SqlConnection(connectionString))
            {
                cmd = new SqlCommand(strSQL, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", Funcionario.Nome);
                cmd.Parameters.AddWithValue("@DataAdmissao", Funcionario.DataAdmissao);
                cmd.Parameters.AddWithValue("@SetorId", Funcionario.SetorId);
                cmd.Parameters.AddWithValue("@FuncionarioId", Funcionario.FuncionarioId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //==================================================================
        public void Delete(int idFuncionario)
        {
            strSQL = "DELETE FROM Funcionario where FuncionarioId = @FuncionarioId";
            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                cmd = new SqlCommand(strSQL, conn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@FuncionarioId", idFuncionario);
                cmd.ExecuteNonQuery();
            }
        }

        //==================================================================
        public List<Funcionario>GetAll()
        {
            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "select * from VW_SetorFuncionario";

                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();

                List<Funcionario> lista = new List<Funcionario>();

                while (dr.Read()) //percorrendo os registros obtidos
                {
                    Funcionario funcionario = new Funcionario();
                    //Funcionario.Setor = new Setor();

                    funcionario.FuncionarioId = Convert.ToInt32(dr["FuncionarioId"]);
                    funcionario.Nome = Convert.ToString(dr["FuncionarioNome"]);
                    funcionario.DataAdmissao = Convert.ToDateTime(dr["DataAdmissao"]);
                    funcionario.SetorId = Convert.ToInt32(dr["SetorId"]);
                    //Funcionario.Setor.SetorId = Convert.ToInt32(dr["SetorId"]);
                    //Funcionario.Setor.Nome = Convert.ToString(dr["SetorNome"]);
                    //Funcionario.Setor.Descricao = Convert.ToString(dr["Descricao"]);

                    lista.Add(funcionario);
                }

                return lista; 
            }
        }

        //==================================================================
        public Funcionario GetById(int idFuncionario)
        {
            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "select * from VW_SetorFuncionario where IdFuncionario = @IdFuncionario";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdFuncionario", idFuncionario);
                dr = cmd.ExecuteReader();

                if (dr.Read()) //se algum registro foi obtido
                {
                    Funcionario funcionario = new Funcionario();
                    //funcionario.Setor = new Setor();

                    funcionario.FuncionarioId = Convert.ToInt32(dr["IdFuncionario"]);
                    funcionario.Nome = Convert.ToString(dr["NomeFuncionario"]);
                    funcionario.DataAdmissao = Convert.ToDateTime(dr["DataAdmissao"]);
                    funcionario.SetorId = Convert.ToInt32(dr["SetorId"]);
                    //funcionario.Setor.SetorId = Convert.ToInt32(dr["SetorId"]);
                    //funcionario.Setor.Nome = Convert.ToString(dr["NomeSetor"]);
                    //funcionario.Setor.Descricao = Convert.ToString(dr["Descricao"]);

                    return funcionario;
                }
                else
                {
                    return null; 
                }
            }
        }

    }

}
