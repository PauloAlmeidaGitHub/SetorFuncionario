using System;
namespace SetorFuncionario.Entities
{
    public class SetorFuncionario
    {
        public int FuncionarioId { get; set; }
        public string FuncionarioNome { get; set; }
        public DateTime DataAdmissao { get; set; }
        public int SetorId { get; set; }
        public string SetorNome { get; set; }
        public string Descricao { get; set; }
    }
}
