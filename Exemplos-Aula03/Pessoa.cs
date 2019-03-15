using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplos_Aula03
{
    public class Pessoa
    {
        public String Nome { get; set; }
        public DateTime Nascimento { get; set; }

        public override string ToString()
        {
            return this.Nome + " " + this.Nascimento;
        }
    }
}
