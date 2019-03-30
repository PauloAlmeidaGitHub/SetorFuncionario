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
    public class SetorFuncionarioRepository
    {
        //==================================================================
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        private string connectionString;
        private string strSQL = "";

        //==================================================================
        public SetorFuncionarioRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["CONNECTION"].ConnectionString;
        }



        //==================================================================
        public List<Entities.SetorFuncionario> GetAll()
        {
            using (conn = new SqlConnection(connectionString))
            {
                strSQL = "SELECT FuncionarioId, FuncionarioNome, DataAdmissao, SetorId, SetorNome, Descricao FROM VW_SetorFuncionario Order By FuncionarioNome";
                cmd = new SqlCommand(strSQL, conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                List<Entities.SetorFuncionario> lista = new List<Entities.SetorFuncionario>();
                while (dr.Read())
                {
                    Entities.SetorFuncionario setorFuncionario = new Entities.SetorFuncionario();
                    setorFuncionario.FuncionarioId = Convert.ToInt32(dr["FuncionarioId"]);
                    setorFuncionario.FuncionarioNome = Convert.ToString(dr["FuncionarioNome"]);
                    setorFuncionario.DataAdmissao = Convert.ToDateTime(dr["DataAdmissao"]);
                    setorFuncionario.SetorId = Convert.ToInt32(dr["SetorId"]);
                    setorFuncionario.SetorNome = Convert.ToString(dr["SetorNome"]);
                    setorFuncionario.Descricao = Convert.ToString(dr["Descricao"]);
                    lista.Add(setorFuncionario);
                }
                return lista;
            }
        }


    }
}
