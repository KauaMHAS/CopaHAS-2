using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaHAS.Models
{
    public class Jogo
    {
        public int Id {get; set; }
        public DateTime DataHora { get; set; }
        public int EstadioId { get; set; }
    }
}