using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; //capturar elementos do App.config.xml
using System.Data.SqlClient; //acesso ao SqlServer
using System.Data; //execução de procedures
using SetorFuncionario.Entities;

namespace SetorFuncionario.Repositories
{
    public class SetorRepository
    {
        //==================================================================
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        private string connectionString;
        private string strSQL = "";

        //==================================================================
        public SetorRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["CONNECTION"].ConnectionString;
        }

        //==================================================================
        public void Insert(Setor Setor)
        {
            using (conn = new SqlConnection(connectionString))
            {
                strSQL = "INSERT INTO Setor (Nome, Descricao) VALUES (@Nome, @Descricao)";
                cmd = new SqlCommand(strSQL, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", Setor.Nome);
                cmd.Parameters.AddWithValue("@Descricao", Setor.Descricao);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //==================================================================
        public void Update(Setor Setor)
        {
            using (conn = new SqlConnection(connectionString))
            {
                strSQL = "UPDATE Setor SET Nome = @Nome, Descricao = @Descricao WHERE SetorId = @SetorId";
                cmd = new SqlCommand(strSQL, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", Setor.Nome);
                cmd.Parameters.AddWithValue("@Descricao", Setor.Descricao);
                cmd.Parameters.AddWithValue("@SetorId", Setor.SetorId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //==================================================================
        public void Delete(int setorId)
        {
            using (conn = new SqlConnection(connectionString))
            {
                strSQL = "DELETE FROM Setor where SetorId = @setorId";
                cmd = new SqlCommand(strSQL, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@SetorId", setorId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //==================================================================
        public List<Setor> GetAll()
        {
            using (conn = new SqlConnection(connectionString))
            {
                strSQL = "SELECT SetorId, Nome, Descricao FROM Setor Order By Nome";
                cmd = new SqlCommand(strSQL, conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                List<Setor> lista = new List<Setor>();
                while (dr.Read())
                {
                    Setor Setor = new Setor();
                    Setor.SetorId = Convert.ToInt32(dr["SetorId"]);
                    Setor.Nome = Convert.ToString(dr["Nome"]);
                    Setor.Descricao = Convert.ToString(dr["Descricao"]);

                    lista.Add(Setor);
                }
                return lista; 
            }
        }

        //==================================================================
        public Setor GetById(int setorId)
        {
            using (conn = new SqlConnection(connectionString))
            {
                strSQL = "select * from VW_SetorFuncionario where SetorId = @SetorId";
                cmd = new SqlCommand(strSQL, conn);
                cmd.Parameters.AddWithValue("@SetorId", setorId);
                conn.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Setor Setor = new Setor();
                    Setor.SetorId = Convert.ToInt32(dr["SetorId"]);
                    Setor.Nome = Convert.ToString(dr["NomeSetor"]);
                    Setor.Descricao = Convert.ToString(dr["Descricao"]);
                    return Setor;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
