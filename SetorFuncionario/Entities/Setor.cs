using SetorFuncionario.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetorFuncionario.Entities
{
    public class Setor 
    {
        //encapsulamento implicito -> prop + 2x[tab]
        public int SetorId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        //Associação (TER-N)
        //Funcionario TEM MUITOS Dependentes
        public List<Funcionario> Funcionarios { get; set; }
    }
}
