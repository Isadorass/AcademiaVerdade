using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Professores
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public int RG { get; set; }
        public string Endereco { get; set; } 
        public int Telefone { get; set; }
        public double Salario { get; set; }
        public double Comissao { get; set; }
        public string Email { get; set; }
        public int Senha { get; set; }
        public Usuarios Usuarios { get; set; }

    }
}
