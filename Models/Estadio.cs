using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaHAS.Models
{
    public class Estadio
    {
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public List<Jogo> Jogos { get; set; } = new List<Jogo>();
    }
}