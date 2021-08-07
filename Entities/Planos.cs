using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Planos
    {
        public int ID { get; set; }
        public double Valor { get; set; }
        public int QtdVezes { get; set; }
        public int Duracao { get; set; }
        public Modalidades Modalidade { get; set; }

        public Planos()
        {
            this.Modalidade = new Modalidades();
        }

    }
}
