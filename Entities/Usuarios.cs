﻿using Entites.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Usuarios
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Senha { get; set; }
        public Papeis Papel { get; set; }

    }
}
