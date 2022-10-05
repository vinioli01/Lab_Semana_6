﻿using System;
using System.Collections.Generic;

namespace ProjetoMySQL.Models
{
    public partial class Eleitor
    {
        public Eleitor()
        {
            Votacoes = new HashSet<Votacao>();
        }

        public int Id { get; set; }
        public string Cpf { get; set; } = null!;
        public string Nome { get; set; } = null!;

        public virtual ICollection<Votacao> Votacoes { get; set; }
    }
}
