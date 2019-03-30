using System;

namespace SetorFuncionario.Entities
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public DateTime DataAdmissao { get; set; }
        public int SetorId { get; set; }
    }
}
