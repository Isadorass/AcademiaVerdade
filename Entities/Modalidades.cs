using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Modalidades
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
