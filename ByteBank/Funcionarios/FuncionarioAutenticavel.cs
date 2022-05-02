using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        public FuncionarioAutenticavel(double salario, string nome, string cpf) : base(salario, nome, cpf)
        {
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
