﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Modalidades
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public override string ToString()
        {
            return this.Descricao;
        }
    }
}
