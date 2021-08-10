using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetVet.Models
{
    public class Agendamento
    {
        public string Nome { get; set; }
        public int Telefone { get; set; }

        public string Data { get; set; }

        public string Animal { get; set; }

        public string Necessidade { get; set; }
    }
}
