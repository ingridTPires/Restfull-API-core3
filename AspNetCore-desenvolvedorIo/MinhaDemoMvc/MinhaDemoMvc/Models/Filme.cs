﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMvc.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Genero { get; set; }
        public decimal Valor { get; set; }
        public int Avaliacao { get; set; }
    }
}
