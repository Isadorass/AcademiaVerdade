using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Clientes
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public int RG { get; set; }
        public int TelefoneCelualar { get; set; }
        public int TelefoneFixo { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataMatricula { get; set; }
        public bool Ativo { get; set; }
        public Usuarios Usuarios { get; set; }
        public string Genero { get; set; }
    }
}